// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Blob restore status. </summary>
    public partial class BlobRestoreStatus
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

        /// <summary> Initializes a new instance of <see cref="BlobRestoreStatus"/>. </summary>
        internal BlobRestoreStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BlobRestoreStatus"/>. </summary>
        /// <param name="status"> The status of blob restore progress. Possible values are: - InProgress: Indicates that blob restore is ongoing. - Complete: Indicates that blob restore has been completed successfully. - Failed: Indicates that blob restore is failed. </param>
        /// <param name="failureReason"> Failure reason when blob restore is failed. </param>
        /// <param name="restoreId"> Id for tracking blob restore request. </param>
        /// <param name="parameters"> Blob restore request parameters. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BlobRestoreStatus(BlobRestoreProgressStatus? status, string failureReason, string restoreId, BlobRestoreContent parameters, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            FailureReason = failureReason;
            RestoreId = restoreId;
            Parameters = parameters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The status of blob restore progress. Possible values are: - InProgress: Indicates that blob restore is ongoing. - Complete: Indicates that blob restore has been completed successfully. - Failed: Indicates that blob restore is failed. </summary>
        [WirePath("status")]
        public BlobRestoreProgressStatus? Status { get; }
        /// <summary> Failure reason when blob restore is failed. </summary>
        [WirePath("failureReason")]
        public string FailureReason { get; }
        /// <summary> Id for tracking blob restore request. </summary>
        [WirePath("restoreId")]
        public string RestoreId { get; }
        /// <summary> Blob restore request parameters. </summary>
        [WirePath("parameters")]
        public BlobRestoreContent Parameters { get; }
    }
}
