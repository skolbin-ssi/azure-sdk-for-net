// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Server properties for MySQL type source. </summary>
    public partial class ServerProperties
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

        /// <summary> Initializes a new instance of <see cref="ServerProperties"/>. </summary>
        internal ServerProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServerProperties"/>. </summary>
        /// <param name="serverPlatform"> Name of the server platform. </param>
        /// <param name="serverName"> Name of the server. </param>
        /// <param name="serverVersion"> Version of the database server. </param>
        /// <param name="serverEdition"> Edition of the database server. </param>
        /// <param name="serverOperatingSystemVersion"> Version of the operating system. </param>
        /// <param name="serverDatabaseCount"> Number of databases in the server. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServerProperties(string serverPlatform, string serverName, string serverVersion, string serverEdition, string serverOperatingSystemVersion, int? serverDatabaseCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ServerPlatform = serverPlatform;
            ServerName = serverName;
            ServerVersion = serverVersion;
            ServerEdition = serverEdition;
            ServerOperatingSystemVersion = serverOperatingSystemVersion;
            ServerDatabaseCount = serverDatabaseCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the server platform. </summary>
        public string ServerPlatform { get; }
        /// <summary> Name of the server. </summary>
        public string ServerName { get; }
        /// <summary> Version of the database server. </summary>
        public string ServerVersion { get; }
        /// <summary> Edition of the database server. </summary>
        public string ServerEdition { get; }
        /// <summary> Version of the operating system. </summary>
        public string ServerOperatingSystemVersion { get; }
        /// <summary> Number of databases in the server. </summary>
        public int? ServerDatabaseCount { get; }
    }
}
