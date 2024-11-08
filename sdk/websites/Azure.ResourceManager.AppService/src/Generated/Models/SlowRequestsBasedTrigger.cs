// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Trigger based on request execution time. </summary>
    public partial class SlowRequestsBasedTrigger
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

        /// <summary> Initializes a new instance of <see cref="SlowRequestsBasedTrigger"/>. </summary>
        public SlowRequestsBasedTrigger()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SlowRequestsBasedTrigger"/>. </summary>
        /// <param name="timeTaken"> Time taken. </param>
        /// <param name="path"> Request Path. </param>
        /// <param name="count"> Request Count. </param>
        /// <param name="timeInterval"> Time interval. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SlowRequestsBasedTrigger(string timeTaken, string path, int? count, string timeInterval, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TimeTaken = timeTaken;
            Path = path;
            Count = count;
            TimeInterval = timeInterval;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Time taken. </summary>
        [WirePath("timeTaken")]
        public string TimeTaken { get; set; }
        /// <summary> Request Path. </summary>
        [WirePath("path")]
        public string Path { get; set; }
        /// <summary> Request Count. </summary>
        [WirePath("count")]
        public int? Count { get; set; }
        /// <summary> Time interval. </summary>
        [WirePath("timeInterval")]
        public string TimeInterval { get; set; }
    }
}
