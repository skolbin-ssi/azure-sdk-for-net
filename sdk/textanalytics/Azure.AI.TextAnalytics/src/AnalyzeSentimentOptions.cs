// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// Options that allow callers to specify details about how the operation
    /// is run. For example set model version, whether to include statistics, and execute Opinion Mining.
    /// </summary>
    public class AnalyzeSentimentOptions : TextAnalyticsRequestOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeSentimentOptions"/>
        /// class which allows callers to specify details about how the operation
        /// is run. For example set model version, whether to include statistics, and execute Opinion Mining.
        /// </summary>
        public AnalyzeSentimentOptions()
        {
        }

        internal AnalyzeSentimentOptions(TextAnalyticsRequestOptions options)
            : base(options.IncludeStatistics, options.ModelVersion)
        {
        }

        /// <summary>
        /// Sentiment analysis results with Opinion Mining, also known as Aspect-based Sentiment Analysis.
        /// Only available for Text Analytics Service version v3.1-preview.1 and above.
        /// </summary>
        public bool IncludeOpinionMining { get; set; }
}
}
