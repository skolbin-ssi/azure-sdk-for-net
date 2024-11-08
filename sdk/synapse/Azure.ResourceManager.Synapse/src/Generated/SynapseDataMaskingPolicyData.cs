// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary> A class representing the SynapseDataMaskingPolicy data model. </summary>
    public partial class SynapseDataMaskingPolicyData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SynapseDataMaskingPolicyData"/>. </summary>
        public SynapseDataMaskingPolicyData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseDataMaskingPolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The location of the data masking policy. </param>
        /// <param name="kind"> The kind of data masking policy. Metadata, used for Azure portal. </param>
        /// <param name="managedBy"> Fully qualified resource ID of the sql pool. </param>
        /// <param name="dataMaskingState"> The state of the data masking policy. </param>
        /// <param name="exemptPrincipals"> The list of the exempt principals. Specifies the semicolon-separated list of database users for which the data masking policy does not apply. The specified users receive data results without masking for all of the database queries. </param>
        /// <param name="applicationPrincipals"> The list of the application principals. This is a legacy parameter and is no longer used. </param>
        /// <param name="maskingLevel"> The masking level. This is a legacy parameter and is no longer used. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseDataMaskingPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, string kind, string managedBy, SynapseDataMaskingState? dataMaskingState, string exemptPrincipals, string applicationPrincipals, string maskingLevel, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Kind = kind;
            ManagedBy = managedBy;
            DataMaskingState = dataMaskingState;
            ExemptPrincipals = exemptPrincipals;
            ApplicationPrincipals = applicationPrincipals;
            MaskingLevel = maskingLevel;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The location of the data masking policy. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The kind of data masking policy. Metadata, used for Azure portal. </summary>
        public string Kind { get; }
        /// <summary> Fully qualified resource ID of the sql pool. </summary>
        public string ManagedBy { get; }
        /// <summary> The state of the data masking policy. </summary>
        public SynapseDataMaskingState? DataMaskingState { get; set; }
        /// <summary> The list of the exempt principals. Specifies the semicolon-separated list of database users for which the data masking policy does not apply. The specified users receive data results without masking for all of the database queries. </summary>
        public string ExemptPrincipals { get; set; }
        /// <summary> The list of the application principals. This is a legacy parameter and is no longer used. </summary>
        public string ApplicationPrincipals { get; }
        /// <summary> The masking level. This is a legacy parameter and is no longer used. </summary>
        public string MaskingLevel { get; }
    }
}
