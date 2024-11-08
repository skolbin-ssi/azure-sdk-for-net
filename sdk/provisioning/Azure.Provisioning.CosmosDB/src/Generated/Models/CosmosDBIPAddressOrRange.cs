// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// IpAddressOrRange object.
/// </summary>
public partial class CosmosDBIPAddressOrRange : ProvisionableConstruct
{
    /// <summary>
    /// A single IPv4 address or a single IPv4 address range in CIDR format.
    /// Provided IPs must be well-formatted and cannot be contained in one of
    /// the following ranges: 10.0.0.0/8, 100.64.0.0/10, 172.16.0.0/12,
    /// 192.168.0.0/16, since these are not enforceable by the IP address
    /// filter. Example of valid inputs: “23.40.210.245” or “23.40.210.0/8”.
    /// </summary>
    public BicepValue<string> IPAddressOrRange 
    {
        get { Initialize(); return _iPAddressOrRange!; }
        set { Initialize(); _iPAddressOrRange!.Assign(value); }
    }
    private BicepValue<string>? _iPAddressOrRange;

    /// <summary>
    /// Creates a new CosmosDBIPAddressOrRange.
    /// </summary>
    public CosmosDBIPAddressOrRange()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of CosmosDBIPAddressOrRange.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _iPAddressOrRange = DefineProperty<string>("IPAddressOrRange", ["ipAddressOrRange"]);
    }
}
