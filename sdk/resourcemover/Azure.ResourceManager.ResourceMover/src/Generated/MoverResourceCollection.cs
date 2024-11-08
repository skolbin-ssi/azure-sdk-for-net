// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ResourceMover
{
    /// <summary>
    /// A class representing a collection of <see cref="MoverResource"/> and their operations.
    /// Each <see cref="MoverResource"/> in the collection will belong to the same instance of <see cref="MoverResourceSetResource"/>.
    /// To get a <see cref="MoverResourceCollection"/> instance call the GetMoverResources method from an instance of <see cref="MoverResourceSetResource"/>.
    /// </summary>
    public partial class MoverResourceCollection : ArmCollection, IEnumerable<MoverResource>, IAsyncEnumerable<MoverResource>
    {
        private readonly ClientDiagnostics _moverResourceMoveResourcesClientDiagnostics;
        private readonly MoveResourcesRestOperations _moverResourceMoveResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MoverResourceCollection"/> class for mocking. </summary>
        protected MoverResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MoverResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MoverResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _moverResourceMoveResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ResourceMover", MoverResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MoverResource.ResourceType, out string moverResourceMoveResourcesApiVersion);
            _moverResourceMoveResourcesRestClient = new MoveResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, moverResourceMoveResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MoverResourceSetResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MoverResourceSetResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a Move Resource in the move collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}/moveResources/{moveResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveResources_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MoverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="moverResourceName"> The Move Resource Name. </param>
        /// <param name="data"> The <see cref="MoverResourceData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MoverResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string moverResourceName, MoverResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moverResourceName, nameof(moverResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _moverResourceMoveResourcesClientDiagnostics.CreateScope("MoverResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _moverResourceMoveResourcesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moverResourceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ResourceMoverArmOperation<MoverResource>(new MoverResourceOperationSource(Client), _moverResourceMoveResourcesClientDiagnostics, Pipeline, _moverResourceMoveResourcesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moverResourceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a Move Resource in the move collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}/moveResources/{moveResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveResources_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MoverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="moverResourceName"> The Move Resource Name. </param>
        /// <param name="data"> The <see cref="MoverResourceData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MoverResource> CreateOrUpdate(WaitUntil waitUntil, string moverResourceName, MoverResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moverResourceName, nameof(moverResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _moverResourceMoveResourcesClientDiagnostics.CreateScope("MoverResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _moverResourceMoveResourcesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moverResourceName, data, cancellationToken);
                var operation = new ResourceMoverArmOperation<MoverResource>(new MoverResourceOperationSource(Client), _moverResourceMoveResourcesClientDiagnostics, Pipeline, _moverResourceMoveResourcesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moverResourceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the Move Resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}/moveResources/{moveResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MoverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moverResourceName"> The Move Resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceName"/> is null. </exception>
        public virtual async Task<Response<MoverResource>> GetAsync(string moverResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moverResourceName, nameof(moverResourceName));

            using var scope = _moverResourceMoveResourcesClientDiagnostics.CreateScope("MoverResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _moverResourceMoveResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moverResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MoverResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Move Resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}/moveResources/{moveResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MoverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moverResourceName"> The Move Resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceName"/> is null. </exception>
        public virtual Response<MoverResource> Get(string moverResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moverResourceName, nameof(moverResourceName));

            using var scope = _moverResourceMoveResourcesClientDiagnostics.CreateScope("MoverResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _moverResourceMoveResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moverResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MoverResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Move Resources in the move collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}/moveResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveResources_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MoverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For example, you can use $filter=Properties/ProvisioningState eq 'Succeeded'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MoverResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MoverResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _moverResourceMoveResourcesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _moverResourceMoveResourcesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MoverResource(Client, MoverResourceData.DeserializeMoverResourceData(e)), _moverResourceMoveResourcesClientDiagnostics, Pipeline, "MoverResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the Move Resources in the move collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}/moveResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveResources_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MoverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For example, you can use $filter=Properties/ProvisioningState eq 'Succeeded'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MoverResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MoverResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _moverResourceMoveResourcesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _moverResourceMoveResourcesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MoverResource(Client, MoverResourceData.DeserializeMoverResourceData(e)), _moverResourceMoveResourcesClientDiagnostics, Pipeline, "MoverResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}/moveResources/{moveResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MoverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moverResourceName"> The Move Resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string moverResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moverResourceName, nameof(moverResourceName));

            using var scope = _moverResourceMoveResourcesClientDiagnostics.CreateScope("MoverResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _moverResourceMoveResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moverResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}/moveResources/{moveResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MoverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moverResourceName"> The Move Resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string moverResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moverResourceName, nameof(moverResourceName));

            using var scope = _moverResourceMoveResourcesClientDiagnostics.CreateScope("MoverResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _moverResourceMoveResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moverResourceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}/moveResources/{moveResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MoverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moverResourceName"> The Move Resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<MoverResource>> GetIfExistsAsync(string moverResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moverResourceName, nameof(moverResourceName));

            using var scope = _moverResourceMoveResourcesClientDiagnostics.CreateScope("MoverResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _moverResourceMoveResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moverResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MoverResource>(response.GetRawResponse());
                return Response.FromValue(new MoverResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}/moveResources/{moveResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MoverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moverResourceName"> The Move Resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceName"/> is null. </exception>
        public virtual NullableResponse<MoverResource> GetIfExists(string moverResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moverResourceName, nameof(moverResourceName));

            using var scope = _moverResourceMoveResourcesClientDiagnostics.CreateScope("MoverResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _moverResourceMoveResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moverResourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MoverResource>(response.GetRawResponse());
                return Response.FromValue(new MoverResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MoverResource> IEnumerable<MoverResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MoverResource> IAsyncEnumerable<MoverResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
