// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VaultHealthProperties : IUtf8JsonSerializable, IJsonModel<VaultHealthProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VaultHealthProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VaultHealthProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultHealthProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VaultHealthProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(VaultErrors))
            {
                writer.WritePropertyName("vaultErrors"u8);
                writer.WriteStartArray();
                foreach (var item in VaultErrors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProtectedItemsHealth))
            {
                writer.WritePropertyName("protectedItemsHealth"u8);
                writer.WriteObjectValue(ProtectedItemsHealth, options);
            }
            if (Optional.IsDefined(FabricsHealth))
            {
                writer.WritePropertyName("fabricsHealth"u8);
                writer.WriteObjectValue(FabricsHealth, options);
            }
            if (Optional.IsDefined(ContainersHealth))
            {
                writer.WritePropertyName("containersHealth"u8);
                writer.WriteObjectValue(ContainersHealth, options);
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

        VaultHealthProperties IJsonModel<VaultHealthProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultHealthProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VaultHealthProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVaultHealthProperties(document.RootElement, options);
        }

        internal static VaultHealthProperties DeserializeVaultHealthProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SiteRecoveryHealthError> vaultErrors = default;
            ResourceHealthSummary protectedItemsHealth = default;
            ResourceHealthSummary fabricsHealth = default;
            ResourceHealthSummary containersHealth = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vaultErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item, options));
                    }
                    vaultErrors = array;
                    continue;
                }
                if (property.NameEquals("protectedItemsHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemsHealth = ResourceHealthSummary.DeserializeResourceHealthSummary(property.Value, options);
                    continue;
                }
                if (property.NameEquals("fabricsHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricsHealth = ResourceHealthSummary.DeserializeResourceHealthSummary(property.Value, options);
                    continue;
                }
                if (property.NameEquals("containersHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containersHealth = ResourceHealthSummary.DeserializeResourceHealthSummary(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VaultHealthProperties(vaultErrors ?? new ChangeTrackingList<SiteRecoveryHealthError>(), protectedItemsHealth, fabricsHealth, containersHealth, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VaultHealthProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultHealthProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VaultHealthProperties)} does not support writing '{options.Format}' format.");
            }
        }

        VaultHealthProperties IPersistableModel<VaultHealthProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultHealthProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVaultHealthProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VaultHealthProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VaultHealthProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
