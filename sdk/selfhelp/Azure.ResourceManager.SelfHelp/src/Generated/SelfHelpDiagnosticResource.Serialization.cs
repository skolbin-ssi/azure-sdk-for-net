// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SelfHelp
{
    public partial class SelfHelpDiagnosticResource : IJsonModel<SelfHelpDiagnosticData>
    {
        void IJsonModel<SelfHelpDiagnosticData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SelfHelpDiagnosticData>)Data).Write(writer, options);

        SelfHelpDiagnosticData IJsonModel<SelfHelpDiagnosticData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SelfHelpDiagnosticData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SelfHelpDiagnosticData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SelfHelpDiagnosticData IPersistableModel<SelfHelpDiagnosticData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SelfHelpDiagnosticData>(data, options);

        string IPersistableModel<SelfHelpDiagnosticData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SelfHelpDiagnosticData>)Data).GetFormatFromOptions(options);
    }
}
