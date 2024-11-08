// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MigrationDiscoverySap
{
    public partial class SapDiscoveryServerInstanceResource : IJsonModel<SapDiscoveryServerInstanceData>
    {
        void IJsonModel<SapDiscoveryServerInstanceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SapDiscoveryServerInstanceData>)Data).Write(writer, options);

        SapDiscoveryServerInstanceData IJsonModel<SapDiscoveryServerInstanceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SapDiscoveryServerInstanceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SapDiscoveryServerInstanceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SapDiscoveryServerInstanceData IPersistableModel<SapDiscoveryServerInstanceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SapDiscoveryServerInstanceData>(data, options);

        string IPersistableModel<SapDiscoveryServerInstanceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SapDiscoveryServerInstanceData>)Data).GetFormatFromOptions(options);
    }
}
