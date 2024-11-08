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

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A class representing a collection of <see cref="BillingDepartmentRoleDefinitionResource"/> and their operations.
    /// Each <see cref="BillingDepartmentRoleDefinitionResource"/> in the collection will belong to the same instance of <see cref="BillingDepartmentResource"/>.
    /// To get a <see cref="BillingDepartmentRoleDefinitionCollection"/> instance call the GetBillingDepartmentRoleDefinitions method from an instance of <see cref="BillingDepartmentResource"/>.
    /// </summary>
    public partial class BillingDepartmentRoleDefinitionCollection : ArmCollection, IEnumerable<BillingDepartmentRoleDefinitionResource>, IAsyncEnumerable<BillingDepartmentRoleDefinitionResource>
    {
        private readonly ClientDiagnostics _billingDepartmentRoleDefinitionBillingRoleDefinitionClientDiagnostics;
        private readonly BillingRoleDefinitionRestOperations _billingDepartmentRoleDefinitionBillingRoleDefinitionRestClient;

        /// <summary> Initializes a new instance of the <see cref="BillingDepartmentRoleDefinitionCollection"/> class for mocking. </summary>
        protected BillingDepartmentRoleDefinitionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingDepartmentRoleDefinitionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BillingDepartmentRoleDefinitionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _billingDepartmentRoleDefinitionBillingRoleDefinitionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Billing", BillingDepartmentRoleDefinitionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BillingDepartmentRoleDefinitionResource.ResourceType, out string billingDepartmentRoleDefinitionBillingRoleDefinitionApiVersion);
            _billingDepartmentRoleDefinitionBillingRoleDefinitionRestClient = new BillingRoleDefinitionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingDepartmentRoleDefinitionBillingRoleDefinitionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BillingDepartmentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BillingDepartmentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the definition for a role on a department. The operation is supported for billing accounts with agreement type Enterprise Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/departments/{departmentName}/billingRoleDefinitions/{roleDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingRoleDefinition_GetByDepartment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingDepartmentRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleDefinitionName"> The ID that uniquely identifies a role definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionName"/> is null. </exception>
        public virtual async Task<Response<BillingDepartmentRoleDefinitionResource>> GetAsync(string roleDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleDefinitionName, nameof(roleDefinitionName));

            using var scope = _billingDepartmentRoleDefinitionBillingRoleDefinitionClientDiagnostics.CreateScope("BillingDepartmentRoleDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _billingDepartmentRoleDefinitionBillingRoleDefinitionRestClient.GetByDepartmentAsync(Id.Parent.Name, Id.Name, roleDefinitionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingDepartmentRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the definition for a role on a department. The operation is supported for billing accounts with agreement type Enterprise Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/departments/{departmentName}/billingRoleDefinitions/{roleDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingRoleDefinition_GetByDepartment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingDepartmentRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleDefinitionName"> The ID that uniquely identifies a role definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionName"/> is null. </exception>
        public virtual Response<BillingDepartmentRoleDefinitionResource> Get(string roleDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleDefinitionName, nameof(roleDefinitionName));

            using var scope = _billingDepartmentRoleDefinitionBillingRoleDefinitionClientDiagnostics.CreateScope("BillingDepartmentRoleDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = _billingDepartmentRoleDefinitionBillingRoleDefinitionRestClient.GetByDepartment(Id.Parent.Name, Id.Name, roleDefinitionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingDepartmentRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List the definition for a department. The operation is supported for billing accounts with agreement type Enterprise Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/departments/{departmentName}/billingRoleDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingRoleDefinition_ListByDepartment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingDepartmentRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BillingDepartmentRoleDefinitionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BillingDepartmentRoleDefinitionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingDepartmentRoleDefinitionBillingRoleDefinitionRestClient.CreateListByDepartmentRequest(Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingDepartmentRoleDefinitionBillingRoleDefinitionRestClient.CreateListByDepartmentNextPageRequest(nextLink, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BillingDepartmentRoleDefinitionResource(Client, BillingRoleDefinitionData.DeserializeBillingRoleDefinitionData(e)), _billingDepartmentRoleDefinitionBillingRoleDefinitionClientDiagnostics, Pipeline, "BillingDepartmentRoleDefinitionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List the definition for a department. The operation is supported for billing accounts with agreement type Enterprise Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/departments/{departmentName}/billingRoleDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingRoleDefinition_ListByDepartment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingDepartmentRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BillingDepartmentRoleDefinitionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BillingDepartmentRoleDefinitionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingDepartmentRoleDefinitionBillingRoleDefinitionRestClient.CreateListByDepartmentRequest(Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingDepartmentRoleDefinitionBillingRoleDefinitionRestClient.CreateListByDepartmentNextPageRequest(nextLink, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BillingDepartmentRoleDefinitionResource(Client, BillingRoleDefinitionData.DeserializeBillingRoleDefinitionData(e)), _billingDepartmentRoleDefinitionBillingRoleDefinitionClientDiagnostics, Pipeline, "BillingDepartmentRoleDefinitionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/departments/{departmentName}/billingRoleDefinitions/{roleDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingRoleDefinition_GetByDepartment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingDepartmentRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleDefinitionName"> The ID that uniquely identifies a role definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string roleDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleDefinitionName, nameof(roleDefinitionName));

            using var scope = _billingDepartmentRoleDefinitionBillingRoleDefinitionClientDiagnostics.CreateScope("BillingDepartmentRoleDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _billingDepartmentRoleDefinitionBillingRoleDefinitionRestClient.GetByDepartmentAsync(Id.Parent.Name, Id.Name, roleDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/departments/{departmentName}/billingRoleDefinitions/{roleDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingRoleDefinition_GetByDepartment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingDepartmentRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleDefinitionName"> The ID that uniquely identifies a role definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionName"/> is null. </exception>
        public virtual Response<bool> Exists(string roleDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleDefinitionName, nameof(roleDefinitionName));

            using var scope = _billingDepartmentRoleDefinitionBillingRoleDefinitionClientDiagnostics.CreateScope("BillingDepartmentRoleDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = _billingDepartmentRoleDefinitionBillingRoleDefinitionRestClient.GetByDepartment(Id.Parent.Name, Id.Name, roleDefinitionName, cancellationToken: cancellationToken);
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
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/departments/{departmentName}/billingRoleDefinitions/{roleDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingRoleDefinition_GetByDepartment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingDepartmentRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleDefinitionName"> The ID that uniquely identifies a role definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionName"/> is null. </exception>
        public virtual async Task<NullableResponse<BillingDepartmentRoleDefinitionResource>> GetIfExistsAsync(string roleDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleDefinitionName, nameof(roleDefinitionName));

            using var scope = _billingDepartmentRoleDefinitionBillingRoleDefinitionClientDiagnostics.CreateScope("BillingDepartmentRoleDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _billingDepartmentRoleDefinitionBillingRoleDefinitionRestClient.GetByDepartmentAsync(Id.Parent.Name, Id.Name, roleDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BillingDepartmentRoleDefinitionResource>(response.GetRawResponse());
                return Response.FromValue(new BillingDepartmentRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/departments/{departmentName}/billingRoleDefinitions/{roleDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingRoleDefinition_GetByDepartment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingDepartmentRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleDefinitionName"> The ID that uniquely identifies a role definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionName"/> is null. </exception>
        public virtual NullableResponse<BillingDepartmentRoleDefinitionResource> GetIfExists(string roleDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleDefinitionName, nameof(roleDefinitionName));

            using var scope = _billingDepartmentRoleDefinitionBillingRoleDefinitionClientDiagnostics.CreateScope("BillingDepartmentRoleDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _billingDepartmentRoleDefinitionBillingRoleDefinitionRestClient.GetByDepartment(Id.Parent.Name, Id.Name, roleDefinitionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BillingDepartmentRoleDefinitionResource>(response.GetRawResponse());
                return Response.FromValue(new BillingDepartmentRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BillingDepartmentRoleDefinitionResource> IEnumerable<BillingDepartmentRoleDefinitionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BillingDepartmentRoleDefinitionResource> IAsyncEnumerable<BillingDepartmentRoleDefinitionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
