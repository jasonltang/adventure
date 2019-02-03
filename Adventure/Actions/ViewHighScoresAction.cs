using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using Newtonsoft.Json;

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
            Console.WriteLine("Getting high scores, please wait...");
            var client = new RestClient("https://adventure-eca6.restdb.io/rest/highscores");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", "936bff927873676f481866565b4d027fcc3c9");
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            if (!response.IsSuccessful)
            {
                Console.WriteLine("Couldn't communicate with web service to get high scores.");
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
                Console.WriteLine($"{i}. {x["Name"]}: {x["Score"]}");
                i++;
            }
        }
    }
}
