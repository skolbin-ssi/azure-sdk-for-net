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
    [JsonConverter(typeof(ZipDeflateReadSettingsConverter))]
    public partial class ZipDeflateReadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PreserveZipFileNameAsFolder))
            {
                writer.WritePropertyName("preserveZipFileNameAsFolder"u8);
                writer.WriteObjectValue<object>(PreserveZipFileNameAsFolder);
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

        internal static ZipDeflateReadSettings DeserializeZipDeflateReadSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object preserveZipFileNameAsFolder = default;
            string type = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preserveZipFileNameAsFolder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preserveZipFileNameAsFolder = property.Value.GetObject();
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
            return new ZipDeflateReadSettings(type, additionalProperties, preserveZipFileNameAsFolder);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new ZipDeflateReadSettings FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeZipDeflateReadSettings(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class ZipDeflateReadSettingsConverter : JsonConverter<ZipDeflateReadSettings>
        {
            public override void Write(Utf8JsonWriter writer, ZipDeflateReadSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override ZipDeflateReadSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeZipDeflateReadSettings(document.RootElement);
            }
        }
    }
}
