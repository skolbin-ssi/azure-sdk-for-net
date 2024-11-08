// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> CIDR Ip address. </summary>
    public partial class CidrIPAddress
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

        /// <summary> Initializes a new instance of <see cref="CidrIPAddress"/>. </summary>
        public CidrIPAddress()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CidrIPAddress"/>. </summary>
        /// <param name="baseIPAddress"> Ip address itself. </param>
        /// <param name="prefixLength"> The length of the prefix of the ip address. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CidrIPAddress(string baseIPAddress, int? prefixLength, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BaseIPAddress = baseIPAddress;
            PrefixLength = prefixLength;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Ip address itself. </summary>
        public string BaseIPAddress { get; set; }
        /// <summary> The length of the prefix of the ip address. </summary>
        public int? PrefixLength { get; set; }
    }
}
