// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Properties for HelmRelease objects. </summary>
    public partial class HelmReleaseProperties
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

        /// <summary> Initializes a new instance of <see cref="HelmReleaseProperties"/>. </summary>
        internal HelmReleaseProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HelmReleaseProperties"/>. </summary>
        /// <param name="lastRevisionApplied"> The revision number of the last released object change. </param>
        /// <param name="helmChartRef"> The reference to the HelmChart object used as the source to this HelmRelease. </param>
        /// <param name="failureCount"> Total number of times that the HelmRelease failed to install or upgrade. </param>
        /// <param name="installFailureCount"> Number of times that the HelmRelease failed to install. </param>
        /// <param name="upgradeFailureCount"> Number of times that the HelmRelease failed to upgrade. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HelmReleaseProperties(long? lastRevisionApplied, KubernetesObjectReference helmChartRef, long? failureCount, long? installFailureCount, long? upgradeFailureCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LastRevisionApplied = lastRevisionApplied;
            HelmChartRef = helmChartRef;
            FailureCount = failureCount;
            InstallFailureCount = installFailureCount;
            UpgradeFailureCount = upgradeFailureCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The revision number of the last released object change. </summary>
        [WirePath("lastRevisionApplied")]
        public long? LastRevisionApplied { get; }
        /// <summary> The reference to the HelmChart object used as the source to this HelmRelease. </summary>
        [WirePath("helmChartRef")]
        public KubernetesObjectReference HelmChartRef { get; }
        /// <summary> Total number of times that the HelmRelease failed to install or upgrade. </summary>
        [WirePath("failureCount")]
        public long? FailureCount { get; }
        /// <summary> Number of times that the HelmRelease failed to install. </summary>
        [WirePath("installFailureCount")]
        public long? InstallFailureCount { get; }
        /// <summary> Number of times that the HelmRelease failed to upgrade. </summary>
        [WirePath("upgradeFailureCount")]
        public long? UpgradeFailureCount { get; }
    }
}
