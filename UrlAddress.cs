using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Sedc_Server_Try_One
{
    public record UrlAddress
    {
        private readonly string[] paths = new string[0];
       
        public IList<string> Path
        {
            get
            {
                return new ReadOnlyCollection<string>(paths);
            }
        }

        private Dictionary<string,string> parameters = new();

        public ReadOnlyDictionary<string, string> Params
        {
            get
            {
                return new ReadOnlyDictionary<string, string>(parameters);
            }
        }
        public UrlAddress(string url)
        {
            var parts = url.Split('/');
            var query = parts.Last();
            var queryParts = query.Split('?');
            if(queryParts.Length > 1)
            {
                var queryParams = queryParts[1].Split("&");
                foreach(var queryParam in queryParams)
                {
                    var keyValue = queryParam.Split('=');
                    parameters.Add(keyValue[0],keyValue[1]);
                }
            }
        }

        public static UrlAddress FromString(string value)
        {
            return new UrlAddress(value);
        }
        public override string ToString()
        {
            var path = string.Join(',', paths);
            var query = string.Join("&", parameters.Select(kvp => $"{kvp.Key}{kvp.Value}"));
            if (string.IsNullOrEmpty(query))
            {
                return path;
            }
            return $"{path}{query}";
        }

        public static string TestAddress()
        {
            Request request = new Request();
            string UrlAddress = string.Join('?', $"{request.Address}");
            if (string.IsNullOrEmpty(UrlAddress))
            {
                return null;
            }
            return UrlAddress;
        }
    }
}