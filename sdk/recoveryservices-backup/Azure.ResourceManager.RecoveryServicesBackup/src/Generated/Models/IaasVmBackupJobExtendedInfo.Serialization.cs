// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class IaasVmBackupJobExtendedInfo : IUtf8JsonSerializable, IJsonModel<IaasVmBackupJobExtendedInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IaasVmBackupJobExtendedInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IaasVmBackupJobExtendedInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmBackupJobExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IaasVmBackupJobExtendedInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(TasksList))
            {
                writer.WritePropertyName("tasksList"u8);
                writer.WriteStartArray();
                foreach (var item in TasksList)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PropertyBag))
            {
                writer.WritePropertyName("propertyBag"u8);
                writer.WriteStartObject();
                foreach (var item in PropertyBag)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(InternalPropertyBag))
            {
                writer.WritePropertyName("internalPropertyBag"u8);
                writer.WriteStartObject();
                foreach (var item in InternalPropertyBag)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ProgressPercentage))
            {
                writer.WritePropertyName("progressPercentage"u8);
                writer.WriteNumberValue(ProgressPercentage.Value);
            }
            if (Optional.IsDefined(EstimatedRemainingDurationValue))
            {
                writer.WritePropertyName("estimatedRemainingDuration"u8);
                writer.WriteStringValue(EstimatedRemainingDurationValue);
            }
            if (Optional.IsDefined(DynamicErrorMessage))
            {
                writer.WritePropertyName("dynamicErrorMessage"u8);
                writer.WriteStringValue(DynamicErrorMessage);
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

        IaasVmBackupJobExtendedInfo IJsonModel<IaasVmBackupJobExtendedInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmBackupJobExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IaasVmBackupJobExtendedInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIaasVmBackupJobExtendedInfo(document.RootElement, options);
        }

        internal static IaasVmBackupJobExtendedInfo DeserializeIaasVmBackupJobExtendedInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<IaasVmBackupJobTaskDetails> tasksList = default;
            IDictionary<string, string> propertyBag = default;
            IDictionary<string, string> internalPropertyBag = default;
            double? progressPercentage = default;
            string estimatedRemainingDuration = default;
            string dynamicErrorMessage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tasksList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IaasVmBackupJobTaskDetails> array = new List<IaasVmBackupJobTaskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IaasVmBackupJobTaskDetails.DeserializeIaasVmBackupJobTaskDetails(item, options));
                    }
                    tasksList = array;
                    continue;
                }
                if (property.NameEquals("propertyBag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    propertyBag = dictionary;
                    continue;
                }
                if (property.NameEquals("internalPropertyBag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    internalPropertyBag = dictionary;
                    continue;
                }
                if (property.NameEquals("progressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    progressPercentage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("estimatedRemainingDuration"u8))
                {
                    estimatedRemainingDuration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dynamicErrorMessage"u8))
                {
                    dynamicErrorMessage = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IaasVmBackupJobExtendedInfo(
                tasksList ?? new ChangeTrackingList<IaasVmBackupJobTaskDetails>(),
                propertyBag ?? new ChangeTrackingDictionary<string, string>(),
                internalPropertyBag ?? new ChangeTrackingDictionary<string, string>(),
                progressPercentage,
                estimatedRemainingDuration,
                dynamicErrorMessage,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IaasVmBackupJobExtendedInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmBackupJobExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IaasVmBackupJobExtendedInfo)} does not support writing '{options.Format}' format.");
            }
        }

        IaasVmBackupJobExtendedInfo IPersistableModel<IaasVmBackupJobExtendedInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmBackupJobExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIaasVmBackupJobExtendedInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IaasVmBackupJobExtendedInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IaasVmBackupJobExtendedInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
