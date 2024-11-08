// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class AveragePartitionLoadScalingTrigger : IUtf8JsonSerializable, IJsonModel<AveragePartitionLoadScalingTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AveragePartitionLoadScalingTrigger>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AveragePartitionLoadScalingTrigger>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AveragePartitionLoadScalingTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AveragePartitionLoadScalingTrigger)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("metricName"u8);
            writer.WriteStringValue(MetricName);
            writer.WritePropertyName("lowerLoadThreshold"u8);
            writer.WriteNumberValue(LowerLoadThreshold);
            writer.WritePropertyName("upperLoadThreshold"u8);
            writer.WriteNumberValue(UpperLoadThreshold);
            writer.WritePropertyName("scaleInterval"u8);
            writer.WriteStringValue(ScaleInterval);
        }

        AveragePartitionLoadScalingTrigger IJsonModel<AveragePartitionLoadScalingTrigger>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AveragePartitionLoadScalingTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AveragePartitionLoadScalingTrigger)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAveragePartitionLoadScalingTrigger(document.RootElement, options);
        }

        internal static AveragePartitionLoadScalingTrigger DeserializeAveragePartitionLoadScalingTrigger(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string metricName = default;
            double lowerLoadThreshold = default;
            double upperLoadThreshold = default;
            string scaleInterval = default;
            ServiceScalingTriggerKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricName"u8))
                {
                    metricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lowerLoadThreshold"u8))
                {
                    lowerLoadThreshold = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("upperLoadThreshold"u8))
                {
                    upperLoadThreshold = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("scaleInterval"u8))
                {
                    scaleInterval = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new ServiceScalingTriggerKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AveragePartitionLoadScalingTrigger(
                kind,
                serializedAdditionalRawData,
                metricName,
                lowerLoadThreshold,
                upperLoadThreshold,
                scaleInterval);
        }

        BinaryData IPersistableModel<AveragePartitionLoadScalingTrigger>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AveragePartitionLoadScalingTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AveragePartitionLoadScalingTrigger)} does not support writing '{options.Format}' format.");
            }
        }

        AveragePartitionLoadScalingTrigger IPersistableModel<AveragePartitionLoadScalingTrigger>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AveragePartitionLoadScalingTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAveragePartitionLoadScalingTrigger(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AveragePartitionLoadScalingTrigger)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AveragePartitionLoadScalingTrigger>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
