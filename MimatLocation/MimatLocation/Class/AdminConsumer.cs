using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MimatLocation.Class
{
    class AdminConsumer
    {
        public async Task<string> GetHttp()
        {

            WebRequest webRequest = WebRequest.Create("https://localhost:44391/api/AdminInstitution");
            WebResponse webResponse = webRequest.GetResponse();
            StreamReader sr = new StreamReader(webResponse.GetResponseStream());
            return await sr.ReadToEndAsync();

        }
    }
}
