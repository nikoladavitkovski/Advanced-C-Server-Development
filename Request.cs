using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sedc_Server_Try_One
{
    internal class Request
    {
        public string Method { get; set; }

        public string Address { get; set; }

        public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();

        private string HeaderRequest(int padBy = 0)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var item in Headers)
            {
                sb.Append($"{string.Empty.PadLeft(padBy, ' ')}{item.Key}: {item.Value}\r\n");
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return $@"Request{Method}{Address}{Headers : HeaderString(4)}";
        }
    }
}
