// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Communication.CallAutomation
{
    internal partial class AddParticipantSucceededInternal
    {
        internal static AddParticipantSucceededInternal DeserializeAddParticipantSucceededInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string operationContext = default;
            ResultInformation resultInformation = default;
            CommunicationIdentifierModel participant = default;
            string callConnectionId = default;
            string serverCallId = default;
            string correlationId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resultInformation = ResultInformation.DeserializeResultInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("participant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    participant = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("callConnectionId"u8))
                {
                    callConnectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverCallId"u8))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
            }
            return new AddParticipantSucceededInternal(
                operationContext,
                resultInformation,
                participant,
                callConnectionId,
                serverCallId,
                correlationId);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AddParticipantSucceededInternal FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAddParticipantSucceededInternal(document.RootElement);
        }
    }
}
