using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MimatLocation.Class
{
    class WorkstationConsumer
    {
      

        public async Task<string> GetHttp()
        {

            WebRequest webRequest = WebRequest.Create("https://localhost:44391/api/WorkstationClassRooms");
            WebResponse webResponse = webRequest.GetResponse();
            StreamReader sr = new StreamReader(webResponse.GetResponseStream());
            return await sr.ReadToEndAsync();

        }

        public void PutItem(int id, string location, int isSafeArea)
        {
            var url = $"https://localhost:44391/api/WorkstationClassRooms";
            var request = (HttpWebRequest)WebRequest.Create(url);
            string json = $"{{\"Id\":\"{id}\",\"Location\":\"{location}\",\"IsSafeArea\":\"{isSafeArea}\"}}";
            request.Method = "PUT";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            Console.WriteLine(responseBody);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
