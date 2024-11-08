// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Kubernetes.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Kubernetes
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Kubernetes. </summary>
    public static partial class KubernetesExtensions
    {
        private static MockableKubernetesArmClient GetMockableKubernetesArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableKubernetesArmClient(client0));
        }

        private static MockableKubernetesResourceGroupResource GetMockableKubernetesResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableKubernetesResourceGroupResource(client, resource.Id));
        }

        private static MockableKubernetesSubscriptionResource GetMockableKubernetesSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableKubernetesSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="ConnectedClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConnectedClusterResource.CreateResourceIdentifier" /> to create a <see cref="ConnectedClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableKubernetesArmClient.GetConnectedClusterResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ConnectedClusterResource"/> object. </returns>
        public static ConnectedClusterResource GetConnectedClusterResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableKubernetesArmClient(client).GetConnectedClusterResource(id);
        }

        /// <summary>
        /// Gets a collection of ConnectedClusterResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableKubernetesResourceGroupResource.GetConnectedClusters()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of ConnectedClusterResources and their operations over a ConnectedClusterResource. </returns>
        public static ConnectedClusterCollection GetConnectedClusters(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableKubernetesResourceGroupResource(resourceGroupResource).GetConnectedClusters();
        }

        /// <summary>
        /// Returns the properties of the specified connected cluster, including name, identity, properties, and additional cluster details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Kubernetes/connectedClusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedCluster_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectedClusterResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableKubernetesResourceGroupResource.GetConnectedClusterAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the Kubernetes cluster on which get is called. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ConnectedClusterResource>> GetConnectedClusterAsync(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableKubernetesResourceGroupResource(resourceGroupResource).GetConnectedClusterAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the properties of the specified connected cluster, including name, identity, properties, and additional cluster details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Kubernetes/connectedClusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedCluster_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectedClusterResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableKubernetesResourceGroupResource.GetConnectedCluster(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the Kubernetes cluster on which get is called. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<ConnectedClusterResource> GetConnectedCluster(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableKubernetesResourceGroupResource(resourceGroupResource).GetConnectedCluster(clusterName, cancellationToken);
        }

        /// <summary>
        /// API to enumerate registered connected K8s clusters under a Subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Kubernetes/connectedClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedCluster_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectedClusterResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableKubernetesSubscriptionResource.GetConnectedClusters(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="ConnectedClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ConnectedClusterResource> GetConnectedClustersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableKubernetesSubscriptionResource(subscriptionResource).GetConnectedClustersAsync(cancellationToken);
        }

        /// <summary>
        /// API to enumerate registered connected K8s clusters under a Subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Kubernetes/connectedClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedCluster_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectedClusterResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableKubernetesSubscriptionResource.GetConnectedClusters(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="ConnectedClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ConnectedClusterResource> GetConnectedClusters(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableKubernetesSubscriptionResource(subscriptionResource).GetConnectedClusters(cancellationToken);
        }
    }
}
