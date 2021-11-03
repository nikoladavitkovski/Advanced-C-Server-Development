using sedc_server_Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sedc_Server_Try_One
{
    public enum StatusEnum
    {
        OK = 200,
        ServerError = 500,
        NotFound = 404,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        SemanticError = 422
    }
    public static class StatusText
    {
        private static Dictionary<Status, string> textStatuses = new();

        static StatusText()
        {
            textStatuses.Add(Status.OK, "OK");
            textStatuses.Add(Status.ServerError, "Internal Server Error");
            textStatuses.Add(Status.NotFound, "Not Found");
        }

        static public string GetText(Status status)
        {
            if (!textStatuses.TryGetValue(status, out string text))
            {
                return status.ToString();
            }
            return text;
        }
    }
}
