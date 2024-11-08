// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;

namespace Azure.ResourceManager.TrafficManager.Models
{
    /// <summary> Subnet first address, scope, and/or last address. </summary>
    public partial class TrafficManagerEndpointSubnetInfo
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

        /// <summary> Initializes a new instance of <see cref="TrafficManagerEndpointSubnetInfo"/>. </summary>
        public TrafficManagerEndpointSubnetInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TrafficManagerEndpointSubnetInfo"/>. </summary>
        /// <param name="first"> First address in the subnet. </param>
        /// <param name="last"> Last address in the subnet. </param>
        /// <param name="scope"> Block size (number of leading bits in the subnet mask). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TrafficManagerEndpointSubnetInfo(IPAddress first, IPAddress last, int? scope, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            First = first;
            Last = last;
            Scope = scope;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> First address in the subnet. </summary>
        public IPAddress First { get; set; }
        /// <summary> Last address in the subnet. </summary>
        public IPAddress Last { get; set; }
        /// <summary> Block size (number of leading bits in the subnet mask). </summary>
        public int? Scope { get; set; }
    }
}
