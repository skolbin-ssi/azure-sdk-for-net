// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Monitor.OpenTelemetry.AspNetCore.Models
{
    /// <summary> A metric configuration set by UX to scope the metrics it's interested in. </summary>
    internal partial class DerivedMetricInfo
    {
        /// <summary> Initializes a new instance of <see cref="DerivedMetricInfo"/>. </summary>
        /// <param name="id"> metric configuration identifier. </param>
        /// <param name="telemetryType"> Telemetry type. </param>
        /// <param name="filterGroups"> A collection of filters to scope metrics that UX needs. </param>
        /// <param name="projection"> Telemetry's metric dimension whose value is to be aggregated. Example values: Duration, Count(),... </param>
        /// <param name="aggregation"> Aggregation type. This is the aggregation done from everything within a single server. </param>
        /// <param name="backEndAggregation"> Aggregation type. This Aggregation is done across the values for all the servers taken together. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="telemetryType"/>, <paramref name="filterGroups"/> or <paramref name="projection"/> is null. </exception>
        internal DerivedMetricInfo(string id, string telemetryType, IEnumerable<FilterConjunctionGroupInfo> filterGroups, string projection, AggregationType aggregation, AggregationType backEndAggregation)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(telemetryType, nameof(telemetryType));
            Argument.AssertNotNull(filterGroups, nameof(filterGroups));
            Argument.AssertNotNull(projection, nameof(projection));

            Id = id;
            TelemetryType = telemetryType;
            FilterGroups = filterGroups.ToList();
            Projection = projection;
            Aggregation = aggregation;
            BackEndAggregation = backEndAggregation;
        }

        /// <summary> Initializes a new instance of <see cref="DerivedMetricInfo"/>. </summary>
        /// <param name="id"> metric configuration identifier. </param>
        /// <param name="telemetryType"> Telemetry type. </param>
        /// <param name="filterGroups"> A collection of filters to scope metrics that UX needs. </param>
        /// <param name="projection"> Telemetry's metric dimension whose value is to be aggregated. Example values: Duration, Count(),... </param>
        /// <param name="aggregation"> Aggregation type. This is the aggregation done from everything within a single server. </param>
        /// <param name="backEndAggregation"> Aggregation type. This Aggregation is done across the values for all the servers taken together. </param>
        internal DerivedMetricInfo(string id, string telemetryType, IReadOnlyList<FilterConjunctionGroupInfo> filterGroups, string projection, AggregationType aggregation, AggregationType backEndAggregation)
        {
            Id = id;
            TelemetryType = telemetryType;
            FilterGroups = filterGroups;
            Projection = projection;
            Aggregation = aggregation;
            BackEndAggregation = backEndAggregation;
        }

        /// <summary> metric configuration identifier. </summary>
        public string Id { get; }
        /// <summary> Telemetry type. </summary>
        public string TelemetryType { get; }
        /// <summary> A collection of filters to scope metrics that UX needs. </summary>
        public IReadOnlyList<FilterConjunctionGroupInfo> FilterGroups { get; }
        /// <summary> Telemetry's metric dimension whose value is to be aggregated. Example values: Duration, Count(),... </summary>
        public string Projection { get; }
        /// <summary> Aggregation type. This is the aggregation done from everything within a single server. </summary>
        public AggregationType Aggregation { get; }
        /// <summary> Aggregation type. This Aggregation is done across the values for all the servers taken together. </summary>
        public AggregationType BackEndAggregation { get; }
    }
}
