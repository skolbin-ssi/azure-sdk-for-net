// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ContainerService
{
    public partial class ContainerServiceAgentPoolResource : IJsonModel<ContainerServiceAgentPoolData>
    {
        void IJsonModel<ContainerServiceAgentPoolData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ContainerServiceAgentPoolData>)Data).Write(writer, options);

        ContainerServiceAgentPoolData IJsonModel<ContainerServiceAgentPoolData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ContainerServiceAgentPoolData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ContainerServiceAgentPoolData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ContainerServiceAgentPoolData IPersistableModel<ContainerServiceAgentPoolData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ContainerServiceAgentPoolData>(data, options);

        string IPersistableModel<ContainerServiceAgentPoolData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ContainerServiceAgentPoolData>)Data).GetFormatFromOptions(options);
    }
}
