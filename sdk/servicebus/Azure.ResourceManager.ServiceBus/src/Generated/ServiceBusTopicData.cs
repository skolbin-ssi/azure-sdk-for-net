// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A class representing the ServiceBusTopic data model.
    /// Description of topic resource.
    /// </summary>
    public partial class ServiceBusTopicData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ServiceBusTopicData"/>. </summary>
        public ServiceBusTopicData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServiceBusTopicData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sizeInBytes"> Size of the topic, in bytes. </param>
        /// <param name="createdOn"> Exact time the message was created. </param>
        /// <param name="updatedOn"> The exact time the message was updated. </param>
        /// <param name="accessedOn"> Last time the message was sent, or a request was received, for this topic. </param>
        /// <param name="subscriptionCount"> Number of subscriptions. </param>
        /// <param name="countDetails"> Message count details. </param>
        /// <param name="defaultMessageTimeToLive"> ISO 8601 Default message timespan to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself. </param>
        /// <param name="maxSizeInMegabytes"> Maximum size of the topic in megabytes, which is the size of the memory allocated for the topic. Default is 1024. </param>
        /// <param name="maxMessageSizeInKilobytes"> Maximum size (in KB) of the message payload that can be accepted by the topic. This property is only used in Premium today and default is 1024. </param>
        /// <param name="requiresDuplicateDetection"> Value indicating if this topic requires duplicate detection. </param>
        /// <param name="duplicateDetectionHistoryTimeWindow"> ISO8601 timespan structure that defines the duration of the duplicate detection history. The default value is 10 minutes. </param>
        /// <param name="enableBatchedOperations"> Value that indicates whether server-side batched operations are enabled. </param>
        /// <param name="status"> Enumerates the possible values for the status of a messaging entity. </param>
        /// <param name="supportOrdering"> Value that indicates whether the topic supports ordering. </param>
        /// <param name="autoDeleteOnIdle"> ISO 8601 timespan idle interval after which the topic is automatically deleted. The minimum duration is 5 minutes. </param>
        /// <param name="enablePartitioning"> Value that indicates whether the topic to be partitioned across multiple message brokers is enabled. </param>
        /// <param name="enableExpress"> Value that indicates whether Express Entities are enabled. An express topic holds a message in memory temporarily before writing it to persistent storage. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceBusTopicData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, long? sizeInBytes, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, DateTimeOffset? accessedOn, int? subscriptionCount, MessageCountDetails countDetails, TimeSpan? defaultMessageTimeToLive, int? maxSizeInMegabytes, long? maxMessageSizeInKilobytes, bool? requiresDuplicateDetection, TimeSpan? duplicateDetectionHistoryTimeWindow, bool? enableBatchedOperations, ServiceBusMessagingEntityStatus? status, bool? supportOrdering, TimeSpan? autoDeleteOnIdle, bool? enablePartitioning, bool? enableExpress, AzureLocation? location, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            SizeInBytes = sizeInBytes;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            AccessedOn = accessedOn;
            SubscriptionCount = subscriptionCount;
            CountDetails = countDetails;
            DefaultMessageTimeToLive = defaultMessageTimeToLive;
            MaxSizeInMegabytes = maxSizeInMegabytes;
            MaxMessageSizeInKilobytes = maxMessageSizeInKilobytes;
            RequiresDuplicateDetection = requiresDuplicateDetection;
            DuplicateDetectionHistoryTimeWindow = duplicateDetectionHistoryTimeWindow;
            EnableBatchedOperations = enableBatchedOperations;
            Status = status;
            SupportOrdering = supportOrdering;
            AutoDeleteOnIdle = autoDeleteOnIdle;
            EnablePartitioning = enablePartitioning;
            EnableExpress = enableExpress;
            Location = location;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Size of the topic, in bytes. </summary>
        [WirePath("properties.sizeInBytes")]
        public long? SizeInBytes { get; }
        /// <summary> Exact time the message was created. </summary>
        [WirePath("properties.createdAt")]
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The exact time the message was updated. </summary>
        [WirePath("properties.updatedAt")]
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> Last time the message was sent, or a request was received, for this topic. </summary>
        [WirePath("properties.accessedAt")]
        public DateTimeOffset? AccessedOn { get; }
        /// <summary> Number of subscriptions. </summary>
        [WirePath("properties.subscriptionCount")]
        public int? SubscriptionCount { get; }
        /// <summary> Message count details. </summary>
        [WirePath("properties.countDetails")]
        public MessageCountDetails CountDetails { get; }
        /// <summary> ISO 8601 Default message timespan to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself. </summary>
        [WirePath("properties.defaultMessageTimeToLive")]
        public TimeSpan? DefaultMessageTimeToLive { get; set; }
        /// <summary> Maximum size of the topic in megabytes, which is the size of the memory allocated for the topic. Default is 1024. </summary>
        [WirePath("properties.maxSizeInMegabytes")]
        public int? MaxSizeInMegabytes { get; set; }
        /// <summary> Maximum size (in KB) of the message payload that can be accepted by the topic. This property is only used in Premium today and default is 1024. </summary>
        [WirePath("properties.maxMessageSizeInKilobytes")]
        public long? MaxMessageSizeInKilobytes { get; set; }
        /// <summary> Value indicating if this topic requires duplicate detection. </summary>
        [WirePath("properties.requiresDuplicateDetection")]
        public bool? RequiresDuplicateDetection { get; set; }
        /// <summary> ISO8601 timespan structure that defines the duration of the duplicate detection history. The default value is 10 minutes. </summary>
        [WirePath("properties.duplicateDetectionHistoryTimeWindow")]
        public TimeSpan? DuplicateDetectionHistoryTimeWindow { get; set; }
        /// <summary> Value that indicates whether server-side batched operations are enabled. </summary>
        [WirePath("properties.enableBatchedOperations")]
        public bool? EnableBatchedOperations { get; set; }
        /// <summary> Enumerates the possible values for the status of a messaging entity. </summary>
        [WirePath("properties.status")]
        public ServiceBusMessagingEntityStatus? Status { get; set; }
        /// <summary> Value that indicates whether the topic supports ordering. </summary>
        [WirePath("properties.supportOrdering")]
        public bool? SupportOrdering { get; set; }
        /// <summary> ISO 8601 timespan idle interval after which the topic is automatically deleted. The minimum duration is 5 minutes. </summary>
        [WirePath("properties.autoDeleteOnIdle")]
        public TimeSpan? AutoDeleteOnIdle { get; set; }
        /// <summary> Value that indicates whether the topic to be partitioned across multiple message brokers is enabled. </summary>
        [WirePath("properties.enablePartitioning")]
        public bool? EnablePartitioning { get; set; }
        /// <summary> Value that indicates whether Express Entities are enabled. An express topic holds a message in memory temporarily before writing it to persistent storage. </summary>
        [WirePath("properties.enableExpress")]
        public bool? EnableExpress { get; set; }
        /// <summary> The geo-location where the resource lives. </summary>
        [WirePath("location")]
        public AzureLocation? Location { get; }
    }
}
