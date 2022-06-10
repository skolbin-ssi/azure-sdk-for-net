// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The details of the user-assigned managed identity assigned to an App.
    /// </summary>
    public partial class UserAssignedManagedIdentity
    {
        /// <summary>
        /// Initializes a new instance of the UserAssignedManagedIdentity
        /// class.
        /// </summary>
        public UserAssignedManagedIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserAssignedManagedIdentity
        /// class.
        /// </summary>
        /// <param name="principalId">Principal Id of user-assigned managed
        /// identity.</param>
        /// <param name="clientId">Client Id of user-assigned managed
        /// identity.</param>
        public UserAssignedManagedIdentity(string principalId = default(string), string clientId = default(string))
        {
            PrincipalId = principalId;
            ClientId = clientId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets principal Id of user-assigned managed identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets client Id of user-assigned managed identity.
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; private set; }

    }
}
