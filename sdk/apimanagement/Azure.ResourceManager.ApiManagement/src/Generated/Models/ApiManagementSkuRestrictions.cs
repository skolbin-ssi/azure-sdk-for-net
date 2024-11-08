// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Describes scaling information of a SKU. </summary>
    public partial class ApiManagementSkuRestrictions
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

        /// <summary> Initializes a new instance of <see cref="ApiManagementSkuRestrictions"/>. </summary>
        internal ApiManagementSkuRestrictions()
        {
            Values = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementSkuRestrictions"/>. </summary>
        /// <param name="restrictionsType"> The type of restrictions. </param>
        /// <param name="values"> The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted. </param>
        /// <param name="restrictionInfo"> The information about the restriction where the SKU cannot be used. </param>
        /// <param name="reasonCode"> The reason for restriction. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementSkuRestrictions(ApiManagementSkuRestrictionsType? restrictionsType, IReadOnlyList<string> values, ApiManagementSkuRestrictionInfo restrictionInfo, ApiManagementSkuRestrictionsReasonCode? reasonCode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RestrictionsType = restrictionsType;
            Values = values;
            RestrictionInfo = restrictionInfo;
            ReasonCode = reasonCode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of restrictions. </summary>
        [WirePath("type")]
        public ApiManagementSkuRestrictionsType? RestrictionsType { get; }
        /// <summary> The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted. </summary>
        [WirePath("values")]
        public IReadOnlyList<string> Values { get; }
        /// <summary> The information about the restriction where the SKU cannot be used. </summary>
        [WirePath("restrictionInfo")]
        public ApiManagementSkuRestrictionInfo RestrictionInfo { get; }
        /// <summary> The reason for restriction. </summary>
        [WirePath("reasonCode")]
        public ApiManagementSkuRestrictionsReasonCode? ReasonCode { get; }
    }
}
