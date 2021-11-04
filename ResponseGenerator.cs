using Azure;
using Azure.Core;
using sedc_server_Server;
using System;

namespace Sedc_Server_Try_One
{
    internal class ResponseGenerator
    {
        public ResponseGenerator()
        {
        }

        internal Response GenerateResponse(Request request)
        {
            if (!ValidateRequest(request))
            {
                throw new ApplicationException("Validation failed");
                //return new Response { Message = "Invalid response"}
            }
            return new Response { Message = $"Hi, I'm a <b>SEDC Server</b>, nice to meet you! You used the {request.Method} method", 
                Status = Status.OK};
        }

        private bool ValidateRequest(Request request)
        {
            return true;
        }
    }
}