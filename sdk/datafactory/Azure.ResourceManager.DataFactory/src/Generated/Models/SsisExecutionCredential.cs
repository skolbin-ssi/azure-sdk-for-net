// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> SSIS package execution credential. </summary>
    public partial class SsisExecutionCredential
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

        /// <summary> Initializes a new instance of <see cref="SsisExecutionCredential"/>. </summary>
        /// <param name="domain"> Domain for windows authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="userName"> UseName for windows authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> Password for windows authentication. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domain"/>, <paramref name="userName"/> or <paramref name="password"/> is null. </exception>
        public SsisExecutionCredential(DataFactoryElement<string> domain, DataFactoryElement<string> userName, DataFactorySecretString password)
        {
            Argument.AssertNotNull(domain, nameof(domain));
            Argument.AssertNotNull(userName, nameof(userName));
            Argument.AssertNotNull(password, nameof(password));

            Domain = domain;
            UserName = userName;
            Password = password;
        }

        /// <summary> Initializes a new instance of <see cref="SsisExecutionCredential"/>. </summary>
        /// <param name="domain"> Domain for windows authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="userName"> UseName for windows authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> Password for windows authentication. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SsisExecutionCredential(DataFactoryElement<string> domain, DataFactoryElement<string> userName, DataFactorySecretString password, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Domain = domain;
            UserName = userName;
            Password = password;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SsisExecutionCredential"/> for deserialization. </summary>
        internal SsisExecutionCredential()
        {
        }

        /// <summary> Domain for windows authentication. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Domain { get; set; }
        /// <summary> UseName for windows authentication. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> UserName { get; set; }
        /// <summary> Password for windows authentication. </summary>
        public DataFactorySecretString Password { get; set; }
    }
}
