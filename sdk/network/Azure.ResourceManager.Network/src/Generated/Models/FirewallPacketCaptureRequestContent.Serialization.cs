// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPacketCaptureRequestContent : IUtf8JsonSerializable, IJsonModel<FirewallPacketCaptureRequestContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallPacketCaptureRequestContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FirewallPacketCaptureRequestContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPacketCaptureRequestContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallPacketCaptureRequestContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(DurationInSeconds))
            {
                writer.WritePropertyName("durationInSeconds"u8);
                writer.WriteNumberValue(DurationInSeconds.Value);
            }
            if (Optional.IsDefined(NumberOfPacketsToCapture))
            {
                writer.WritePropertyName("numberOfPacketsToCapture"u8);
                writer.WriteNumberValue(NumberOfPacketsToCapture.Value);
            }
            if (Optional.IsDefined(SasUri))
            {
                writer.WritePropertyName("sasUrl"u8);
                writer.WriteStringValue(SasUri.AbsoluteUri);
            }
            if (Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("fileName"u8);
                writer.WriteStringValue(FileName);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Flags))
            {
                writer.WritePropertyName("flags"u8);
                writer.WriteStartArray();
                foreach (var item in Flags)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Filters))
            {
                writer.WritePropertyName("filters"u8);
                writer.WriteStartArray();
                foreach (var item in Filters)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        FirewallPacketCaptureRequestContent IJsonModel<FirewallPacketCaptureRequestContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPacketCaptureRequestContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallPacketCaptureRequestContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallPacketCaptureRequestContent(document.RootElement, options);
        }

        internal static FirewallPacketCaptureRequestContent DeserializeFirewallPacketCaptureRequestContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? durationInSeconds = default;
            int? numberOfPacketsToCapture = default;
            Uri sasUrl = default;
            string fileName = default;
            AzureFirewallNetworkRuleProtocol? protocol = default;
            IList<AzureFirewallPacketCaptureFlags> flags = default;
            IList<AzureFirewallPacketCaptureRule> filters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("durationInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    durationInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numberOfPacketsToCapture"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfPacketsToCapture = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sasUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sasUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fileName"u8))
                {
                    fileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protocol = new AzureFirewallNetworkRuleProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("flags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureFirewallPacketCaptureFlags> array = new List<AzureFirewallPacketCaptureFlags>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureFirewallPacketCaptureFlags.DeserializeAzureFirewallPacketCaptureFlags(item, options));
                    }
                    flags = array;
                    continue;
                }
                if (property.NameEquals("filters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureFirewallPacketCaptureRule> array = new List<AzureFirewallPacketCaptureRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureFirewallPacketCaptureRule.DeserializeAzureFirewallPacketCaptureRule(item, options));
                    }
                    filters = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FirewallPacketCaptureRequestContent(
                durationInSeconds,
                numberOfPacketsToCapture,
                sasUrl,
                fileName,
                protocol,
                flags ?? new ChangeTrackingList<AzureFirewallPacketCaptureFlags>(),
                filters ?? new ChangeTrackingList<AzureFirewallPacketCaptureRule>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirewallPacketCaptureRequestContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPacketCaptureRequestContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FirewallPacketCaptureRequestContent)} does not support writing '{options.Format}' format.");
            }
        }

        FirewallPacketCaptureRequestContent IPersistableModel<FirewallPacketCaptureRequestContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPacketCaptureRequestContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFirewallPacketCaptureRequestContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirewallPacketCaptureRequestContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirewallPacketCaptureRequestContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
