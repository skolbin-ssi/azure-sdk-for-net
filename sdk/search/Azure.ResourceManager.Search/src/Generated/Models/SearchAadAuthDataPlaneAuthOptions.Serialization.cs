// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Search.Models
{
    public partial class SearchAadAuthDataPlaneAuthOptions : IUtf8JsonSerializable, IJsonModel<SearchAadAuthDataPlaneAuthOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SearchAadAuthDataPlaneAuthOptions>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SearchAadAuthDataPlaneAuthOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchAadAuthDataPlaneAuthOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SearchAadAuthDataPlaneAuthOptions)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ApiKeyOnly))
            {
                writer.WritePropertyName("apiKeyOnly"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ApiKeyOnly);
#else
                using (JsonDocument document = JsonDocument.Parse(ApiKeyOnly))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(AadOrApiKey))
            {
                writer.WritePropertyName("aadOrApiKey"u8);
                writer.WriteObjectValue(AadOrApiKey, options);
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

        SearchAadAuthDataPlaneAuthOptions IJsonModel<SearchAadAuthDataPlaneAuthOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchAadAuthDataPlaneAuthOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SearchAadAuthDataPlaneAuthOptions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchAadAuthDataPlaneAuthOptions(document.RootElement, options);
        }

        internal static SearchAadAuthDataPlaneAuthOptions DeserializeSearchAadAuthDataPlaneAuthOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BinaryData apiKeyOnly = default;
            DataPlaneAadOrApiKeyAuthOption aadOrApiKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiKeyOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    apiKeyOnly = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("aadOrApiKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aadOrApiKey = DataPlaneAadOrApiKeyAuthOption.DeserializeDataPlaneAadOrApiKeyAuthOption(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SearchAadAuthDataPlaneAuthOptions(apiKeyOnly, aadOrApiKey, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiKeyOnly), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  apiKeyOnly: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiKeyOnly))
                {
                    builder.Append("  apiKeyOnly: ");
                    builder.AppendLine($"'{ApiKeyOnly.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("AadAuthFailureMode", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  aadOrApiKey: ");
                builder.AppendLine("{");
                builder.Append("    aadAuthFailureMode: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(AadOrApiKey))
                {
                    builder.Append("  aadOrApiKey: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AadOrApiKey, options, 2, false, "  aadOrApiKey: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SearchAadAuthDataPlaneAuthOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchAadAuthDataPlaneAuthOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SearchAadAuthDataPlaneAuthOptions)} does not support writing '{options.Format}' format.");
            }
        }

        SearchAadAuthDataPlaneAuthOptions IPersistableModel<SearchAadAuthDataPlaneAuthOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchAadAuthDataPlaneAuthOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSearchAadAuthDataPlaneAuthOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SearchAadAuthDataPlaneAuthOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SearchAadAuthDataPlaneAuthOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
