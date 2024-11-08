// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ComputeFleet.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableComputeFleetSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _computeFleetFleetsClientDiagnostics;
        private FleetsRestOperations _computeFleetFleetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableComputeFleetSubscriptionResource"/> class for mocking. </summary>
        protected MockableComputeFleetSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableComputeFleetSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableComputeFleetSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ComputeFleetFleetsClientDiagnostics => _computeFleetFleetsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ComputeFleet", ComputeFleetResource.ResourceType.Namespace, Diagnostics);
        private FleetsRestOperations ComputeFleetFleetsRestClient => _computeFleetFleetsRestClient ??= new FleetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ComputeFleetResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List Fleet resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureFleet/fleets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleet_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ComputeFleetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ComputeFleetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ComputeFleetResource> GetComputeFleetsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ComputeFleetFleetsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ComputeFleetFleetsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ComputeFleetResource(Client, ComputeFleetData.DeserializeComputeFleetData(e)), ComputeFleetFleetsClientDiagnostics, Pipeline, "MockableComputeFleetSubscriptionResource.GetComputeFleets", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Fleet resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureFleet/fleets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleet_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ComputeFleetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ComputeFleetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ComputeFleetResource> GetComputeFleets(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ComputeFleetFleetsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ComputeFleetFleetsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ComputeFleetResource(Client, ComputeFleetData.DeserializeComputeFleetData(e)), ComputeFleetFleetsClientDiagnostics, Pipeline, "MockableComputeFleetSubscriptionResource.GetComputeFleets", "value", "nextLink", cancellationToken);
        }
    }
}
