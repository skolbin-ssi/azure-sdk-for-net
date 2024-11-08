// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class RelationshipsLookup : IUtf8JsonSerializable, IJsonModel<RelationshipsLookup>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RelationshipsLookup>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RelationshipsLookup>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RelationshipsLookup>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RelationshipsLookup)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ProfileName))
            {
                writer.WritePropertyName("profileName"u8);
                writer.WriteStringValue(ProfileName);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ProfilePropertyReferences))
            {
                writer.WritePropertyName("profilePropertyReferences"u8);
                writer.WriteStartArray();
                foreach (var item in ProfilePropertyReferences)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(RelatedProfileName))
            {
                writer.WritePropertyName("relatedProfileName"u8);
                writer.WriteStringValue(RelatedProfileName);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RelatedProfilePropertyReferences))
            {
                writer.WritePropertyName("relatedProfilePropertyReferences"u8);
                writer.WriteStartArray();
                foreach (var item in RelatedProfilePropertyReferences)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ExistingRelationshipName))
            {
                writer.WritePropertyName("existingRelationshipName"u8);
                writer.WriteStringValue(ExistingRelationshipName);
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

        RelationshipsLookup IJsonModel<RelationshipsLookup>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RelationshipsLookup>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RelationshipsLookup)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRelationshipsLookup(document.RootElement, options);
        }

        internal static RelationshipsLookup DeserializeRelationshipsLookup(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string profileName = default;
            IReadOnlyList<ParticipantProfilePropertyReference> profilePropertyReferences = default;
            string relatedProfileName = default;
            IReadOnlyList<ParticipantProfilePropertyReference> relatedProfilePropertyReferences = default;
            string existingRelationshipName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("profileName"u8))
                {
                    profileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("profilePropertyReferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ParticipantProfilePropertyReference> array = new List<ParticipantProfilePropertyReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ParticipantProfilePropertyReference.DeserializeParticipantProfilePropertyReference(item, options));
                    }
                    profilePropertyReferences = array;
                    continue;
                }
                if (property.NameEquals("relatedProfileName"u8))
                {
                    relatedProfileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relatedProfilePropertyReferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ParticipantProfilePropertyReference> array = new List<ParticipantProfilePropertyReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ParticipantProfilePropertyReference.DeserializeParticipantProfilePropertyReference(item, options));
                    }
                    relatedProfilePropertyReferences = array;
                    continue;
                }
                if (property.NameEquals("existingRelationshipName"u8))
                {
                    existingRelationshipName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RelationshipsLookup(
                profileName,
                profilePropertyReferences ?? new ChangeTrackingList<ParticipantProfilePropertyReference>(),
                relatedProfileName,
                relatedProfilePropertyReferences ?? new ChangeTrackingList<ParticipantProfilePropertyReference>(),
                existingRelationshipName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RelationshipsLookup>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RelationshipsLookup>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RelationshipsLookup)} does not support writing '{options.Format}' format.");
            }
        }

        RelationshipsLookup IPersistableModel<RelationshipsLookup>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RelationshipsLookup>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRelationshipsLookup(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RelationshipsLookup)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RelationshipsLookup>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
