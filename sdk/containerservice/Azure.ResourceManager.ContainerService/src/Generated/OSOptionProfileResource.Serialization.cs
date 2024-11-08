// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ContainerService
{
    public partial class OSOptionProfileResource : IJsonModel<OSOptionProfileData>
    {
        void IJsonModel<OSOptionProfileData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<OSOptionProfileData>)Data).Write(writer, options);

        OSOptionProfileData IJsonModel<OSOptionProfileData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<OSOptionProfileData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<OSOptionProfileData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        OSOptionProfileData IPersistableModel<OSOptionProfileData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<OSOptionProfileData>(data, options);

        string IPersistableModel<OSOptionProfileData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<OSOptionProfileData>)Data).GetFormatFromOptions(options);
    }
}
