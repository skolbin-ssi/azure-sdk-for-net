// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> The parameters used to update a virtual network rule. </summary>
    public partial class DataLakeStoreVirtualNetworkRulePatch
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

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreVirtualNetworkRulePatch"/>. </summary>
        public DataLakeStoreVirtualNetworkRulePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreVirtualNetworkRulePatch"/>. </summary>
        /// <param name="subnetId"> The resource identifier for the subnet. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeStoreVirtualNetworkRulePatch(ResourceIdentifier subnetId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SubnetId = subnetId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource identifier for the subnet. </summary>
        public ResourceIdentifier SubnetId { get; set; }
    }
}
