// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class DeviceTwinInfoX509Thumbprint
    {
        internal static DeviceTwinInfoX509Thumbprint DeserializeDeviceTwinInfoX509Thumbprint(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string primaryThumbprint = default;
            string secondaryThumbprint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryThumbprint"u8))
                {
                    primaryThumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryThumbprint"u8))
                {
                    secondaryThumbprint = property.Value.GetString();
                    continue;
                }
            }
            return new DeviceTwinInfoX509Thumbprint(primaryThumbprint, secondaryThumbprint);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DeviceTwinInfoX509Thumbprint FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDeviceTwinInfoX509Thumbprint(document.RootElement);
        }
    }
}
