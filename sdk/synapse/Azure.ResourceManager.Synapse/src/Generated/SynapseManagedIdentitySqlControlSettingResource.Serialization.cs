// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseManagedIdentitySqlControlSettingResource : IJsonModel<SynapseManagedIdentitySqlControlSettingData>
    {
        void IJsonModel<SynapseManagedIdentitySqlControlSettingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SynapseManagedIdentitySqlControlSettingData>)Data).Write(writer, options);

        SynapseManagedIdentitySqlControlSettingData IJsonModel<SynapseManagedIdentitySqlControlSettingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SynapseManagedIdentitySqlControlSettingData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SynapseManagedIdentitySqlControlSettingData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SynapseManagedIdentitySqlControlSettingData IPersistableModel<SynapseManagedIdentitySqlControlSettingData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SynapseManagedIdentitySqlControlSettingData>(data, options);

        string IPersistableModel<SynapseManagedIdentitySqlControlSettingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SynapseManagedIdentitySqlControlSettingData>)Data).GetFormatFromOptions(options);
    }
}
