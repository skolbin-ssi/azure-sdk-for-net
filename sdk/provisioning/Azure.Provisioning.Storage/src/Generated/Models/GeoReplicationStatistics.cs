// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// Statistics related to replication for storage account&apos;s Blob, Table,
/// Queue and File services. It is only available when geo-redundant
/// replication is enabled for the storage account.
/// </summary>
public partial class GeoReplicationStatistics : ProvisionableConstruct
{
    /// <summary>
    /// The status of the secondary location. Possible values are: - Live:
    /// Indicates that the secondary location is active and operational. -
    /// Bootstrap: Indicates initial synchronization from the primary location
    /// to the secondary location is in progress.This typically occurs when
    /// replication is first enabled. - Unavailable: Indicates that the
    /// secondary location is temporarily unavailable.
    /// </summary>
    public BicepValue<GeoReplicationStatus> Status 
    {
        get { Initialize(); return _status!; }
    }
    private BicepValue<GeoReplicationStatus>? _status;

    /// <summary>
    /// All primary writes preceding this UTC date/time value are guaranteed to
    /// be available for read operations. Primary writes following this point
    /// in time may or may not be available for reads. Element may be default
    /// value if value of LastSyncTime is not available, this can happen if
    /// secondary is offline or we are in bootstrap.
    /// </summary>
    public BicepValue<DateTimeOffset> LastSyncOn 
    {
        get { Initialize(); return _lastSyncOn!; }
    }
    private BicepValue<DateTimeOffset>? _lastSyncOn;

    /// <summary>
    /// A boolean flag which indicates whether or not account failover is
    /// supported for the account.
    /// </summary>
    public BicepValue<bool> CanFailover 
    {
        get { Initialize(); return _canFailover!; }
    }
    private BicepValue<bool>? _canFailover;

    /// <summary>
    /// Creates a new GeoReplicationStatistics.
    /// </summary>
    public GeoReplicationStatistics()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of GeoReplicationStatistics.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _status = DefineProperty<GeoReplicationStatus>("Status", ["status"], isOutput: true);
        _lastSyncOn = DefineProperty<DateTimeOffset>("LastSyncOn", ["lastSyncTime"], isOutput: true);
        _canFailover = DefineProperty<bool>("CanFailover", ["canFailover"], isOutput: true);
    }
}
