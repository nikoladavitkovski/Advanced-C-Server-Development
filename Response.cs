using sedc_server_Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sedc_Server_Try_One
{
    internal class Response
    {
        public string Message { get; set; }

        public string Address { get; set; }

        public Status Status { get; set; }

        public Response()
        {
            Status = Status.ServerError;
        }

    }
}
