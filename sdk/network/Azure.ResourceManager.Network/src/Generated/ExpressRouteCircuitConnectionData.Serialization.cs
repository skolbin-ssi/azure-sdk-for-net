// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class ExpressRouteCircuitConnectionData : IUtf8JsonSerializable, IJsonModel<ExpressRouteCircuitConnectionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExpressRouteCircuitConnectionData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExpressRouteCircuitConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitConnectionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteCircuitConnectionData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ExpressRouteCircuitPeering))
            {
                writer.WritePropertyName("expressRouteCircuitPeering"u8);
                JsonSerializer.Serialize(writer, ExpressRouteCircuitPeering);
            }
            if (Optional.IsDefined(PeerExpressRouteCircuitPeering))
            {
                writer.WritePropertyName("peerExpressRouteCircuitPeering"u8);
                JsonSerializer.Serialize(writer, PeerExpressRouteCircuitPeering);
            }
            if (Optional.IsDefined(AddressPrefix))
            {
                writer.WritePropertyName("addressPrefix"u8);
                writer.WriteStringValue(AddressPrefix);
            }
            if (Optional.IsDefined(AuthorizationKey))
            {
                writer.WritePropertyName("authorizationKey"u8);
                writer.WriteStringValue(AuthorizationKey);
            }
            if (Optional.IsDefined(IPv6CircuitConnectionConfig))
            {
                writer.WritePropertyName("ipv6CircuitConnectionConfig"u8);
                writer.WriteObjectValue(IPv6CircuitConnectionConfig, options);
            }
            if (options.Format != "W" && Optional.IsDefined(CircuitConnectionStatus))
            {
                writer.WritePropertyName("circuitConnectionStatus"u8);
                writer.WriteStringValue(CircuitConnectionStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        ExpressRouteCircuitConnectionData IJsonModel<ExpressRouteCircuitConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitConnectionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteCircuitConnectionData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRouteCircuitConnectionData(document.RootElement, options);
        }

        internal static ExpressRouteCircuitConnectionData DeserializeExpressRouteCircuitConnectionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            WritableSubResource expressRouteCircuitPeering = default;
            WritableSubResource peerExpressRouteCircuitPeering = default;
            string addressPrefix = default;
            string authorizationKey = default;
            IPv6CircuitConnectionConfig ipv6CircuitConnectionConfig = default;
            CircuitConnectionStatus? circuitConnectionStatus = default;
            NetworkProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("expressRouteCircuitPeering"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expressRouteCircuitPeering = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("peerExpressRouteCircuitPeering"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peerExpressRouteCircuitPeering = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("addressPrefix"u8))
                        {
                            addressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authorizationKey"u8))
                        {
                            authorizationKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ipv6CircuitConnectionConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ipv6CircuitConnectionConfig = IPv6CircuitConnectionConfig.DeserializeIPv6CircuitConnectionConfig(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("circuitConnectionStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            circuitConnectionStatus = new CircuitConnectionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExpressRouteCircuitConnectionData(
                id,
                name,
                type,
                serializedAdditionalRawData,
                etag,
                expressRouteCircuitPeering,
                peerExpressRouteCircuitPeering,
                addressPrefix,
                authorizationKey,
                ipv6CircuitConnectionConfig,
                circuitConnectionStatus,
                provisioningState);
        }

        BinaryData IPersistableModel<ExpressRouteCircuitConnectionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitConnectionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteCircuitConnectionData)} does not support writing '{options.Format}' format.");
            }
        }

        ExpressRouteCircuitConnectionData IPersistableModel<ExpressRouteCircuitConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitConnectionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExpressRouteCircuitConnectionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteCircuitConnectionData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExpressRouteCircuitConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
