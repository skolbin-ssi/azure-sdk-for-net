// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ThrottlingMetric. </summary>
    public partial class ThrottlingMetric
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

        /// <summary> Initializes a new instance of <see cref="ThrottlingMetric"/>. </summary>
        /// <param name="metricType"></param>
        /// <param name="limit"></param>
        public ThrottlingMetric(ThrottlingMetricType metricType, long limit)
        {
            MetricType = metricType;
            Limit = limit;
        }

        /// <summary> Initializes a new instance of <see cref="ThrottlingMetric"/>. </summary>
        /// <param name="metricType"></param>
        /// <param name="limit"></param>
        /// <param name="interval"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ThrottlingMetric(ThrottlingMetricType metricType, long limit, TimeSpan? interval, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MetricType = metricType;
            Limit = limit;
            Interval = interval;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ThrottlingMetric"/> for deserialization. </summary>
        internal ThrottlingMetric()
        {
        }

        /// <summary> Gets or sets the metric type. </summary>
        public ThrottlingMetricType MetricType { get; set; }
        /// <summary> Gets or sets the limit. </summary>
        public long Limit { get; set; }
        /// <summary> Gets or sets the interval. </summary>
        public TimeSpan? Interval { get; set; }
    }
}
