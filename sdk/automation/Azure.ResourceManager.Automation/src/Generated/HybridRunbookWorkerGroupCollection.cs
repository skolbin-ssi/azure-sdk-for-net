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
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing a collection of <see cref="HybridRunbookWorkerGroupResource"/> and their operations.
    /// Each <see cref="HybridRunbookWorkerGroupResource"/> in the collection will belong to the same instance of <see cref="AutomationAccountResource"/>.
    /// To get a <see cref="HybridRunbookWorkerGroupCollection"/> instance call the GetHybridRunbookWorkerGroups method from an instance of <see cref="AutomationAccountResource"/>.
    /// </summary>
    public partial class HybridRunbookWorkerGroupCollection : ArmCollection, IEnumerable<HybridRunbookWorkerGroupResource>, IAsyncEnumerable<HybridRunbookWorkerGroupResource>
    {
        private readonly ClientDiagnostics _hybridRunbookWorkerGroupClientDiagnostics;
        private readonly HybridRunbookWorkerGroupRestOperations _hybridRunbookWorkerGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="HybridRunbookWorkerGroupCollection"/> class for mocking. </summary>
        protected HybridRunbookWorkerGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HybridRunbookWorkerGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HybridRunbookWorkerGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hybridRunbookWorkerGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", HybridRunbookWorkerGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HybridRunbookWorkerGroupResource.ResourceType, out string hybridRunbookWorkerGroupApiVersion);
            _hybridRunbookWorkerGroupRestClient = new HybridRunbookWorkerGroupRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hybridRunbookWorkerGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AutomationAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AutomationAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a hybrid runbook worker group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkerGroup_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridRunbookWorkerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hybridRunbookWorkerGroupName"> The hybrid runbook worker group name. </param>
        /// <param name="content"> The create or update parameters for hybrid runbook worker group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridRunbookWorkerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridRunbookWorkerGroupName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<HybridRunbookWorkerGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string hybridRunbookWorkerGroupName, HybridRunbookWorkerGroupCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridRunbookWorkerGroupName, nameof(hybridRunbookWorkerGroupName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _hybridRunbookWorkerGroupClientDiagnostics.CreateScope("HybridRunbookWorkerGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hybridRunbookWorkerGroupRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridRunbookWorkerGroupName, content, cancellationToken).ConfigureAwait(false);
                var uri = _hybridRunbookWorkerGroupRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridRunbookWorkerGroupName, content);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AutomationArmOperation<HybridRunbookWorkerGroupResource>(Response.FromValue(new HybridRunbookWorkerGroupResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create a hybrid runbook worker group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkerGroup_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridRunbookWorkerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hybridRunbookWorkerGroupName"> The hybrid runbook worker group name. </param>
        /// <param name="content"> The create or update parameters for hybrid runbook worker group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridRunbookWorkerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridRunbookWorkerGroupName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<HybridRunbookWorkerGroupResource> CreateOrUpdate(WaitUntil waitUntil, string hybridRunbookWorkerGroupName, HybridRunbookWorkerGroupCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridRunbookWorkerGroupName, nameof(hybridRunbookWorkerGroupName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _hybridRunbookWorkerGroupClientDiagnostics.CreateScope("HybridRunbookWorkerGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hybridRunbookWorkerGroupRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridRunbookWorkerGroupName, content, cancellationToken);
                var uri = _hybridRunbookWorkerGroupRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridRunbookWorkerGroupName, content);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AutomationArmOperation<HybridRunbookWorkerGroupResource>(Response.FromValue(new HybridRunbookWorkerGroupResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Retrieve a hybrid runbook worker group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkerGroup_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridRunbookWorkerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hybridRunbookWorkerGroupName"> The hybrid runbook worker group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridRunbookWorkerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridRunbookWorkerGroupName"/> is null. </exception>
        public virtual async Task<Response<HybridRunbookWorkerGroupResource>> GetAsync(string hybridRunbookWorkerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridRunbookWorkerGroupName, nameof(hybridRunbookWorkerGroupName));

            using var scope = _hybridRunbookWorkerGroupClientDiagnostics.CreateScope("HybridRunbookWorkerGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _hybridRunbookWorkerGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridRunbookWorkerGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridRunbookWorkerGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a hybrid runbook worker group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkerGroup_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridRunbookWorkerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hybridRunbookWorkerGroupName"> The hybrid runbook worker group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridRunbookWorkerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridRunbookWorkerGroupName"/> is null. </exception>
        public virtual Response<HybridRunbookWorkerGroupResource> Get(string hybridRunbookWorkerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridRunbookWorkerGroupName, nameof(hybridRunbookWorkerGroupName));

            using var scope = _hybridRunbookWorkerGroupClientDiagnostics.CreateScope("HybridRunbookWorkerGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _hybridRunbookWorkerGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridRunbookWorkerGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridRunbookWorkerGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of hybrid runbook worker groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkerGroup_ListByAutomationAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridRunbookWorkerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridRunbookWorkerGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HybridRunbookWorkerGroupResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridRunbookWorkerGroupRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hybridRunbookWorkerGroupRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HybridRunbookWorkerGroupResource(Client, HybridRunbookWorkerGroupData.DeserializeHybridRunbookWorkerGroupData(e)), _hybridRunbookWorkerGroupClientDiagnostics, Pipeline, "HybridRunbookWorkerGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of hybrid runbook worker groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkerGroup_ListByAutomationAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridRunbookWorkerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridRunbookWorkerGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HybridRunbookWorkerGroupResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridRunbookWorkerGroupRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hybridRunbookWorkerGroupRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HybridRunbookWorkerGroupResource(Client, HybridRunbookWorkerGroupData.DeserializeHybridRunbookWorkerGroupData(e)), _hybridRunbookWorkerGroupClientDiagnostics, Pipeline, "HybridRunbookWorkerGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkerGroup_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridRunbookWorkerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hybridRunbookWorkerGroupName"> The hybrid runbook worker group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridRunbookWorkerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridRunbookWorkerGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string hybridRunbookWorkerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridRunbookWorkerGroupName, nameof(hybridRunbookWorkerGroupName));

            using var scope = _hybridRunbookWorkerGroupClientDiagnostics.CreateScope("HybridRunbookWorkerGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hybridRunbookWorkerGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridRunbookWorkerGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkerGroup_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridRunbookWorkerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hybridRunbookWorkerGroupName"> The hybrid runbook worker group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridRunbookWorkerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridRunbookWorkerGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string hybridRunbookWorkerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridRunbookWorkerGroupName, nameof(hybridRunbookWorkerGroupName));

            using var scope = _hybridRunbookWorkerGroupClientDiagnostics.CreateScope("HybridRunbookWorkerGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _hybridRunbookWorkerGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridRunbookWorkerGroupName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkerGroup_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridRunbookWorkerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hybridRunbookWorkerGroupName"> The hybrid runbook worker group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridRunbookWorkerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridRunbookWorkerGroupName"/> is null. </exception>
        public virtual async Task<NullableResponse<HybridRunbookWorkerGroupResource>> GetIfExistsAsync(string hybridRunbookWorkerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridRunbookWorkerGroupName, nameof(hybridRunbookWorkerGroupName));

            using var scope = _hybridRunbookWorkerGroupClientDiagnostics.CreateScope("HybridRunbookWorkerGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _hybridRunbookWorkerGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridRunbookWorkerGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<HybridRunbookWorkerGroupResource>(response.GetRawResponse());
                return Response.FromValue(new HybridRunbookWorkerGroupResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkerGroup_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridRunbookWorkerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hybridRunbookWorkerGroupName"> The hybrid runbook worker group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridRunbookWorkerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridRunbookWorkerGroupName"/> is null. </exception>
        public virtual NullableResponse<HybridRunbookWorkerGroupResource> GetIfExists(string hybridRunbookWorkerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridRunbookWorkerGroupName, nameof(hybridRunbookWorkerGroupName));

            using var scope = _hybridRunbookWorkerGroupClientDiagnostics.CreateScope("HybridRunbookWorkerGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _hybridRunbookWorkerGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridRunbookWorkerGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<HybridRunbookWorkerGroupResource>(response.GetRawResponse());
                return Response.FromValue(new HybridRunbookWorkerGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HybridRunbookWorkerGroupResource> IEnumerable<HybridRunbookWorkerGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HybridRunbookWorkerGroupResource> IAsyncEnumerable<HybridRunbookWorkerGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
