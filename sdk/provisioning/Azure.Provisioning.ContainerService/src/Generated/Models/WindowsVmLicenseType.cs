// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// The license type to use for Windows VMs. See [Azure Hybrid User
/// Benefits](https://azure.microsoft.com/pricing/hybrid-benefit/faq/) for
/// more details.
/// </summary>
public enum WindowsVmLicenseType
{
    /// <summary>
    /// No additional licensing is applied.
    /// </summary>
    None,

    /// <summary>
    /// Enables Azure Hybrid User Benefits for Windows VMs.
    /// </summary>
    [DataMember(Name = "Windows_Server")]
    WindowsServer,
}
