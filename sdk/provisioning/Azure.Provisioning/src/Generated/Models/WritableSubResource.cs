// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.Resources;

/// <summary>
/// A class representing a sub-resource that contains only the ID.
/// </summary>
public partial class WritableSubResource : ProvisionableConstruct
{
    /// <summary>
    /// Gets or sets the ARM resource identifier.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
        set { Initialize(); _id!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Creates a new WritableSubResource.
    /// </summary>
    public WritableSubResource()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of WritableSubResource.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"]);
    }
}
