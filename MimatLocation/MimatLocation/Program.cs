using System;
using System.Collections.Generic;
using System.Configuration;
using System.Device.Location;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml;
using MimatLocation.Class;
using MimatLocation.Models.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;

namespace MimatLocation
{
    class AsyncProgram
    {
        static void Main(string[] args)
        {
            CLocation myLocation = new CLocation();
            MethodsOfAction methodsOfAction = new MethodsOfAction(myLocation);
            methodsOfAction.Action();

        }



        class CLocation
        {
            GeoCoordinateWatcher watcher;

            public void GetLocationEvent()
            {
                this.watcher = new GeoCoordinateWatcher();
                this.watcher.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(watcher_PositionChanged);
                bool started = this.watcher.TryStart(false, TimeSpan.FromMilliseconds(2000));
                if (!started)
                {
                    Console.WriteLine("GeoCoordinateWatcher timed out on start.");
                }
            }

            void watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
            {
                PrintPosition(e.Position.Location.Latitude, e.Position.Location.Longitude);
            }

            void PrintPosition(double Latitude, double Longitude)
            {

                Console.WriteLine("Latitude: {0}, Longitude {1}", Latitude, Longitude);
                UpdateLocation(Latitude, Longitude);

            }

            private void UpdateLocation(double latitude, double longitude)
            {

                WorkstationConsumer wConsumer = new WorkstationConsumer();


                string reLatitude = latitude + "";
                string reLongitude = longitude + "";
                reLatitude = reLatitude.Replace(",", ".");
                reLongitude = reLongitude.Replace(",", ".");
                string currentLocation = reLatitude + "," + reLongitude;

                wConsumer.PutItem(2, currentLocation, 0);


            }
        }

        class MethodsOfAction
        {
            CLocation myLocation;

            public MethodsOfAction(CLocation _myLocation)
            {
                myLocation = _myLocation;
            }

            public void Action()
            {
                VerifySettings();
            }




            private void VerifySettings()
            {
                string checker = ConfigurationManager.AppSettings["keyadmin"];

                if (checker == "183%6^q6SP73N4^oTzQQ")
                {
                    ExecuteLocation();
                }
                else
                {
                    ExecuteLogin();
                }
            }


            private void ExecuteLocation()
            {
                myLocation.GetLocationEvent();
                Console.WriteLine("Presione cualquier tecla para terminar con el servicio.");
                Console.ReadLine();
            }

            private async void ExecuteConfigure()
            {

                string classroomSetting; string getResultConfigure = "";
                WorkstationConsumer workstationConsumer = new WorkstationConsumer();
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

                Console.WriteLine("\n¡ACCESO CORRECTO! :) \n\n Nueva Configuración \n\n Ingresa el numero de Aula:");

                classroomSetting = Console.ReadLine();

                foreach (XmlElement element in xmlDoc.DocumentElement)
                {
                    var equals = element.Name.Equals("appSettings");
                    if (element.Name.Equals("appSettings"))
                    {
                        foreach (XmlNode node in element.ChildNodes)
                        {
                            if (node.Attributes[0].Value == "keyadmin")
                            {
                                node.Attributes[1].Value = "183%6^q6SP73N4^oTzQQ";
                            }

                            if (node.Attributes[0].Value == "classroom")
                            {
                                node.Attributes[1].Value = classroomSetting;
                            }
                            if (node.Attributes[0].Value == "indentity")
                            {
                                getResultConfigure = await workstationConsumer.GetHttp();
                                List<Models.Request.WorkstationRequest> workList = JsonConvert.DeserializeObject<List<Models.Request.WorkstationRequest>>(getResultConfigure);
                                for (int i = 0; i < workList.Count; i++)
                                {
                                    if (workList[i].Classroom == classroomSetting)
                                    {
                                        node.Attributes[1].Value = workList[i].Id + "";
                                    }
                                }

                            }


                        }
                    }

                    xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                    ConfigurationManager.RefreshSection("appSettings");
                    VerifySettings();
                }
            }

            private async void ExecuteLogin()
            {

                string mailAccess = ""; string passwordAccess = ""; string getResultLogin = "";
                bool access = false;
                AdminConsumer adminConsumer = new AdminConsumer();
                Console.WriteLine(" MIMAT GEO: ¡HOLA! TE DAMOS LA BIENVENIDA \n");

                try
                {
                    while (access == false)
                    {

                        Console.WriteLine("\nIngresa Email Administrador:");
                        mailAccess = Console.ReadLine();
                        Console.WriteLine("\nContraseña:");
                        passwordAccess = Console.ReadLine();
                        getResultLogin = await adminConsumer.GetHttp();
                        List<Models.Request.AdminRequest> adminsList =
                            JsonConvert.DeserializeObject<List<Models.Request.AdminRequest>>(getResultLogin);

                        for (int i = 0; i < adminsList.Count; i++)
                        {
                            if (adminsList[i].Mail == mailAccess && adminsList[i].Password == passwordAccess)
                            {

                                ExecuteConfigure();
                                access = true;
                            }
                            else
                            {
                                Console.WriteLine("\nACCESO INCORRECTO");
                            }

                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n " + e.Message + "- Verifique la conexión a internet del equipo.");
                    Console.ReadLine();
                }
            }



        }
    }
}





