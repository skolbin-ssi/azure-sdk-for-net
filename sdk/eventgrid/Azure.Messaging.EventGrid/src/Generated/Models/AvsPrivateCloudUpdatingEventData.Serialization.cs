// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AvsPrivateCloudUpdatingEventDataConverter))]
    public partial class AvsPrivateCloudUpdatingEventData
    {
        internal static AvsPrivateCloudUpdatingEventData DeserializeAvsPrivateCloudUpdatingEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string operationId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
            }
            return new AvsPrivateCloudUpdatingEventData(operationId);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AvsPrivateCloudUpdatingEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAvsPrivateCloudUpdatingEventData(document.RootElement);
        }

        internal partial class AvsPrivateCloudUpdatingEventDataConverter : JsonConverter<AvsPrivateCloudUpdatingEventData>
        {
            public override void Write(Utf8JsonWriter writer, AvsPrivateCloudUpdatingEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override AvsPrivateCloudUpdatingEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAvsPrivateCloudUpdatingEventData(document.RootElement);
            }
        }
    }
}
