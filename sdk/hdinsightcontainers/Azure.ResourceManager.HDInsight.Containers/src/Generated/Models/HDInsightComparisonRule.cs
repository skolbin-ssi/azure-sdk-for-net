// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The comparison rule. </summary>
    public partial class HDInsightComparisonRule
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

        /// <summary> Initializes a new instance of <see cref="HDInsightComparisonRule"/>. </summary>
        /// <param name="operator"> The comparison operator. </param>
        /// <param name="threshold"> Threshold setting. </param>
        public HDInsightComparisonRule(HDInsightComparisonOperator @operator, float threshold)
        {
            Operator = @operator;
            Threshold = threshold;
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightComparisonRule"/>. </summary>
        /// <param name="operator"> The comparison operator. </param>
        /// <param name="threshold"> Threshold setting. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightComparisonRule(HDInsightComparisonOperator @operator, float threshold, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Operator = @operator;
            Threshold = threshold;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightComparisonRule"/> for deserialization. </summary>
        internal HDInsightComparisonRule()
        {
        }

        /// <summary> The comparison operator. </summary>
        [WirePath("operator")]
        public HDInsightComparisonOperator Operator { get; set; }
        /// <summary> Threshold setting. </summary>
        [WirePath("threshold")]
        public float Threshold { get; set; }
    }
}
