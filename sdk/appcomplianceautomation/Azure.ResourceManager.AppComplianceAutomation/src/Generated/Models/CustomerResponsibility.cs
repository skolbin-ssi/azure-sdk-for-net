// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> A class represent the customer responsibility. </summary>
    public partial class CustomerResponsibility
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

        /// <summary> Initializes a new instance of <see cref="CustomerResponsibility"/>. </summary>
        internal CustomerResponsibility()
        {
            ResourceList = new ChangeTrackingList<ResponsibilityResourceItem>();
            RecommendationList = new ChangeTrackingList<RecommendationDetails>();
            EvidenceFiles = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="CustomerResponsibility"/>. </summary>
        /// <param name="responsibilityId"> The id of the customer responsibility. </param>
        /// <param name="responsibilityTitle"> The title of the customer responsibility. </param>
        /// <param name="responsibilityDescription"> The description of the customer responsibility. </param>
        /// <param name="responsibilityType"> The type of customer responsibility. </param>
        /// <param name="responsibilitySeverity"> The severity level of this customer responsibility. </param>
        /// <param name="responsibilityStatus"> The status of this customer responsibility. </param>
        /// <param name="responsibilityEnvironment"> The supported cloud environment of this customer responsibility. </param>
        /// <param name="failedResourceCount"> The count of all failed resources. </param>
        /// <param name="totalResourceCount"> The count of all resources. </param>
        /// <param name="resourceList"> List of resource. </param>
        /// <param name="recommendationList"> List of recommendation. </param>
        /// <param name="guidance"> The evidence upload guidance description. </param>
        /// <param name="justification"> The justification given by the user to clarify the reason. </param>
        /// <param name="evidenceFiles"> List of evidence file url. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomerResponsibility(string responsibilityId, string responsibilityTitle, string responsibilityDescription, ResponsibilityType? responsibilityType, ResponsibilitySeverity? responsibilitySeverity, ResponsibilityStatus? responsibilityStatus, ResponsibilityEnvironment? responsibilityEnvironment, int? failedResourceCount, int? totalResourceCount, IReadOnlyList<ResponsibilityResourceItem> resourceList, IReadOnlyList<RecommendationDetails> recommendationList, string guidance, string justification, IReadOnlyList<string> evidenceFiles, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResponsibilityId = responsibilityId;
            ResponsibilityTitle = responsibilityTitle;
            ResponsibilityDescription = responsibilityDescription;
            ResponsibilityType = responsibilityType;
            ResponsibilitySeverity = responsibilitySeverity;
            ResponsibilityStatus = responsibilityStatus;
            ResponsibilityEnvironment = responsibilityEnvironment;
            FailedResourceCount = failedResourceCount;
            TotalResourceCount = totalResourceCount;
            ResourceList = resourceList;
            RecommendationList = recommendationList;
            Guidance = guidance;
            Justification = justification;
            EvidenceFiles = evidenceFiles;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The id of the customer responsibility. </summary>
        public string ResponsibilityId { get; }
        /// <summary> The title of the customer responsibility. </summary>
        public string ResponsibilityTitle { get; }
        /// <summary> The description of the customer responsibility. </summary>
        public string ResponsibilityDescription { get; }
        /// <summary> The type of customer responsibility. </summary>
        public ResponsibilityType? ResponsibilityType { get; }
        /// <summary> The severity level of this customer responsibility. </summary>
        public ResponsibilitySeverity? ResponsibilitySeverity { get; }
        /// <summary> The status of this customer responsibility. </summary>
        public ResponsibilityStatus? ResponsibilityStatus { get; }
        /// <summary> The supported cloud environment of this customer responsibility. </summary>
        public ResponsibilityEnvironment? ResponsibilityEnvironment { get; }
        /// <summary> The count of all failed resources. </summary>
        public int? FailedResourceCount { get; }
        /// <summary> The count of all resources. </summary>
        public int? TotalResourceCount { get; }
        /// <summary> List of resource. </summary>
        public IReadOnlyList<ResponsibilityResourceItem> ResourceList { get; }
        /// <summary> List of recommendation. </summary>
        public IReadOnlyList<RecommendationDetails> RecommendationList { get; }
        /// <summary> The evidence upload guidance description. </summary>
        public string Guidance { get; }
        /// <summary> The justification given by the user to clarify the reason. </summary>
        public string Justification { get; }
        /// <summary> List of evidence file url. </summary>
        public IReadOnlyList<string> EvidenceFiles { get; }
    }
}
