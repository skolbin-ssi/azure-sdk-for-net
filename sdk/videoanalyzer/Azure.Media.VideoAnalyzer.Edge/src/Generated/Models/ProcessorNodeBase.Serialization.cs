// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class ProcessorNodeBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("inputs"u8);
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static ProcessorNodeBase DeserializeProcessorNodeBase(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.VideoAnalyzer.CognitiveServicesVisionProcessor": return CognitiveServicesVisionProcessor.DeserializeCognitiveServicesVisionProcessor(element);
                    case "#Microsoft.VideoAnalyzer.ExtensionProcessorBase": return ExtensionProcessorBase.DeserializeExtensionProcessorBase(element);
                    case "#Microsoft.VideoAnalyzer.GrpcExtension": return GrpcExtension.DeserializeGrpcExtension(element);
                    case "#Microsoft.VideoAnalyzer.HttpExtension": return HttpExtension.DeserializeHttpExtension(element);
                    case "#Microsoft.VideoAnalyzer.LineCrossingProcessor": return LineCrossingProcessor.DeserializeLineCrossingProcessor(element);
                    case "#Microsoft.VideoAnalyzer.MotionDetectionProcessor": return MotionDetectionProcessor.DeserializeMotionDetectionProcessor(element);
                    case "#Microsoft.VideoAnalyzer.ObjectTrackingProcessor": return ObjectTrackingProcessor.DeserializeObjectTrackingProcessor(element);
                    case "#Microsoft.VideoAnalyzer.SignalGateProcessor": return SignalGateProcessor.DeserializeSignalGateProcessor(element);
                }
            }
            return UnknownProcessorNodeBase.DeserializeUnknownProcessorNodeBase(element);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ProcessorNodeBase FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeProcessorNodeBase(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
