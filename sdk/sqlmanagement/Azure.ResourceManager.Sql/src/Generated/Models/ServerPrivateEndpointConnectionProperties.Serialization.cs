// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ServerPrivateEndpointConnectionProperties : IUtf8JsonSerializable, IJsonModel<ServerPrivateEndpointConnectionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServerPrivateEndpointConnectionProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ServerPrivateEndpointConnectionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerPrivateEndpointConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerPrivateEndpointConnectionProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PrivateEndpoint))
            {
                writer.WritePropertyName("privateEndpoint"u8);
                JsonSerializer.Serialize(writer, PrivateEndpoint);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(GroupIds))
            {
                writer.WritePropertyName("groupIds"u8);
                writer.WriteStartArray();
                foreach (var item in GroupIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ConnectionState))
            {
                writer.WritePropertyName("privateLinkServiceConnectionState"u8);
                writer.WriteObjectValue(ConnectionState, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        ServerPrivateEndpointConnectionProperties IJsonModel<ServerPrivateEndpointConnectionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerPrivateEndpointConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerPrivateEndpointConnectionProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServerPrivateEndpointConnectionProperties(document.RootElement, options);
        }

        internal static ServerPrivateEndpointConnectionProperties DeserializeServerPrivateEndpointConnectionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WritableSubResource privateEndpoint = default;
            IReadOnlyList<string> groupIds = default;
            SqlPrivateLinkServiceConnectionStateProperty privateLinkServiceConnectionState = default;
            SqlPrivateEndpointProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateEndpoint = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("groupIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    groupIds = array;
                    continue;
                }
                if (property.NameEquals("privateLinkServiceConnectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateLinkServiceConnectionState = SqlPrivateLinkServiceConnectionStateProperty.DeserializeSqlPrivateLinkServiceConnectionStateProperty(property.Value, options);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new SqlPrivateEndpointProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ServerPrivateEndpointConnectionProperties(privateEndpoint, groupIds ?? new ChangeTrackingList<string>(), privateLinkServiceConnectionState, provisioningState, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("PrivateEndpointId", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  privateEndpoint: ");
                builder.AppendLine("{");
                builder.Append("    id: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(PrivateEndpoint))
                {
                    builder.Append("  privateEndpoint: ");
                    BicepSerializationHelpers.AppendChildObject(builder, PrivateEndpoint, options, 2, false, "  privateEndpoint: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GroupIds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  groupIds: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(GroupIds))
                {
                    if (GroupIds.Any())
                    {
                        builder.Append("  groupIds: ");
                        builder.AppendLine("[");
                        foreach (var item in GroupIds)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConnectionState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  privateLinkServiceConnectionState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConnectionState))
                {
                    builder.Append("  privateLinkServiceConnectionState: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ConnectionState, options, 2, false, "  privateLinkServiceConnectionState: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("  provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ServerPrivateEndpointConnectionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerPrivateEndpointConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ServerPrivateEndpointConnectionProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ServerPrivateEndpointConnectionProperties IPersistableModel<ServerPrivateEndpointConnectionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerPrivateEndpointConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServerPrivateEndpointConnectionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServerPrivateEndpointConnectionProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServerPrivateEndpointConnectionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
