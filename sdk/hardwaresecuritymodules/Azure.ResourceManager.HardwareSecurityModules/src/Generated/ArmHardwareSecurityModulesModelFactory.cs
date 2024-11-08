// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmHardwareSecurityModulesModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="HardwareSecurityModules.CloudHsmClusterData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Properties of the Cloud HSM Cluster. </param>
        /// <param name="identity"> Managed service identity (system assigned and/or user assigned identities). </param>
        /// <param name="sku"> SKU details. </param>
        /// <returns> A new <see cref="HardwareSecurityModules.CloudHsmClusterData"/> instance for mocking. </returns>
        public static CloudHsmClusterData CloudHsmClusterData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, CloudHsmClusterProperties properties = null, ManagedServiceIdentity identity = null, CloudHsmClusterSku sku = null)
        {
            tags ??= new Dictionary<string, string>();

            return new CloudHsmClusterData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                properties,
                identity,
                sku,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CloudHsmClusterProperties"/>. </summary>
        /// <param name="activationState"> State of security domain activation. </param>
        /// <param name="autoGeneratedDomainNameLabelScope"> The Cloud HSM Cluster's auto-generated Domain Name Label Scope. </param>
        /// <param name="hsms"> An array of Cloud HSM Cluster's HSMs. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connection resources. </param>
        /// <param name="provisioningState"> The Cloud HSM Cluster's provisioningState. </param>
        /// <param name="publicNetworkAccess"> The Cloud HSM Cluster public network access. </param>
        /// <param name="statusMessage"> Cloud HSM Cluster status message. </param>
        /// <returns> A new <see cref="Models.CloudHsmClusterProperties"/> instance for mocking. </returns>
        public static CloudHsmClusterProperties CloudHsmClusterProperties(SecurityDomainActivationState? activationState = null, AutoGeneratedDomainNameLabelScope? autoGeneratedDomainNameLabelScope = null, IEnumerable<CloudHsmProperties> hsms = null, IEnumerable<CloudHsmClusterPrivateEndpointConnectionData> privateEndpointConnections = null, CloudHsmClusterProvisioningState? provisioningState = null, CloudHsmClusterPublicNetworkAccess? publicNetworkAccess = null, string statusMessage = null)
        {
            hsms ??= new List<CloudHsmProperties>();
            privateEndpointConnections ??= new List<CloudHsmClusterPrivateEndpointConnectionData>();

            return new CloudHsmClusterProperties(
                activationState,
                autoGeneratedDomainNameLabelScope,
                hsms?.ToList(),
                privateEndpointConnections?.ToList(),
                provisioningState,
                publicNetworkAccess,
                statusMessage,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CloudHsmProperties"/>. </summary>
        /// <param name="fqdn"> FQDN of the Cloud HSM. </param>
        /// <param name="state"> The Cloud HSM State. Values are: Deploying, ConfiguringSlb, Starting, Starting, Failed, Failed, Deleting, DeletingSlbEntry, InitialProvisioning, Updating. </param>
        /// <param name="stateMessage"> The Cloud HSM State message. </param>
        /// <returns> A new <see cref="Models.CloudHsmProperties"/> instance for mocking. </returns>
        public static CloudHsmProperties CloudHsmProperties(string fqdn = null, string state = null, string stateMessage = null)
        {
            return new CloudHsmProperties(fqdn, state, stateMessage, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="HardwareSecurityModules.CloudHsmClusterPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Resource properties. </param>
        /// <param name="etag"> Modified whenever there is a change in the state of private endpoint connection. </param>
        /// <returns> A new <see cref="HardwareSecurityModules.CloudHsmClusterPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static CloudHsmClusterPrivateEndpointConnectionData CloudHsmClusterPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, CloudHsmClusterPrivateEndpointConnectionProperties properties = null, ETag? etag = null)
        {
            return new CloudHsmClusterPrivateEndpointConnectionData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                etag,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CloudHsmClusterPrivateEndpointConnectionProperties"/>. </summary>
        /// <param name="privateEndpointId"> The private endpoint resource. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        /// <param name="groupIds"> The group ids for the private endpoint resource. </param>
        /// <returns> A new <see cref="Models.CloudHsmClusterPrivateEndpointConnectionProperties"/> instance for mocking. </returns>
        public static CloudHsmClusterPrivateEndpointConnectionProperties CloudHsmClusterPrivateEndpointConnectionProperties(ResourceIdentifier privateEndpointId = null, CloudHsmClusterPrivateLinkServiceConnectionState connectionState = null, CloudHsmClusterPrivateEndpointConnectionProvisioningState? provisioningState = null, IEnumerable<string> groupIds = null)
        {
            groupIds ??= new List<string>();

            return new CloudHsmClusterPrivateEndpointConnectionProperties(privateEndpointId != null ? ResourceManagerModelFactory.SubResource(privateEndpointId) : null, connectionState, provisioningState, groupIds?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CloudHsmClusterPrivateLinkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Resource properties. </param>
        /// <returns> A new <see cref="Models.CloudHsmClusterPrivateLinkData"/> instance for mocking. </returns>
        public static CloudHsmClusterPrivateLinkData CloudHsmClusterPrivateLinkData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, CloudHsmClusterPrivateLinkResourceProperties properties = null)
        {
            return new CloudHsmClusterPrivateLinkData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CloudHsmClusterPrivateLinkResourceProperties"/>. </summary>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <param name="requiredZoneNames"> The private link resource private link DNS zone name. </param>
        /// <returns> A new <see cref="Models.CloudHsmClusterPrivateLinkResourceProperties"/> instance for mocking. </returns>
        public static CloudHsmClusterPrivateLinkResourceProperties CloudHsmClusterPrivateLinkResourceProperties(string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();

            return new CloudHsmClusterPrivateLinkResourceProperties(groupId, requiredMembers?.ToList(), requiredZoneNames?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CloudHsmClusterBackupContent"/>. </summary>
        /// <param name="azureStorageBlobContainerUri"> The Azure blob storage container Uri which contains the backup. </param>
        /// <param name="token"> The SAS token pointing to an Azure blob storage container. This property is reserved for Azure Backup Service. </param>
        /// <returns> A new <see cref="Models.CloudHsmClusterBackupContent"/> instance for mocking. </returns>
        public static CloudHsmClusterBackupContent CloudHsmClusterBackupContent(Uri azureStorageBlobContainerUri = null, string token = null)
        {
            return new CloudHsmClusterBackupContent(azureStorageBlobContainerUri, token, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.BackupRestoreRequestBaseProperties"/>. </summary>
        /// <param name="azureStorageBlobContainerUri"> The Azure blob storage container Uri which contains the backup. </param>
        /// <param name="token"> The SAS token pointing to an Azure blob storage container. This property is reserved for Azure Backup Service. </param>
        /// <returns> A new <see cref="Models.BackupRestoreRequestBaseProperties"/> instance for mocking. </returns>
        public static BackupRestoreRequestBaseProperties BackupRestoreRequestBaseProperties(Uri azureStorageBlobContainerUri = null, string token = null)
        {
            return new BackupRestoreRequestBaseProperties(azureStorageBlobContainerUri, token, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CloudHsmClusterBackupResult"/>. </summary>
        /// <param name="properties"> Properties of the Cloud HSM Cluster. </param>
        /// <returns> A new <see cref="Models.CloudHsmClusterBackupResult"/> instance for mocking. </returns>
        public static CloudHsmClusterBackupResult CloudHsmClusterBackupResult(CloudHsmClusterBackupResultProperties properties = null)
        {
            return new CloudHsmClusterBackupResult(properties, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CloudHsmClusterBackupResultProperties"/>. </summary>
        /// <param name="status"> Status of the backup/restore operation. </param>
        /// <param name="statusDetails"> The status details of backup/restore operation. </param>
        /// <param name="error"> Error encountered, if any, during the backup/restore operation. </param>
        /// <param name="startOn"> The start time of the backup/restore operation in UTC. </param>
        /// <param name="endOn"> The end time of the backup/restore operation in UTC. </param>
        /// <param name="jobId"> Identifier for the backup/restore operation. </param>
        /// <param name="azureStorageBlobContainerUri"> The Azure blob storage container Uri which contains the backup. </param>
        /// <param name="backupId"> The ID of the backup. </param>
        /// <returns> A new <see cref="Models.CloudHsmClusterBackupResultProperties"/> instance for mocking. </returns>
        public static CloudHsmClusterBackupResultProperties CloudHsmClusterBackupResultProperties(BackupRestoreOperationStatus? status = null, string statusDetails = null, ResponseError error = null, DateTimeOffset? startOn = null, DateTimeOffset? endOn = null, string jobId = null, Uri azureStorageBlobContainerUri = null, string backupId = null)
        {
            return new CloudHsmClusterBackupResultProperties(
                status,
                statusDetails,
                error,
                startOn,
                endOn,
                jobId,
                serializedAdditionalRawData: null,
                azureStorageBlobContainerUri,
                backupId);
        }

        /// <summary> Initializes a new instance of <see cref="Models.BackupRestoreBaseResultProperties"/>. </summary>
        /// <param name="status"> Status of the backup/restore operation. </param>
        /// <param name="statusDetails"> The status details of backup/restore operation. </param>
        /// <param name="error"> Error encountered, if any, during the backup/restore operation. </param>
        /// <param name="startOn"> The start time of the backup/restore operation in UTC. </param>
        /// <param name="endOn"> The end time of the backup/restore operation in UTC. </param>
        /// <param name="jobId"> Identifier for the backup/restore operation. </param>
        /// <returns> A new <see cref="Models.BackupRestoreBaseResultProperties"/> instance for mocking. </returns>
        public static BackupRestoreBaseResultProperties BackupRestoreBaseResultProperties(BackupRestoreOperationStatus? status = null, string statusDetails = null, ResponseError error = null, DateTimeOffset? startOn = null, DateTimeOffset? endOn = null, string jobId = null)
        {
            return new BackupRestoreBaseResultProperties(
                status,
                statusDetails,
                error,
                startOn,
                endOn,
                jobId,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CloudHsmClusterRestoreContent"/>. </summary>
        /// <param name="azureStorageBlobContainerUri"> The Azure blob storage container Uri which contains the backup. </param>
        /// <param name="token"> The SAS token pointing to an Azure blob storage container. This property is reserved for Azure Backup Service. </param>
        /// <param name="backupId"> An autogenerated unique string ID for labeling the backup. It contains both a UUID and a date timestamp. </param>
        /// <returns> A new <see cref="Models.CloudHsmClusterRestoreContent"/> instance for mocking. </returns>
        public static CloudHsmClusterRestoreContent CloudHsmClusterRestoreContent(Uri azureStorageBlobContainerUri = null, string token = null, string backupId = null)
        {
            return new CloudHsmClusterRestoreContent(azureStorageBlobContainerUri, token, serializedAdditionalRawData: null, backupId);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CloudHsmClusterRestoreResult"/>. </summary>
        /// <param name="properties"> Backup and Restore operation common properties. </param>
        /// <returns> A new <see cref="Models.CloudHsmClusterRestoreResult"/> instance for mocking. </returns>
        public static CloudHsmClusterRestoreResult CloudHsmClusterRestoreResult(BackupRestoreBaseResultProperties properties = null)
        {
            return new CloudHsmClusterRestoreResult(properties, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="HardwareSecurityModules.DedicatedHsmData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="skuName"> SKU details. </param>
        /// <param name="zones"> The Dedicated Hsm zones. </param>
        /// <param name="properties"> Properties of the dedicated HSM. </param>
        /// <returns> A new <see cref="HardwareSecurityModules.DedicatedHsmData"/> instance for mocking. </returns>
        public static DedicatedHsmData DedicatedHsmData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, DedicatedHsmSkuName? skuName = null, IEnumerable<string> zones = null, DedicatedHsmProperties properties = null)
        {
            tags ??= new Dictionary<string, string>();
            zones ??= new List<string>();

            return new DedicatedHsmData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                skuName != null ? new DedicatedHsmSku(skuName, serializedAdditionalRawData: null) : null,
                zones?.ToList(),
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DedicatedHsmProperties"/>. </summary>
        /// <param name="networkProfile"> Specifies the network interfaces of the dedicated hsm. </param>
        /// <param name="managementNetworkProfile"> Specifies the management network interfaces of the dedicated hsm. </param>
        /// <param name="stampId"> This field will be used when RP does not support Availability zones. </param>
        /// <param name="statusMessage"> Resource Status Message. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <returns> A new <see cref="Models.DedicatedHsmProperties"/> instance for mocking. </returns>
        public static DedicatedHsmProperties DedicatedHsmProperties(DedicatedHsmNetworkProfile networkProfile = null, DedicatedHsmNetworkProfile managementNetworkProfile = null, string stampId = null, string statusMessage = null, DedicatedHsmJsonWebKeyType? provisioningState = null)
        {
            return new DedicatedHsmProperties(
                networkProfile,
                managementNetworkProfile,
                stampId,
                statusMessage,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DedicatedHsmNetworkInterface"/>. </summary>
        /// <param name="resourceId"> The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/... </param>
        /// <param name="privateIPAddress"> Private Ip address of the interface. </param>
        /// <returns> A new <see cref="Models.DedicatedHsmNetworkInterface"/> instance for mocking. </returns>
        public static DedicatedHsmNetworkInterface DedicatedHsmNetworkInterface(ResourceIdentifier resourceId = null, string privateIPAddress = null)
        {
            return new DedicatedHsmNetworkInterface(resourceId, privateIPAddress, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DedicatedHsmEgressEndpoint"/>. </summary>
        /// <param name="category"> The category of endpoints accessed by the dedicated hsm service, e.g. azure-resource-management, apiserver, etc. </param>
        /// <param name="endpoints"> The endpoints that dedicated hsm service connects to. </param>
        /// <returns> A new <see cref="Models.DedicatedHsmEgressEndpoint"/> instance for mocking. </returns>
        public static DedicatedHsmEgressEndpoint DedicatedHsmEgressEndpoint(string category = null, IEnumerable<DedicatedHsmEndpointDependency> endpoints = null)
        {
            endpoints ??= new List<DedicatedHsmEndpointDependency>();

            return new DedicatedHsmEgressEndpoint(category, endpoints?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DedicatedHsmEndpointDependency"/>. </summary>
        /// <param name="domainName"> The domain name of the dependency. </param>
        /// <param name="endpointDetails"> The Ports and Protocols used when connecting to domainName. </param>
        /// <returns> A new <see cref="Models.DedicatedHsmEndpointDependency"/> instance for mocking. </returns>
        public static DedicatedHsmEndpointDependency DedicatedHsmEndpointDependency(string domainName = null, IEnumerable<DedicatedHsmEndpointDetail> endpointDetails = null)
        {
            endpointDetails ??= new List<DedicatedHsmEndpointDetail>();

            return new DedicatedHsmEndpointDependency(domainName, endpointDetails?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DedicatedHsmEndpointDetail"/>. </summary>
        /// <param name="ipAddress"> An IP Address that Domain Name currently resolves to. </param>
        /// <param name="port"> The port an endpoint is connected to. </param>
        /// <param name="protocol"> The protocol used for connection. </param>
        /// <param name="description"> Description of the detail. </param>
        /// <returns> A new <see cref="Models.DedicatedHsmEndpointDetail"/> instance for mocking. </returns>
        public static DedicatedHsmEndpointDetail DedicatedHsmEndpointDetail(string ipAddress = null, int? port = null, string protocol = null, string description = null)
        {
            return new DedicatedHsmEndpointDetail(ipAddress, port, protocol, description, serializedAdditionalRawData: null);
        }
    }
}
