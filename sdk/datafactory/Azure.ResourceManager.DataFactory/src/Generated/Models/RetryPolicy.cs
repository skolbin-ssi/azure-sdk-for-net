// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Execution policy for an activity. </summary>
    public partial class RetryPolicy
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

        /// <summary> Initializes a new instance of <see cref="RetryPolicy"/>. </summary>
        public RetryPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RetryPolicy"/>. </summary>
        /// <param name="count"> Maximum ordinary retry attempts. Default is 0. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="intervalInSeconds"> Interval between retries in seconds. Default is 30. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RetryPolicy(DataFactoryElement<int> count, int? intervalInSeconds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Count = count;
            IntervalInSeconds = intervalInSeconds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Maximum ordinary retry attempts. Default is 0. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public DataFactoryElement<int> Count { get; set; }
        /// <summary> Interval between retries in seconds. Default is 30. </summary>
        public int? IntervalInSeconds { get; set; }
    }
}
