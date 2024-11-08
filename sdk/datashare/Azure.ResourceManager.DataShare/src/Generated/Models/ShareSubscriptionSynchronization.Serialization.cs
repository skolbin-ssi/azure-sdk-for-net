// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class ShareSubscriptionSynchronization : IUtf8JsonSerializable, IJsonModel<ShareSubscriptionSynchronization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ShareSubscriptionSynchronization>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ShareSubscriptionSynchronization>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareSubscriptionSynchronization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ShareSubscriptionSynchronization)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(DurationInMilliSeconds))
            {
                writer.WritePropertyName("durationMs"u8);
                writer.WriteNumberValue(DurationInMilliSeconds.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            writer.WritePropertyName("synchronizationId"u8);
            writer.WriteStringValue(SynchronizationId);
            if (options.Format != "W" && Optional.IsDefined(SynchronizationMode))
            {
                writer.WritePropertyName("synchronizationMode"u8);
                writer.WriteStringValue(SynchronizationMode.Value.ToString());
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

        ShareSubscriptionSynchronization IJsonModel<ShareSubscriptionSynchronization>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareSubscriptionSynchronization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ShareSubscriptionSynchronization)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeShareSubscriptionSynchronization(document.RootElement, options);
        }

        internal static ShareSubscriptionSynchronization DeserializeShareSubscriptionSynchronization(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? durationMs = default;
            DateTimeOffset? endTime = default;
            string message = default;
            DateTimeOffset? startTime = default;
            string status = default;
            Guid synchronizationId = default;
            SynchronizationMode? synchronizationMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("durationMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    durationMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("synchronizationId"u8))
                {
                    synchronizationId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("synchronizationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    synchronizationMode = new SynchronizationMode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ShareSubscriptionSynchronization(
                durationMs,
                endTime,
                message,
                startTime,
                status,
                synchronizationId,
                synchronizationMode,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ShareSubscriptionSynchronization>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareSubscriptionSynchronization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ShareSubscriptionSynchronization)} does not support writing '{options.Format}' format.");
            }
        }

        ShareSubscriptionSynchronization IPersistableModel<ShareSubscriptionSynchronization>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareSubscriptionSynchronization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeShareSubscriptionSynchronization(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ShareSubscriptionSynchronization)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ShareSubscriptionSynchronization>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
