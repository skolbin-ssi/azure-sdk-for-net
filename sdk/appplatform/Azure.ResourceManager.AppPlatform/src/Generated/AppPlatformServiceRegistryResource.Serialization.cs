// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppPlatform
{
    public partial class AppPlatformServiceRegistryResource : IJsonModel<AppPlatformServiceRegistryData>
    {
        void IJsonModel<AppPlatformServiceRegistryData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AppPlatformServiceRegistryData>)Data).Write(writer, options);

        AppPlatformServiceRegistryData IJsonModel<AppPlatformServiceRegistryData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AppPlatformServiceRegistryData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<AppPlatformServiceRegistryData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        AppPlatformServiceRegistryData IPersistableModel<AppPlatformServiceRegistryData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AppPlatformServiceRegistryData>(data, options);

        string IPersistableModel<AppPlatformServiceRegistryData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AppPlatformServiceRegistryData>)Data).GetFormatFromOptions(options);
    }
}
