// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Storage.LifecyclePolicyCompleted event. </summary>
    public partial class StorageLifecyclePolicyCompletedEventData
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

        /// <summary> Initializes a new instance of <see cref="StorageLifecyclePolicyCompletedEventData"/>. </summary>
        /// <param name="deleteSummary"> Execution statistics of a specific policy action in a Blob Management cycle. </param>
        /// <param name="tierToCoolSummary"> Execution statistics of a specific policy action in a Blob Management cycle. </param>
        /// <param name="tierToArchiveSummary"> Execution statistics of a specific policy action in a Blob Management cycle. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deleteSummary"/>, <paramref name="tierToCoolSummary"/> or <paramref name="tierToArchiveSummary"/> is null. </exception>
        internal StorageLifecyclePolicyCompletedEventData(StorageLifecyclePolicyActionSummaryDetail deleteSummary, StorageLifecyclePolicyActionSummaryDetail tierToCoolSummary, StorageLifecyclePolicyActionSummaryDetail tierToArchiveSummary)
        {
            Argument.AssertNotNull(deleteSummary, nameof(deleteSummary));
            Argument.AssertNotNull(tierToCoolSummary, nameof(tierToCoolSummary));
            Argument.AssertNotNull(tierToArchiveSummary, nameof(tierToArchiveSummary));

            DeleteSummary = deleteSummary;
            TierToCoolSummary = tierToCoolSummary;
            TierToArchiveSummary = tierToArchiveSummary;
        }

        /// <summary> Initializes a new instance of <see cref="StorageLifecyclePolicyCompletedEventData"/>. </summary>
        /// <param name="scheduleTime"> The time the policy task was scheduled. </param>
        /// <param name="deleteSummary"> Execution statistics of a specific policy action in a Blob Management cycle. </param>
        /// <param name="tierToCoolSummary"> Execution statistics of a specific policy action in a Blob Management cycle. </param>
        /// <param name="tierToArchiveSummary"> Execution statistics of a specific policy action in a Blob Management cycle. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageLifecyclePolicyCompletedEventData(string scheduleTime, StorageLifecyclePolicyActionSummaryDetail deleteSummary, StorageLifecyclePolicyActionSummaryDetail tierToCoolSummary, StorageLifecyclePolicyActionSummaryDetail tierToArchiveSummary, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ScheduleTime = scheduleTime;
            DeleteSummary = deleteSummary;
            TierToCoolSummary = tierToCoolSummary;
            TierToArchiveSummary = tierToArchiveSummary;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageLifecyclePolicyCompletedEventData"/> for deserialization. </summary>
        internal StorageLifecyclePolicyCompletedEventData()
        {
        }

        /// <summary> The time the policy task was scheduled. </summary>
        public string ScheduleTime { get; }
        /// <summary> Execution statistics of a specific policy action in a Blob Management cycle. </summary>
        public StorageLifecyclePolicyActionSummaryDetail DeleteSummary { get; }
        /// <summary> Execution statistics of a specific policy action in a Blob Management cycle. </summary>
        public StorageLifecyclePolicyActionSummaryDetail TierToCoolSummary { get; }
        /// <summary> Execution statistics of a specific policy action in a Blob Management cycle. </summary>
        public StorageLifecyclePolicyActionSummaryDetail TierToArchiveSummary { get; }
    }
}
