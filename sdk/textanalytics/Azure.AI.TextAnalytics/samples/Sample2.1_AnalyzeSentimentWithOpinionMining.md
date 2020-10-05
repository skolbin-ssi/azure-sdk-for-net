# Analyze sentiment with Opinion Mining

This sample demonstrates how to analyze sentiment of documents and get more granular information about the opinions related to aspects of a product/service, also knows as Aspect-based Sentiment Analysis in Natural Language Processing (NLP). This feature is only available for clients with api version v3.1-preview.1 and higher.

In order to do so, we will use the Sentiment Analysis feature of the Text Analytics client library. To get started you'll need a Text Analytics endpoint and credentials.  See [README][README] for links and instructions.

## Creating a `TextAnalyticsClient`

To create a new `TextAnalyticsClient`, you need a Text Analytics endpoint and credentials.  You can use the [DefaultAzureCredential][DefaultAzureCredential] to try a number of common authentication methods optimized for both running as a service and development.  In the sample below, however, you'll use a Text Analytics API key credential by creating an `AzureKeyCredential` object, that if needed, will allow you to update the API key without creating a new client.

You can set `endpoint` and `apiKey` based on an environment variable, a configuration setting, or any way that works for your application.

```C# Snippet:TextAnalyticsSample1CreateClient
var client = new TextAnalyticsClient(new Uri(endpoint), new AzureKeyCredential(apiKey));
```

## Opinion Mining

To get a deeper analysis youe will need to include the `AdditionalSentimentAnalyses.OpinionMining` type into the `AnalyzeSentimentOptions`.

```C# Snippet:TAAnalyzeSentimentWithOpinionMining
var documents = new List<string>
{
    "Bad atmosphere.",
    "Staff are not friendly and helpful."
};

AnalyzeSentimentResultCollection reviews = client.AnalyzeSentimentBatch(documents, options: new AnalyzeSentimentOptions() { AdditionalSentimentAnalyses = AdditionalSentimentAnalyses.OpinionMining });

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
```

[DefaultAzureCredential]: https://github.com/Azure/azure-sdk-for-net/blob/master/sdk/identity/Azure.Identity/README.md
[README]: https://github.com/Azure/azure-sdk-for-net/blob/master/sdk/textanalytics/Azure.AI.TextAnalytics/README.md