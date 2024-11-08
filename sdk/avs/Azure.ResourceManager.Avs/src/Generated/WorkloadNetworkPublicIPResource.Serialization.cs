// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Avs
{
    public partial class WorkloadNetworkPublicIPResource : IJsonModel<WorkloadNetworkPublicIPData>
    {
        void IJsonModel<WorkloadNetworkPublicIPData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<WorkloadNetworkPublicIPData>)Data).Write(writer, options);

        WorkloadNetworkPublicIPData IJsonModel<WorkloadNetworkPublicIPData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<WorkloadNetworkPublicIPData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<WorkloadNetworkPublicIPData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        WorkloadNetworkPublicIPData IPersistableModel<WorkloadNetworkPublicIPData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<WorkloadNetworkPublicIPData>(data, options);

        string IPersistableModel<WorkloadNetworkPublicIPData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<WorkloadNetworkPublicIPData>)Data).GetFormatFromOptions(options);
    }
}
