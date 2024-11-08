// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class SecurityInsightsIncidentRelationResource : IJsonModel<SecurityInsightsIncidentRelationData>
    {
        void IJsonModel<SecurityInsightsIncidentRelationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SecurityInsightsIncidentRelationData>)Data).Write(writer, options);

        SecurityInsightsIncidentRelationData IJsonModel<SecurityInsightsIncidentRelationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SecurityInsightsIncidentRelationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SecurityInsightsIncidentRelationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SecurityInsightsIncidentRelationData IPersistableModel<SecurityInsightsIncidentRelationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SecurityInsightsIncidentRelationData>(data, options);

        string IPersistableModel<SecurityInsightsIncidentRelationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SecurityInsightsIncidentRelationData>)Data).GetFormatFromOptions(options);
    }
}
