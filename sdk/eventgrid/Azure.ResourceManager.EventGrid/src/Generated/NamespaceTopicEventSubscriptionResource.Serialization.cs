// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.EventGrid
{
    public partial class NamespaceTopicEventSubscriptionResource : IJsonModel<NamespaceTopicEventSubscriptionData>
    {
        void IJsonModel<NamespaceTopicEventSubscriptionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<NamespaceTopicEventSubscriptionData>)Data).Write(writer, options);

        NamespaceTopicEventSubscriptionData IJsonModel<NamespaceTopicEventSubscriptionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<NamespaceTopicEventSubscriptionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<NamespaceTopicEventSubscriptionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        NamespaceTopicEventSubscriptionData IPersistableModel<NamespaceTopicEventSubscriptionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<NamespaceTopicEventSubscriptionData>(data, options);

        string IPersistableModel<NamespaceTopicEventSubscriptionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<NamespaceTopicEventSubscriptionData>)Data).GetFormatFromOptions(options);
    }
}
