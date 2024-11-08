// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Maps.Geolocation
{
    internal partial class CountryRegion
    {
        internal static CountryRegion DeserializeCountryRegion(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string isoCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isoCode"u8))
                {
                    isoCode = property.Value.GetString();
                    continue;
                }
            }
            return new CountryRegion(isoCode);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CountryRegion FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCountryRegion(document.RootElement);
        }
    }
}
