// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlDatabaseSensitivityLabelResource : IJsonModel<SensitivityLabelData>
    {
        void IJsonModel<SensitivityLabelData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SensitivityLabelData>)Data).Write(writer, options);

        SensitivityLabelData IJsonModel<SensitivityLabelData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SensitivityLabelData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SensitivityLabelData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SensitivityLabelData IPersistableModel<SensitivityLabelData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SensitivityLabelData>(data, options);

        string IPersistableModel<SensitivityLabelData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SensitivityLabelData>)Data).GetFormatFromOptions(options);
    }
}
