// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CosmosDB
{
    public partial class CassandraViewGetResultResource : IJsonModel<CassandraViewGetResultData>
    {
        void IJsonModel<CassandraViewGetResultData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<CassandraViewGetResultData>)Data).Write(writer, options);

        CassandraViewGetResultData IJsonModel<CassandraViewGetResultData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<CassandraViewGetResultData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<CassandraViewGetResultData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        CassandraViewGetResultData IPersistableModel<CassandraViewGetResultData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<CassandraViewGetResultData>(data, options);

        string IPersistableModel<CassandraViewGetResultData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<CassandraViewGetResultData>)Data).GetFormatFromOptions(options);
    }
}
