// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PowerBIDedicated.Models
{
    /// <summary> Details of capacity name request body. </summary>
    public partial class CheckCapacityNameAvailabilityContent
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

        /// <summary> Initializes a new instance of <see cref="CheckCapacityNameAvailabilityContent"/>. </summary>
        public CheckCapacityNameAvailabilityContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CheckCapacityNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Name for checking availability. </param>
        /// <param name="resourceType"> The resource type of PowerBI dedicated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CheckCapacityNameAvailabilityContent(string name, string resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ResourceType = resourceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name for checking availability. </summary>
        public string Name { get; set; }
        /// <summary> The resource type of PowerBI dedicated. </summary>
        public string ResourceType { get; set; }
    }
}
