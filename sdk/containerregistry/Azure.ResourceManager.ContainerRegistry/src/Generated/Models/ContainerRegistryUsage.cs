// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The quota usage for a container registry. </summary>
    public partial class ContainerRegistryUsage
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

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryUsage"/>. </summary>
        internal ContainerRegistryUsage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryUsage"/>. </summary>
        /// <param name="name"> The name of the usage. </param>
        /// <param name="limit"> The limit of the usage. </param>
        /// <param name="currentValue"> The current value of the usage. </param>
        /// <param name="unit"> The unit of measurement. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryUsage(string name, long? limit, long? currentValue, ContainerRegistryUsageUnit? unit, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Limit = limit;
            CurrentValue = currentValue;
            Unit = unit;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the usage. </summary>
        [WirePath("name")]
        public string Name { get; }
        /// <summary> The limit of the usage. </summary>
        [WirePath("limit")]
        public long? Limit { get; }
        /// <summary> The current value of the usage. </summary>
        [WirePath("currentValue")]
        public long? CurrentValue { get; }
        /// <summary> The unit of measurement. </summary>
        [WirePath("unit")]
        public ContainerRegistryUsageUnit? Unit { get; }
    }
}
