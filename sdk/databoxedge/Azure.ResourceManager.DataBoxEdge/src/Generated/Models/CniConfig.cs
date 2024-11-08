// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Cni configuration. </summary>
    public partial class CniConfig
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

        /// <summary> Initializes a new instance of <see cref="CniConfig"/>. </summary>
        internal CniConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CniConfig"/>. </summary>
        /// <param name="cniConfigType"> Cni type. </param>
        /// <param name="version"> Cni version. </param>
        /// <param name="podSubnet"> Pod Subnet. </param>
        /// <param name="serviceSubnet"> Service subnet. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CniConfig(string cniConfigType, string version, string podSubnet, string serviceSubnet, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CniConfigType = cniConfigType;
            Version = version;
            PodSubnet = podSubnet;
            ServiceSubnet = serviceSubnet;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Cni type. </summary>
        public string CniConfigType { get; }
        /// <summary> Cni version. </summary>
        public string Version { get; }
        /// <summary> Pod Subnet. </summary>
        public string PodSubnet { get; }
        /// <summary> Service subnet. </summary>
        public string ServiceSubnet { get; }
    }
}
