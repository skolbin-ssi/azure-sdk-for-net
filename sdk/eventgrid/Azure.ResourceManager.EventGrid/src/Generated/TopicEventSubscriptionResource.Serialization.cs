// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.EventGrid
{
    public partial class TopicEventSubscriptionResource : IJsonModel<EventGridSubscriptionData>
    {
        void IJsonModel<EventGridSubscriptionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<EventGridSubscriptionData>)Data).Write(writer, options);

        EventGridSubscriptionData IJsonModel<EventGridSubscriptionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<EventGridSubscriptionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<EventGridSubscriptionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        EventGridSubscriptionData IPersistableModel<EventGridSubscriptionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<EventGridSubscriptionData>(data, options);

        string IPersistableModel<EventGridSubscriptionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<EventGridSubscriptionData>)Data).GetFormatFromOptions(options);
    }
}
