using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MimatLocation.Models.Request
{
    class WorkstationRequest
    {
       
            public int Id { get; set; }
            public string Model { get; set; }
            public string Cpu { get; set; }
            public string Classroom { get; set; }
            public string Location { get; set; }
            public int InSafeArea { get; set; }
            public DateTime LastUpdate { get; set; }
        
    }
}
