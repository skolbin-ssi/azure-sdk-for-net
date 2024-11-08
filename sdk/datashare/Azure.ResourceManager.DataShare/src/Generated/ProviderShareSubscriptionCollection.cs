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

namespace Azure.ResourceManager.DataShare
{
    /// <summary>
    /// A class representing a collection of <see cref="ProviderShareSubscriptionResource"/> and their operations.
    /// Each <see cref="ProviderShareSubscriptionResource"/> in the collection will belong to the same instance of <see cref="DataShareResource"/>.
    /// To get a <see cref="ProviderShareSubscriptionCollection"/> instance call the GetProviderShareSubscriptions method from an instance of <see cref="DataShareResource"/>.
    /// </summary>
    public partial class ProviderShareSubscriptionCollection : ArmCollection, IEnumerable<ProviderShareSubscriptionResource>, IAsyncEnumerable<ProviderShareSubscriptionResource>
    {
        private readonly ClientDiagnostics _providerShareSubscriptionClientDiagnostics;
        private readonly ProviderShareSubscriptionsRestOperations _providerShareSubscriptionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ProviderShareSubscriptionCollection"/> class for mocking. </summary>
        protected ProviderShareSubscriptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ProviderShareSubscriptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ProviderShareSubscriptionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _providerShareSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataShare", ProviderShareSubscriptionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ProviderShareSubscriptionResource.ResourceType, out string providerShareSubscriptionApiVersion);
            _providerShareSubscriptionRestClient = new ProviderShareSubscriptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, providerShareSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataShareResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataShareResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get share subscription in a provider share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/providerShareSubscriptions/{providerShareSubscriptionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderShareSubscriptions_GetByShare</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProviderShareSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerShareSubscriptionId"> To locate shareSubscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerShareSubscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerShareSubscriptionId"/> is null. </exception>
        public virtual async Task<Response<ProviderShareSubscriptionResource>> GetAsync(string providerShareSubscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerShareSubscriptionId, nameof(providerShareSubscriptionId));

            using var scope = _providerShareSubscriptionClientDiagnostics.CreateScope("ProviderShareSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _providerShareSubscriptionRestClient.GetByShareAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, providerShareSubscriptionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProviderShareSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get share subscription in a provider share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/providerShareSubscriptions/{providerShareSubscriptionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderShareSubscriptions_GetByShare</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProviderShareSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerShareSubscriptionId"> To locate shareSubscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerShareSubscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerShareSubscriptionId"/> is null. </exception>
        public virtual Response<ProviderShareSubscriptionResource> Get(string providerShareSubscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerShareSubscriptionId, nameof(providerShareSubscriptionId));

            using var scope = _providerShareSubscriptionClientDiagnostics.CreateScope("ProviderShareSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = _providerShareSubscriptionRestClient.GetByShare(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, providerShareSubscriptionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProviderShareSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List share subscriptions in a provider share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/providerShareSubscriptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderShareSubscriptions_ListByShare</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProviderShareSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Continuation Token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProviderShareSubscriptionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProviderShareSubscriptionResource> GetAllAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _providerShareSubscriptionRestClient.CreateListByShareRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _providerShareSubscriptionRestClient.CreateListByShareNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ProviderShareSubscriptionResource(Client, ProviderShareSubscriptionData.DeserializeProviderShareSubscriptionData(e)), _providerShareSubscriptionClientDiagnostics, Pipeline, "ProviderShareSubscriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List share subscriptions in a provider share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/providerShareSubscriptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderShareSubscriptions_ListByShare</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProviderShareSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Continuation Token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProviderShareSubscriptionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProviderShareSubscriptionResource> GetAll(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _providerShareSubscriptionRestClient.CreateListByShareRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _providerShareSubscriptionRestClient.CreateListByShareNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ProviderShareSubscriptionResource(Client, ProviderShareSubscriptionData.DeserializeProviderShareSubscriptionData(e)), _providerShareSubscriptionClientDiagnostics, Pipeline, "ProviderShareSubscriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/providerShareSubscriptions/{providerShareSubscriptionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderShareSubscriptions_GetByShare</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProviderShareSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerShareSubscriptionId"> To locate shareSubscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerShareSubscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerShareSubscriptionId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string providerShareSubscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerShareSubscriptionId, nameof(providerShareSubscriptionId));

            using var scope = _providerShareSubscriptionClientDiagnostics.CreateScope("ProviderShareSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _providerShareSubscriptionRestClient.GetByShareAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, providerShareSubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/providerShareSubscriptions/{providerShareSubscriptionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderShareSubscriptions_GetByShare</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProviderShareSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerShareSubscriptionId"> To locate shareSubscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerShareSubscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerShareSubscriptionId"/> is null. </exception>
        public virtual Response<bool> Exists(string providerShareSubscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerShareSubscriptionId, nameof(providerShareSubscriptionId));

            using var scope = _providerShareSubscriptionClientDiagnostics.CreateScope("ProviderShareSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = _providerShareSubscriptionRestClient.GetByShare(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, providerShareSubscriptionId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/providerShareSubscriptions/{providerShareSubscriptionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderShareSubscriptions_GetByShare</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProviderShareSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerShareSubscriptionId"> To locate shareSubscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerShareSubscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerShareSubscriptionId"/> is null. </exception>
        public virtual async Task<NullableResponse<ProviderShareSubscriptionResource>> GetIfExistsAsync(string providerShareSubscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerShareSubscriptionId, nameof(providerShareSubscriptionId));

            using var scope = _providerShareSubscriptionClientDiagnostics.CreateScope("ProviderShareSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _providerShareSubscriptionRestClient.GetByShareAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, providerShareSubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ProviderShareSubscriptionResource>(response.GetRawResponse());
                return Response.FromValue(new ProviderShareSubscriptionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/providerShareSubscriptions/{providerShareSubscriptionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderShareSubscriptions_GetByShare</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProviderShareSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerShareSubscriptionId"> To locate shareSubscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerShareSubscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerShareSubscriptionId"/> is null. </exception>
        public virtual NullableResponse<ProviderShareSubscriptionResource> GetIfExists(string providerShareSubscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerShareSubscriptionId, nameof(providerShareSubscriptionId));

            using var scope = _providerShareSubscriptionClientDiagnostics.CreateScope("ProviderShareSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _providerShareSubscriptionRestClient.GetByShare(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, providerShareSubscriptionId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ProviderShareSubscriptionResource>(response.GetRawResponse());
                return Response.FromValue(new ProviderShareSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ProviderShareSubscriptionResource> IEnumerable<ProviderShareSubscriptionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ProviderShareSubscriptionResource> IAsyncEnumerable<ProviderShareSubscriptionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
