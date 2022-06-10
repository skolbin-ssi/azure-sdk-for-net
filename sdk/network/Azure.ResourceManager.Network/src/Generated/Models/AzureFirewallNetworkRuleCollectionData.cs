// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Network rule collection resource. </summary>
    public partial class AzureFirewallNetworkRuleCollectionData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of AzureFirewallNetworkRuleCollectionData. </summary>
        public AzureFirewallNetworkRuleCollectionData()
        {
            Rules = new ChangeTrackingList<AzureFirewallNetworkRule>();
        }

        /// <summary> Initializes a new instance of AzureFirewallNetworkRuleCollectionData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="priority"> Priority of the network rule collection resource. </param>
        /// <param name="action"> The action type of a rule collection. </param>
        /// <param name="rules"> Collection of rules used by a network rule collection. </param>
        /// <param name="provisioningState"> The provisioning state of the network rule collection resource. </param>
        internal AzureFirewallNetworkRuleCollectionData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, int? priority, AzureFirewallRCAction action, IList<AzureFirewallNetworkRule> rules, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            Etag = etag;
            Priority = priority;
            Action = action;
            Rules = rules;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? Etag { get; }
        /// <summary> Priority of the network rule collection resource. </summary>
        public int? Priority { get; set; }
        /// <summary> The action type of a rule collection. </summary>
        internal AzureFirewallRCAction Action { get; set; }
        /// <summary> The type of action. </summary>
        public AzureFirewallRCActionType? ActionType
        {
            get => Action is null ? default : Action.ActionType;
            set
            {
                if (Action is null)
                    Action = new AzureFirewallRCAction();
                Action.ActionType = value;
            }
        }

        /// <summary> Collection of rules used by a network rule collection. </summary>
        public IList<AzureFirewallNetworkRule> Rules { get; }
        /// <summary> The provisioning state of the network rule collection resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
