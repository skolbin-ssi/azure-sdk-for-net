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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ScVmm
{
    /// <summary>
    /// A class representing a collection of <see cref="ScVmmCloudResource"/> and their operations.
    /// Each <see cref="ScVmmCloudResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="ScVmmCloudCollection"/> instance call the GetScVmmClouds method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class ScVmmCloudCollection : ArmCollection, IEnumerable<ScVmmCloudResource>, IAsyncEnumerable<ScVmmCloudResource>
    {
        private readonly ClientDiagnostics _scVmmCloudCloudsClientDiagnostics;
        private readonly CloudsRestOperations _scVmmCloudCloudsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ScVmmCloudCollection"/> class for mocking. </summary>
        protected ScVmmCloudCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScVmmCloudCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ScVmmCloudCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scVmmCloudCloudsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ScVmm", ScVmmCloudResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ScVmmCloudResource.ResourceType, out string scVmmCloudCloudsApiVersion);
            _scVmmCloudCloudsRestClient = new CloudsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scVmmCloudCloudsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Onboards the ScVmm fabric cloud as an Azure cloud resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/clouds/{cloudResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clouds_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-07</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmCloudResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cloudResourceName"> Name of the Cloud. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ScVmmCloudResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string cloudResourceName, ScVmmCloudData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudResourceName, nameof(cloudResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scVmmCloudCloudsClientDiagnostics.CreateScope("ScVmmCloudCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _scVmmCloudCloudsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudResourceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ScVmmArmOperation<ScVmmCloudResource>(new ScVmmCloudOperationSource(Client), _scVmmCloudCloudsClientDiagnostics, Pipeline, _scVmmCloudCloudsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, cloudResourceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Onboards the ScVmm fabric cloud as an Azure cloud resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/clouds/{cloudResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clouds_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-07</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmCloudResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cloudResourceName"> Name of the Cloud. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ScVmmCloudResource> CreateOrUpdate(WaitUntil waitUntil, string cloudResourceName, ScVmmCloudData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudResourceName, nameof(cloudResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scVmmCloudCloudsClientDiagnostics.CreateScope("ScVmmCloudCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _scVmmCloudCloudsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, cloudResourceName, data, cancellationToken);
                var operation = new ScVmmArmOperation<ScVmmCloudResource>(new ScVmmCloudOperationSource(Client), _scVmmCloudCloudsClientDiagnostics, Pipeline, _scVmmCloudCloudsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, cloudResourceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Implements Cloud GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/clouds/{cloudResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clouds_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-07</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmCloudResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudResourceName"> Name of the Cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudResourceName"/> is null. </exception>
        public virtual async Task<Response<ScVmmCloudResource>> GetAsync(string cloudResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudResourceName, nameof(cloudResourceName));

            using var scope = _scVmmCloudCloudsClientDiagnostics.CreateScope("ScVmmCloudCollection.Get");
            scope.Start();
            try
            {
                var response = await _scVmmCloudCloudsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScVmmCloudResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements Cloud GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/clouds/{cloudResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clouds_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-07</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmCloudResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudResourceName"> Name of the Cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudResourceName"/> is null. </exception>
        public virtual Response<ScVmmCloudResource> Get(string cloudResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudResourceName, nameof(cloudResourceName));

            using var scope = _scVmmCloudCloudsClientDiagnostics.CreateScope("ScVmmCloudCollection.Get");
            scope.Start();
            try
            {
                var response = _scVmmCloudCloudsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cloudResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScVmmCloudResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of Clouds in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/clouds</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clouds_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-07</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmCloudResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScVmmCloudResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScVmmCloudResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scVmmCloudCloudsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scVmmCloudCloudsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ScVmmCloudResource(Client, ScVmmCloudData.DeserializeScVmmCloudData(e)), _scVmmCloudCloudsClientDiagnostics, Pipeline, "ScVmmCloudCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of Clouds in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/clouds</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clouds_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-07</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmCloudResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScVmmCloudResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScVmmCloudResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scVmmCloudCloudsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scVmmCloudCloudsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ScVmmCloudResource(Client, ScVmmCloudData.DeserializeScVmmCloudData(e)), _scVmmCloudCloudsClientDiagnostics, Pipeline, "ScVmmCloudCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/clouds/{cloudResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clouds_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-07</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmCloudResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudResourceName"> Name of the Cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string cloudResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudResourceName, nameof(cloudResourceName));

            using var scope = _scVmmCloudCloudsClientDiagnostics.CreateScope("ScVmmCloudCollection.Exists");
            scope.Start();
            try
            {
                var response = await _scVmmCloudCloudsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/clouds/{cloudResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clouds_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-07</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmCloudResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudResourceName"> Name of the Cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string cloudResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudResourceName, nameof(cloudResourceName));

            using var scope = _scVmmCloudCloudsClientDiagnostics.CreateScope("ScVmmCloudCollection.Exists");
            scope.Start();
            try
            {
                var response = _scVmmCloudCloudsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cloudResourceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/clouds/{cloudResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clouds_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-07</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmCloudResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudResourceName"> Name of the Cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudResourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<ScVmmCloudResource>> GetIfExistsAsync(string cloudResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudResourceName, nameof(cloudResourceName));

            using var scope = _scVmmCloudCloudsClientDiagnostics.CreateScope("ScVmmCloudCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _scVmmCloudCloudsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ScVmmCloudResource>(response.GetRawResponse());
                return Response.FromValue(new ScVmmCloudResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/clouds/{cloudResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clouds_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-07</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmCloudResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudResourceName"> Name of the Cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudResourceName"/> is null. </exception>
        public virtual NullableResponse<ScVmmCloudResource> GetIfExists(string cloudResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudResourceName, nameof(cloudResourceName));

            using var scope = _scVmmCloudCloudsClientDiagnostics.CreateScope("ScVmmCloudCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _scVmmCloudCloudsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cloudResourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ScVmmCloudResource>(response.GetRawResponse());
                return Response.FromValue(new ScVmmCloudResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ScVmmCloudResource> IEnumerable<ScVmmCloudResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ScVmmCloudResource> IAsyncEnumerable<ScVmmCloudResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
