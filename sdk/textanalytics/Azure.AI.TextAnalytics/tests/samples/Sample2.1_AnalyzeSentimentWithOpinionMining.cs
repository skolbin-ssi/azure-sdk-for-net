// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.TextAnalytics.Samples
{
    [LiveOnly]
    public partial class TextAnalyticsSamples
    {
        [Test]
        public void AnalyzeSentimentWithOpinionMining()
        {
            string endpoint = TestEnvironment.Endpoint;
            string apiKey = TestEnvironment.ApiKey;

            // Instantiate a client that will be used to call the service.
            var client = new TextAnalyticsClient(new Uri(endpoint), new AzureKeyCredential(apiKey));

            #region Snippet:TAAnalyzeSentimentWithOpinionMining
            var documents = new List<string>
            {
                "Bad atmosphere.",
                "Staff are not friendly and helpful."
            };

            AnalyzeSentimentResultCollection reviews = client.AnalyzeSentimentBatch(documents, options: new AnalyzeSentimentOptions() { IncludeOpinionMining = true });

            foreach (AnalyzeSentimentResult review in reviews)
            {
                foreach (SentenceSentiment sentence in review.DocumentSentiment.Sentences)
                {
                    Console.WriteLine($"For sentence: {sentence.Text}");
                    Console.WriteLine($"    Sentiment: {sentence.Sentiment}");
                    Console.WriteLine($"    Confidence Scores: {sentence.Sentiment}");
                    Console.WriteLine($"        Positive: {sentence.ConfidenceScores.Positive}");
                    Console.WriteLine($"        Negative: {sentence.ConfidenceScores.Negative}");
                    Console.WriteLine($"        Neutral: {sentence.ConfidenceScores.Neutral}");
                    foreach (MinedOpinion minedOpinion in sentence.MinedOpinions)
                    {
                        Console.WriteLine($"    Aspect: {minedOpinion.Aspect.Text}");
                        Console.WriteLine($"        Sentiment: {minedOpinion.Aspect.Sentiment}");
                        foreach (var opinion in minedOpinion.Opinions)
                        {
                            Console.WriteLine($"    Opinion: {opinion.Text}");
                            Console.WriteLine($"        Sentiment: {opinion.Sentiment}");
                            Console.WriteLine($"        Is negated: {opinion.IsNegated}");
                        }
                    }
                }
            }
            #endregion
        }
    }
}
