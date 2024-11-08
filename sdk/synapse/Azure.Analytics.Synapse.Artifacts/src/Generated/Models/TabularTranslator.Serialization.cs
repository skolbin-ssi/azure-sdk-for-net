// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(TabularTranslatorConverter))]
    public partial class TabularTranslator : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ColumnMappings))
            {
                writer.WritePropertyName("columnMappings"u8);
                writer.WriteObjectValue<object>(ColumnMappings);
            }
            if (Optional.IsDefined(SchemaMapping))
            {
                writer.WritePropertyName("schemaMapping"u8);
                writer.WriteObjectValue<object>(SchemaMapping);
            }
            if (Optional.IsDefined(CollectionReference))
            {
                writer.WritePropertyName("collectionReference"u8);
                writer.WriteObjectValue<object>(CollectionReference);
            }
            if (Optional.IsDefined(MapComplexValuesToString))
            {
                writer.WritePropertyName("mapComplexValuesToString"u8);
                writer.WriteObjectValue<object>(MapComplexValuesToString);
            }
            if (Optional.IsDefined(Mappings))
            {
                writer.WritePropertyName("mappings"u8);
                writer.WriteObjectValue<object>(Mappings);
            }
            if (Optional.IsDefined(TypeConversion))
            {
                writer.WritePropertyName("typeConversion"u8);
                writer.WriteObjectValue<object>(TypeConversion);
            }
            if (Optional.IsDefined(TypeConversionSettings))
            {
                writer.WritePropertyName("typeConversionSettings"u8);
                writer.WriteObjectValue(TypeConversionSettings);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue<object>(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static TabularTranslator DeserializeTabularTranslator(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object columnMappings = default;
            object schemaMapping = default;
            object collectionReference = default;
            object mapComplexValuesToString = default;
            object mappings = default;
            object typeConversion = default;
            TypeConversionSettings typeConversionSettings = default;
            string type = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("columnMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    columnMappings = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("schemaMapping"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schemaMapping = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("collectionReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    collectionReference = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("mapComplexValuesToString"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mapComplexValuesToString = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("mappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mappings = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("typeConversion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    typeConversion = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("typeConversionSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    typeConversionSettings = TypeConversionSettings.DeserializeTypeConversionSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new TabularTranslator(
                type,
                additionalProperties,
                columnMappings,
                schemaMapping,
                collectionReference,
                mapComplexValuesToString,
                mappings,
                typeConversion,
                typeConversionSettings);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new TabularTranslator FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTabularTranslator(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class TabularTranslatorConverter : JsonConverter<TabularTranslator>
        {
            public override void Write(Utf8JsonWriter writer, TabularTranslator model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override TabularTranslator Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTabularTranslator(document.RootElement);
            }
        }
    }
}
