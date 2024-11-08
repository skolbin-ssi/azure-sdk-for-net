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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary>
    /// A class representing a collection of <see cref="BackupProtectionContainerResource"/> and their operations.
    /// Each <see cref="BackupProtectionContainerResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="BackupProtectionContainerCollection"/> instance call the GetBackupProtectionContainers method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class BackupProtectionContainerCollection : ArmCollection
    {
        private readonly ClientDiagnostics _backupProtectionContainerProtectionContainersClientDiagnostics;
        private readonly ProtectionContainersRestOperations _backupProtectionContainerProtectionContainersRestClient;

        /// <summary> Initializes a new instance of the <see cref="BackupProtectionContainerCollection"/> class for mocking. </summary>
        protected BackupProtectionContainerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BackupProtectionContainerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BackupProtectionContainerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _backupProtectionContainerProtectionContainersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesBackup", BackupProtectionContainerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BackupProtectionContainerResource.ResourceType, out string backupProtectionContainerProtectionContainersApiVersion);
            _backupProtectionContainerProtectionContainersRestClient = new ProtectionContainersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, backupProtectionContainerProtectionContainersApiVersion);
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
        /// Registers the container with Recovery Services vault.
        /// This is an asynchronous operation. To track the operation status, use location header to call get latest status of
        /// the operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionContainers_Register</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the container. </param>
        /// <param name="containerName"> Name of the container to be registered. </param>
        /// <param name="data"> Request body for operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BackupProtectionContainerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vaultName, string fabricName, string containerName, BackupProtectionContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _backupProtectionContainerProtectionContainersClientDiagnostics.CreateScope("BackupProtectionContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _backupProtectionContainerProtectionContainersRestClient.RegisterAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, fabricName, containerName, data, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesBackupArmOperation<BackupProtectionContainerResource>(new BackupProtectionContainerOperationSource(Client), _backupProtectionContainerProtectionContainersClientDiagnostics, Pipeline, _backupProtectionContainerProtectionContainersRestClient.CreateRegisterRequest(Id.SubscriptionId, Id.ResourceGroupName, vaultName, fabricName, containerName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Registers the container with Recovery Services vault.
        /// This is an asynchronous operation. To track the operation status, use location header to call get latest status of
        /// the operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionContainers_Register</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the container. </param>
        /// <param name="containerName"> Name of the container to be registered. </param>
        /// <param name="data"> Request body for operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BackupProtectionContainerResource> CreateOrUpdate(WaitUntil waitUntil, string vaultName, string fabricName, string containerName, BackupProtectionContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _backupProtectionContainerProtectionContainersClientDiagnostics.CreateScope("BackupProtectionContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _backupProtectionContainerProtectionContainersRestClient.Register(Id.SubscriptionId, Id.ResourceGroupName, vaultName, fabricName, containerName, data, cancellationToken);
                var operation = new RecoveryServicesBackupArmOperation<BackupProtectionContainerResource>(new BackupProtectionContainerOperationSource(Client), _backupProtectionContainerProtectionContainersClientDiagnostics, Pipeline, _backupProtectionContainerProtectionContainersRestClient.CreateRegisterRequest(Id.SubscriptionId, Id.ResourceGroupName, vaultName, fabricName, containerName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets details of the specific container registered to your Recovery Services Vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Name of the fabric where the container belongs. </param>
        /// <param name="containerName"> Name of the container whose details need to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="containerName"/> is null. </exception>
        public virtual async Task<Response<BackupProtectionContainerResource>> GetAsync(string vaultName, string fabricName, string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _backupProtectionContainerProtectionContainersClientDiagnostics.CreateScope("BackupProtectionContainerCollection.Get");
            scope.Start();
            try
            {
                var response = await _backupProtectionContainerProtectionContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, fabricName, containerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupProtectionContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details of the specific container registered to your Recovery Services Vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Name of the fabric where the container belongs. </param>
        /// <param name="containerName"> Name of the container whose details need to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="containerName"/> is null. </exception>
        public virtual Response<BackupProtectionContainerResource> Get(string vaultName, string fabricName, string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _backupProtectionContainerProtectionContainersClientDiagnostics.CreateScope("BackupProtectionContainerCollection.Get");
            scope.Start();
            try
            {
                var response = _backupProtectionContainerProtectionContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vaultName, fabricName, containerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupProtectionContainerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Name of the fabric where the container belongs. </param>
        /// <param name="containerName"> Name of the container whose details need to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="containerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vaultName, string fabricName, string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _backupProtectionContainerProtectionContainersClientDiagnostics.CreateScope("BackupProtectionContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _backupProtectionContainerProtectionContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, fabricName, containerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Name of the fabric where the container belongs. </param>
        /// <param name="containerName"> Name of the container whose details need to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="containerName"/> is null. </exception>
        public virtual Response<bool> Exists(string vaultName, string fabricName, string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _backupProtectionContainerProtectionContainersClientDiagnostics.CreateScope("BackupProtectionContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = _backupProtectionContainerProtectionContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vaultName, fabricName, containerName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Name of the fabric where the container belongs. </param>
        /// <param name="containerName"> Name of the container whose details need to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="containerName"/> is null. </exception>
        public virtual async Task<NullableResponse<BackupProtectionContainerResource>> GetIfExistsAsync(string vaultName, string fabricName, string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _backupProtectionContainerProtectionContainersClientDiagnostics.CreateScope("BackupProtectionContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _backupProtectionContainerProtectionContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, fabricName, containerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BackupProtectionContainerResource>(response.GetRawResponse());
                return Response.FromValue(new BackupProtectionContainerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Name of the fabric where the container belongs. </param>
        /// <param name="containerName"> Name of the container whose details need to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="containerName"/> is null. </exception>
        public virtual NullableResponse<BackupProtectionContainerResource> GetIfExists(string vaultName, string fabricName, string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _backupProtectionContainerProtectionContainersClientDiagnostics.CreateScope("BackupProtectionContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _backupProtectionContainerProtectionContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vaultName, fabricName, containerName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BackupProtectionContainerResource>(response.GetRawResponse());
                return Response.FromValue(new BackupProtectionContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
