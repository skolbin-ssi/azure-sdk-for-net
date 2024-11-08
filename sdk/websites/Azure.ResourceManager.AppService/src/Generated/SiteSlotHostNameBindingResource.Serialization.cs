// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppService
{
    public partial class SiteSlotHostNameBindingResource : IJsonModel<HostNameBindingData>
    {
        void IJsonModel<HostNameBindingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<HostNameBindingData>)Data).Write(writer, options);

        HostNameBindingData IJsonModel<HostNameBindingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<HostNameBindingData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<HostNameBindingData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        HostNameBindingData IPersistableModel<HostNameBindingData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<HostNameBindingData>(data, options);

        string IPersistableModel<HostNameBindingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<HostNameBindingData>)Data).GetFormatFromOptions(options);
    }
}
