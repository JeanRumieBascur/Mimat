using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MimatLocation.Models.Request
{
    class AdminRequest
    {
        public int Id { get; set; }
        public string Institution { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string CreateAt { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
