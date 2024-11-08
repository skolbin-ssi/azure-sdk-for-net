// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.EventHubs
{
    public partial class EventHubsNetworkRuleSetResource : IJsonModel<EventHubsNetworkRuleSetData>
    {
        void IJsonModel<EventHubsNetworkRuleSetData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<EventHubsNetworkRuleSetData>)Data).Write(writer, options);

        EventHubsNetworkRuleSetData IJsonModel<EventHubsNetworkRuleSetData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<EventHubsNetworkRuleSetData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<EventHubsNetworkRuleSetData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        EventHubsNetworkRuleSetData IPersistableModel<EventHubsNetworkRuleSetData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<EventHubsNetworkRuleSetData>(data, options);

        string IPersistableModel<EventHubsNetworkRuleSetData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<EventHubsNetworkRuleSetData>)Data).GetFormatFromOptions(options);
    }
}
