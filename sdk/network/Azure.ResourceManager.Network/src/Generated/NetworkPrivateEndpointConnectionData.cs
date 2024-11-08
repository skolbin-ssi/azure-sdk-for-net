// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the NetworkPrivateEndpointConnection data model.
    /// PrivateEndpointConnection resource.
    /// </summary>
    public partial class NetworkPrivateEndpointConnectionData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="NetworkPrivateEndpointConnectionData"/>. </summary>
        public NetworkPrivateEndpointConnectionData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="privateEndpoint"> The resource of private end point. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        /// <param name="linkIdentifier"> The consumer link id. </param>
        /// <param name="privateEndpointLocation"> The location of the private endpoint. </param>
        internal NetworkPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType? resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, ETag? etag, PrivateEndpointData privateEndpoint, NetworkPrivateLinkServiceConnectionState connectionState, NetworkProvisioningState? provisioningState, string linkIdentifier, string privateEndpointLocation) : base(id, name, resourceType, serializedAdditionalRawData)
        {
            ETag = etag;
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            ProvisioningState = provisioningState;
            LinkIdentifier = linkIdentifier;
            PrivateEndpointLocation = privateEndpointLocation;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The resource of private end point. </summary>
        public PrivateEndpointData PrivateEndpoint { get; }
        /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
        public NetworkPrivateLinkServiceConnectionState ConnectionState { get; set; }
        /// <summary> The provisioning state of the private endpoint connection resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The consumer link id. </summary>
        public string LinkIdentifier { get; }
        /// <summary> The location of the private endpoint. </summary>
        public string PrivateEndpointLocation { get; }
    }
}
