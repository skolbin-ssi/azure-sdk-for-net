// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    internal partial class AcsMessageChannelEventError
    {
        internal static AcsMessageChannelEventError DeserializeAcsMessageChannelEventError(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string channelCode = default;
            string channelMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("channelCode"u8))
                {
                    channelCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelMessage"u8))
                {
                    channelMessage = property.Value.GetString();
                    continue;
                }
            }
            return new AcsMessageChannelEventError(channelCode, channelMessage);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AcsMessageChannelEventError FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAcsMessageChannelEventError(document.RootElement);
        }
    }
}
