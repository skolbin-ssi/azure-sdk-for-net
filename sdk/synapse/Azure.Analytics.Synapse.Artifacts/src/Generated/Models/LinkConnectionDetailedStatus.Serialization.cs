// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LinkConnectionDetailedStatusConverter))]
    public partial class LinkConnectionDetailedStatus
    {
        internal static LinkConnectionDetailedStatus DeserializeLinkConnectionDetailedStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string name = default;
            bool? isApplyingChanges = default;
            bool? isPartiallyFailed = default;
            object startTime = default;
            object stopTime = default;
            string status = default;
            string continuousRunId = default;
            object error = default;
            LinkConnectionRefreshStatus refreshStatus = default;
            DateTimeOffset? landingZoneCredentialExpireTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isApplyingChanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isApplyingChanges = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isPartiallyFailed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPartiallyFailed = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("stopTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stopTime = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("continuousRunId"u8))
                {
                    continuousRunId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("refreshStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    refreshStatus = LinkConnectionRefreshStatus.DeserializeLinkConnectionRefreshStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("landingZoneCredentialExpireTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    landingZoneCredentialExpireTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new LinkConnectionDetailedStatus(
                id,
                name,
                isApplyingChanges,
                isPartiallyFailed,
                startTime,
                stopTime,
                status,
                continuousRunId,
                error,
                refreshStatus,
                landingZoneCredentialExpireTime);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static LinkConnectionDetailedStatus FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeLinkConnectionDetailedStatus(document.RootElement);
        }

        internal partial class LinkConnectionDetailedStatusConverter : JsonConverter<LinkConnectionDetailedStatus>
        {
            public override void Write(Utf8JsonWriter writer, LinkConnectionDetailedStatus model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override LinkConnectionDetailedStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkConnectionDetailedStatus(document.RootElement);
            }
        }
    }
}
