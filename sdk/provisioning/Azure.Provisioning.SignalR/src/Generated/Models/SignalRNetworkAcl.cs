// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.SignalR;

/// <summary>
/// Network ACL.
/// </summary>
public partial class SignalRNetworkAcl : ProvisionableConstruct
{
    /// <summary>
    /// Allowed request types. The value can be one or more of:
    /// ClientConnection, ServerConnection, RESTAPI.
    /// </summary>
    public BicepList<SignalRRequestType> Allow 
    {
        get { Initialize(); return _allow!; }
        set { Initialize(); _allow!.Assign(value); }
    }
    private BicepList<SignalRRequestType>? _allow;

    /// <summary>
    /// Denied request types. The value can be one or more of:
    /// ClientConnection, ServerConnection, RESTAPI.
    /// </summary>
    public BicepList<SignalRRequestType> Deny 
    {
        get { Initialize(); return _deny!; }
        set { Initialize(); _deny!.Assign(value); }
    }
    private BicepList<SignalRRequestType>? _deny;

    /// <summary>
    /// Creates a new SignalRNetworkAcl.
    /// </summary>
    public SignalRNetworkAcl()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of SignalRNetworkAcl.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _allow = DefineListProperty<SignalRRequestType>("Allow", ["allow"]);
        _deny = DefineListProperty<SignalRRequestType>("Deny", ["deny"]);
    }
}
