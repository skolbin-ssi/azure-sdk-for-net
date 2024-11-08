// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevOpsInfrastructure.Models
{
    /// <summary> The OS profile of the machines in the pool. </summary>
    public partial class DevOpsOSProfile
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

        /// <summary> Initializes a new instance of <see cref="DevOpsOSProfile"/>. </summary>
        public DevOpsOSProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevOpsOSProfile"/>. </summary>
        /// <param name="secretsManagementSettings"> The secret management settings of the machines in the pool. </param>
        /// <param name="logonType"> Determines how the service should be run. By default, this will be set to Service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DevOpsOSProfile(SecretsManagementSettings secretsManagementSettings, DevOpsLogonType? logonType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SecretsManagementSettings = secretsManagementSettings;
            LogonType = logonType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The secret management settings of the machines in the pool. </summary>
        public SecretsManagementSettings SecretsManagementSettings { get; set; }
        /// <summary> Determines how the service should be run. By default, this will be set to Service. </summary>
        public DevOpsLogonType? LogonType { get; set; }
    }
}
