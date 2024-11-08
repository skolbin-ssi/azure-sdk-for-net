// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    public partial class ExadataIormConfig : IUtf8JsonSerializable, IJsonModel<ExadataIormConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExadataIormConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExadataIormConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExadataIormConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExadataIormConfig)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(DBPlans))
            {
                writer.WritePropertyName("dbPlans"u8);
                writer.WriteStartArray();
                foreach (var item in DBPlans)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LifecycleDetails))
            {
                writer.WritePropertyName("lifecycleDetails"u8);
                writer.WriteStringValue(LifecycleDetails);
            }
            if (Optional.IsDefined(LifecycleState))
            {
                writer.WritePropertyName("lifecycleState"u8);
                writer.WriteStringValue(LifecycleState.Value.ToString());
            }
            if (Optional.IsDefined(Objective))
            {
                writer.WritePropertyName("objective"u8);
                writer.WriteStringValue(Objective.Value.ToString());
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

        ExadataIormConfig IJsonModel<ExadataIormConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExadataIormConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExadataIormConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExadataIormConfig(document.RootElement, options);
        }

        internal static ExadataIormConfig DeserializeExadataIormConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DBIormConfig> dbPlans = default;
            string lifecycleDetails = default;
            IormLifecycleState? lifecycleState = default;
            IormObjective? objective = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dbPlans"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DBIormConfig> array = new List<DBIormConfig>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DBIormConfig.DeserializeDBIormConfig(item, options));
                    }
                    dbPlans = array;
                    continue;
                }
                if (property.NameEquals("lifecycleDetails"u8))
                {
                    lifecycleDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lifecycleState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lifecycleState = new IormLifecycleState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("objective"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    objective = new IormObjective(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExadataIormConfig(dbPlans ?? new ChangeTrackingList<DBIormConfig>(), lifecycleDetails, lifecycleState, objective, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExadataIormConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExadataIormConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExadataIormConfig)} does not support writing '{options.Format}' format.");
            }
        }

        ExadataIormConfig IPersistableModel<ExadataIormConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExadataIormConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExadataIormConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExadataIormConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExadataIormConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
