// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The RequestLogging. </summary>
    internal partial class RequestLogging
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

        /// <summary> Initializes a new instance of <see cref="RequestLogging"/>. </summary>
        public RequestLogging()
        {
            CaptureHeaders = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="RequestLogging"/>. </summary>
        /// <param name="captureHeaders"> For payload logging, we only collect payload by default. If customers also want to collect the specified headers, they can set them in captureHeaders so that backend will collect those headers along with payload. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RequestLogging(IList<string> captureHeaders, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CaptureHeaders = captureHeaders;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> For payload logging, we only collect payload by default. If customers also want to collect the specified headers, they can set them in captureHeaders so that backend will collect those headers along with payload. </summary>
        [WirePath("captureHeaders")]
        public IList<string> CaptureHeaders { get; set; }
    }
}
