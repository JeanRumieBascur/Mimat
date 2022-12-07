using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MimatAPI.Models.ViewModel
{
    public class WorkstationClassrooms
    {
        public int Id{ get; set; }
        public string Model{ get; set; }
        public string Cpu { get; set; }
        public string Classrooms { get; set; }
        public string Location { get; set; }
        public int InSafeArea { get; set; }
        public DateTime LastUpdate{ get; set; }
    }
}