// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableHDInsightContainersResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableHDInsightContainersResourceGroupResource"/> class for mocking. </summary>
        protected MockableHDInsightContainersResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableHDInsightContainersResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableHDInsightContainersResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of HDInsightClusterPoolResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of HDInsightClusterPoolResources and their operations over a HDInsightClusterPoolResource. </returns>
        public virtual HDInsightClusterPoolCollection GetHDInsightClusterPools()
        {
            return GetCachedClient(client => new HDInsightClusterPoolCollection(client, Id));
        }

        /// <summary>
        /// Gets a cluster pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusterpools/{clusterPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HDInsightClusterPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterPoolName"> The name of the cluster pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<HDInsightClusterPoolResource>> GetHDInsightClusterPoolAsync(string clusterPoolName, CancellationToken cancellationToken = default)
        {
            return await GetHDInsightClusterPools().GetAsync(clusterPoolName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a cluster pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusterpools/{clusterPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HDInsightClusterPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterPoolName"> The name of the cluster pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<HDInsightClusterPoolResource> GetHDInsightClusterPool(string clusterPoolName, CancellationToken cancellationToken = default)
        {
            return GetHDInsightClusterPools().Get(clusterPoolName, cancellationToken);
        }
    }
}
