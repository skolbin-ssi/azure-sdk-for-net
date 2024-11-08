// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The Object used to describe a Service Provider supported by Bot Service. </summary>
    public partial class BotServiceProviderProperties
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

        /// <summary> Initializes a new instance of <see cref="BotServiceProviderProperties"/>. </summary>
        internal BotServiceProviderProperties()
        {
            Parameters = new ChangeTrackingList<BotServiceProviderParameter>();
        }

        /// <summary> Initializes a new instance of <see cref="BotServiceProviderProperties"/>. </summary>
        /// <param name="id"> Id for Service Provider. </param>
        /// <param name="displayName"> Display Name of the Service Provider. </param>
        /// <param name="serviceProviderName"> Name of the Service Provider. </param>
        /// <param name="devPortalUri"> URL of Dev Portal. </param>
        /// <param name="iconUri"> The URL of icon. </param>
        /// <param name="parameters"> The list of parameters for the Service Provider. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BotServiceProviderProperties(string id, string displayName, string serviceProviderName, Uri devPortalUri, Uri iconUri, IReadOnlyList<BotServiceProviderParameter> parameters, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            DisplayName = displayName;
            ServiceProviderName = serviceProviderName;
            DevPortalUri = devPortalUri;
            IconUri = iconUri;
            Parameters = parameters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Id for Service Provider. </summary>
        public string Id { get; }
        /// <summary> Display Name of the Service Provider. </summary>
        public string DisplayName { get; }
        /// <summary> Name of the Service Provider. </summary>
        public string ServiceProviderName { get; }
        /// <summary> URL of Dev Portal. </summary>
        public Uri DevPortalUri { get; }
        /// <summary> The URL of icon. </summary>
        public Uri IconUri { get; }
        /// <summary> The list of parameters for the Service Provider. </summary>
        public IReadOnlyList<BotServiceProviderParameter> Parameters { get; }
    }
}
