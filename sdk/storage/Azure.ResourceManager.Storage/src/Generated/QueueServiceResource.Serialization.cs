// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Storage
{
    public partial class QueueServiceResource : IJsonModel<QueueServiceData>
    {
        void IJsonModel<QueueServiceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<QueueServiceData>)Data).Write(writer, options);

        QueueServiceData IJsonModel<QueueServiceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<QueueServiceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<QueueServiceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        QueueServiceData IPersistableModel<QueueServiceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<QueueServiceData>(data, options);

        string IPersistableModel<QueueServiceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<QueueServiceData>)Data).GetFormatFromOptions(options);
    }
}
