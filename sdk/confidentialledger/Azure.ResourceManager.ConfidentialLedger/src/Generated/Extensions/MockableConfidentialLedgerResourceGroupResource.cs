// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ConfidentialLedger.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableConfidentialLedgerResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableConfidentialLedgerResourceGroupResource"/> class for mocking. </summary>
        protected MockableConfidentialLedgerResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableConfidentialLedgerResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableConfidentialLedgerResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ConfidentialLedgerResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ConfidentialLedgerResources and their operations over a ConfidentialLedgerResource. </returns>
        public virtual ConfidentialLedgerCollection GetConfidentialLedgers()
        {
            return GetCachedClient(client => new ConfidentialLedgerCollection(client, Id));
        }

        /// <summary>
        /// Retrieves the properties of a Confidential Ledger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/ledgers/{ledgerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Ledger_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-28-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConfidentialLedgerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ledgerName"> Name of the Confidential Ledger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ledgerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="ledgerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ConfidentialLedgerResource>> GetConfidentialLedgerAsync(string ledgerName, CancellationToken cancellationToken = default)
        {
            return await GetConfidentialLedgers().GetAsync(ledgerName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves the properties of a Confidential Ledger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/ledgers/{ledgerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Ledger_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-28-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConfidentialLedgerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ledgerName"> Name of the Confidential Ledger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ledgerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="ledgerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ConfidentialLedgerResource> GetConfidentialLedger(string ledgerName, CancellationToken cancellationToken = default)
        {
            return GetConfidentialLedgers().Get(ledgerName, cancellationToken);
        }

        /// <summary> Gets a collection of ManagedCcfResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ManagedCcfResources and their operations over a ManagedCcfResource. </returns>
        public virtual ManagedCcfCollection GetManagedCcfs()
        {
            return GetCachedClient(client => new ManagedCcfCollection(client, Id));
        }

        /// <summary>
        /// Retrieves the properties of a Managed CCF app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/managedCCFs/{appName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCCF_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-28-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedCcfResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appName"> Name of the Managed CCF. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="appName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ManagedCcfResource>> GetManagedCcfAsync(string appName, CancellationToken cancellationToken = default)
        {
            return await GetManagedCcfs().GetAsync(appName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves the properties of a Managed CCF app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/managedCCFs/{appName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCCF_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-28-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedCcfResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appName"> Name of the Managed CCF. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="appName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ManagedCcfResource> GetManagedCcf(string appName, CancellationToken cancellationToken = default)
        {
            return GetManagedCcfs().Get(appName, cancellationToken);
        }
    }
}
