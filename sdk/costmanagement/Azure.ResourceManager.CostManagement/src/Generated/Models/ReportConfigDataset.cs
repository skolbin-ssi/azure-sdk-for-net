// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The definition of data present in the report. </summary>
    public partial class ReportConfigDataset
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

        /// <summary> Initializes a new instance of <see cref="ReportConfigDataset"/>. </summary>
        public ReportConfigDataset()
        {
            Aggregation = new ChangeTrackingDictionary<string, ReportConfigAggregation>();
            Grouping = new ChangeTrackingList<ReportConfigGrouping>();
            Sorting = new ChangeTrackingList<ReportConfigSorting>();
        }

        /// <summary> Initializes a new instance of <see cref="ReportConfigDataset"/>. </summary>
        /// <param name="granularity"> The granularity of rows in the report. </param>
        /// <param name="configuration"> Has configuration information for the data in the report. The configuration will be ignored if aggregation and grouping are provided. </param>
        /// <param name="aggregation"> Dictionary of aggregation expression to use in the report. The key of each item in the dictionary is the alias for the aggregated column. Report can have up to 2 aggregation clauses. </param>
        /// <param name="grouping"> Array of group by expression to use in the report. Report can have up to 2 group by clauses. </param>
        /// <param name="sorting"> Array of order by expression to use in the report. </param>
        /// <param name="filter"> Has filter expression to use in the report. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReportConfigDataset(ReportGranularityType? granularity, ReportConfigDatasetConfiguration configuration, IDictionary<string, ReportConfigAggregation> aggregation, IList<ReportConfigGrouping> grouping, IList<ReportConfigSorting> sorting, ReportConfigFilter filter, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Granularity = granularity;
            Configuration = configuration;
            Aggregation = aggregation;
            Grouping = grouping;
            Sorting = sorting;
            Filter = filter;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The granularity of rows in the report. </summary>
        public ReportGranularityType? Granularity { get; set; }
        /// <summary> Has configuration information for the data in the report. The configuration will be ignored if aggregation and grouping are provided. </summary>
        internal ReportConfigDatasetConfiguration Configuration { get; set; }
        /// <summary> Array of column names to be included in the report. Any valid report column name is allowed. If not provided, then report includes all columns. </summary>
        public IList<string> Columns
        {
            get
            {
                if (Configuration is null)
                    Configuration = new ReportConfigDatasetConfiguration();
                return Configuration.Columns;
            }
        }

        /// <summary> Dictionary of aggregation expression to use in the report. The key of each item in the dictionary is the alias for the aggregated column. Report can have up to 2 aggregation clauses. </summary>
        public IDictionary<string, ReportConfigAggregation> Aggregation { get; }
        /// <summary> Array of group by expression to use in the report. Report can have up to 2 group by clauses. </summary>
        public IList<ReportConfigGrouping> Grouping { get; }
        /// <summary> Array of order by expression to use in the report. </summary>
        public IList<ReportConfigSorting> Sorting { get; }
        /// <summary> Has filter expression to use in the report. </summary>
        public ReportConfigFilter Filter { get; set; }
    }
}
