// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Datadog.Models
{
    /// <summary> The definition of a filtering tag. Filtering tags are used for capturing resources and include/exclude them from being monitored. </summary>
    public partial class FilteringTag
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

        /// <summary> Initializes a new instance of <see cref="FilteringTag"/>. </summary>
        public FilteringTag()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FilteringTag"/>. </summary>
        /// <param name="name"> The name (also known as the key) of the tag. </param>
        /// <param name="value"> The value of the tag. </param>
        /// <param name="action"> Valid actions for a filtering tag. Exclusion takes priority over inclusion. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FilteringTag(string name, string value, TagAction? action, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Value = value;
            Action = action;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name (also known as the key) of the tag. </summary>
        public string Name { get; set; }
        /// <summary> The value of the tag. </summary>
        public string Value { get; set; }
        /// <summary> Valid actions for a filtering tag. Exclusion takes priority over inclusion. </summary>
        public TagAction? Action { get; set; }
    }
}
