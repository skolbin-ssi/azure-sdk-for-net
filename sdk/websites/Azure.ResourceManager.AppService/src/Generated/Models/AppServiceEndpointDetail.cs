// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Current TCP connectivity information from the App Service Environment to a single endpoint. </summary>
    public partial class AppServiceEndpointDetail
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

        /// <summary> Initializes a new instance of <see cref="AppServiceEndpointDetail"/>. </summary>
        internal AppServiceEndpointDetail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceEndpointDetail"/>. </summary>
        /// <param name="ipAddress"> An IP Address that Domain Name currently resolves to. </param>
        /// <param name="port"> The port an endpoint is connected to. </param>
        /// <param name="latency"> The time in milliseconds it takes for a TCP connection to be created from the App Service Environment to this IpAddress at this Port. </param>
        /// <param name="isAccessible"> Whether it is possible to create a TCP connection from the App Service Environment to this IpAddress at this Port. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceEndpointDetail(IPAddress ipAddress, int? port, double? latency, bool? isAccessible, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IPAddress = ipAddress;
            Port = port;
            Latency = latency;
            IsAccessible = isAccessible;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> An IP Address that Domain Name currently resolves to. </summary>
        [WirePath("ipAddress")]
        public IPAddress IPAddress { get; }
        /// <summary> The port an endpoint is connected to. </summary>
        [WirePath("port")]
        public int? Port { get; }
        /// <summary> The time in milliseconds it takes for a TCP connection to be created from the App Service Environment to this IpAddress at this Port. </summary>
        [WirePath("latency")]
        public double? Latency { get; }
        /// <summary> Whether it is possible to create a TCP connection from the App Service Environment to this IpAddress at this Port. </summary>
        [WirePath("isAccessible")]
        public bool? IsAccessible { get; }
    }
}
