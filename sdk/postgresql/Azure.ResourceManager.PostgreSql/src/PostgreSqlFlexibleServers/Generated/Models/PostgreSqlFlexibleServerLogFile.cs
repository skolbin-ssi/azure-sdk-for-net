// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Represents a logFile. </summary>
    public partial class PostgreSqlFlexibleServerLogFile : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerLogFile"/>. </summary>
        public PostgreSqlFlexibleServerLogFile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerLogFile"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="createdOn"> Creation timestamp of the log file. </param>
        /// <param name="lastModifiedOn"> Last modified timestamp of the log file. </param>
        /// <param name="sizeInKb"> The size in kb of the logFile. </param>
        /// <param name="typePropertiesType"> Type of the log file. </param>
        /// <param name="uri"> The url to download the log file from. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlFlexibleServerLogFile(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn, long? sizeInKb, string typePropertiesType, Uri uri, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            SizeInKb = sizeInKb;
            TypePropertiesType = typePropertiesType;
            Uri = uri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Creation timestamp of the log file. </summary>
        [WirePath("properties.createdTime")]
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> Last modified timestamp of the log file. </summary>
        [WirePath("properties.lastModifiedTime")]
        public DateTimeOffset? LastModifiedOn { get; set; }
        /// <summary> The size in kb of the logFile. </summary>
        [WirePath("properties.sizeInKb")]
        public long? SizeInKb { get; set; }
        /// <summary> Type of the log file. </summary>
        [WirePath("properties.type")]
        public string TypePropertiesType { get; set; }
        /// <summary> The url to download the log file from. </summary>
        [WirePath("properties.url")]
        public Uri Uri { get; set; }
    }
}
