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
    [JsonConverter(typeof(EvaluateDataFlowExpressionRequestConverter))]
    public partial class EvaluateDataFlowExpressionRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId);
            }
            if (Optional.IsDefined(DataFlowName))
            {
                writer.WritePropertyName("dataFlowName"u8);
                writer.WriteStringValue(DataFlowName);
            }
            if (Optional.IsDefined(StreamName))
            {
                writer.WritePropertyName("streamName"u8);
                writer.WriteStringValue(StreamName);
            }
            if (Optional.IsDefined(RowLimits))
            {
                writer.WritePropertyName("rowLimits"u8);
                writer.WriteNumberValue(RowLimits.Value);
            }
            if (Optional.IsDefined(Expression))
            {
                writer.WritePropertyName("expression"u8);
                writer.WriteStringValue(Expression);
            }
            writer.WriteEndObject();
        }

        internal static EvaluateDataFlowExpressionRequest DeserializeEvaluateDataFlowExpressionRequest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sessionId = default;
            string dataFlowName = default;
            string streamName = default;
            int? rowLimits = default;
            string expression = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"u8))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFlowName"u8))
                {
                    dataFlowName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streamName"u8))
                {
                    streamName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rowLimits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rowLimits = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("expression"u8))
                {
                    expression = property.Value.GetString();
                    continue;
                }
            }
            return new EvaluateDataFlowExpressionRequest(sessionId, dataFlowName, streamName, rowLimits, expression);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static EvaluateDataFlowExpressionRequest FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeEvaluateDataFlowExpressionRequest(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class EvaluateDataFlowExpressionRequestConverter : JsonConverter<EvaluateDataFlowExpressionRequest>
        {
            public override void Write(Utf8JsonWriter writer, EvaluateDataFlowExpressionRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override EvaluateDataFlowExpressionRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEvaluateDataFlowExpressionRequest(document.RootElement);
            }
        }
    }
}
