// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableDevTestLabsResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableDevTestLabsResourceGroupResource"/> class for mocking. </summary>
        protected MockableDevTestLabsResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDevTestLabsResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDevTestLabsResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DevTestLabResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DevTestLabResources and their operations over a DevTestLabResource. </returns>
        public virtual DevTestLabCollection GetDevTestLabs()
        {
            return GetCachedClient(client => new DevTestLabCollection(client, Id));
        }

        /// <summary>
        /// Get lab.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the lab. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=defaultStorageAccount)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DevTestLabResource>> GetDevTestLabAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetDevTestLabs().GetAsync(name, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get lab.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the lab. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=defaultStorageAccount)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DevTestLabResource> GetDevTestLab(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetDevTestLabs().Get(name, expand, cancellationToken);
        }

        /// <summary> Gets a collection of DevTestLabGlobalScheduleResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DevTestLabGlobalScheduleResources and their operations over a DevTestLabGlobalScheduleResource. </returns>
        public virtual DevTestLabGlobalScheduleCollection GetDevTestLabGlobalSchedules()
        {
            return GetCachedClient(client => new DevTestLabGlobalScheduleCollection(client, Id));
        }

        /// <summary>
        /// Get schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabGlobalScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DevTestLabGlobalScheduleResource>> GetDevTestLabGlobalScheduleAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetDevTestLabGlobalSchedules().GetAsync(name, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabGlobalScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DevTestLabGlobalScheduleResource> GetDevTestLabGlobalSchedule(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetDevTestLabGlobalSchedules().Get(name, expand, cancellationToken);
        }
    }
}
