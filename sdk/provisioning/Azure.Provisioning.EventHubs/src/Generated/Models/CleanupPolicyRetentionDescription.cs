// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.EventHubs;

/// <summary>
/// Enumerates the possible values for cleanup policy.
/// </summary>
public enum CleanupPolicyRetentionDescription
{
    /// <summary>
    /// Delete.
    /// </summary>
    Delete,

    /// <summary>
    /// Compact.
    /// </summary>
    [DataMember(Name = "Compact")]
    Compaction,
}
