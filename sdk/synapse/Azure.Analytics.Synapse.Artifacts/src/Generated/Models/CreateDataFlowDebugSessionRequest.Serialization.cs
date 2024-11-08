// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(CreateDataFlowDebugSessionRequestConverter))]
    public partial class CreateDataFlowDebugSessionRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ComputeType))
            {
                writer.WritePropertyName("computeType"u8);
                writer.WriteStringValue(ComputeType);
            }
            if (Optional.IsDefined(CoreCount))
            {
                writer.WritePropertyName("coreCount"u8);
                writer.WriteNumberValue(CoreCount.Value);
            }
            if (Optional.IsDefined(TimeToLive))
            {
                writer.WritePropertyName("timeToLive"u8);
                writer.WriteNumberValue(TimeToLive.Value);
            }
            if (Optional.IsDefined(IntegrationRuntime))
            {
                writer.WritePropertyName("integrationRuntime"u8);
                writer.WriteObjectValue(IntegrationRuntime);
            }
            writer.WriteEndObject();
        }

        internal static CreateDataFlowDebugSessionRequest DeserializeCreateDataFlowDebugSessionRequest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string computeType = default;
            int? coreCount = default;
            int? timeToLive = default;
            IntegrationRuntimeDebugResource integrationRuntime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computeType"u8))
                {
                    computeType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("coreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    coreCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeToLive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeToLive = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("integrationRuntime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    integrationRuntime = IntegrationRuntimeDebugResource.DeserializeIntegrationRuntimeDebugResource(property.Value);
                    continue;
                }
            }
            return new CreateDataFlowDebugSessionRequest(computeType, coreCount, timeToLive, integrationRuntime);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CreateDataFlowDebugSessionRequest FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCreateDataFlowDebugSessionRequest(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class CreateDataFlowDebugSessionRequestConverter : JsonConverter<CreateDataFlowDebugSessionRequest>
        {
            public override void Write(Utf8JsonWriter writer, CreateDataFlowDebugSessionRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override CreateDataFlowDebugSessionRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeCreateDataFlowDebugSessionRequest(document.RootElement);
            }
        }
    }
}
