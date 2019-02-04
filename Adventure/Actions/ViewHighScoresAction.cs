using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Adventure.Actions
{
    public class ViewHighScoresAction : IAction
    {
        public string GetText()
        {
            return "High scores";
        }

        public void Execute()
        {
            Console.WriteLine("Getting high scores, please wait up to 2 minutes...");
            Task<IRestResponse> task = Task.Factory.StartNew(() => MakeWebServiceCall());
            task.Wait(120000);
            if (!task.IsCompleted)
            {
                Console.WriteLine("Getting high scores timed out.");
                return;
            }
            var response = task.Result;
            if (!response.IsSuccessful)
            {
                Console.WriteLine("Web service rejected the request to get high scores.");
                return;
            }

            var responseObject = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(response.Content);
            var sortedHighScores =
                responseObject
                .OrderByDescending(s => s["Time"])
                .GroupBy(s => s["PlayerID"])
                .Select(n => n.First())
                .OrderByDescending(s => s["Score"])
                .Take(10)
                .ToList();
            int i = 1;
            foreach (var x in sortedHighScores)
            {
                var paddedNumber = $"{i}".PadRight(4);
                var paddedName = $"{x["Name"]}".PadRight(20);
                Console.WriteLine($"{paddedNumber}{paddedName}{x["Score"]}");
                i++;
            }
        }

        private IRestResponse MakeWebServiceCall()
        {
            var client = new RestClient("https://adventure-eca6.restdb.io/rest/highscores");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", "936bff927873676f481866565b4d027fcc3c9");
            request.AddHeader("content-type", "application/json");
            return client.Execute(request);
        }
    }
}
