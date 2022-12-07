using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MimatAPI.Models.ViewModel
{
    public class AdminInstitution
    {
        public int Id { get; set; }
        public string Institution { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string CreateAt { get; set; }
        public DateTime LastLogin { get; set; }
    }
}