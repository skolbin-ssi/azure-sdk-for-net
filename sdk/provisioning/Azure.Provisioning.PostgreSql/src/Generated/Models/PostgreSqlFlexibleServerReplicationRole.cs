// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// Used to indicate role of the server in replication set.
/// </summary>
public enum PostgreSqlFlexibleServerReplicationRole
{
    /// <summary>
    /// Secondary.
    /// </summary>
    Secondary,

    /// <summary>
    /// WalReplica.
    /// </summary>
    WalReplica,

    /// <summary>
    /// SyncReplica.
    /// </summary>
    SyncReplica,

    /// <summary>
    /// AsyncReplica.
    /// </summary>
    GeoSyncReplica,

    /// <summary>
    /// None.
    /// </summary>
    None,

    /// <summary>
    /// Primary.
    /// </summary>
    Primary,

    /// <summary>
    /// AsyncReplica.
    /// </summary>
    AsyncReplica,

    /// <summary>
    /// GeoAsyncReplica.
    /// </summary>
    GeoAsyncReplica,
}
