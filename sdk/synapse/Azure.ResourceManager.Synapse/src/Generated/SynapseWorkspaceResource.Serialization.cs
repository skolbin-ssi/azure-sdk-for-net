// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseWorkspaceResource : IJsonModel<SynapseWorkspaceData>
    {
        void IJsonModel<SynapseWorkspaceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SynapseWorkspaceData>)Data).Write(writer, options);

        SynapseWorkspaceData IJsonModel<SynapseWorkspaceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SynapseWorkspaceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SynapseWorkspaceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SynapseWorkspaceData IPersistableModel<SynapseWorkspaceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SynapseWorkspaceData>(data, options);

        string IPersistableModel<SynapseWorkspaceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SynapseWorkspaceData>)Data).GetFormatFromOptions(options);
    }
}
