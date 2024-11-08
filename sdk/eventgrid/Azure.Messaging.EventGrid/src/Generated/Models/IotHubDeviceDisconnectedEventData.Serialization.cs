// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(IotHubDeviceDisconnectedEventDataConverter))]
    public partial class IotHubDeviceDisconnectedEventData
    {
        internal static IotHubDeviceDisconnectedEventData DeserializeIotHubDeviceDisconnectedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string deviceId = default;
            string moduleId = default;
            string hubName = default;
            DeviceConnectionStateEventInfo deviceConnectionStateEventInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceId"u8))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("moduleId"u8))
                {
                    moduleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hubName"u8))
                {
                    hubName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceConnectionStateEventInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceConnectionStateEventInfo = DeviceConnectionStateEventInfo.DeserializeDeviceConnectionStateEventInfo(property.Value);
                    continue;
                }
            }
            return new IotHubDeviceDisconnectedEventData(deviceId, moduleId, hubName, deviceConnectionStateEventInfo);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new IotHubDeviceDisconnectedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeIotHubDeviceDisconnectedEventData(document.RootElement);
        }

        internal partial class IotHubDeviceDisconnectedEventDataConverter : JsonConverter<IotHubDeviceDisconnectedEventData>
        {
            public override void Write(Utf8JsonWriter writer, IotHubDeviceDisconnectedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override IotHubDeviceDisconnectedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeIotHubDeviceDisconnectedEventData(document.RootElement);
            }
        }
    }
}
