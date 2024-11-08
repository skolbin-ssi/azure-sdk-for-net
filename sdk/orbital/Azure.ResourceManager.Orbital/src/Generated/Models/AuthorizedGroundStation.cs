// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Orbital.Models
{
    /// <summary> Authorized groundstation. </summary>
    public partial class AuthorizedGroundStation
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

        /// <summary> Initializes a new instance of <see cref="AuthorizedGroundStation"/>. </summary>
        internal AuthorizedGroundStation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AuthorizedGroundStation"/>. </summary>
        /// <param name="groundStationName"> Groundstation name. </param>
        /// <param name="expireOn"> Date of authorization expiration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AuthorizedGroundStation(string groundStationName, DateTimeOffset? expireOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            GroundStationName = groundStationName;
            ExpireOn = expireOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Groundstation name. </summary>
        public string GroundStationName { get; }
        /// <summary> Date of authorization expiration. </summary>
        public DateTimeOffset? ExpireOn { get; }
    }
}
