// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Azure storage specific error information. </summary>
    public partial class WorkloadErrorInfo
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

        /// <summary> Initializes a new instance of <see cref="WorkloadErrorInfo"/>. </summary>
        public WorkloadErrorInfo()
        {
            Recommendations = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadErrorInfo"/>. </summary>
        /// <param name="errorCode"> Error code. </param>
        /// <param name="errorString"> Localized error string. </param>
        /// <param name="errorTitle"> Title: Typically, the entity that the error pertains to. </param>
        /// <param name="recommendations"> List of localized recommendations for above error code. </param>
        /// <param name="additionalDetails"> Additional details for above error code. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkloadErrorInfo(int? errorCode, string errorString, string errorTitle, IList<string> recommendations, string additionalDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ErrorCode = errorCode;
            ErrorString = errorString;
            ErrorTitle = errorTitle;
            Recommendations = recommendations;
            AdditionalDetails = additionalDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Error code. </summary>
        public int? ErrorCode { get; set; }
        /// <summary> Localized error string. </summary>
        public string ErrorString { get; set; }
        /// <summary> Title: Typically, the entity that the error pertains to. </summary>
        public string ErrorTitle { get; set; }
        /// <summary> List of localized recommendations for above error code. </summary>
        public IList<string> Recommendations { get; }
        /// <summary> Additional details for above error code. </summary>
        public string AdditionalDetails { get; set; }
    }
}
