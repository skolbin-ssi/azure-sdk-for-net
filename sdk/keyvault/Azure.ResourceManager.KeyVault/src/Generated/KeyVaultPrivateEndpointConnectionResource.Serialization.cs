// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.KeyVault
{
    public partial class KeyVaultPrivateEndpointConnectionResource : IJsonModel<KeyVaultPrivateEndpointConnectionData>
    {
        void IJsonModel<KeyVaultPrivateEndpointConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<KeyVaultPrivateEndpointConnectionData>)Data).Write(writer, options);

        KeyVaultPrivateEndpointConnectionData IJsonModel<KeyVaultPrivateEndpointConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<KeyVaultPrivateEndpointConnectionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<KeyVaultPrivateEndpointConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        KeyVaultPrivateEndpointConnectionData IPersistableModel<KeyVaultPrivateEndpointConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<KeyVaultPrivateEndpointConnectionData>(data, options);

        string IPersistableModel<KeyVaultPrivateEndpointConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<KeyVaultPrivateEndpointConnectionData>)Data).GetFormatFromOptions(options);
    }
}
