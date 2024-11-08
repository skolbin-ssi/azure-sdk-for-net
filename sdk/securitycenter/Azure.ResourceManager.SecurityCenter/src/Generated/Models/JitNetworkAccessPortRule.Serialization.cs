// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class JitNetworkAccessPortRule : IUtf8JsonSerializable, IJsonModel<JitNetworkAccessPortRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JitNetworkAccessPortRule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<JitNetworkAccessPortRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitNetworkAccessPortRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JitNetworkAccessPortRule)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("number"u8);
            writer.WriteNumberValue(Number);
            writer.WritePropertyName("protocol"u8);
            writer.WriteStringValue(Protocol.ToString());
            if (Optional.IsDefined(AllowedSourceAddressPrefix))
            {
                writer.WritePropertyName("allowedSourceAddressPrefix"u8);
                writer.WriteStringValue(AllowedSourceAddressPrefix);
            }
            if (Optional.IsCollectionDefined(AllowedSourceAddressPrefixes))
            {
                writer.WritePropertyName("allowedSourceAddressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedSourceAddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("maxRequestAccessDuration"u8);
            writer.WriteStringValue(MaxRequestAccessDuration, "P");
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

        JitNetworkAccessPortRule IJsonModel<JitNetworkAccessPortRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitNetworkAccessPortRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JitNetworkAccessPortRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJitNetworkAccessPortRule(document.RootElement, options);
        }

        internal static JitNetworkAccessPortRule DeserializeJitNetworkAccessPortRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int number = default;
            JitNetworkAccessPortProtocol protocol = default;
            string allowedSourceAddressPrefix = default;
            IList<string> allowedSourceAddressPrefixes = default;
            TimeSpan maxRequestAccessDuration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("number"u8))
                {
                    number = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    protocol = new JitNetworkAccessPortProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowedSourceAddressPrefix"u8))
                {
                    allowedSourceAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowedSourceAddressPrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedSourceAddressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("maxRequestAccessDuration"u8))
                {
                    maxRequestAccessDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new JitNetworkAccessPortRule(
                number,
                protocol,
                allowedSourceAddressPrefix,
                allowedSourceAddressPrefixes ?? new ChangeTrackingList<string>(),
                maxRequestAccessDuration,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<JitNetworkAccessPortRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitNetworkAccessPortRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(JitNetworkAccessPortRule)} does not support writing '{options.Format}' format.");
            }
        }

        JitNetworkAccessPortRule IPersistableModel<JitNetworkAccessPortRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitNetworkAccessPortRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeJitNetworkAccessPortRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(JitNetworkAccessPortRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<JitNetworkAccessPortRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
