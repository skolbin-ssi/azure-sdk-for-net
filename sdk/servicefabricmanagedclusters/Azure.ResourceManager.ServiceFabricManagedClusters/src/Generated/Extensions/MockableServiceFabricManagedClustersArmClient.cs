// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableServiceFabricManagedClustersArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableServiceFabricManagedClustersArmClient"/> class for mocking. </summary>
        protected MockableServiceFabricManagedClustersArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableServiceFabricManagedClustersArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableServiceFabricManagedClustersArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableServiceFabricManagedClustersArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceFabricManagedClusterResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceFabricManagedClusterResource.CreateResourceIdentifier" /> to create a <see cref="ServiceFabricManagedClusterResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceFabricManagedClusterResource"/> object. </returns>
        public virtual ServiceFabricManagedClusterResource GetServiceFabricManagedClusterResource(ResourceIdentifier id)
        {
            ServiceFabricManagedClusterResource.ValidateResourceId(id);
            return new ServiceFabricManagedClusterResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceFabricManagedNodeTypeResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceFabricManagedNodeTypeResource.CreateResourceIdentifier" /> to create a <see cref="ServiceFabricManagedNodeTypeResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceFabricManagedNodeTypeResource"/> object. </returns>
        public virtual ServiceFabricManagedNodeTypeResource GetServiceFabricManagedNodeTypeResource(ResourceIdentifier id)
        {
            ServiceFabricManagedNodeTypeResource.ValidateResourceId(id);
            return new ServiceFabricManagedNodeTypeResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceFabricManagedApplicationTypeResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceFabricManagedApplicationTypeResource.CreateResourceIdentifier" /> to create a <see cref="ServiceFabricManagedApplicationTypeResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceFabricManagedApplicationTypeResource"/> object. </returns>
        public virtual ServiceFabricManagedApplicationTypeResource GetServiceFabricManagedApplicationTypeResource(ResourceIdentifier id)
        {
            ServiceFabricManagedApplicationTypeResource.ValidateResourceId(id);
            return new ServiceFabricManagedApplicationTypeResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceFabricManagedApplicationTypeVersionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceFabricManagedApplicationTypeVersionResource.CreateResourceIdentifier" /> to create a <see cref="ServiceFabricManagedApplicationTypeVersionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceFabricManagedApplicationTypeVersionResource"/> object. </returns>
        public virtual ServiceFabricManagedApplicationTypeVersionResource GetServiceFabricManagedApplicationTypeVersionResource(ResourceIdentifier id)
        {
            ServiceFabricManagedApplicationTypeVersionResource.ValidateResourceId(id);
            return new ServiceFabricManagedApplicationTypeVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceFabricManagedApplicationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceFabricManagedApplicationResource.CreateResourceIdentifier" /> to create a <see cref="ServiceFabricManagedApplicationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceFabricManagedApplicationResource"/> object. </returns>
        public virtual ServiceFabricManagedApplicationResource GetServiceFabricManagedApplicationResource(ResourceIdentifier id)
        {
            ServiceFabricManagedApplicationResource.ValidateResourceId(id);
            return new ServiceFabricManagedApplicationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceFabricManagedServiceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceFabricManagedServiceResource.CreateResourceIdentifier" /> to create a <see cref="ServiceFabricManagedServiceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceFabricManagedServiceResource"/> object. </returns>
        public virtual ServiceFabricManagedServiceResource GetServiceFabricManagedServiceResource(ResourceIdentifier id)
        {
            ServiceFabricManagedServiceResource.ValidateResourceId(id);
            return new ServiceFabricManagedServiceResource(Client, id);
        }
    }
}
