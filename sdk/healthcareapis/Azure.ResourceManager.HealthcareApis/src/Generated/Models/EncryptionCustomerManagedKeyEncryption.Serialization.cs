// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    internal partial class EncryptionCustomerManagedKeyEncryption : IUtf8JsonSerializable, IJsonModel<EncryptionCustomerManagedKeyEncryption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EncryptionCustomerManagedKeyEncryption>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EncryptionCustomerManagedKeyEncryption>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionCustomerManagedKeyEncryption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EncryptionCustomerManagedKeyEncryption)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(KeyEncryptionKeyUri))
            {
                writer.WritePropertyName("keyEncryptionKeyUrl"u8);
                writer.WriteStringValue(KeyEncryptionKeyUri.AbsoluteUri);
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

        EncryptionCustomerManagedKeyEncryption IJsonModel<EncryptionCustomerManagedKeyEncryption>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionCustomerManagedKeyEncryption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EncryptionCustomerManagedKeyEncryption)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEncryptionCustomerManagedKeyEncryption(document.RootElement, options);
        }

        internal static EncryptionCustomerManagedKeyEncryption DeserializeEncryptionCustomerManagedKeyEncryption(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri keyEncryptionKeyUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyEncryptionKeyUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyEncryptionKeyUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EncryptionCustomerManagedKeyEncryption(keyEncryptionKeyUrl, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EncryptionCustomerManagedKeyEncryption>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionCustomerManagedKeyEncryption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EncryptionCustomerManagedKeyEncryption)} does not support writing '{options.Format}' format.");
            }
        }

        EncryptionCustomerManagedKeyEncryption IPersistableModel<EncryptionCustomerManagedKeyEncryption>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionCustomerManagedKeyEncryption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEncryptionCustomerManagedKeyEncryption(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EncryptionCustomerManagedKeyEncryption)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EncryptionCustomerManagedKeyEncryption>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
