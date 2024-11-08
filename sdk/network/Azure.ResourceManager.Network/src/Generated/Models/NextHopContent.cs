// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters that define the source and destination endpoint. </summary>
    public partial class NextHopContent
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

        /// <summary> Initializes a new instance of <see cref="NextHopContent"/>. </summary>
        /// <param name="targetResourceId"> The resource identifier of the target resource against which the action is to be performed. </param>
        /// <param name="sourceIPAddress"> The source IP address. </param>
        /// <param name="destinationIPAddress"> The destination IP address. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceId"/>, <paramref name="sourceIPAddress"/> or <paramref name="destinationIPAddress"/> is null. </exception>
        public NextHopContent(ResourceIdentifier targetResourceId, string sourceIPAddress, string destinationIPAddress)
        {
            Argument.AssertNotNull(targetResourceId, nameof(targetResourceId));
            Argument.AssertNotNull(sourceIPAddress, nameof(sourceIPAddress));
            Argument.AssertNotNull(destinationIPAddress, nameof(destinationIPAddress));

            TargetResourceId = targetResourceId;
            SourceIPAddress = sourceIPAddress;
            DestinationIPAddress = destinationIPAddress;
        }

        /// <summary> Initializes a new instance of <see cref="NextHopContent"/>. </summary>
        /// <param name="targetResourceId"> The resource identifier of the target resource against which the action is to be performed. </param>
        /// <param name="sourceIPAddress"> The source IP address. </param>
        /// <param name="destinationIPAddress"> The destination IP address. </param>
        /// <param name="targetNicResourceId"> The NIC ID. (If VM has multiple NICs and IP forwarding is enabled on any of the nics, then this parameter must be specified. Otherwise optional). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NextHopContent(ResourceIdentifier targetResourceId, string sourceIPAddress, string destinationIPAddress, ResourceIdentifier targetNicResourceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TargetResourceId = targetResourceId;
            SourceIPAddress = sourceIPAddress;
            DestinationIPAddress = destinationIPAddress;
            TargetNicResourceId = targetNicResourceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NextHopContent"/> for deserialization. </summary>
        internal NextHopContent()
        {
        }

        /// <summary> The resource identifier of the target resource against which the action is to be performed. </summary>
        public ResourceIdentifier TargetResourceId { get; }
        /// <summary> The source IP address. </summary>
        public string SourceIPAddress { get; }
        /// <summary> The destination IP address. </summary>
        public string DestinationIPAddress { get; }
        /// <summary> The NIC ID. (If VM has multiple NICs and IP forwarding is enabled on any of the nics, then this parameter must be specified. Otherwise optional). </summary>
        public ResourceIdentifier TargetNicResourceId { get; set; }
    }
}
