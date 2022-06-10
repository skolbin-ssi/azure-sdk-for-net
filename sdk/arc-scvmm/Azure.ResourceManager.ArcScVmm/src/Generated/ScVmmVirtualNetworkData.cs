// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ArcScVmm.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ArcScVmm
{
    /// <summary> A class representing the ScVmmVirtualNetwork data model. </summary>
    public partial class ScVmmVirtualNetworkData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ScVmmVirtualNetworkData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extendedLocation"/> is null. </exception>
        public ScVmmVirtualNetworkData(AzureLocation location, ExtendedLocation extendedLocation) : base(location)
        {
            if (extendedLocation == null)
            {
                throw new ArgumentNullException(nameof(extendedLocation));
            }

            ExtendedLocation = extendedLocation;
        }

        /// <summary> Initializes a new instance of ScVmmVirtualNetworkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location. </param>
        /// <param name="inventoryItemId"> Gets or sets the inventory Item ID for the resource. </param>
        /// <param name="uuid"> Unique ID of the virtual network. </param>
        /// <param name="vmmServerId"> ARM Id of the vmmServer resource in which this resource resides. </param>
        /// <param name="networkName"> Name of the virtual network in vmmServer. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state. </param>
        internal ScVmmVirtualNetworkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, string inventoryItemId, string uuid, string vmmServerId, string networkName, string provisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            InventoryItemId = inventoryItemId;
            Uuid = uuid;
            VmmServerId = vmmServerId;
            NetworkName = networkName;
            ProvisioningState = provisioningState;
        }

        /// <summary> The extended location. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> Gets or sets the inventory Item ID for the resource. </summary>
        public string InventoryItemId { get; set; }
        /// <summary> Unique ID of the virtual network. </summary>
        public string Uuid { get; set; }
        /// <summary> ARM Id of the vmmServer resource in which this resource resides. </summary>
        public string VmmServerId { get; set; }
        /// <summary> Name of the virtual network in vmmServer. </summary>
        public string NetworkName { get; }
        /// <summary> Gets or sets the provisioning state. </summary>
        public string ProvisioningState { get; }
    }
}
