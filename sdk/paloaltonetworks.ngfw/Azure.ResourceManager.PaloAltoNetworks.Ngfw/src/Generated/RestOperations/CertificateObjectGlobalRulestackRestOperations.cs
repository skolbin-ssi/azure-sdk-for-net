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
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    internal partial class CertificateObjectGlobalRulestackRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of CertificateObjectGlobalRulestackRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public CertificateObjectGlobalRulestackRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-09-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListRequestUri(string globalRulestackName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/", false);
            uri.AppendPath(globalRulestackName, true);
            uri.AppendPath("/certificates", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string globalRulestackName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/", false);
            uri.AppendPath(globalRulestackName, true);
            uri.AppendPath("/certificates", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List CertificateObjectGlobalRulestackResource resources by Tenant. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<GlobalRulestackCertificateObjectListResult>> ListAsync(string globalRulestackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));

            using var message = CreateListRequest(globalRulestackName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GlobalRulestackCertificateObjectListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GlobalRulestackCertificateObjectListResult.DeserializeGlobalRulestackCertificateObjectListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List CertificateObjectGlobalRulestackResource resources by Tenant. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<GlobalRulestackCertificateObjectListResult> List(string globalRulestackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));

            using var message = CreateListRequest(globalRulestackName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GlobalRulestackCertificateObjectListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GlobalRulestackCertificateObjectListResult.DeserializeGlobalRulestackCertificateObjectListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string globalRulestackName, string name)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/", false);
            uri.AppendPath(globalRulestackName, true);
            uri.AppendPath("/certificates/", false);
            uri.AppendPath(name, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string globalRulestackName, string name)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/", false);
            uri.AppendPath(globalRulestackName, true);
            uri.AppendPath("/certificates/", false);
            uri.AppendPath(name, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a CertificateObjectGlobalRulestackResource. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="name"> certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> or <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> or <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<GlobalRulestackCertificateObjectData>> GetAsync(string globalRulestackName, string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var message = CreateGetRequest(globalRulestackName, name);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GlobalRulestackCertificateObjectData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GlobalRulestackCertificateObjectData.DeserializeGlobalRulestackCertificateObjectData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((GlobalRulestackCertificateObjectData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a CertificateObjectGlobalRulestackResource. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="name"> certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> or <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> or <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<GlobalRulestackCertificateObjectData> Get(string globalRulestackName, string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var message = CreateGetRequest(globalRulestackName, name);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GlobalRulestackCertificateObjectData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GlobalRulestackCertificateObjectData.DeserializeGlobalRulestackCertificateObjectData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((GlobalRulestackCertificateObjectData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string globalRulestackName, string name, GlobalRulestackCertificateObjectData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/", false);
            uri.AppendPath(globalRulestackName, true);
            uri.AppendPath("/certificates/", false);
            uri.AppendPath(name, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string globalRulestackName, string name, GlobalRulestackCertificateObjectData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/", false);
            uri.AppendPath(globalRulestackName, true);
            uri.AppendPath("/certificates/", false);
            uri.AppendPath(name, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create a CertificateObjectGlobalRulestackResource. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="name"> certificate name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/>, <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> or <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string globalRulestackName, string name, GlobalRulestackCertificateObjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(globalRulestackName, name, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create a CertificateObjectGlobalRulestackResource. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="name"> certificate name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/>, <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> or <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string globalRulestackName, string name, GlobalRulestackCertificateObjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(globalRulestackName, name, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string globalRulestackName, string name)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/", false);
            uri.AppendPath(globalRulestackName, true);
            uri.AppendPath("/certificates/", false);
            uri.AppendPath(name, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string globalRulestackName, string name)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/", false);
            uri.AppendPath(globalRulestackName, true);
            uri.AppendPath("/certificates/", false);
            uri.AppendPath(name, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete a CertificateObjectGlobalRulestackResource. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="name"> certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> or <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> or <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string globalRulestackName, string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var message = CreateDeleteRequest(globalRulestackName, name);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete a CertificateObjectGlobalRulestackResource. </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="name"> certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> or <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> or <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string globalRulestackName, string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var message = CreateDeleteRequest(globalRulestackName, name);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string globalRulestackName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string globalRulestackName)
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

        /// <summary> List CertificateObjectGlobalRulestackResource resources by Tenant. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="globalRulestackName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<GlobalRulestackCertificateObjectListResult>> ListNextPageAsync(string nextLink, string globalRulestackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));

            using var message = CreateListNextPageRequest(nextLink, globalRulestackName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GlobalRulestackCertificateObjectListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GlobalRulestackCertificateObjectListResult.DeserializeGlobalRulestackCertificateObjectListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List CertificateObjectGlobalRulestackResource resources by Tenant. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="globalRulestackName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<GlobalRulestackCertificateObjectListResult> ListNextPage(string nextLink, string globalRulestackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));

            using var message = CreateListNextPageRequest(nextLink, globalRulestackName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GlobalRulestackCertificateObjectListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GlobalRulestackCertificateObjectListResult.DeserializeGlobalRulestackCertificateObjectListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
