// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A copy activity Azure SQL Managed Instance sink. </summary>
    public partial class SqlMISink : CopySink
    {
        /// <summary> Initializes a new instance of <see cref="SqlMISink"/>. </summary>
        public SqlMISink()
        {
            CopySinkType = "SqlMISink";
        }

        /// <summary> Initializes a new instance of <see cref="SqlMISink"/>. </summary>
        /// <param name="copySinkType"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="sqlWriterStoredProcedureName"> SQL writer stored procedure name. Type: string (or Expression with resultType string). </param>
        /// <param name="sqlWriterTableType"> SQL writer table type. Type: string (or Expression with resultType string). </param>
        /// <param name="preCopyScript"> SQL pre-copy script. Type: string (or Expression with resultType string). </param>
        /// <param name="storedProcedureParameters"> SQL stored procedure parameters. </param>
        /// <param name="storedProcedureTableTypeParameterName"> The stored procedure parameter name of the table type. Type: string (or Expression with resultType string). </param>
        /// <param name="tableOption"> The option to handle sink table, such as autoCreate. For now only 'autoCreate' value is supported. Type: string (or Expression with resultType string). </param>
        /// <param name="sqlWriterUseTableLock"> Whether to use table lock during bulk copy. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="writeBehavior"> White behavior when copying data into azure SQL MI. Type: string (or Expression with resultType string). </param>
        /// <param name="upsertSettings"> SQL upsert settings. </param>
        internal SqlMISink(string copySinkType, DataFactoryElement<int> writeBatchSize, DataFactoryElement<string> writeBatchTimeout, DataFactoryElement<int> sinkRetryCount, DataFactoryElement<string> sinkRetryWait, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> sqlWriterStoredProcedureName, DataFactoryElement<string> sqlWriterTableType, DataFactoryElement<string> preCopyScript, BinaryData storedProcedureParameters, DataFactoryElement<string> storedProcedureTableTypeParameterName, DataFactoryElement<string> tableOption, DataFactoryElement<bool> sqlWriterUseTableLock, DataFactoryElement<string> writeBehavior, SqlUpsertSettings upsertSettings) : base(copySinkType, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            SqlWriterStoredProcedureName = sqlWriterStoredProcedureName;
            SqlWriterTableType = sqlWriterTableType;
            PreCopyScript = preCopyScript;
            StoredProcedureParameters = storedProcedureParameters;
            StoredProcedureTableTypeParameterName = storedProcedureTableTypeParameterName;
            TableOption = tableOption;
            SqlWriterUseTableLock = sqlWriterUseTableLock;
            WriteBehavior = writeBehavior;
            UpsertSettings = upsertSettings;
            CopySinkType = copySinkType ?? "SqlMISink";
        }

        /// <summary> SQL writer stored procedure name. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SqlWriterStoredProcedureName { get; set; }
        /// <summary> SQL writer table type. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SqlWriterTableType { get; set; }
        /// <summary> SQL pre-copy script. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> PreCopyScript { get; set; }
        /// <summary>
        /// SQL stored procedure parameters.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData StoredProcedureParameters { get; set; }
        /// <summary> The stored procedure parameter name of the table type. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> StoredProcedureTableTypeParameterName { get; set; }
        /// <summary> The option to handle sink table, such as autoCreate. For now only 'autoCreate' value is supported. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> TableOption { get; set; }
        /// <summary> Whether to use table lock during bulk copy. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> SqlWriterUseTableLock { get; set; }
        /// <summary> White behavior when copying data into azure SQL MI. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> WriteBehavior { get; set; }
        /// <summary> SQL upsert settings. </summary>
        public SqlUpsertSettings UpsertSettings { get; set; }
    }
}
