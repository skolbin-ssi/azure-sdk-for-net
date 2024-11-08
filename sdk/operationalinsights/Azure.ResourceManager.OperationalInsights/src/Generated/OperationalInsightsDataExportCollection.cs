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

namespace Azure.ResourceManager.OperationalInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="OperationalInsightsDataExportResource"/> and their operations.
    /// Each <see cref="OperationalInsightsDataExportResource"/> in the collection will belong to the same instance of <see cref="OperationalInsightsWorkspaceResource"/>.
    /// To get an <see cref="OperationalInsightsDataExportCollection"/> instance call the GetOperationalInsightsDataExports method from an instance of <see cref="OperationalInsightsWorkspaceResource"/>.
    /// </summary>
    public partial class OperationalInsightsDataExportCollection : ArmCollection, IEnumerable<OperationalInsightsDataExportResource>, IAsyncEnumerable<OperationalInsightsDataExportResource>
    {
        private readonly ClientDiagnostics _operationalInsightsDataExportDataExportsClientDiagnostics;
        private readonly DataExportsRestOperations _operationalInsightsDataExportDataExportsRestClient;

        /// <summary> Initializes a new instance of the <see cref="OperationalInsightsDataExportCollection"/> class for mocking. </summary>
        protected OperationalInsightsDataExportCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OperationalInsightsDataExportCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal OperationalInsightsDataExportCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _operationalInsightsDataExportDataExportsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.OperationalInsights", OperationalInsightsDataExportResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(OperationalInsightsDataExportResource.ResourceType, out string operationalInsightsDataExportDataExportsApiVersion);
            _operationalInsightsDataExportDataExportsRestClient = new DataExportsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, operationalInsightsDataExportDataExportsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != OperationalInsightsWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, OperationalInsightsWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a data export.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/dataExports/{dataExportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataExports_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OperationalInsightsDataExportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataExportName"> The data export rule name. </param>
        /// <param name="data"> The parameters required to create or update a data export. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataExportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataExportName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<OperationalInsightsDataExportResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dataExportName, OperationalInsightsDataExportData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataExportName, nameof(dataExportName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _operationalInsightsDataExportDataExportsClientDiagnostics.CreateScope("OperationalInsightsDataExportCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _operationalInsightsDataExportDataExportsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataExportName, data, cancellationToken).ConfigureAwait(false);
                var uri = _operationalInsightsDataExportDataExportsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataExportName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new OperationalInsightsArmOperation<OperationalInsightsDataExportResource>(Response.FromValue(new OperationalInsightsDataExportResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create or update a data export.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/dataExports/{dataExportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataExports_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OperationalInsightsDataExportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataExportName"> The data export rule name. </param>
        /// <param name="data"> The parameters required to create or update a data export. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataExportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataExportName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<OperationalInsightsDataExportResource> CreateOrUpdate(WaitUntil waitUntil, string dataExportName, OperationalInsightsDataExportData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataExportName, nameof(dataExportName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _operationalInsightsDataExportDataExportsClientDiagnostics.CreateScope("OperationalInsightsDataExportCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _operationalInsightsDataExportDataExportsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataExportName, data, cancellationToken);
                var uri = _operationalInsightsDataExportDataExportsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataExportName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new OperationalInsightsArmOperation<OperationalInsightsDataExportResource>(Response.FromValue(new OperationalInsightsDataExportResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets a data export instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/dataExports/{dataExportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataExports_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OperationalInsightsDataExportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataExportName"> The data export rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataExportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataExportName"/> is null. </exception>
        public virtual async Task<Response<OperationalInsightsDataExportResource>> GetAsync(string dataExportName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataExportName, nameof(dataExportName));

            using var scope = _operationalInsightsDataExportDataExportsClientDiagnostics.CreateScope("OperationalInsightsDataExportCollection.Get");
            scope.Start();
            try
            {
                var response = await _operationalInsightsDataExportDataExportsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataExportName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OperationalInsightsDataExportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a data export instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/dataExports/{dataExportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataExports_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OperationalInsightsDataExportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataExportName"> The data export rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataExportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataExportName"/> is null. </exception>
        public virtual Response<OperationalInsightsDataExportResource> Get(string dataExportName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataExportName, nameof(dataExportName));

            using var scope = _operationalInsightsDataExportDataExportsClientDiagnostics.CreateScope("OperationalInsightsDataExportCollection.Get");
            scope.Start();
            try
            {
                var response = _operationalInsightsDataExportDataExportsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataExportName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OperationalInsightsDataExportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the data export instances within a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/dataExports</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataExports_ListByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OperationalInsightsDataExportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OperationalInsightsDataExportResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OperationalInsightsDataExportResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _operationalInsightsDataExportDataExportsRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new OperationalInsightsDataExportResource(Client, OperationalInsightsDataExportData.DeserializeOperationalInsightsDataExportData(e)), _operationalInsightsDataExportDataExportsClientDiagnostics, Pipeline, "OperationalInsightsDataExportCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists the data export instances within a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/dataExports</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataExports_ListByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OperationalInsightsDataExportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OperationalInsightsDataExportResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OperationalInsightsDataExportResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _operationalInsightsDataExportDataExportsRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new OperationalInsightsDataExportResource(Client, OperationalInsightsDataExportData.DeserializeOperationalInsightsDataExportData(e)), _operationalInsightsDataExportDataExportsClientDiagnostics, Pipeline, "OperationalInsightsDataExportCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/dataExports/{dataExportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataExports_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OperationalInsightsDataExportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataExportName"> The data export rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataExportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataExportName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dataExportName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataExportName, nameof(dataExportName));

            using var scope = _operationalInsightsDataExportDataExportsClientDiagnostics.CreateScope("OperationalInsightsDataExportCollection.Exists");
            scope.Start();
            try
            {
                var response = await _operationalInsightsDataExportDataExportsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataExportName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/dataExports/{dataExportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataExports_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OperationalInsightsDataExportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataExportName"> The data export rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataExportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataExportName"/> is null. </exception>
        public virtual Response<bool> Exists(string dataExportName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataExportName, nameof(dataExportName));

            using var scope = _operationalInsightsDataExportDataExportsClientDiagnostics.CreateScope("OperationalInsightsDataExportCollection.Exists");
            scope.Start();
            try
            {
                var response = _operationalInsightsDataExportDataExportsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataExportName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/dataExports/{dataExportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataExports_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OperationalInsightsDataExportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataExportName"> The data export rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataExportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataExportName"/> is null. </exception>
        public virtual async Task<NullableResponse<OperationalInsightsDataExportResource>> GetIfExistsAsync(string dataExportName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataExportName, nameof(dataExportName));

            using var scope = _operationalInsightsDataExportDataExportsClientDiagnostics.CreateScope("OperationalInsightsDataExportCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _operationalInsightsDataExportDataExportsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataExportName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<OperationalInsightsDataExportResource>(response.GetRawResponse());
                return Response.FromValue(new OperationalInsightsDataExportResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/dataExports/{dataExportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataExports_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OperationalInsightsDataExportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataExportName"> The data export rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataExportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataExportName"/> is null. </exception>
        public virtual NullableResponse<OperationalInsightsDataExportResource> GetIfExists(string dataExportName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataExportName, nameof(dataExportName));

            using var scope = _operationalInsightsDataExportDataExportsClientDiagnostics.CreateScope("OperationalInsightsDataExportCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _operationalInsightsDataExportDataExportsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataExportName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<OperationalInsightsDataExportResource>(response.GetRawResponse());
                return Response.FromValue(new OperationalInsightsDataExportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<OperationalInsightsDataExportResource> IEnumerable<OperationalInsightsDataExportResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<OperationalInsightsDataExportResource> IAsyncEnumerable<OperationalInsightsDataExportResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
