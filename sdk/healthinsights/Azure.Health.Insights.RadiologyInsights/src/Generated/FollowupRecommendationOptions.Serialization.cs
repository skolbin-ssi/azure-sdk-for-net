// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Health.Insights.RadiologyInsights
{
    public partial class FollowupRecommendationOptions : IUtf8JsonSerializable, IJsonModel<FollowupRecommendationOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FollowupRecommendationOptions>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FollowupRecommendationOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FollowupRecommendationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FollowupRecommendationOptions)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IncludeRecommendationsWithNoSpecifiedModality))
            {
                writer.WritePropertyName("includeRecommendationsWithNoSpecifiedModality"u8);
                writer.WriteBooleanValue(IncludeRecommendationsWithNoSpecifiedModality.Value);
            }
            if (Optional.IsDefined(IncludeRecommendationsInReferences))
            {
                writer.WritePropertyName("includeRecommendationsInReferences"u8);
                writer.WriteBooleanValue(IncludeRecommendationsInReferences.Value);
            }
            if (Optional.IsDefined(ProvideFocusedSentenceEvidence))
            {
                writer.WritePropertyName("provideFocusedSentenceEvidence"u8);
                writer.WriteBooleanValue(ProvideFocusedSentenceEvidence.Value);
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

        FollowupRecommendationOptions IJsonModel<FollowupRecommendationOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FollowupRecommendationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FollowupRecommendationOptions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFollowupRecommendationOptions(document.RootElement, options);
        }

        internal static FollowupRecommendationOptions DeserializeFollowupRecommendationOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? includeRecommendationsWithNoSpecifiedModality = default;
            bool? includeRecommendationsInReferences = default;
            bool? provideFocusedSentenceEvidence = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("includeRecommendationsWithNoSpecifiedModality"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includeRecommendationsWithNoSpecifiedModality = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("includeRecommendationsInReferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includeRecommendationsInReferences = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("provideFocusedSentenceEvidence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provideFocusedSentenceEvidence = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FollowupRecommendationOptions(includeRecommendationsWithNoSpecifiedModality, includeRecommendationsInReferences, provideFocusedSentenceEvidence, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FollowupRecommendationOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FollowupRecommendationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FollowupRecommendationOptions)} does not support writing '{options.Format}' format.");
            }
        }

        FollowupRecommendationOptions IPersistableModel<FollowupRecommendationOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FollowupRecommendationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFollowupRecommendationOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FollowupRecommendationOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FollowupRecommendationOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static FollowupRecommendationOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeFollowupRecommendationOptions(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
