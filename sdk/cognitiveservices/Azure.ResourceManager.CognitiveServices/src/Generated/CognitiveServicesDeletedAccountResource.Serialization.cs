// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CognitiveServices
{
    public partial class CognitiveServicesDeletedAccountResource : IJsonModel<CognitiveServicesAccountData>
    {
        void IJsonModel<CognitiveServicesAccountData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<CognitiveServicesAccountData>)Data).Write(writer, options);

        CognitiveServicesAccountData IJsonModel<CognitiveServicesAccountData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<CognitiveServicesAccountData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<CognitiveServicesAccountData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        CognitiveServicesAccountData IPersistableModel<CognitiveServicesAccountData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<CognitiveServicesAccountData>(data, options);

        string IPersistableModel<CognitiveServicesAccountData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<CognitiveServicesAccountData>)Data).GetFormatFromOptions(options);
    }
}
