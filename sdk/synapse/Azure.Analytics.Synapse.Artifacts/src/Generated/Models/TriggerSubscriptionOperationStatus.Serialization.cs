// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(TriggerSubscriptionOperationStatusConverter))]
    public partial class TriggerSubscriptionOperationStatus
    {
        internal static TriggerSubscriptionOperationStatus DeserializeTriggerSubscriptionOperationStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string triggerName = default;
            EventSubscriptionStatus? status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("triggerName"u8))
                {
                    triggerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new EventSubscriptionStatus(property.Value.GetString());
                    continue;
                }
            }
            return new TriggerSubscriptionOperationStatus(triggerName, status);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TriggerSubscriptionOperationStatus FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTriggerSubscriptionOperationStatus(document.RootElement);
        }

        internal partial class TriggerSubscriptionOperationStatusConverter : JsonConverter<TriggerSubscriptionOperationStatus>
        {
            public override void Write(Utf8JsonWriter writer, TriggerSubscriptionOperationStatus model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override TriggerSubscriptionOperationStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTriggerSubscriptionOperationStatus(document.RootElement);
            }
        }
    }
}
