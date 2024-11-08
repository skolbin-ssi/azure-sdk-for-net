// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class GrpcExtensionDataTransfer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SharedMemorySizeMiB))
            {
                writer.WritePropertyName("sharedMemorySizeMiB"u8);
                writer.WriteStringValue(SharedMemorySizeMiB);
            }
            writer.WritePropertyName("mode"u8);
            writer.WriteStringValue(Mode.ToString());
            writer.WriteEndObject();
        }

        internal static GrpcExtensionDataTransfer DeserializeGrpcExtensionDataTransfer(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sharedMemorySizeMiB = default;
            GrpcExtensionDataTransferMode mode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sharedMemorySizeMiB"u8))
                {
                    sharedMemorySizeMiB = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    mode = new GrpcExtensionDataTransferMode(property.Value.GetString());
                    continue;
                }
            }
            return new GrpcExtensionDataTransfer(sharedMemorySizeMiB, mode);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static GrpcExtensionDataTransfer FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeGrpcExtensionDataTransfer(document.RootElement);
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
