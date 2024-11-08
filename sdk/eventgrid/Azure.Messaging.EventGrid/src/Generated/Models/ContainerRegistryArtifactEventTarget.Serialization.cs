// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class ContainerRegistryArtifactEventTarget
    {
        internal static ContainerRegistryArtifactEventTarget DeserializeContainerRegistryArtifactEventTarget(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string mediaType = default;
            long? size = default;
            string digest = default;
            string repository = default;
            string tag = default;
            string name = default;
            string version = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mediaType"u8))
                {
                    mediaType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    size = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("digest"u8))
                {
                    digest = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repository"u8))
                {
                    repository = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tag"u8))
                {
                    tag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerRegistryArtifactEventTarget(
                mediaType,
                size,
                digest,
                repository,
                tag,
                name,
                version);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ContainerRegistryArtifactEventTarget FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeContainerRegistryArtifactEventTarget(document.RootElement);
        }
    }
}
