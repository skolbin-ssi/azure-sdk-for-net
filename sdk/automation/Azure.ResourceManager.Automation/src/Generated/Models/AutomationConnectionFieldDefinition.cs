// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the connection fields. </summary>
    public partial class AutomationConnectionFieldDefinition
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

        /// <summary> Initializes a new instance of <see cref="AutomationConnectionFieldDefinition"/>. </summary>
        /// <param name="fieldDefinitionType"> Gets or sets the type of the connection field definition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fieldDefinitionType"/> is null. </exception>
        public AutomationConnectionFieldDefinition(string fieldDefinitionType)
        {
            Argument.AssertNotNull(fieldDefinitionType, nameof(fieldDefinitionType));

            FieldDefinitionType = fieldDefinitionType;
        }

        /// <summary> Initializes a new instance of <see cref="AutomationConnectionFieldDefinition"/>. </summary>
        /// <param name="isEncrypted"> Gets or sets the isEncrypted flag of the connection field definition. </param>
        /// <param name="isOptional"> Gets or sets the isOptional flag of the connection field definition. </param>
        /// <param name="fieldDefinitionType"> Gets or sets the type of the connection field definition. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationConnectionFieldDefinition(bool? isEncrypted, bool? isOptional, string fieldDefinitionType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEncrypted = isEncrypted;
            IsOptional = isOptional;
            FieldDefinitionType = fieldDefinitionType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AutomationConnectionFieldDefinition"/> for deserialization. </summary>
        internal AutomationConnectionFieldDefinition()
        {
        }

        /// <summary> Gets or sets the isEncrypted flag of the connection field definition. </summary>
        public bool? IsEncrypted { get; set; }
        /// <summary> Gets or sets the isOptional flag of the connection field definition. </summary>
        public bool? IsOptional { get; set; }
        /// <summary> Gets or sets the type of the connection field definition. </summary>
        public string FieldDefinitionType { get; set; }
    }
}
