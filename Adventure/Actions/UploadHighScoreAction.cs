using System;
using System.Threading.Tasks;
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
            var player = Player.GetInstance();
            Console.WriteLine("Uploading high score, please wait...");
            Task<IRestResponse> task = Task.Factory.StartNew(() => UploadToWebService());
            task.Wait(120000);
            if (!task.IsCompleted)
            {
                Console.WriteLine("Attempt to upload high scores timed out.");
                return;
            }
            var response = task.Result;
            if (!response.IsSuccessful)
            {
                Console.WriteLine("Couldn't communicate with web service to upload high score.");
                return;
            }
            Console.WriteLine($"Uploaded high score ({player.Confidence}) successfully!");
        }

        private IRestResponse UploadToWebService()
        {
            var player = Player.GetInstance();
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
                    ""Score"":""{player.Confidence}"",
                    ""Time"":""{DateTime.Now.Ticks}""}}",
                ParameterType.RequestBody);
            return client.Execute(request);
        }
    }
}
