using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Drupal8Rest


{
    class Program
    {
        static void Main(string[] args)
        {
           var node =  GetDrupalNode<DrupalNodeBase>(3);

        }

        private static T GetDrupalNode<T>(int nid)
        {
            var jsonResult = WebRequestGetJsonResponse(@"http://piazzetta8.socialvision.it/node/" + nid, "dotnet", "passworddidotnet");
            var deserializedResult = JsonConvert.DeserializeObject<T>(jsonResult);
            return deserializedResult;
        }

        private static string WebRequestGetJsonResponse(string url, string user, string password)
        {
            WebRequest req = WebRequest.Create($@"{url}?_format=json");
            req.Method = "GET";
            req.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes($"{user}:{password}"));
            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;

            string content = string.Empty;
            using (var stream = resp.GetResponseStream())
            {
                using (var sr = new StreamReader(stream))
                {
                    content = sr.ReadToEnd();
                }
            }


            resp.Close();

            return content;
           
        }
    }
}
