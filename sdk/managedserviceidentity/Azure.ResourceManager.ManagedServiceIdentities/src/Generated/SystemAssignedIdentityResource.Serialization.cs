// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ManagedServiceIdentities
{
    public partial class SystemAssignedIdentityResource : IJsonModel<SystemAssignedIdentityData>
    {
        void IJsonModel<SystemAssignedIdentityData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SystemAssignedIdentityData>)Data).Write(writer, options);

        SystemAssignedIdentityData IJsonModel<SystemAssignedIdentityData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SystemAssignedIdentityData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SystemAssignedIdentityData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SystemAssignedIdentityData IPersistableModel<SystemAssignedIdentityData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SystemAssignedIdentityData>(data, options);

        string IPersistableModel<SystemAssignedIdentityData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SystemAssignedIdentityData>)Data).GetFormatFromOptions(options);
    }
}
