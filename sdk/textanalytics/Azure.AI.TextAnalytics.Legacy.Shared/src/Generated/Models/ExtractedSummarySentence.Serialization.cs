// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    internal partial class ExtractedSummarySentence
    {
        internal static ExtractedSummarySentence DeserializeExtractedSummarySentence(JsonElement element)
        {
            string text = default;
            double rankScore = default;
            int offset = default;
            int length = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rankScore"))
                {
                    rankScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("offset"))
                {
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
            }
            return new ExtractedSummarySentence(text, rankScore, offset, length);
        }
    }
}
