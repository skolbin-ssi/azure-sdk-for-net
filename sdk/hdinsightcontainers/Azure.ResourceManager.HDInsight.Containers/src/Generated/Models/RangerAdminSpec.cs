// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Specification for the Ranger Admin service. </summary>
    public partial class RangerAdminSpec
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

        /// <summary> Initializes a new instance of <see cref="RangerAdminSpec"/>. </summary>
        /// <param name="admins"> List of usernames that should be marked as ranger admins. These usernames should match the user principal name (UPN) of the respective AAD users. </param>
        /// <param name="database"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="admins"/> or <paramref name="database"/> is null. </exception>
        public RangerAdminSpec(IEnumerable<string> admins, RangerAdminSpecDatabase database)
        {
            Argument.AssertNotNull(admins, nameof(admins));
            Argument.AssertNotNull(database, nameof(database));

            Admins = admins.ToList();
            Database = database;
        }

        /// <summary> Initializes a new instance of <see cref="RangerAdminSpec"/>. </summary>
        /// <param name="admins"> List of usernames that should be marked as ranger admins. These usernames should match the user principal name (UPN) of the respective AAD users. </param>
        /// <param name="database"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RangerAdminSpec(IList<string> admins, RangerAdminSpecDatabase database, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Admins = admins;
            Database = database;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RangerAdminSpec"/> for deserialization. </summary>
        internal RangerAdminSpec()
        {
        }

        /// <summary> List of usernames that should be marked as ranger admins. These usernames should match the user principal name (UPN) of the respective AAD users. </summary>
        [WirePath("admins")]
        public IList<string> Admins { get; }
        /// <summary> Gets or sets the database. </summary>
        [WirePath("database")]
        public RangerAdminSpecDatabase Database { get; set; }
    }
}
