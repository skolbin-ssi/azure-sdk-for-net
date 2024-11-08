// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CosmosDB
{
    public partial class CosmosDBLocationResource : IJsonModel<CosmosDBLocationData>
    {
        void IJsonModel<CosmosDBLocationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<CosmosDBLocationData>)Data).Write(writer, options);

        CosmosDBLocationData IJsonModel<CosmosDBLocationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<CosmosDBLocationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<CosmosDBLocationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        CosmosDBLocationData IPersistableModel<CosmosDBLocationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<CosmosDBLocationData>(data, options);

        string IPersistableModel<CosmosDBLocationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<CosmosDBLocationData>)Data).GetFormatFromOptions(options);
    }
}
