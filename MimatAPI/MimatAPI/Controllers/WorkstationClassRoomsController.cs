using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace MimatAPI.Controllers
{
    public class WorkstationClassRoomsController : ApiController
    {


        [System.Web.Http.HttpPost]
        public IHttpActionResult Add(Models.ViewModel.WorkstationClassrooms model)
        {
            Models.MimatEntities contextDb = new Models.MimatEntities();
            try
            {
                using (contextDb)
                {
                    var oWorkstation = new Models.workstation_classrooms();
                    oWorkstation.model = model.Model;
                    oWorkstation.cpu = model.Cpu;
                    oWorkstation.classroom = model.Classrooms;
                    oWorkstation.location = model.Location;
                    oWorkstation.inSafeArea = model.InSafeArea;
                    oWorkstation.lastUpdate = model.LastUpdate;

                    contextDb.workstation_classrooms.Add(oWorkstation);
                    contextDb.SaveChanges();
                };

            }
            catch (Exception e)
            {
                return NotFound();
            }

            return Ok("Exito");

        }

        [System.Web.Http.HttpPut]
        public IHttpActionResult Put(Models.ViewModel.WorkstationClassrooms model)
        {
            Models.MimatEntities contextDb = new Models.MimatEntities();
            try
            {
                using (contextDb)
                {
                    var workStation = contextDb.workstation_classrooms.Find(model.Id);
                    workStation.location = model.Location;
                    workStation.inSafeArea = model.InSafeArea;
                    contextDb.SaveChanges();

                }
            }
            catch (Exception e)
            {
                return NotFound();
            }

            return Ok();

        }



    }
}
