// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SapLandscapeMonitorMetricThresholds : IUtf8JsonSerializable, IJsonModel<SapLandscapeMonitorMetricThresholds>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SapLandscapeMonitorMetricThresholds>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SapLandscapeMonitorMetricThresholds>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapLandscapeMonitorMetricThresholds>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapLandscapeMonitorMetricThresholds)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Green))
            {
                writer.WritePropertyName("green"u8);
                writer.WriteNumberValue(Green.Value);
            }
            if (Optional.IsDefined(Yellow))
            {
                writer.WritePropertyName("yellow"u8);
                writer.WriteNumberValue(Yellow.Value);
            }
            if (Optional.IsDefined(Red))
            {
                writer.WritePropertyName("red"u8);
                writer.WriteNumberValue(Red.Value);
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

        SapLandscapeMonitorMetricThresholds IJsonModel<SapLandscapeMonitorMetricThresholds>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapLandscapeMonitorMetricThresholds>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapLandscapeMonitorMetricThresholds)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSapLandscapeMonitorMetricThresholds(document.RootElement, options);
        }

        internal static SapLandscapeMonitorMetricThresholds DeserializeSapLandscapeMonitorMetricThresholds(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            float? green = default;
            float? yellow = default;
            float? red = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("green"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    green = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("yellow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    yellow = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("red"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    red = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SapLandscapeMonitorMetricThresholds(name, green, yellow, red, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SapLandscapeMonitorMetricThresholds>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapLandscapeMonitorMetricThresholds>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SapLandscapeMonitorMetricThresholds)} does not support writing '{options.Format}' format.");
            }
        }

        SapLandscapeMonitorMetricThresholds IPersistableModel<SapLandscapeMonitorMetricThresholds>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapLandscapeMonitorMetricThresholds>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSapLandscapeMonitorMetricThresholds(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SapLandscapeMonitorMetricThresholds)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SapLandscapeMonitorMetricThresholds>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
