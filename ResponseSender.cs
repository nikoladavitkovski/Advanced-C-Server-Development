using Azure;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace Sedc_Server_Try_One
{
    internal class ResponseSender
    {
        public ResponseSender()
        {
        }

        internal void Send(Response response, Stream stream)
        {
            var statusLine = string.Format("HTTP/1.1 {0} {1}\r\n", response.Status,response.Message);
            var separator = "\r\n";
            var body = response.Message;

            var responseString = $"{statusLine}{separator}{body}";

            var responseBytes = Encoding.ASCII.GetBytes(responseString);
            stream.Write(responseBytes);

        }
    }
}