// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// Options that allow callers to specify details about how the operation
    /// is run. For example set model version, whether to include statistics, and  execute opinion minding.
    /// </summary>
    public class AnalyzeSentimentOptions : TextAnalyticsRequestOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeSentimentOptions"/>
        /// class which allows callers to specify details about how the operation
        /// is run. For example set model version, whether to include statistics, and  execute opinion minding.
        /// </summary>
        public AnalyzeSentimentOptions()
        {
        }

        internal AnalyzeSentimentOptions(TextAnalyticsRequestOptions options)
            : base(options.IncludeStatistics, options.ModelVersion)
        {
        }

        /// <summary>
        /// Additional types of Sentiment Analysis to be applied to the
        /// AnalyzeSentiment method, like for example Opinion Mining.
        /// </summary>
        public AdditionalSentimentAnalyses AdditionalSentimentAnalyses { get; set; }
}
}
