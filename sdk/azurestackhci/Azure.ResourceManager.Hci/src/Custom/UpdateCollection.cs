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
    /// A class representing a collection of <see cref="UpdateResource"/> and their operations.
    /// Each <see cref="UpdateResource"/> in the collection will belong to the same instance of <see cref="HciClusterResource"/>.
    /// To get an <see cref="UpdateCollection"/> instance call the GetUpdates method from an instance of <see cref="HciClusterResource"/>.
    /// </summary>
    [Obsolete("This class is now deprecated. Please use the new class `HciClusterUpdateCollection` moving forward.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class UpdateCollection : ArmCollection, IEnumerable<UpdateResource>, IAsyncEnumerable<UpdateResource>
    {
        private readonly ClientDiagnostics _updateClientDiagnostics;
        private readonly UpdatesRestOperations _updateRestClient;

        /// <summary> Initializes a new instance of the <see cref="UpdateCollection"/> class for mocking. </summary>
        protected UpdateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="UpdateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal UpdateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _updateClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Hci", UpdateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(UpdateResource.ResourceType, out string updateApiVersion);
            _updateRestClient = new UpdatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, updateApiVersion);
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
        /// Put specified Update
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/updates/{updateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Updates_Put</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UpdateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="updateName"> The name of the Update. </param>
        /// <param name="data"> Properties of the Updates object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<UpdateResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string updateName, UpdateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateName, nameof(updateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _updateClientDiagnostics.CreateScope("UpdateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _updateRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateName, data.ToHciClusterUpdateData(), cancellationToken).ConfigureAwait(false);
                var uri = _updateRestClient.CreatePutRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateName, data.ToHciClusterUpdateData());
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new HciArmOperation<UpdateResource>(Response.FromValue(new UpdateResource(Client, new UpdateData(response.Value)), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Put specified Update
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/updates/{updateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Updates_Put</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UpdateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="updateName"> The name of the Update. </param>
        /// <param name="data"> Properties of the Updates object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<UpdateResource> CreateOrUpdate(WaitUntil waitUntil, string updateName, UpdateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateName, nameof(updateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _updateClientDiagnostics.CreateScope("UpdateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _updateRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateName, data.ToHciClusterUpdateData(), cancellationToken);
                var uri = _updateRestClient.CreatePutRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateName, data.ToHciClusterUpdateData());
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new HciArmOperation<UpdateResource>(Response.FromValue(new UpdateResource(Client, new UpdateData(response.Value)), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get specified Update
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/updates/{updateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Updates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UpdateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateName"> The name of the Update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateName"/> is null. </exception>
        public virtual async Task<Response<UpdateResource>> GetAsync(string updateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateName, nameof(updateName));

            using var scope = _updateClientDiagnostics.CreateScope("UpdateCollection.Get");
            scope.Start();
            try
            {
                var response = await _updateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new UpdateResource(Client, new UpdateData(response.Value)), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get specified Update
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/updates/{updateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Updates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UpdateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateName"> The name of the Update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateName"/> is null. </exception>
        public virtual Response<UpdateResource> Get(string updateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateName, nameof(updateName));

            using var scope = _updateClientDiagnostics.CreateScope("UpdateCollection.Get");
            scope.Start();
            try
            {
                var response = _updateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new UpdateResource(Client, new UpdateData(response.Value)), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all Updates
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/updates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Updates_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UpdateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="UpdateResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<UpdateResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _updateRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _updateRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new UpdateResource(Client, new UpdateData(HciClusterUpdateData.DeserializeHciClusterUpdateData(e))), _updateClientDiagnostics, Pipeline, "UpdateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all Updates
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/updates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Updates_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UpdateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="UpdateResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<UpdateResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _updateRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _updateRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new UpdateResource(Client, new UpdateData(HciClusterUpdateData.DeserializeHciClusterUpdateData(e))), _updateClientDiagnostics, Pipeline, "UpdateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/updates/{updateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Updates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UpdateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateName"> The name of the Update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string updateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateName, nameof(updateName));

            using var scope = _updateClientDiagnostics.CreateScope("UpdateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _updateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/updates/{updateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Updates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UpdateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateName"> The name of the Update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateName"/> is null. </exception>
        public virtual Response<bool> Exists(string updateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateName, nameof(updateName));

            using var scope = _updateClientDiagnostics.CreateScope("UpdateCollection.Exists");
            scope.Start();
            try
            {
                var response = _updateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/updates/{updateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Updates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UpdateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateName"> The name of the Update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateName"/> is null. </exception>
        public virtual async Task<NullableResponse<UpdateResource>> GetIfExistsAsync(string updateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateName, nameof(updateName));

            using var scope = _updateClientDiagnostics.CreateScope("UpdateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _updateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<UpdateResource>(response.GetRawResponse());
                return Response.FromValue(new UpdateResource(Client, new UpdateData(response.Value)), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/updates/{updateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Updates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UpdateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateName"> The name of the Update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateName"/> is null. </exception>
        public virtual NullableResponse<UpdateResource> GetIfExists(string updateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateName, nameof(updateName));

            using var scope = _updateClientDiagnostics.CreateScope("UpdateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _updateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<UpdateResource>(response.GetRawResponse());
                return Response.FromValue(new UpdateResource(Client, new UpdateData(response.Value)), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<UpdateResource> IEnumerable<UpdateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<UpdateResource> IAsyncEnumerable<UpdateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
