// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines rules that scrub sensitive fields in the Azure Front Door profile logs. </summary>
    public partial class ProfileLogScrubbing
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

        /// <summary> Initializes a new instance of <see cref="ProfileLogScrubbing"/>. </summary>
        public ProfileLogScrubbing()
        {
            ScrubbingRules = new ChangeTrackingList<ProfileScrubbingRules>();
        }

        /// <summary> Initializes a new instance of <see cref="ProfileLogScrubbing"/>. </summary>
        /// <param name="state"> State of the log scrubbing config. Default value is Enabled. </param>
        /// <param name="scrubbingRules"> List of log scrubbing rules applied to the Azure Front Door profile logs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProfileLogScrubbing(ProfileScrubbingState? state, IList<ProfileScrubbingRules> scrubbingRules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            State = state;
            ScrubbingRules = scrubbingRules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> State of the log scrubbing config. Default value is Enabled. </summary>
        public ProfileScrubbingState? State { get; set; }
        /// <summary> List of log scrubbing rules applied to the Azure Front Door profile logs. </summary>
        public IList<ProfileScrubbingRules> ScrubbingRules { get; }
    }
}
