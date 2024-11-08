// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Relay.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableRelayResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableRelayResourceGroupResource"/> class for mocking. </summary>
        protected MockableRelayResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableRelayResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableRelayResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of RelayNamespaceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of RelayNamespaceResources and their operations over a RelayNamespaceResource. </returns>
        public virtual RelayNamespaceCollection GetRelayNamespaces()
        {
            return GetCachedClient(client => new RelayNamespaceCollection(client, Id));
        }

        /// <summary>
        /// Returns the description for the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RelayNamespaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<RelayNamespaceResource>> GetRelayNamespaceAsync(string namespaceName, CancellationToken cancellationToken = default)
        {
            return await GetRelayNamespaces().GetAsync(namespaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the description for the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RelayNamespaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<RelayNamespaceResource> GetRelayNamespace(string namespaceName, CancellationToken cancellationToken = default)
        {
            return GetRelayNamespaces().Get(namespaceName, cancellationToken);
        }
    }
}
