// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CognitiveServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CognitiveServices
{
    /// <summary>
    /// A class representing the CommitmentPlan data model.
    /// Cognitive Services account commitment plan.
    /// </summary>
    public partial class CommitmentPlanData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="CommitmentPlanData"/>. </summary>
        public CommitmentPlanData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="CommitmentPlanData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="kind"> The Kind of the resource. </param>
        /// <param name="sku"> The resource model definition representing SKU. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="properties"> Properties of Cognitive Services account commitment plan. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CommitmentPlanData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, string kind, CognitiveServicesSku sku, IDictionary<string, string> tags, AzureLocation? location, CommitmentPlanProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ETag = etag;
            Kind = kind;
            Sku = sku;
            Tags = tags;
            Location = location;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource Etag. </summary>
        [WirePath("etag")]
        public ETag? ETag { get; }
        /// <summary> The Kind of the resource. </summary>
        [WirePath("kind")]
        public string Kind { get; set; }
        /// <summary> The resource model definition representing SKU. </summary>
        [WirePath("sku")]
        public CognitiveServicesSku Sku { get; set; }
        /// <summary> Resource tags. </summary>
        [WirePath("tags")]
        public IDictionary<string, string> Tags { get; }
        /// <summary> The geo-location where the resource lives. </summary>
        [WirePath("location")]
        public AzureLocation? Location { get; set; }
        /// <summary> Properties of Cognitive Services account commitment plan. </summary>
        [WirePath("properties")]
        public CommitmentPlanProperties Properties { get; set; }
    }
}
