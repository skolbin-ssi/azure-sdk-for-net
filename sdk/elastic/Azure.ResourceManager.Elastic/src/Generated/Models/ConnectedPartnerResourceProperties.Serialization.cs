// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Elastic.Models
{
    public partial class ConnectedPartnerResourceProperties : IUtf8JsonSerializable, IJsonModel<ConnectedPartnerResourceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectedPartnerResourceProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConnectedPartnerResourceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedPartnerResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectedPartnerResourceProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PartnerDeploymentName))
            {
                writer.WritePropertyName("partnerDeploymentName"u8);
                writer.WriteStringValue(PartnerDeploymentName);
            }
            if (Optional.IsDefined(PartnerDeploymentUri))
            {
                writer.WritePropertyName("partnerDeploymentUri"u8);
                writer.WriteStringValue(PartnerDeploymentUri.AbsoluteUri);
            }
            if (Optional.IsDefined(AzureResourceId))
            {
                writer.WritePropertyName("azureResourceId"u8);
                writer.WriteStringValue(AzureResourceId);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
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

        ConnectedPartnerResourceProperties IJsonModel<ConnectedPartnerResourceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedPartnerResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectedPartnerResourceProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectedPartnerResourceProperties(document.RootElement, options);
        }

        internal static ConnectedPartnerResourceProperties DeserializeConnectedPartnerResourceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string partnerDeploymentName = default;
            Uri partnerDeploymentUri = default;
            string azureResourceId = default;
            AzureLocation? location = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partnerDeploymentName"u8))
                {
                    partnerDeploymentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("partnerDeploymentUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partnerDeploymentUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azureResourceId"u8))
                {
                    azureResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConnectedPartnerResourceProperties(partnerDeploymentName, partnerDeploymentUri, azureResourceId, location, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectedPartnerResourceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedPartnerResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectedPartnerResourceProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ConnectedPartnerResourceProperties IPersistableModel<ConnectedPartnerResourceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedPartnerResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectedPartnerResourceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectedPartnerResourceProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectedPartnerResourceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
