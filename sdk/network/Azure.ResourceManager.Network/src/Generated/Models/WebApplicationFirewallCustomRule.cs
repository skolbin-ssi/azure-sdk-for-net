// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Defines contents of a web application rule. </summary>
    public partial class WebApplicationFirewallCustomRule
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

        /// <summary> Initializes a new instance of <see cref="WebApplicationFirewallCustomRule"/>. </summary>
        /// <param name="priority"> Priority of the rule. Rules with a lower value will be evaluated before rules with a higher value. </param>
        /// <param name="ruleType"> The rule type. </param>
        /// <param name="matchConditions"> List of match conditions. </param>
        /// <param name="action"> Type of Actions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="matchConditions"/> is null. </exception>
        public WebApplicationFirewallCustomRule(int priority, WebApplicationFirewallRuleType ruleType, IEnumerable<MatchCondition> matchConditions, WebApplicationFirewallAction action)
        {
            Argument.AssertNotNull(matchConditions, nameof(matchConditions));

            Priority = priority;
            RuleType = ruleType;
            MatchConditions = matchConditions.ToList();
            GroupByUserSession = new ChangeTrackingList<GroupByUserSession>();
            Action = action;
        }

        /// <summary> Initializes a new instance of <see cref="WebApplicationFirewallCustomRule"/>. </summary>
        /// <param name="name"> The name of the resource that is unique within a policy. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="priority"> Priority of the rule. Rules with a lower value will be evaluated before rules with a higher value. </param>
        /// <param name="state"> Describes if the custom rule is in enabled or disabled state. Defaults to Enabled if not specified. </param>
        /// <param name="rateLimitDuration"> Duration over which Rate Limit policy will be applied. Applies only when ruleType is RateLimitRule. </param>
        /// <param name="rateLimitThreshold"> Rate Limit threshold to apply in case ruleType is RateLimitRule. Must be greater than or equal to 1. </param>
        /// <param name="ruleType"> The rule type. </param>
        /// <param name="matchConditions"> List of match conditions. </param>
        /// <param name="groupByUserSession"> List of user session identifier group by clauses. </param>
        /// <param name="action"> Type of Actions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WebApplicationFirewallCustomRule(string name, ETag? etag, int priority, WebApplicationFirewallState? state, ApplicationGatewayFirewallRateLimitDuration? rateLimitDuration, int? rateLimitThreshold, WebApplicationFirewallRuleType ruleType, IList<MatchCondition> matchConditions, IList<GroupByUserSession> groupByUserSession, WebApplicationFirewallAction action, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ETag = etag;
            Priority = priority;
            State = state;
            RateLimitDuration = rateLimitDuration;
            RateLimitThreshold = rateLimitThreshold;
            RuleType = ruleType;
            MatchConditions = matchConditions;
            GroupByUserSession = groupByUserSession;
            Action = action;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="WebApplicationFirewallCustomRule"/> for deserialization. </summary>
        internal WebApplicationFirewallCustomRule()
        {
        }

        /// <summary> The name of the resource that is unique within a policy. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Priority of the rule. Rules with a lower value will be evaluated before rules with a higher value. </summary>
        public int Priority { get; set; }
        /// <summary> Describes if the custom rule is in enabled or disabled state. Defaults to Enabled if not specified. </summary>
        public WebApplicationFirewallState? State { get; set; }
        /// <summary> Duration over which Rate Limit policy will be applied. Applies only when ruleType is RateLimitRule. </summary>
        public ApplicationGatewayFirewallRateLimitDuration? RateLimitDuration { get; set; }
        /// <summary> Rate Limit threshold to apply in case ruleType is RateLimitRule. Must be greater than or equal to 1. </summary>
        public int? RateLimitThreshold { get; set; }
        /// <summary> The rule type. </summary>
        public WebApplicationFirewallRuleType RuleType { get; set; }
        /// <summary> List of match conditions. </summary>
        public IList<MatchCondition> MatchConditions { get; }
        /// <summary> List of user session identifier group by clauses. </summary>
        public IList<GroupByUserSession> GroupByUserSession { get; }
        /// <summary> Type of Actions. </summary>
        public WebApplicationFirewallAction Action { get; set; }
    }
}
