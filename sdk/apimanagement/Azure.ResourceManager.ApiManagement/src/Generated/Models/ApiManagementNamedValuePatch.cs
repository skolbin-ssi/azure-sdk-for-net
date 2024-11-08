// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> NamedValue update Parameters. </summary>
    public partial class ApiManagementNamedValuePatch
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

        /// <summary> Initializes a new instance of <see cref="ApiManagementNamedValuePatch"/>. </summary>
        public ApiManagementNamedValuePatch()
        {
            Tags = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementNamedValuePatch"/>. </summary>
        /// <param name="tags"> Optional tags that when provided can be used to filter the NamedValue list. </param>
        /// <param name="isSecret"> Determines whether the value is a secret and should be encrypted or not. Default value is false. </param>
        /// <param name="displayName"> Unique name of NamedValue. It may contain only letters, digits, period, dash, and underscore characters. </param>
        /// <param name="value"> Value of the NamedValue. Can contain policy expressions. It may not be empty or consist only of whitespace. </param>
        /// <param name="keyVault"> KeyVault location details of the namedValue. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementNamedValuePatch(IList<string> tags, bool? isSecret, string displayName, string value, KeyVaultContractCreateProperties keyVault, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            IsSecret = isSecret;
            DisplayName = displayName;
            Value = value;
            KeyVault = keyVault;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Optional tags that when provided can be used to filter the NamedValue list. </summary>
        [WirePath("properties.tags")]
        public IList<string> Tags { get; }
        /// <summary> Determines whether the value is a secret and should be encrypted or not. Default value is false. </summary>
        [WirePath("properties.secret")]
        public bool? IsSecret { get; set; }
        /// <summary> Unique name of NamedValue. It may contain only letters, digits, period, dash, and underscore characters. </summary>
        [WirePath("properties.displayName")]
        public string DisplayName { get; set; }
        /// <summary> Value of the NamedValue. Can contain policy expressions. It may not be empty or consist only of whitespace. </summary>
        [WirePath("properties.value")]
        public string Value { get; set; }
        /// <summary> KeyVault location details of the namedValue. </summary>
        [WirePath("properties.keyVault")]
        public KeyVaultContractCreateProperties KeyVault { get; set; }
    }
}
