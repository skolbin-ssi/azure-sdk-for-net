// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class SignalRServiceClientConnectionConnectedEventData : IUtf8JsonSerializable, IJsonModel<SignalRServiceClientConnectionConnectedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SignalRServiceClientConnectionConnectedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SignalRServiceClientConnectionConnectedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRServiceClientConnectionConnectedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SignalRServiceClientConnectionConnectedEventData)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("timestamp"u8);
            writer.WriteStringValue(Timestamp, "O");
            if (Optional.IsDefined(HubName))
            {
                writer.WritePropertyName("hubName"u8);
                writer.WriteStringValue(HubName);
            }
            if (Optional.IsDefined(ConnectionId))
            {
                writer.WritePropertyName("connectionId"u8);
                writer.WriteStringValue(ConnectionId);
            }
            if (Optional.IsDefined(UserId))
            {
                writer.WritePropertyName("userId"u8);
                writer.WriteStringValue(UserId);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        SignalRServiceClientConnectionConnectedEventData IJsonModel<SignalRServiceClientConnectionConnectedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRServiceClientConnectionConnectedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SignalRServiceClientConnectionConnectedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSignalRServiceClientConnectionConnectedEventData(document.RootElement, options);
        }

        internal static SignalRServiceClientConnectionConnectedEventData DeserializeSignalRServiceClientConnectionConnectedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset timestamp = default;
            string hubName = default;
            string connectionId = default;
            string userId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"u8))
                {
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("hubName"u8))
                {
                    hubName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionId"u8))
                {
                    connectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userId"u8))
                {
                    userId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SignalRServiceClientConnectionConnectedEventData(timestamp, hubName, connectionId, userId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SignalRServiceClientConnectionConnectedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRServiceClientConnectionConnectedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SignalRServiceClientConnectionConnectedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        SignalRServiceClientConnectionConnectedEventData IPersistableModel<SignalRServiceClientConnectionConnectedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRServiceClientConnectionConnectedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSignalRServiceClientConnectionConnectedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SignalRServiceClientConnectionConnectedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SignalRServiceClientConnectionConnectedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SignalRServiceClientConnectionConnectedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSignalRServiceClientConnectionConnectedEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
