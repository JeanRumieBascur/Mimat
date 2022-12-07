using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MimatAPI.Controllers
{
    public class AdminInstitutionController : ApiController
    {
        


        [System.Web.Http.HttpGet]
        public IHttpActionResult Get()
        {
            Models.MimatEntities contextDb = new Models.MimatEntities();
            List<Models.ViewModel.AdminInstitution> adminList = new List<Models.ViewModel.AdminInstitution>();
            using (contextDb)
            {
                adminList = (from d in contextDb.admin_institution
                            select new Models.ViewModel.AdminInstitution
                            {
                                Id = d.id,
                                Institution = d.institution,
                                Mail = d.mail,
                                Password = d.password,
                                CreateAt = d.created_at,
                                LastLogin = d.last_login
                            }).ToList();
            }
            return Ok(adminList);
        }
    }
}