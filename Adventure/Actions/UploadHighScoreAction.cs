using System;
using RestSharp;

namespace Adventure.Actions
{
    public class UploadHighScoreAction : IAction
    {
        public string GetText()
        {
            return "Upload high score";
        }

        public void Execute()
        {
            Console.WriteLine("Uploading high score, please wait...");
            var player = Player.GetInstance();
            var time = DateTime.Now.Ticks;
            var client = new RestClient("https://adventure-eca6.restdb.io/rest/highscores");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", "936bff927873676f481866565b4d027fcc3c9");
            request.AddHeader("content-type", "application/json");
            request.AddParameter(
                "application/json",
                $@"{{
                    ""PlayerID"":""{player.ID.ToString()}"",
                    ""Name"":""{player.Name}"",
                    ""Score"":""{player.Gold * 10}"",
                    ""Time"":""{time}""}}",
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            if (!response.IsSuccessful)
            {
                Console.WriteLine("Couldn't communicate with web service to upload high score.");
                return;
            }
            Console.WriteLine("Uploaded high score successfully!");
        }
    }
}
