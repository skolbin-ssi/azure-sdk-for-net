// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Rendering
{
    public partial class RegionalCopyright
    {
        internal static RegionalCopyright DeserializeRegionalCopyright(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<string> copyrights = default;
            RegionalCopyrightCountry country = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("copyrights"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    copyrights = array;
                    continue;
                }
                if (property.NameEquals("country"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    country = RegionalCopyrightCountry.DeserializeRegionalCopyrightCountry(property.Value);
                    continue;
                }
            }
            return new RegionalCopyright(copyrights ?? new ChangeTrackingList<string>(), country);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RegionalCopyright FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRegionalCopyright(document.RootElement);
        }
    }
}
