// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndexerLimits
    {
        internal static SearchIndexerLimits DeserializeSearchIndexerLimits(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSpan? maxRunTime = default;
            long? maxDocumentExtractionSize = default;
            long? maxDocumentContentCharactersToExtract = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxRunTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxRunTime = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("maxDocumentExtractionSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDocumentExtractionSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxDocumentContentCharactersToExtract"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDocumentContentCharactersToExtract = property.Value.GetInt64();
                    continue;
                }
            }
            return new SearchIndexerLimits(maxRunTime, maxDocumentExtractionSize, maxDocumentContentCharactersToExtract);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SearchIndexerLimits FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSearchIndexerLimits(document.RootElement);
        }
    }
}
