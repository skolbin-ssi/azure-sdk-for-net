// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.ChatThreadWithUserDeleted event. </summary>
    public partial class AcsChatThreadWithUserDeletedEventData : AcsChatThreadEventBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="AcsChatThreadWithUserDeletedEventData"/>. </summary>
        internal AcsChatThreadWithUserDeletedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AcsChatThreadWithUserDeletedEventData"/>. </summary>
        /// <param name="recipientCommunicationIdentifier"> The communication identifier of the target user. </param>
        /// <param name="transactionId"> The transaction id will be used as co-relation vector. </param>
        /// <param name="threadId"> The chat thread id. </param>
        /// <param name="createTime"> The original creation time of the thread. </param>
        /// <param name="version"> The version of the thread. </param>
        /// <param name="deletedByCommunicationIdentifier"> The communication identifier of the user who deleted the thread. </param>
        /// <param name="deleteTime"> The deletion time of the thread. </param>
        internal AcsChatThreadWithUserDeletedEventData(CommunicationIdentifierModel recipientCommunicationIdentifier, string transactionId, string threadId, DateTimeOffset? createTime, long? version, CommunicationIdentifierModel deletedByCommunicationIdentifier, DateTimeOffset? deleteTime) : base(recipientCommunicationIdentifier, transactionId, threadId, createTime, version)
        {
            DeletedByCommunicationIdentifier = deletedByCommunicationIdentifier;
            DeleteTime = deleteTime;
        }

        /// <summary> The communication identifier of the user who deleted the thread. </summary>
        public CommunicationIdentifierModel DeletedByCommunicationIdentifier { get; }
        /// <summary> The deletion time of the thread. </summary>
        public DateTimeOffset? DeleteTime { get; }
    }
}
