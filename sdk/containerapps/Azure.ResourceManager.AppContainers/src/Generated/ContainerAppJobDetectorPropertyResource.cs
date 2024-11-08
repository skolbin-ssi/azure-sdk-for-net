// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A Class representing a ContainerAppJobDetectorProperty along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ContainerAppJobDetectorPropertyResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetContainerAppJobDetectorPropertyResource method.
    /// Otherwise you can get one from its parent resource <see cref="ContainerAppJobResource"/> using the GetContainerAppJobDetectorProperty method.
    /// </summary>
    public partial class ContainerAppJobDetectorPropertyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ContainerAppJobDetectorPropertyResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="jobName"> The jobName. </param>
        /// <param name="apiName"> The apiName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string jobName, string apiName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}/detectorProperties/{apiName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _containerAppJobDetectorPropertyJobsClientDiagnostics;
        private readonly JobsRestOperations _containerAppJobDetectorPropertyJobsRestClient;
        private readonly ContainerAppJobData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.App/jobs/detectorProperties";

        /// <summary> Initializes a new instance of the <see cref="ContainerAppJobDetectorPropertyResource"/> class for mocking. </summary>
        protected ContainerAppJobDetectorPropertyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppJobDetectorPropertyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ContainerAppJobDetectorPropertyResource(ArmClient client, ContainerAppJobData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppJobDetectorPropertyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ContainerAppJobDetectorPropertyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppJobDetectorPropertyJobsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string containerAppJobDetectorPropertyJobsApiVersion);
            _containerAppJobDetectorPropertyJobsRestClient = new JobsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppJobDetectorPropertyJobsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ContainerAppJobData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the properties of a Container App Job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}/detectorProperties/{apiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_ProxyGet</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppJobDetectorPropertyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ContainerAppJobDetectorPropertyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppJobDetectorPropertyJobsClientDiagnostics.CreateScope("ContainerAppJobDetectorPropertyResource.Get");
            scope.Start();
            try
            {
                var response = await _containerAppJobDetectorPropertyJobsRestClient.ProxyGetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppJobDetectorPropertyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the properties of a Container App Job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}/detectorProperties/{apiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_ProxyGet</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppJobDetectorPropertyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ContainerAppJobDetectorPropertyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppJobDetectorPropertyJobsClientDiagnostics.CreateScope("ContainerAppJobDetectorPropertyResource.Get");
            scope.Start();
            try
            {
                var response = _containerAppJobDetectorPropertyJobsRestClient.ProxyGet(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppJobDetectorPropertyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
