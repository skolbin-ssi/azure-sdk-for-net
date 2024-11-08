// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// SqlServerAzureADOnlyAuthentication.
/// </summary>
public partial class SqlServerAzureADOnlyAuthentication : ProvisionableResource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Azure Active Directory only Authentication enabled.
    /// </summary>
    public BicepValue<bool> IsAzureADOnlyAuthenticationEnabled 
    {
        get { Initialize(); return _isAzureADOnlyAuthenticationEnabled!; }
        set { Initialize(); _isAzureADOnlyAuthenticationEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isAzureADOnlyAuthenticationEnabled;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent SqlServer.
    /// </summary>
    public SqlServer? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<SqlServer>? _parent;

    /// <summary>
    /// Creates a new SqlServerAzureADOnlyAuthentication.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SqlServerAzureADOnlyAuthentication
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SqlServerAzureADOnlyAuthentication.</param>
    public SqlServerAzureADOnlyAuthentication(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/servers/azureADOnlyAuthentications", resourceVersion ?? "2021-11-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// SqlServerAzureADOnlyAuthentication.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _isAzureADOnlyAuthenticationEnabled = DefineProperty<bool>("IsAzureADOnlyAuthenticationEnabled", ["properties", "azureADOnlyAuthentication"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<SqlServer>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SqlServerAzureADOnlyAuthentication resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";

        /// <summary>
        /// 2014-01-01.
        /// </summary>
        public static readonly string V2014_01_01 = "2014-01-01";
    }

    /// <summary>
    /// Creates a reference to an existing SqlServerAzureADOnlyAuthentication.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SqlServerAzureADOnlyAuthentication
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SqlServerAzureADOnlyAuthentication.</param>
    /// <returns>The existing SqlServerAzureADOnlyAuthentication resource.</returns>
    public static SqlServerAzureADOnlyAuthentication FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
