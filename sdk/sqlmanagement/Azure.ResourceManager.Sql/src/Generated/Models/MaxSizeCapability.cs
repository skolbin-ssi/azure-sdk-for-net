// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The maximum size capability. </summary>
    public partial class MaxSizeCapability
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

        /// <summary> Initializes a new instance of <see cref="MaxSizeCapability"/>. </summary>
        internal MaxSizeCapability()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MaxSizeCapability"/>. </summary>
        /// <param name="limit"> The maximum size limit (see 'unit' for the units). </param>
        /// <param name="unit"> The units that the limit is expressed in. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MaxSizeCapability(int? limit, MaxSizeUnit? unit, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Limit = limit;
            Unit = unit;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The maximum size limit (see 'unit' for the units). </summary>
        [WirePath("limit")]
        public int? Limit { get; }
        /// <summary> The units that the limit is expressed in. </summary>
        [WirePath("unit")]
        public MaxSizeUnit? Unit { get; }
    }
}
