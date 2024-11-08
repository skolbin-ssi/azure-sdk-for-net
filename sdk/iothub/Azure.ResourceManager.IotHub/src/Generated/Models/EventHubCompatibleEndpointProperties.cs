// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The properties of the provisioned Event Hub-compatible endpoint used by the IoT hub. </summary>
    public partial class EventHubCompatibleEndpointProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EventHubCompatibleEndpointProperties"/>. </summary>
        public EventHubCompatibleEndpointProperties()
        {
            PartitionIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="EventHubCompatibleEndpointProperties"/>. </summary>
        /// <param name="retentionTimeInDays"> The retention time for device-to-cloud messages in days. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#device-to-cloud-messages. </param>
        /// <param name="partitionCount"> The number of partitions for receiving device-to-cloud messages in the Event Hub-compatible endpoint. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#device-to-cloud-messages. </param>
        /// <param name="partitionIds"> The partition ids in the Event Hub-compatible endpoint. </param>
        /// <param name="eventHubCompatibleName"> The Event Hub-compatible name. </param>
        /// <param name="endpoint"> The Event Hub-compatible endpoint. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EventHubCompatibleEndpointProperties(long? retentionTimeInDays, int? partitionCount, IReadOnlyList<string> partitionIds, string eventHubCompatibleName, string endpoint, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RetentionTimeInDays = retentionTimeInDays;
            PartitionCount = partitionCount;
            PartitionIds = partitionIds;
            EventHubCompatibleName = eventHubCompatibleName;
            Endpoint = endpoint;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The retention time for device-to-cloud messages in days. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#device-to-cloud-messages. </summary>
        public long? RetentionTimeInDays { get; set; }
        /// <summary> The number of partitions for receiving device-to-cloud messages in the Event Hub-compatible endpoint. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#device-to-cloud-messages. </summary>
        public int? PartitionCount { get; set; }
        /// <summary> The partition ids in the Event Hub-compatible endpoint. </summary>
        public IReadOnlyList<string> PartitionIds { get; }
        /// <summary> The Event Hub-compatible name. </summary>
        public string EventHubCompatibleName { get; }
        /// <summary> The Event Hub-compatible endpoint. </summary>
        public string Endpoint { get; }
    }
}
