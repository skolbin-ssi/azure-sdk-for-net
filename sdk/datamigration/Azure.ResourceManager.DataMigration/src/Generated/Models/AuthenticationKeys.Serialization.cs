// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class AuthenticationKeys : IUtf8JsonSerializable, IJsonModel<AuthenticationKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AuthenticationKeys>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AuthenticationKeys>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthenticationKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AuthenticationKeys)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AuthKey1))
            {
                writer.WritePropertyName("authKey1"u8);
                writer.WriteStringValue(AuthKey1);
            }
            if (Optional.IsDefined(AuthKey2))
            {
                writer.WritePropertyName("authKey2"u8);
                writer.WriteStringValue(AuthKey2);
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

        AuthenticationKeys IJsonModel<AuthenticationKeys>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthenticationKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AuthenticationKeys)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAuthenticationKeys(document.RootElement, options);
        }

        internal static AuthenticationKeys DeserializeAuthenticationKeys(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string authKey1 = default;
            string authKey2 = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authKey1"u8))
                {
                    authKey1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authKey2"u8))
                {
                    authKey2 = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AuthenticationKeys(authKey1, authKey2, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AuthenticationKeys>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthenticationKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AuthenticationKeys)} does not support writing '{options.Format}' format.");
            }
        }

        AuthenticationKeys IPersistableModel<AuthenticationKeys>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthenticationKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAuthenticationKeys(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AuthenticationKeys)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AuthenticationKeys>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
