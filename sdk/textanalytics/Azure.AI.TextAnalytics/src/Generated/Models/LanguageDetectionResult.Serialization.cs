// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class LanguageDetectionResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("documents"u8);
            writer.WriteStartArray();
            foreach (var item in Documents)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("errors"u8);
            writer.WriteStartArray();
            foreach (var item in Errors)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Statistics))
            {
                writer.WritePropertyName("statistics"u8);
                writer.WriteObjectValue(Statistics);
            }
            writer.WritePropertyName("modelVersion"u8);
            writer.WriteStringValue(ModelVersion);
            writer.WriteEndObject();
        }

        internal static LanguageDetectionResult DeserializeLanguageDetectionResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<LanguageDetectionDocumentResult> documents = default;
            IList<DocumentError> errors = default;
            TextDocumentBatchStatistics statistics = default;
            string modelVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documents"u8))
                {
                    List<LanguageDetectionDocumentResult> array = new List<LanguageDetectionDocumentResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LanguageDetectionDocumentResult.DeserializeLanguageDetectionDocumentResult(item));
                    }
                    documents = array;
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    List<DocumentError> array = new List<DocumentError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentError.DeserializeDocumentError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("statistics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statistics = TextDocumentBatchStatistics.DeserializeTextDocumentBatchStatistics(property.Value);
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
            }
            return new LanguageDetectionResult(errors, statistics, modelVersion, documents);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new LanguageDetectionResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeLanguageDetectionResult(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
