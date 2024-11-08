// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ResourceMover.Models;

namespace Azure.ResourceManager.ResourceMover
{
    internal partial class UnresolvedDependenciesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of UnresolvedDependenciesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public UnresolvedDependenciesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-08-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string moverResourceSetName, MoverDependencyLevel? dependencyLevel, string orderby, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Migrate/moveCollections/", false);
            uri.AppendPath(moverResourceSetName, true);
            uri.AppendPath("/unresolvedDependencies", false);
            if (dependencyLevel != null)
            {
                uri.AppendQuery("dependencyLevel", dependencyLevel.Value.ToString(), true);
            }
            if (orderby != null)
            {
                uri.AppendQuery("$orderby", orderby, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string moverResourceSetName, MoverDependencyLevel? dependencyLevel, string orderby, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Migrate/moveCollections/", false);
            uri.AppendPath(moverResourceSetName, true);
            uri.AppendPath("/unresolvedDependencies", false);
            if (dependencyLevel != null)
            {
                uri.AppendQuery("dependencyLevel", dependencyLevel.Value.ToString(), true);
            }
            if (orderby != null)
            {
                uri.AppendQuery("$orderby", orderby, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a list of unresolved dependencies. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="dependencyLevel"> Defines the dependency level. </param>
        /// <param name="orderby"> OData order by query option. For example, you can use $orderby=Count desc. </param>
        /// <param name="filter"> The filter to apply on the operation. For example, $apply=filter(count eq 2). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="moverResourceSetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="moverResourceSetName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MoverUnresolvedDependencyList>> GetAsync(string subscriptionId, string resourceGroupName, string moverResourceSetName, MoverDependencyLevel? dependencyLevel = null, string orderby = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(moverResourceSetName, nameof(moverResourceSetName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, moverResourceSetName, dependencyLevel, orderby, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MoverUnresolvedDependencyList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MoverUnresolvedDependencyList.DeserializeMoverUnresolvedDependencyList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a list of unresolved dependencies. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="dependencyLevel"> Defines the dependency level. </param>
        /// <param name="orderby"> OData order by query option. For example, you can use $orderby=Count desc. </param>
        /// <param name="filter"> The filter to apply on the operation. For example, $apply=filter(count eq 2). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="moverResourceSetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="moverResourceSetName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MoverUnresolvedDependencyList> Get(string subscriptionId, string resourceGroupName, string moverResourceSetName, MoverDependencyLevel? dependencyLevel = null, string orderby = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(moverResourceSetName, nameof(moverResourceSetName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, moverResourceSetName, dependencyLevel, orderby, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MoverUnresolvedDependencyList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MoverUnresolvedDependencyList.DeserializeMoverUnresolvedDependencyList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string moverResourceSetName, MoverDependencyLevel? dependencyLevel, string orderby, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateGetNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string moverResourceSetName, MoverDependencyLevel? dependencyLevel, string orderby, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a list of unresolved dependencies. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="dependencyLevel"> Defines the dependency level. </param>
        /// <param name="orderby"> OData order by query option. For example, you can use $orderby=Count desc. </param>
        /// <param name="filter"> The filter to apply on the operation. For example, $apply=filter(count eq 2). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="moverResourceSetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="moverResourceSetName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MoverUnresolvedDependencyList>> GetNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string moverResourceSetName, MoverDependencyLevel? dependencyLevel = null, string orderby = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(moverResourceSetName, nameof(moverResourceSetName));

            using var message = CreateGetNextPageRequest(nextLink, subscriptionId, resourceGroupName, moverResourceSetName, dependencyLevel, orderby, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MoverUnresolvedDependencyList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MoverUnresolvedDependencyList.DeserializeMoverUnresolvedDependencyList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a list of unresolved dependencies. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="dependencyLevel"> Defines the dependency level. </param>
        /// <param name="orderby"> OData order by query option. For example, you can use $orderby=Count desc. </param>
        /// <param name="filter"> The filter to apply on the operation. For example, $apply=filter(count eq 2). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="moverResourceSetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="moverResourceSetName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MoverUnresolvedDependencyList> GetNextPage(string nextLink, string subscriptionId, string resourceGroupName, string moverResourceSetName, MoverDependencyLevel? dependencyLevel = null, string orderby = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(moverResourceSetName, nameof(moverResourceSetName));

            using var message = CreateGetNextPageRequest(nextLink, subscriptionId, resourceGroupName, moverResourceSetName, dependencyLevel, orderby, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MoverUnresolvedDependencyList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MoverUnresolvedDependencyList.DeserializeMoverUnresolvedDependencyList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
