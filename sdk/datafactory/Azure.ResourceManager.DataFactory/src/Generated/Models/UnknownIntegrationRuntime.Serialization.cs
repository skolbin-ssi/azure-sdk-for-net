// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class UnknownIntegrationRuntime : IUtf8JsonSerializable, IJsonModel<DataFactoryIntegrationRuntimeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryIntegrationRuntimeProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataFactoryIntegrationRuntimeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryIntegrationRuntimeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryIntegrationRuntimeProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            foreach (var item in AdditionalProperties)
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

        DataFactoryIntegrationRuntimeProperties IJsonModel<DataFactoryIntegrationRuntimeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryIntegrationRuntimeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryIntegrationRuntimeProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryIntegrationRuntimeProperties(document.RootElement, options);
        }

        internal static UnknownIntegrationRuntime DeserializeUnknownIntegrationRuntime(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationRuntimeType type = "Unknown";
            string description = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new IntegrationRuntimeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new UnknownIntegrationRuntime(type, description, additionalProperties);
        }

        BinaryData IPersistableModel<DataFactoryIntegrationRuntimeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryIntegrationRuntimeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFactoryIntegrationRuntimeProperties)} does not support writing '{options.Format}' format.");
            }
        }

        DataFactoryIntegrationRuntimeProperties IPersistableModel<DataFactoryIntegrationRuntimeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryIntegrationRuntimeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFactoryIntegrationRuntimeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFactoryIntegrationRuntimeProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryIntegrationRuntimeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
