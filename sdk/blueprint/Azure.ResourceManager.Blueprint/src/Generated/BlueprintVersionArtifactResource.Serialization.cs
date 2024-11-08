// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Blueprint
{
    public partial class BlueprintVersionArtifactResource : IJsonModel<ArtifactData>
    {
        void IJsonModel<ArtifactData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ArtifactData>)Data).Write(writer, options);

        ArtifactData IJsonModel<ArtifactData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ArtifactData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ArtifactData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ArtifactData IPersistableModel<ArtifactData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ArtifactData>(data, options);

        string IPersistableModel<ArtifactData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ArtifactData>)Data).GetFormatFromOptions(options);
    }
}
