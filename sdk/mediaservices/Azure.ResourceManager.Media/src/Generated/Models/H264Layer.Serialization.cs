// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class H264Layer : IUtf8JsonSerializable, IJsonModel<H264Layer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<H264Layer>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<H264Layer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<H264Layer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(H264Layer)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Profile))
            {
                writer.WritePropertyName("profile"u8);
                writer.WriteStringValue(Profile.Value.ToString());
            }
            if (Optional.IsDefined(Level))
            {
                writer.WritePropertyName("level"u8);
                writer.WriteStringValue(Level);
            }
            if (Optional.IsDefined(BufferWindow))
            {
                writer.WritePropertyName("bufferWindow"u8);
                writer.WriteStringValue(BufferWindow.Value, "P");
            }
            if (Optional.IsDefined(ConstantRateFactor))
            {
                writer.WritePropertyName("crf"u8);
                writer.WriteNumberValue(ConstantRateFactor.Value);
            }
            if (Optional.IsDefined(ReferenceFrames))
            {
                writer.WritePropertyName("referenceFrames"u8);
                writer.WriteNumberValue(ReferenceFrames.Value);
            }
            if (Optional.IsDefined(EntropyMode))
            {
                writer.WritePropertyName("entropyMode"u8);
                writer.WriteStringValue(EntropyMode.Value.ToString());
            }
        }

        H264Layer IJsonModel<H264Layer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<H264Layer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(H264Layer)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeH264Layer(document.RootElement, options);
        }

        internal static H264Layer DeserializeH264Layer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            H264VideoProfile? profile = default;
            string level = default;
            TimeSpan? bufferWindow = default;
            float? crf = default;
            int? referenceFrames = default;
            LayerEntropyMode? entropyMode = default;
            int bitrate = default;
            int? maxBitrate = default;
            int? bFrames = default;
            string frameRate = default;
            int? slices = default;
            bool? adaptiveBFrame = default;
            string width = default;
            string height = default;
            string label = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("profile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    profile = new H264VideoProfile(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("level"u8))
                {
                    level = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bufferWindow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bufferWindow = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("crf"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    crf = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("referenceFrames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    referenceFrames = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("entropyMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    entropyMode = new LayerEntropyMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("bitrate"u8))
                {
                    bitrate = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxBitrate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxBitrate = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bFrames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bFrames = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("frameRate"u8))
                {
                    frameRate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("slices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    slices = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("adaptiveBFrame"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    adaptiveBFrame = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("width"u8))
                {
                    width = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("height"u8))
                {
                    height = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new H264Layer(
                width,
                height,
                label,
                serializedAdditionalRawData,
                bitrate,
                maxBitrate,
                bFrames,
                frameRate,
                slices,
                adaptiveBFrame,
                profile,
                level,
                bufferWindow,
                crf,
                referenceFrames,
                entropyMode);
        }

        BinaryData IPersistableModel<H264Layer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<H264Layer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(H264Layer)} does not support writing '{options.Format}' format.");
            }
        }

        H264Layer IPersistableModel<H264Layer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<H264Layer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeH264Layer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(H264Layer)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<H264Layer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
