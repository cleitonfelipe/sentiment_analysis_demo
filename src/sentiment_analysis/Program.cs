using System;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using sentiment_analysis.Service;

namespace sentiment_analysis
{
    class Program
    {
        private static readonly string key = "<Key Access>";
        private static readonly string endpoint = "<Endpoint>";

        static void Main(string[] args)
        {
            var client = authenticateClient();

            sentimentAnalysisExample(client);
            Console.Write("Press any key to exit.");
            Console.ReadKey();
        }
        static void sentimentAnalysisExample(ITextAnalyticsClient client)
        {
            var result = client.Sentiment("I had the best day of my life.", "en");
            Console.WriteLine("I had the best day of my life.");
            Console.WriteLine($"Sentiment Score: {result.Score:0.00}");
        }

        static TextAnalyticsClient authenticateClient()
        {
            ApiKeyServiceClientCredentials credentials = new ApiKeyServiceClientCredentials(key);
            TextAnalyticsClient client = new TextAnalyticsClient(credentials)
            {
                Endpoint = endpoint
            };
            return client;
        }
    }
}
