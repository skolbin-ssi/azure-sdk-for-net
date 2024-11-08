// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppService
{
    public partial class SiteSlotBackupResource : IJsonModel<WebAppBackupData>
    {
        void IJsonModel<WebAppBackupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<WebAppBackupData>)Data).Write(writer, options);

        WebAppBackupData IJsonModel<WebAppBackupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<WebAppBackupData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<WebAppBackupData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        WebAppBackupData IPersistableModel<WebAppBackupData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<WebAppBackupData>(data, options);

        string IPersistableModel<WebAppBackupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<WebAppBackupData>)Data).GetFormatFromOptions(options);
    }
}
