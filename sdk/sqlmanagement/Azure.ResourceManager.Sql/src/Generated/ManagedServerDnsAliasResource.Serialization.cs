// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class ManagedServerDnsAliasResource : IJsonModel<ManagedServerDnsAliasData>
    {
        void IJsonModel<ManagedServerDnsAliasData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ManagedServerDnsAliasData>)Data).Write(writer, options);

        ManagedServerDnsAliasData IJsonModel<ManagedServerDnsAliasData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ManagedServerDnsAliasData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ManagedServerDnsAliasData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ManagedServerDnsAliasData IPersistableModel<ManagedServerDnsAliasData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ManagedServerDnsAliasData>(data, options);

        string IPersistableModel<ManagedServerDnsAliasData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ManagedServerDnsAliasData>)Data).GetFormatFromOptions(options);
    }
}
