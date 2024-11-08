// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class SecurityInsightsEntityQueryTemplateResource : IJsonModel<SecurityInsightsEntityQueryTemplateData>
    {
        void IJsonModel<SecurityInsightsEntityQueryTemplateData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SecurityInsightsEntityQueryTemplateData>)Data).Write(writer, options);

        SecurityInsightsEntityQueryTemplateData IJsonModel<SecurityInsightsEntityQueryTemplateData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SecurityInsightsEntityQueryTemplateData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SecurityInsightsEntityQueryTemplateData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SecurityInsightsEntityQueryTemplateData IPersistableModel<SecurityInsightsEntityQueryTemplateData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SecurityInsightsEntityQueryTemplateData>(data, options);

        string IPersistableModel<SecurityInsightsEntityQueryTemplateData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SecurityInsightsEntityQueryTemplateData>)Data).GetFormatFromOptions(options);
    }
}
