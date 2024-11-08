// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Result of the request to list networkManagerEffectiveSecurityAdminRules. It contains a list of groups and a skiptoken to get the next set of results. </summary>
    internal partial class NetworkManagerEffectiveSecurityAdminRulesListResult
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

        /// <summary> Initializes a new instance of <see cref="NetworkManagerEffectiveSecurityAdminRulesListResult"/>. </summary>
        internal NetworkManagerEffectiveSecurityAdminRulesListResult()
        {
            Value = new ChangeTrackingList<EffectiveBaseSecurityAdminRule>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkManagerEffectiveSecurityAdminRulesListResult"/>. </summary>
        /// <param name="value">
        /// Gets a page of NetworkManagerEffectiveSecurityAdminRules
        /// Please note <see cref="EffectiveBaseSecurityAdminRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="EffectiveSecurityAdminRule"/> and <see cref="EffectiveDefaultSecurityAdminRule"/>.
        /// </param>
        /// <param name="skipToken"> When present, the value can be passed to a subsequent query call (together with the same query and scopes used in the current request) to retrieve the next page of data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkManagerEffectiveSecurityAdminRulesListResult(IReadOnlyList<EffectiveBaseSecurityAdminRule> value, string skipToken, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            SkipToken = skipToken;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Gets a page of NetworkManagerEffectiveSecurityAdminRules
        /// Please note <see cref="EffectiveBaseSecurityAdminRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="EffectiveSecurityAdminRule"/> and <see cref="EffectiveDefaultSecurityAdminRule"/>.
        /// </summary>
        public IReadOnlyList<EffectiveBaseSecurityAdminRule> Value { get; }
        /// <summary> When present, the value can be passed to a subsequent query call (together with the same query and scopes used in the current request) to retrieve the next page of data. </summary>
        public string SkipToken { get; }
    }
}
