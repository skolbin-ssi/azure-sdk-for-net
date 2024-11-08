// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> The details of a message created as a part of a run step. </summary>
    public partial class RunStepMessageCreationReference
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

        /// <summary> Initializes a new instance of <see cref="RunStepMessageCreationReference"/>. </summary>
        /// <param name="messageId"> The ID of the message created by this run step. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messageId"/> is null. </exception>
        internal RunStepMessageCreationReference(string messageId)
        {
            Argument.AssertNotNull(messageId, nameof(messageId));

            MessageId = messageId;
        }

        /// <summary> Initializes a new instance of <see cref="RunStepMessageCreationReference"/>. </summary>
        /// <param name="messageId"> The ID of the message created by this run step. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RunStepMessageCreationReference(string messageId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MessageId = messageId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RunStepMessageCreationReference"/> for deserialization. </summary>
        internal RunStepMessageCreationReference()
        {
        }

        /// <summary> The ID of the message created by this run step. </summary>
        public string MessageId { get; }
    }
}
