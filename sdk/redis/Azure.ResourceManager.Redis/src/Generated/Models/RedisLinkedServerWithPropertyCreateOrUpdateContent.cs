// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> Parameter required for creating a linked server to redis cache. </summary>
    public partial class RedisLinkedServerWithPropertyCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="RedisLinkedServerWithPropertyCreateOrUpdateContent"/>. </summary>
        /// <param name="linkedRedisCacheId"> Fully qualified resourceId of the linked redis cache. </param>
        /// <param name="linkedRedisCacheLocation"> Location of the linked redis cache. </param>
        /// <param name="serverRole"> Role of the linked server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedRedisCacheId"/> is null. </exception>
        public RedisLinkedServerWithPropertyCreateOrUpdateContent(ResourceIdentifier linkedRedisCacheId, AzureLocation linkedRedisCacheLocation, RedisLinkedServerRole serverRole)
        {
            Argument.AssertNotNull(linkedRedisCacheId, nameof(linkedRedisCacheId));

            LinkedRedisCacheId = linkedRedisCacheId;
            LinkedRedisCacheLocation = linkedRedisCacheLocation;
            ServerRole = serverRole;
        }

        /// <summary> Initializes a new instance of <see cref="RedisLinkedServerWithPropertyCreateOrUpdateContent"/>. </summary>
        /// <param name="linkedRedisCacheId"> Fully qualified resourceId of the linked redis cache. </param>
        /// <param name="linkedRedisCacheLocation"> Location of the linked redis cache. </param>
        /// <param name="serverRole"> Role of the linked server. </param>
        /// <param name="geoReplicatedPrimaryHostName"> The unchanging DNS name which will always point to current geo-primary cache among the linked redis caches for seamless Geo Failover experience. </param>
        /// <param name="primaryHostName"> The changing DNS name that resolves to the current geo-primary cache among the linked redis caches before or after the Geo Failover. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisLinkedServerWithPropertyCreateOrUpdateContent(ResourceIdentifier linkedRedisCacheId, AzureLocation linkedRedisCacheLocation, RedisLinkedServerRole serverRole, string geoReplicatedPrimaryHostName, string primaryHostName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LinkedRedisCacheId = linkedRedisCacheId;
            LinkedRedisCacheLocation = linkedRedisCacheLocation;
            ServerRole = serverRole;
            GeoReplicatedPrimaryHostName = geoReplicatedPrimaryHostName;
            PrimaryHostName = primaryHostName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RedisLinkedServerWithPropertyCreateOrUpdateContent"/> for deserialization. </summary>
        internal RedisLinkedServerWithPropertyCreateOrUpdateContent()
        {
        }

        /// <summary> Fully qualified resourceId of the linked redis cache. </summary>
        [WirePath("properties.linkedRedisCacheId")]
        public ResourceIdentifier LinkedRedisCacheId { get; }
        /// <summary> Location of the linked redis cache. </summary>
        [WirePath("properties.linkedRedisCacheLocation")]
        public AzureLocation LinkedRedisCacheLocation { get; }
        /// <summary> Role of the linked server. </summary>
        [WirePath("properties.serverRole")]
        public RedisLinkedServerRole ServerRole { get; }
        /// <summary> The unchanging DNS name which will always point to current geo-primary cache among the linked redis caches for seamless Geo Failover experience. </summary>
        [WirePath("properties.geoReplicatedPrimaryHostName")]
        public string GeoReplicatedPrimaryHostName { get; }
        /// <summary> The changing DNS name that resolves to the current geo-primary cache among the linked redis caches before or after the Geo Failover. </summary>
        [WirePath("properties.primaryHostName")]
        public string PrimaryHostName { get; }
    }
}
