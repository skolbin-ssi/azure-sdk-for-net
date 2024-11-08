// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.OperationalInsights.Models;

namespace Azure.ResourceManager.OperationalInsights
{
    /// <summary>
    /// A class representing the LogAnalyticsQuery data model.
    /// A Log Analytics QueryPack-Query definition.
    /// </summary>
    public partial class LogAnalyticsQueryData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="LogAnalyticsQueryData"/>. </summary>
        public LogAnalyticsQueryData()
        {
            Tags = new ChangeTrackingDictionary<string, IList<string>>();
        }

        /// <summary> Initializes a new instance of <see cref="LogAnalyticsQueryData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="applicationId"> The unique ID of your application. This field cannot be changed. </param>
        /// <param name="displayName"> Unique display name for your query within the Query Pack. </param>
        /// <param name="createdOn"> Creation Date for the Log Analytics Query, in ISO 8601 format. </param>
        /// <param name="modifiedOn"> Last modified date of the Log Analytics Query, in ISO 8601 format. </param>
        /// <param name="author"> Object Id of user creating the query. </param>
        /// <param name="description"> Description of the query. </param>
        /// <param name="body"> Body of the query. </param>
        /// <param name="related"> The related metadata items for the function. </param>
        /// <param name="tags"> Tags associated with the query. </param>
        /// <param name="properties"> Additional properties that can be set for the query. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LogAnalyticsQueryData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Guid? applicationId, string displayName, DateTimeOffset? createdOn, DateTimeOffset? modifiedOn, string author, string description, string body, LogAnalyticsQueryRelatedMetadata related, IDictionary<string, IList<string>> tags, BinaryData properties, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ApplicationId = applicationId;
            DisplayName = displayName;
            CreatedOn = createdOn;
            ModifiedOn = modifiedOn;
            Author = author;
            Description = description;
            Body = body;
            Related = related;
            Tags = tags;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The unique ID of your application. This field cannot be changed. </summary>
        [WirePath("properties.id")]
        public Guid? ApplicationId { get; }
        /// <summary> Unique display name for your query within the Query Pack. </summary>
        [WirePath("properties.displayName")]
        public string DisplayName { get; set; }
        /// <summary> Creation Date for the Log Analytics Query, in ISO 8601 format. </summary>
        [WirePath("properties.timeCreated")]
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Last modified date of the Log Analytics Query, in ISO 8601 format. </summary>
        [WirePath("properties.timeModified")]
        public DateTimeOffset? ModifiedOn { get; }
        /// <summary> Object Id of user creating the query. </summary>
        [WirePath("properties.author")]
        public string Author { get; }
        /// <summary> Description of the query. </summary>
        [WirePath("properties.description")]
        public string Description { get; set; }
        /// <summary> Body of the query. </summary>
        [WirePath("properties.body")]
        public string Body { get; set; }
        /// <summary> The related metadata items for the function. </summary>
        [WirePath("properties.related")]
        public LogAnalyticsQueryRelatedMetadata Related { get; set; }
        /// <summary> Tags associated with the query. </summary>
        [WirePath("properties.tags")]
        public IDictionary<string, IList<string>> Tags { get; }
        /// <summary>
        /// Additional properties that can be set for the query.
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
        [WirePath("properties.properties")]
        public BinaryData Properties { get; set; }
    }
}
