// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> The DataLakeStoreAccountCreateOrUpdateContent. </summary>
    public partial class DataLakeStoreAccountCreateOrUpdateContent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreAccountCreateOrUpdateContent"/>. </summary>
        /// <param name="location"> The resource location. </param>
        public DataLakeStoreAccountCreateOrUpdateContent(AzureLocation location)
        {
            Location = location;
            Tags = new ChangeTrackingDictionary<string, string>();
            FirewallRules = new ChangeTrackingList<FirewallRuleForDataLakeStoreAccountCreateOrUpdateContent>();
            VirtualNetworkRules = new ChangeTrackingList<VirtualNetworkRuleForDataLakeStoreAccountCreateOrUpdateContent>();
            TrustedIdProviders = new ChangeTrackingList<TrustedIdProviderForDataLakeStoreAccountCreateOrUpdateContent>();
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreAccountCreateOrUpdateContent"/>. </summary>
        /// <param name="location"> The resource location. </param>
        /// <param name="tags"> The resource tags. </param>
        /// <param name="identity"> The Key Vault encryption identity, if any. Current supported identity types: SystemAssigned. </param>
        /// <param name="defaultGroup"> The default owner group for all new folders and files created in the Data Lake Store account. </param>
        /// <param name="encryptionConfig"> The Key Vault encryption configuration. </param>
        /// <param name="encryptionState"> The current state of encryption for this Data Lake Store account. </param>
        /// <param name="firewallRules"> The list of firewall rules associated with this Data Lake Store account. </param>
        /// <param name="virtualNetworkRules"> The list of virtual network rules associated with this Data Lake Store account. </param>
        /// <param name="firewallState"> The current state of the IP address firewall for this Data Lake Store account. </param>
        /// <param name="firewallAllowAzureIPs"> The current state of allowing or disallowing IPs originating within Azure through the firewall. If the firewall is disabled, this is not enforced. </param>
        /// <param name="trustedIdProviders"> The list of trusted identity providers associated with this Data Lake Store account. </param>
        /// <param name="trustedIdProviderState"> The current state of the trusted identity provider feature for this Data Lake Store account. </param>
        /// <param name="newTier"> The commitment tier to use for next month. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeStoreAccountCreateOrUpdateContent(AzureLocation location, IDictionary<string, string> tags, ManagedServiceIdentity identity, string defaultGroup, DataLakeStoreAccountEncryptionConfig encryptionConfig, DataLakeStoreEncryptionState? encryptionState, IList<FirewallRuleForDataLakeStoreAccountCreateOrUpdateContent> firewallRules, IList<VirtualNetworkRuleForDataLakeStoreAccountCreateOrUpdateContent> virtualNetworkRules, DataLakeStoreFirewallState? firewallState, DataLakeStoreFirewallAllowAzureIPsState? firewallAllowAzureIPs, IList<TrustedIdProviderForDataLakeStoreAccountCreateOrUpdateContent> trustedIdProviders, DataLakeStoreTrustedIdProviderState? trustedIdProviderState, DataLakeStoreCommitmentTierType? newTier, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Location = location;
            Tags = tags;
            Identity = identity;
            DefaultGroup = defaultGroup;
            EncryptionConfig = encryptionConfig;
            EncryptionState = encryptionState;
            FirewallRules = firewallRules;
            VirtualNetworkRules = virtualNetworkRules;
            FirewallState = firewallState;
            FirewallAllowAzureIPs = firewallAllowAzureIPs;
            TrustedIdProviders = trustedIdProviders;
            TrustedIdProviderState = trustedIdProviderState;
            NewTier = newTier;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreAccountCreateOrUpdateContent"/> for deserialization. </summary>
        internal DataLakeStoreAccountCreateOrUpdateContent()
        {
        }

        /// <summary> The resource location. </summary>
        public AzureLocation Location { get; }
        /// <summary> The resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The Key Vault encryption identity, if any. Current supported identity types: SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The default owner group for all new folders and files created in the Data Lake Store account. </summary>
        public string DefaultGroup { get; set; }
        /// <summary> The Key Vault encryption configuration. </summary>
        public DataLakeStoreAccountEncryptionConfig EncryptionConfig { get; set; }
        /// <summary> The current state of encryption for this Data Lake Store account. </summary>
        public DataLakeStoreEncryptionState? EncryptionState { get; set; }
        /// <summary> The list of firewall rules associated with this Data Lake Store account. </summary>
        public IList<FirewallRuleForDataLakeStoreAccountCreateOrUpdateContent> FirewallRules { get; }
        /// <summary> The list of virtual network rules associated with this Data Lake Store account. </summary>
        public IList<VirtualNetworkRuleForDataLakeStoreAccountCreateOrUpdateContent> VirtualNetworkRules { get; }
        /// <summary> The current state of the IP address firewall for this Data Lake Store account. </summary>
        public DataLakeStoreFirewallState? FirewallState { get; set; }
        /// <summary> The current state of allowing or disallowing IPs originating within Azure through the firewall. If the firewall is disabled, this is not enforced. </summary>
        public DataLakeStoreFirewallAllowAzureIPsState? FirewallAllowAzureIPs { get; set; }
        /// <summary> The list of trusted identity providers associated with this Data Lake Store account. </summary>
        public IList<TrustedIdProviderForDataLakeStoreAccountCreateOrUpdateContent> TrustedIdProviders { get; }
        /// <summary> The current state of the trusted identity provider feature for this Data Lake Store account. </summary>
        public DataLakeStoreTrustedIdProviderState? TrustedIdProviderState { get; set; }
        /// <summary> The commitment tier to use for next month. </summary>
        public DataLakeStoreCommitmentTierType? NewTier { get; set; }
    }
}
