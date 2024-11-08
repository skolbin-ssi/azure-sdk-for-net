// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.SelfHelp.Models;

namespace Azure.ResourceManager.SelfHelp.Mocking
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    public partial class MockableSelfHelpTenantResource : ArmResource
    {
        private ClientDiagnostics _discoverySolutionClientDiagnostics;
        private DiscoverySolutionRestOperations _discoverySolutionRestClient;
        private ClientDiagnostics _solutionSelfHelpClientDiagnostics;
        private SolutionSelfHelpRestOperations _solutionSelfHelpRestClient;
        private ClientDiagnostics _discoverySolutionNlpClientDiagnostics;
        private DiscoverySolutionNLPRestOperations _discoverySolutionNlpRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableSelfHelpTenantResource"/> class for mocking. </summary>
        protected MockableSelfHelpTenantResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableSelfHelpTenantResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableSelfHelpTenantResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DiscoverySolutionClientDiagnostics => _discoverySolutionClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.SelfHelp", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private DiscoverySolutionRestOperations DiscoverySolutionRestClient => _discoverySolutionRestClient ??= new DiscoverySolutionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics SolutionSelfHelpClientDiagnostics => _solutionSelfHelpClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.SelfHelp", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private SolutionSelfHelpRestOperations SolutionSelfHelpRestClient => _solutionSelfHelpRestClient ??= new SolutionSelfHelpRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics DiscoverySolutionNLPClientDiagnostics => _discoverySolutionNlpClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.SelfHelp", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private DiscoverySolutionNLPRestOperations DiscoverySolutionNLPRestClient => _discoverySolutionNlpRestClient ??= new DiscoverySolutionNLPRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists the relevant Azure Diagnostics, Solutions and Troubleshooters using [problemClassification API](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP)) AND  resourceUri or resourceType.&lt;br/&gt; Discovery Solutions is the initial entry point within Help API, which identifies relevant Azure diagnostics and solutions. &lt;br/&gt;&lt;br/&gt; Required Input :  problemClassificationId (Use the [problemClassification API](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP)) &lt;br/&gt;Optional input: resourceUri OR resource Type &lt;br/&gt;&lt;br/&gt; &lt;b&gt;Note: &lt;/b&gt;  ‘requiredInputs’ from Discovery solutions response must be passed via ‘additionalParameters’ as an input to Diagnostics and Solutions API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Help/discoverySolutions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySolution_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> 'ProblemClassificationId' is a mandatory filter to get solutions ids. It also supports optional 'ResourceType' and 'SolutionType' filters. The [$filter](https://learn.microsoft.com/en-us/odata/webapi/first-odata-api#filter) supports only 'and', 'or' and 'eq' operators. Example: $filter=ProblemClassificationId eq '1ddda5b4-cf6c-4d4f-91ad-bc38ab0e811e'. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SelfHelpSolutionMetadata"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SelfHelpSolutionMetadata> DiscoverSolutionsAsync(string filter = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DiscoverySolutionRestClient.CreateListRequest(filter, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DiscoverySolutionRestClient.CreateListNextPageRequest(nextLink, filter, skiptoken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => SelfHelpSolutionMetadata.DeserializeSelfHelpSolutionMetadata(e), DiscoverySolutionClientDiagnostics, Pipeline, "MockableSelfHelpTenantResource.DiscoverSolutions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the relevant Azure Diagnostics, Solutions and Troubleshooters using [problemClassification API](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP)) AND  resourceUri or resourceType.&lt;br/&gt; Discovery Solutions is the initial entry point within Help API, which identifies relevant Azure diagnostics and solutions. &lt;br/&gt;&lt;br/&gt; Required Input :  problemClassificationId (Use the [problemClassification API](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP)) &lt;br/&gt;Optional input: resourceUri OR resource Type &lt;br/&gt;&lt;br/&gt; &lt;b&gt;Note: &lt;/b&gt;  ‘requiredInputs’ from Discovery solutions response must be passed via ‘additionalParameters’ as an input to Diagnostics and Solutions API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Help/discoverySolutions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySolution_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> 'ProblemClassificationId' is a mandatory filter to get solutions ids. It also supports optional 'ResourceType' and 'SolutionType' filters. The [$filter](https://learn.microsoft.com/en-us/odata/webapi/first-odata-api#filter) supports only 'and', 'or' and 'eq' operators. Example: $filter=ProblemClassificationId eq '1ddda5b4-cf6c-4d4f-91ad-bc38ab0e811e'. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SelfHelpSolutionMetadata"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SelfHelpSolutionMetadata> DiscoverSolutions(string filter = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DiscoverySolutionRestClient.CreateListRequest(filter, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DiscoverySolutionRestClient.CreateListNextPageRequest(nextLink, filter, skiptoken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => SelfHelpSolutionMetadata.DeserializeSelfHelpSolutionMetadata(e), DiscoverySolutionClientDiagnostics, Pipeline, "MockableSelfHelpTenantResource.DiscoverSolutions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets Self Help Solutions for a given solutionId. Self Help Solutions consist of rich instructional video tutorials, links and guides to public documentation related to a specific problem that enables users to troubleshoot Azure issues.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Help/selfHelp/{solutionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SolutionSelfHelp_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="solutionId"> SolutionId is a unique id to identify a solution. You can retrieve the solution id using the Discovery api - https://learn.microsoft.com/en-us/rest/api/help/discovery-solution/list?view=rest-help-2023-09-01-preview&amp;tabs=HTTP. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="solutionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionId"/> is null. </exception>
        public virtual async Task<Response<SelfHelpSolutionResult>> GetSelfHelpSolutionByIdAsync(string solutionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(solutionId, nameof(solutionId));

            using var scope = SolutionSelfHelpClientDiagnostics.CreateScope("MockableSelfHelpTenantResource.GetSelfHelpSolutionById");
            scope.Start();
            try
            {
                var response = await SolutionSelfHelpRestClient.GetAsync(solutionId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets Self Help Solutions for a given solutionId. Self Help Solutions consist of rich instructional video tutorials, links and guides to public documentation related to a specific problem that enables users to troubleshoot Azure issues.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Help/selfHelp/{solutionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SolutionSelfHelp_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="solutionId"> SolutionId is a unique id to identify a solution. You can retrieve the solution id using the Discovery api - https://learn.microsoft.com/en-us/rest/api/help/discovery-solution/list?view=rest-help-2023-09-01-preview&amp;tabs=HTTP. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="solutionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionId"/> is null. </exception>
        public virtual Response<SelfHelpSolutionResult> GetSelfHelpSolutionById(string solutionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(solutionId, nameof(solutionId));

            using var scope = SolutionSelfHelpClientDiagnostics.CreateScope("MockableSelfHelpTenantResource.GetSelfHelpSolutionById");
            scope.Start();
            try
            {
                var response = SolutionSelfHelpRestClient.Get(solutionId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Search for relevant Azure Diagnostics, Solutions and Troubleshooters using a natural language issue summary.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Help/discoverSolutions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySolutionNLP_DiscoverSolutions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Request body for discovering solutions using NLP. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SolutionNlpMetadata"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SolutionNlpMetadata> DiscoverSolutionsNlpAsync(DiscoveryNlpContent content = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DiscoverySolutionNLPRestClient.CreateDiscoverSolutionsRequest(content);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => SolutionNlpMetadata.DeserializeSolutionNlpMetadata(e), DiscoverySolutionNLPClientDiagnostics, Pipeline, "MockableSelfHelpTenantResource.DiscoverSolutionsNlp", "value", null, cancellationToken);
        }

        /// <summary>
        /// Search for relevant Azure Diagnostics, Solutions and Troubleshooters using a natural language issue summary.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Help/discoverSolutions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySolutionNLP_DiscoverSolutions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Request body for discovering solutions using NLP. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SolutionNlpMetadata"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SolutionNlpMetadata> DiscoverSolutionsNlp(DiscoveryNlpContent content = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DiscoverySolutionNLPRestClient.CreateDiscoverSolutionsRequest(content);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => SolutionNlpMetadata.DeserializeSolutionNlpMetadata(e), DiscoverySolutionNLPClientDiagnostics, Pipeline, "MockableSelfHelpTenantResource.DiscoverSolutionsNlp", "value", null, cancellationToken);
        }
    }
}
