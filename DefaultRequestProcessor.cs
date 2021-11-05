using Azure.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sedc_server_Server
{
    class DefaultRequestGenerator : IRequestProcessor
    {
        public IResponse Process(Request request)
        {
            return new TextResponse
            {
                Message = $"Hi,I'm a SEDC Server, nice to meet you! You used the {request.Method} method on the {request.Address} URL",
                Status = Status.OK
            };
        }
    }
}
