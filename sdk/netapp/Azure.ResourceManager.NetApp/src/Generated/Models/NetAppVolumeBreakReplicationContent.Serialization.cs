// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeBreakReplicationContent : IUtf8JsonSerializable, IJsonModel<NetAppVolumeBreakReplicationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppVolumeBreakReplicationContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetAppVolumeBreakReplicationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBreakReplicationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumeBreakReplicationContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ForceBreakReplication))
            {
                writer.WritePropertyName("forceBreakReplication"u8);
                writer.WriteBooleanValue(ForceBreakReplication.Value);
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

        NetAppVolumeBreakReplicationContent IJsonModel<NetAppVolumeBreakReplicationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBreakReplicationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumeBreakReplicationContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppVolumeBreakReplicationContent(document.RootElement, options);
        }

        internal static NetAppVolumeBreakReplicationContent DeserializeNetAppVolumeBreakReplicationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? forceBreakReplication = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("forceBreakReplication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    forceBreakReplication = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetAppVolumeBreakReplicationContent(forceBreakReplication, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppVolumeBreakReplicationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBreakReplicationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeBreakReplicationContent)} does not support writing '{options.Format}' format.");
            }
        }

        NetAppVolumeBreakReplicationContent IPersistableModel<NetAppVolumeBreakReplicationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBreakReplicationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetAppVolumeBreakReplicationContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeBreakReplicationContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetAppVolumeBreakReplicationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
