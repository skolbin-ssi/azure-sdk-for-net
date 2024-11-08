// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Relay
{
    public partial class RelayNetworkRuleSetResource : IJsonModel<RelayNetworkRuleSetData>
    {
        void IJsonModel<RelayNetworkRuleSetData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<RelayNetworkRuleSetData>)Data).Write(writer, options);

        RelayNetworkRuleSetData IJsonModel<RelayNetworkRuleSetData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<RelayNetworkRuleSetData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<RelayNetworkRuleSetData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        RelayNetworkRuleSetData IPersistableModel<RelayNetworkRuleSetData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<RelayNetworkRuleSetData>(data, options);

        string IPersistableModel<RelayNetworkRuleSetData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<RelayNetworkRuleSetData>)Data).GetFormatFromOptions(options);
    }
}
