using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sedc_Server_Try_One
{
    internal class RequestParser
    {
        internal static Request Parse(string input)
        {
            var lines = input.Split("\r\n");
            var requestLine = lines[0];

            var rlRegex = new Regex("");
            var rlMatch = rlRegex.Match(requestLine);

            var headerLines = lines.Skip(1).TakeWhile(line => line != "");
            var hlRegex = new Regex(@"^([a-zA-z0-9-+]+):\s(.+)");
            var result = new Request
            {
                Method = rlMatch.Groups[1].Value,
                Address = rlMatch.Groups[2].Value
            };
            return result;
        }
    }
}
