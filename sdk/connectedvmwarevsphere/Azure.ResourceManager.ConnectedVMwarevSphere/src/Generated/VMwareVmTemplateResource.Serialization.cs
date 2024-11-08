// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    public partial class VMwareVmTemplateResource : IJsonModel<VMwareVmTemplateData>
    {
        void IJsonModel<VMwareVmTemplateData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<VMwareVmTemplateData>)Data).Write(writer, options);

        VMwareVmTemplateData IJsonModel<VMwareVmTemplateData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<VMwareVmTemplateData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<VMwareVmTemplateData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        VMwareVmTemplateData IPersistableModel<VMwareVmTemplateData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<VMwareVmTemplateData>(data, options);

        string IPersistableModel<VMwareVmTemplateData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<VMwareVmTemplateData>)Data).GetFormatFromOptions(options);
    }
}
