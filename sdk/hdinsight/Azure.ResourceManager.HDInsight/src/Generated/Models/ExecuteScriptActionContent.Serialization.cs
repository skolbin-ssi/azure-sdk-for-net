// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class ExecuteScriptActionContent : IUtf8JsonSerializable, IJsonModel<ExecuteScriptActionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExecuteScriptActionContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExecuteScriptActionContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecuteScriptActionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExecuteScriptActionContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(ScriptActions))
            {
                writer.WritePropertyName("scriptActions"u8);
                writer.WriteStartArray();
                foreach (var item in ScriptActions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("persistOnSuccess"u8);
            writer.WriteBooleanValue(PersistOnSuccess);
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

        ExecuteScriptActionContent IJsonModel<ExecuteScriptActionContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecuteScriptActionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExecuteScriptActionContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExecuteScriptActionContent(document.RootElement, options);
        }

        internal static ExecuteScriptActionContent DeserializeExecuteScriptActionContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<RuntimeScriptAction> scriptActions = default;
            bool persistOnSuccess = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scriptActions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RuntimeScriptAction> array = new List<RuntimeScriptAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RuntimeScriptAction.DeserializeRuntimeScriptAction(item, options));
                    }
                    scriptActions = array;
                    continue;
                }
                if (property.NameEquals("persistOnSuccess"u8))
                {
                    persistOnSuccess = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExecuteScriptActionContent(scriptActions ?? new ChangeTrackingList<RuntimeScriptAction>(), persistOnSuccess, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExecuteScriptActionContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecuteScriptActionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExecuteScriptActionContent)} does not support writing '{options.Format}' format.");
            }
        }

        ExecuteScriptActionContent IPersistableModel<ExecuteScriptActionContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecuteScriptActionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExecuteScriptActionContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExecuteScriptActionContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExecuteScriptActionContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
