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
           var node7 =  GetDrupalNode<Drupal7NodeBase>(45246, @"http://dev.piazzetta.socialvision.it/dotnetrest", "dotnet", "passworddidotnet");
           var node8 =  GetDrupalNode<Drupal8NodeBase>(3, @"http://piazzetta8.socialvision.it", "dotnet", "passworddidotnet");
        }

        private static T GetDrupalNode<T>(int nid, string baseUrl, string user, string password)
        {
            var jsonResult = WebRequestGetJsonResponse(baseUrl + "/node/" + nid, user, password);
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
