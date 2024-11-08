// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A class representing a collection of <see cref="PublisherResource"/> and their operations.
    /// Each <see cref="PublisherResource"/> in the collection will belong to the same instance of <see cref="HciClusterResource"/>.
    /// To get a <see cref="PublisherCollection"/> instance call the GetPublishers method from an instance of <see cref="HciClusterResource"/>.
    /// </summary>
    [Obsolete("This class is now deprecated. Please use the new class `HciClusterPublisherCollection` moving forward.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class PublisherCollection : ArmCollection, IEnumerable<PublisherResource>, IAsyncEnumerable<PublisherResource>
    {
        private readonly ClientDiagnostics _publisherClientDiagnostics;
        private readonly PublishersRestOperations _publisherRestClient;

        /// <summary> Initializes a new instance of the <see cref="PublisherCollection"/> class for mocking. </summary>
        protected PublisherCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PublisherCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PublisherCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _publisherClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Hci", PublisherResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PublisherResource.ResourceType, out string publisherApiVersion);
            _publisherRestClient = new PublishersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, publisherApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HciClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HciClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get Publisher resource details of HCI Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/publishers/{publisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublisherResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherName"> The name of the publisher available within HCI cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> is null. </exception>
        public virtual async Task<Response<PublisherResource>> GetAsync(string publisherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publisherName, nameof(publisherName));

            using var scope = _publisherClientDiagnostics.CreateScope("PublisherCollection.Get");
            scope.Start();
            try
            {
                var response = await _publisherRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publisherName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PublisherResource(Client, new PublisherData(response.Value)), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Publisher resource details of HCI Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/publishers/{publisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublisherResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherName"> The name of the publisher available within HCI cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> is null. </exception>
        public virtual Response<PublisherResource> Get(string publisherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publisherName, nameof(publisherName));

            using var scope = _publisherClientDiagnostics.CreateScope("PublisherCollection.Get");
            scope.Start();
            try
            {
                var response = _publisherRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publisherName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PublisherResource(Client, new PublisherData(response.Value)), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Publishers available for the HCI Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/publishers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_ListByCluster</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublisherResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PublisherResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PublisherResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _publisherRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _publisherRestClient.CreateListByClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PublisherResource(Client, new PublisherData(HciClusterPublisherData.DeserializeHciClusterPublisherData(e))), _publisherClientDiagnostics, Pipeline, "PublisherCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Publishers available for the HCI Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/publishers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_ListByCluster</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublisherResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PublisherResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PublisherResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _publisherRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _publisherRestClient.CreateListByClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PublisherResource(Client, new PublisherData(HciClusterPublisherData.DeserializeHciClusterPublisherData(e))), _publisherClientDiagnostics, Pipeline, "PublisherCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/publishers/{publisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublisherResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherName"> The name of the publisher available within HCI cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string publisherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publisherName, nameof(publisherName));

            using var scope = _publisherClientDiagnostics.CreateScope("PublisherCollection.Exists");
            scope.Start();
            try
            {
                var response = await _publisherRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publisherName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/publishers/{publisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublisherResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherName"> The name of the publisher available within HCI cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> is null. </exception>
        public virtual Response<bool> Exists(string publisherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publisherName, nameof(publisherName));

            using var scope = _publisherClientDiagnostics.CreateScope("PublisherCollection.Exists");
            scope.Start();
            try
            {
                var response = _publisherRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publisherName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/publishers/{publisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublisherResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherName"> The name of the publisher available within HCI cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> is null. </exception>
        public virtual async Task<NullableResponse<PublisherResource>> GetIfExistsAsync(string publisherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publisherName, nameof(publisherName));

            using var scope = _publisherClientDiagnostics.CreateScope("PublisherCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _publisherRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publisherName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PublisherResource>(response.GetRawResponse());
                return Response.FromValue(new PublisherResource(Client, new PublisherData(response.Value)), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/publishers/{publisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublisherResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherName"> The name of the publisher available within HCI cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> is null. </exception>
        public virtual NullableResponse<PublisherResource> GetIfExists(string publisherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publisherName, nameof(publisherName));

            using var scope = _publisherClientDiagnostics.CreateScope("PublisherCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _publisherRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publisherName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PublisherResource>(response.GetRawResponse());
                return Response.FromValue(new PublisherResource(Client, new PublisherData(response.Value)), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PublisherResource> IEnumerable<PublisherResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PublisherResource> IAsyncEnumerable<PublisherResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
