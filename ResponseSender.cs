using Azure;
using sedc_server_Server;
using System;
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

            if(response is TextResponse textResponse)
            {
                var body = textResponse.Message;

                var responseString = $"{statusLine}{separator}{body}";

                var responseBytes = Encoding.ASCII.GetBytes(responseString);
                stream.Write(responseBytes);
            } else if(response is BinaryResponse binaryResponse)
            {
                var responseString = $"{separator}{statusLine}";
                var responseBytes = Encoding.ASCII.GetBytes(responseString);
                stream.Write(responseBytes);
                var body = binaryResponse.Message;
                stream.Write(body);
            }
            else
            {
                throw new ApplicationException($"Invalid response type {response.GetType().FullName}");
            }
        }
    }
}