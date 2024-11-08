// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Monitor.OpenTelemetry.AspNetCore.Models
{
    internal partial class CollectionConfigurationInfo
    {
        internal static CollectionConfigurationInfo DeserializeCollectionConfigurationInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string eTag = default;
            IReadOnlyList<DerivedMetricInfo> metrics = default;
            IReadOnlyList<DocumentStreamInfo> documentStreams = default;
            QuotaConfigurationInfo quotaInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ETag"u8))
                {
                    eTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Metrics"u8))
                {
                    List<DerivedMetricInfo> array = new List<DerivedMetricInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DerivedMetricInfo.DeserializeDerivedMetricInfo(item));
                    }
                    metrics = array;
                    continue;
                }
                if (property.NameEquals("DocumentStreams"u8))
                {
                    List<DocumentStreamInfo> array = new List<DocumentStreamInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentStreamInfo.DeserializeDocumentStreamInfo(item));
                    }
                    documentStreams = array;
                    continue;
                }
                if (property.NameEquals("QuotaInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quotaInfo = QuotaConfigurationInfo.DeserializeQuotaConfigurationInfo(property.Value);
                    continue;
                }
            }
            return new CollectionConfigurationInfo(eTag, metrics, documentStreams, quotaInfo);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CollectionConfigurationInfo FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCollectionConfigurationInfo(document.RootElement);
        }
    }
}
