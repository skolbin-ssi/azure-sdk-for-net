// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure Data Factory expression definition. </summary>
    public partial class DataFactoryExpression
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

        /// <summary> Initializes a new instance of <see cref="DataFactoryExpression"/>. </summary>
        /// <param name="expressionType"> Expression type. </param>
        /// <param name="value"> Expression value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataFactoryExpression(DataFactoryExpressionType expressionType, string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            ExpressionType = expressionType;
            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryExpression"/>. </summary>
        /// <param name="expressionType"> Expression type. </param>
        /// <param name="value"> Expression value. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFactoryExpression(DataFactoryExpressionType expressionType, string value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ExpressionType = expressionType;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryExpression"/> for deserialization. </summary>
        internal DataFactoryExpression()
        {
        }

        /// <summary> Expression type. </summary>
        public DataFactoryExpressionType ExpressionType { get; set; }
        /// <summary> Expression value. </summary>
        public string Value { get; set; }
    }
}
