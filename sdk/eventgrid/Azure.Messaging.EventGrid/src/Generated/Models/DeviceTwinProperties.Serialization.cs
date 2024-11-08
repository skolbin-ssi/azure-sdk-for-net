// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class DeviceTwinProperties
    {
        internal static DeviceTwinProperties DeserializeDeviceTwinProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DeviceTwinMetadata metadata = default;
            float? version = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = DeviceTwinMetadata.DeserializeDeviceTwinMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetSingle();
                    continue;
                }
            }
            return new DeviceTwinProperties(metadata, version);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DeviceTwinProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDeviceTwinProperties(document.RootElement);
        }
    }
}
