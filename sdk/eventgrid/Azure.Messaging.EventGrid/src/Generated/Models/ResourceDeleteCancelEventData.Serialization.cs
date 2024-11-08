// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ResourceDeleteCancelEventDataConverter))]
    public partial class ResourceDeleteCancelEventData
    {
        internal static ResourceDeleteCancelEventData DeserializeResourceDeleteCancelEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string tenantId = default;
            string subscriptionId = default;
            string resourceGroup = default;
            string resourceProvider = default;
            string resourceUri = default;
            string operationName = default;
            string status = default;
            JsonElement authorization = default;
            JsonElement claims = default;
            string correlationId = default;
            JsonElement httpRequest = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"u8))
                {
                    tenantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceProvider"u8))
                {
                    resourceProvider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceUri"u8))
                {
                    resourceUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationName"u8))
                {
                    operationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authorization"u8))
                {
                    authorization = property.Value.Clone();
                    continue;
                }
                if (property.NameEquals("claims"u8))
                {
                    claims = property.Value.Clone();
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpRequest"u8))
                {
                    httpRequest = property.Value.Clone();
                    continue;
                }
            }
            return new ResourceDeleteCancelEventData(
                tenantId,
                subscriptionId,
                resourceGroup,
                resourceProvider,
                resourceUri,
                operationName,
                status,
                authorization,
                claims,
                correlationId,
                httpRequest);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ResourceDeleteCancelEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeResourceDeleteCancelEventData(document.RootElement);
        }

        internal partial class ResourceDeleteCancelEventDataConverter : JsonConverter<ResourceDeleteCancelEventData>
        {
            public override void Write(Utf8JsonWriter writer, ResourceDeleteCancelEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override ResourceDeleteCancelEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeResourceDeleteCancelEventData(document.RootElement);
            }
        }
    }
}
