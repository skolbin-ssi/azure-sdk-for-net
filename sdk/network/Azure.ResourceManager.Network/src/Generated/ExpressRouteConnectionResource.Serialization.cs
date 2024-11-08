// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class ExpressRouteConnectionResource : IJsonModel<ExpressRouteConnectionData>
    {
        void IJsonModel<ExpressRouteConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ExpressRouteConnectionData>)Data).Write(writer, options);

        ExpressRouteConnectionData IJsonModel<ExpressRouteConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ExpressRouteConnectionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ExpressRouteConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ExpressRouteConnectionData IPersistableModel<ExpressRouteConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ExpressRouteConnectionData>(data, options);

        string IPersistableModel<ExpressRouteConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ExpressRouteConnectionData>)Data).GetFormatFromOptions(options);
    }
}
