// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Routing.Models
{
    public partial class RouteDirectionsBatchResult
    {
        internal static RouteDirectionsBatchResult DeserializeRouteDirectionsBatchResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<RouteDirectionsBatchItem> batchItems = default;
            BatchResultSummary summary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("batchItems"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouteDirectionsBatchItem> array = new List<RouteDirectionsBatchItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteDirectionsBatchItem.DeserializeRouteDirectionsBatchItem(item));
                    }
                    batchItems = array;
                    continue;
                }
                if (property.NameEquals("summary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    summary = BatchResultSummary.DeserializeBatchResultSummary(property.Value);
                    continue;
                }
            }
            return new RouteDirectionsBatchResult(summary, batchItems ?? new ChangeTrackingList<RouteDirectionsBatchItem>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new RouteDirectionsBatchResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRouteDirectionsBatchResult(document.RootElement);
        }
    }
}
