using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using TestsProject.ApiModels;

namespace AutomationProjectQA.HelpMethods
{
    public class ApiManager : HelpMethodsClass
    {
        public RestClient CreateAPIClient(string method)
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            RestClient client = null;

            try
            {
                client = new RestClient(method);
                client.Timeout = 90 * 1000;

                client.Authenticator = new HttpBasicAuthenticator(appConfigParameters.GetApiUserName(), appConfigParameters.GetApiUserPassword());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return client;
        }

        public string GetDemo(string demo)
        {
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");

            var resp = CreateAPIClient($@"https://demo.com/api/v5/Demo?$top=1&$filter=name eq '{demo}'").Execute(request);
            var myJsonResponse = JsonConvert.DeserializeObject<DemoApiModel>(resp.Content);

            return myJsonResponse.response[0].id;
        }

        public List<string> GetListDemo(string server, string testReference)
        {
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");

            var resp = CreateAPIClient($@"https://demo.com/api/v5/Demo?$top=1&$filter=name").Execute(request);
            var myObject = JsonConvert.DeserializeObject<DemoApiModel>(resp.Content);


            var listReferences = myObject.response.Select(demo => demo.id).ToList();
            return listReferences;
        }

        public string PostDemo()
        {
            return "";
        }
    }
}
