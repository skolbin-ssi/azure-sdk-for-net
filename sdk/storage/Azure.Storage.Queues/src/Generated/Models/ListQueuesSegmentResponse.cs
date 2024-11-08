// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Storage.Common;

namespace Azure.Storage.Queues.Models
{
    /// <summary> The object returned when calling List Queues on a Queue Service. </summary>
    internal partial class ListQueuesSegmentResponse
    {
        /// <summary> Initializes a new instance of <see cref="ListQueuesSegmentResponse"/>. </summary>
        /// <param name="serviceEndpoint"></param>
        /// <param name="prefix"></param>
        /// <param name="maxResults"></param>
        /// <param name="nextMarker"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpoint"/>, <paramref name="prefix"/> or <paramref name="nextMarker"/> is null. </exception>
        internal ListQueuesSegmentResponse(string serviceEndpoint, string prefix, int maxResults, string nextMarker)
        {
            Argument.AssertNotNull(serviceEndpoint, nameof(serviceEndpoint));
            Argument.AssertNotNull(prefix, nameof(prefix));
            Argument.AssertNotNull(nextMarker, nameof(nextMarker));

            ServiceEndpoint = serviceEndpoint;
            Prefix = prefix;
            MaxResults = maxResults;
            QueueItems = new ChangeTrackingList<QueueItem>();
            NextMarker = nextMarker;
        }

        /// <summary> Initializes a new instance of <see cref="ListQueuesSegmentResponse"/>. </summary>
        /// <param name="serviceEndpoint"></param>
        /// <param name="prefix"></param>
        /// <param name="marker"></param>
        /// <param name="maxResults"></param>
        /// <param name="queueItems"></param>
        /// <param name="nextMarker"></param>
        internal ListQueuesSegmentResponse(string serviceEndpoint, string prefix, string marker, int maxResults, IReadOnlyList<QueueItem> queueItems, string nextMarker)
        {
            ServiceEndpoint = serviceEndpoint;
            Prefix = prefix;
            Marker = marker;
            MaxResults = maxResults;
            QueueItems = queueItems;
            NextMarker = nextMarker;
        }

        /// <summary> Gets the service endpoint. </summary>
        public string ServiceEndpoint { get; }
        /// <summary> Gets the prefix. </summary>
        public string Prefix { get; }
        /// <summary> Gets the marker. </summary>
        public string Marker { get; }
        /// <summary> Gets the max results. </summary>
        public int MaxResults { get; }
        /// <summary> Gets the queue items. </summary>
        public IReadOnlyList<QueueItem> QueueItems { get; }
        /// <summary> Gets the next marker. </summary>
        public string NextMarker { get; }
    }
}
