// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Managed service identity (system assigned and/or user assigned identities). </summary>
    public partial class PartialManagedServiceIdentity
    {
        /// <summary> Initializes a new instance of PartialManagedServiceIdentity. </summary>
        public PartialManagedServiceIdentity()
        {
            UserAssignedIdentities = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Managed service identity (system assigned and/or user assigned identities). </summary>
        public ManagedServiceIdentityType? ManagedServiceIdentityType { get; set; }
        /// <summary> The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM resource ids in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. The dictionary values can be empty objects ({}) in requests. </summary>
        public IDictionary<string, BinaryData> UserAssignedIdentities { get; }
    }
}
