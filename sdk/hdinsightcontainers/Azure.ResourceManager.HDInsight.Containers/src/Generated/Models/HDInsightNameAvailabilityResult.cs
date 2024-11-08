// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Result of check name availability. </summary>
    public partial class HDInsightNameAvailabilityResult
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

        /// <summary> Initializes a new instance of <see cref="HDInsightNameAvailabilityResult"/>. </summary>
        internal HDInsightNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"> Indicator of availability of the Microsoft.HDInsight resource name. </param>
        /// <param name="reason"> The reason of unavailability. </param>
        /// <param name="message"> The error message of unavailability. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightNameAvailabilityResult(bool? isNameAvailable, string reason, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsNameAvailable = isNameAvailable;
            Reason = reason;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicator of availability of the Microsoft.HDInsight resource name. </summary>
        [WirePath("nameAvailable")]
        public bool? IsNameAvailable { get; }
        /// <summary> The reason of unavailability. </summary>
        [WirePath("reason")]
        public string Reason { get; }
        /// <summary> The error message of unavailability. </summary>
        [WirePath("message")]
        public string Message { get; }
    }
}
