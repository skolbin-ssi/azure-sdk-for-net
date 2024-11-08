// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AnomalyResultList
    {
        internal static AnomalyResultList DeserializeAnomalyResultList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string nextLink = default;
            IReadOnlyList<DataPointAnomaly> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    List<DataPointAnomaly> array = new List<DataPointAnomaly>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataPointAnomaly.DeserializeDataPointAnomaly(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new AnomalyResultList(nextLink, value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AnomalyResultList FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAnomalyResultList(document.RootElement);
        }
    }
}
