// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetworkFunction.Models
{
    /// <summary> Emission policy properties. </summary>
    public partial class EmissionPoliciesPropertiesFormat
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

        /// <summary> Initializes a new instance of <see cref="EmissionPoliciesPropertiesFormat"/>. </summary>
        public EmissionPoliciesPropertiesFormat()
        {
            EmissionDestinations = new ChangeTrackingList<EmissionPolicyDestination>();
        }

        /// <summary> Initializes a new instance of <see cref="EmissionPoliciesPropertiesFormat"/>. </summary>
        /// <param name="emissionType"> Emission format type. </param>
        /// <param name="emissionDestinations"> Emission policy destinations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EmissionPoliciesPropertiesFormat(EmissionType? emissionType, IList<EmissionPolicyDestination> emissionDestinations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EmissionType = emissionType;
            EmissionDestinations = emissionDestinations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Emission format type. </summary>
        public EmissionType? EmissionType { get; set; }
        /// <summary> Emission policy destinations. </summary>
        public IList<EmissionPolicyDestination> EmissionDestinations { get; }
    }
}
