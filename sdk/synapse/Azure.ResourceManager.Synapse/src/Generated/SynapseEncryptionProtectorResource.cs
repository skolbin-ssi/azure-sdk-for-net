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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A Class representing a SynapseEncryptionProtector along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SynapseEncryptionProtectorResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSynapseEncryptionProtectorResource method.
    /// Otherwise you can get one from its parent resource <see cref="SynapseWorkspaceResource"/> using the GetSynapseEncryptionProtector method.
    /// </summary>
    public partial class SynapseEncryptionProtectorResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SynapseEncryptionProtectorResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="workspaceName"> The workspaceName. </param>
        /// <param name="encryptionProtectorName"> The encryptionProtectorName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, SynapseEncryptionProtectorName encryptionProtectorName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/encryptionProtector/{encryptionProtectorName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics;
        private readonly WorkspaceManagedSqlServerEncryptionProtectorRestOperations _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient;
        private readonly SynapseEncryptionProtectorData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Synapse/workspaces/encryptionProtector";

        /// <summary> Initializes a new instance of the <see cref="SynapseEncryptionProtectorResource"/> class for mocking. </summary>
        protected SynapseEncryptionProtectorResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseEncryptionProtectorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SynapseEncryptionProtectorResource(ArmClient client, SynapseEncryptionProtectorData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseEncryptionProtectorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SynapseEncryptionProtectorResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorApiVersion);
            _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient = new WorkspaceManagedSqlServerEncryptionProtectorRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SynapseEncryptionProtectorData Data
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
        /// Get workspace managed sql server's encryption protector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/encryptionProtector/{encryptionProtectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerEncryptionProtector_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseEncryptionProtectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapseEncryptionProtectorResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics.CreateScope("SynapseEncryptionProtectorResource.Get");
            scope.Start();
            try
            {
                var response = await _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseEncryptionProtectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get workspace managed sql server's encryption protector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/encryptionProtector/{encryptionProtectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerEncryptionProtector_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseEncryptionProtectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapseEncryptionProtectorResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics.CreateScope("SynapseEncryptionProtectorResource.Get");
            scope.Start();
            try
            {
                var response = _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseEncryptionProtectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates workspace managed sql server's encryption protector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/encryptionProtector/{encryptionProtectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerEncryptionProtector_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseEncryptionProtectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The requested encryption protector resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseEncryptionProtectorResource>> UpdateAsync(WaitUntil waitUntil, SynapseEncryptionProtectorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics.CreateScope("SynapseEncryptionProtectorResource.Update");
            scope.Start();
            try
            {
                var response = await _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseEncryptionProtectorResource>(new SynapseEncryptionProtectorOperationSource(Client), _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics, Pipeline, _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Updates workspace managed sql server's encryption protector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/encryptionProtector/{encryptionProtectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerEncryptionProtector_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseEncryptionProtectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The requested encryption protector resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseEncryptionProtectorResource> Update(WaitUntil waitUntil, SynapseEncryptionProtectorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics.CreateScope("SynapseEncryptionProtectorResource.Update");
            scope.Start();
            try
            {
                var response = _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapseEncryptionProtectorResource>(new SynapseEncryptionProtectorOperationSource(Client), _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics, Pipeline, _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Revalidates workspace managed sql server's existing encryption protector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/encryptionProtector/{encryptionProtectorName}/revalidate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerEncryptionProtector_Revalidate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseEncryptionProtectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> RevalidateAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics.CreateScope("SynapseEncryptionProtectorResource.Revalidate");
            scope.Start();
            try
            {
                var response = await _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.RevalidateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation(_synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics, Pipeline, _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.CreateRevalidateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Revalidates workspace managed sql server's existing encryption protector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/encryptionProtector/{encryptionProtectorName}/revalidate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerEncryptionProtector_Revalidate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseEncryptionProtectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Revalidate(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics.CreateScope("SynapseEncryptionProtectorResource.Revalidate");
            scope.Start();
            try
            {
                var response = _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.Revalidate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SynapseArmOperation(_synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics, Pipeline, _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.CreateRevalidateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
