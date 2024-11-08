// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    /// <summary> The details for role assignment common properties. </summary>
    public partial class RoleAssignmentCommonProperties
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

        /// <summary> Initializes a new instance of <see cref="RoleAssignmentCommonProperties"/>. </summary>
        /// <param name="roleId"> Role Id of the Built-In Role. </param>
        /// <param name="principalId"> Object ID of the AAD principal or security-group. </param>
        /// <param name="userName"> User name. </param>
        /// <param name="dataTypeScope"> Data Type Scope at which the role assignment is created. </param>
        /// <param name="principalType"> Type of the principal Id: User, Group or ServicePrincipal. </param>
        /// <param name="role"> Data Product role to be assigned to a user. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleId"/>, <paramref name="principalId"/>, <paramref name="userName"/>, <paramref name="dataTypeScope"/> or <paramref name="principalType"/> is null. </exception>
        public RoleAssignmentCommonProperties(string roleId, string principalId, string userName, IEnumerable<string> dataTypeScope, string principalType, DataProductUserRole role)
        {
            Argument.AssertNotNull(roleId, nameof(roleId));
            Argument.AssertNotNull(principalId, nameof(principalId));
            Argument.AssertNotNull(userName, nameof(userName));
            Argument.AssertNotNull(dataTypeScope, nameof(dataTypeScope));
            Argument.AssertNotNull(principalType, nameof(principalType));

            RoleId = roleId;
            PrincipalId = principalId;
            UserName = userName;
            DataTypeScope = dataTypeScope.ToList();
            PrincipalType = principalType;
            Role = role;
        }

        /// <summary> Initializes a new instance of <see cref="RoleAssignmentCommonProperties"/>. </summary>
        /// <param name="roleId"> Role Id of the Built-In Role. </param>
        /// <param name="principalId"> Object ID of the AAD principal or security-group. </param>
        /// <param name="userName"> User name. </param>
        /// <param name="dataTypeScope"> Data Type Scope at which the role assignment is created. </param>
        /// <param name="principalType"> Type of the principal Id: User, Group or ServicePrincipal. </param>
        /// <param name="role"> Data Product role to be assigned to a user. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RoleAssignmentCommonProperties(string roleId, string principalId, string userName, IList<string> dataTypeScope, string principalType, DataProductUserRole role, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RoleId = roleId;
            PrincipalId = principalId;
            UserName = userName;
            DataTypeScope = dataTypeScope;
            PrincipalType = principalType;
            Role = role;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RoleAssignmentCommonProperties"/> for deserialization. </summary>
        internal RoleAssignmentCommonProperties()
        {
        }

        /// <summary> Role Id of the Built-In Role. </summary>
        public string RoleId { get; }
        /// <summary> Object ID of the AAD principal or security-group. </summary>
        public string PrincipalId { get; }
        /// <summary> User name. </summary>
        public string UserName { get; }
        /// <summary> Data Type Scope at which the role assignment is created. </summary>
        public IList<string> DataTypeScope { get; }
        /// <summary> Type of the principal Id: User, Group or ServicePrincipal. </summary>
        public string PrincipalType { get; }
        /// <summary> Data Product role to be assigned to a user. </summary>
        public DataProductUserRole Role { get; }
    }
}
