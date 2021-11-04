using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Sedc_Server_Try_One
{
    public record UrlAddress
    {
        public List<string> paths;

        public ReadOnlyCollection<string> Path
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
            paths = parts.Skip(1).ToList();
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
            var query = path.Skip(1).ToList();
            foreach(var pat in paths)
            {
                var keyValue = query.ToString();
                return keyValue;
            }
            return path;
        }
    }
}