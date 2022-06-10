// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class GatewayServerProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static GatewayServerProperties DeserializeGatewayServerProperties(JsonElement element)
        {
            Optional<long?> port = default;
            Optional<SapHealthState> health = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("port"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        port = null;
                        continue;
                    }
                    port = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("health"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    health = new SapHealthState(property.Value.GetString());
                    continue;
                }
            }
            return new GatewayServerProperties(Optional.ToNullable(port), Optional.ToNullable(health));
        }
    }
}
