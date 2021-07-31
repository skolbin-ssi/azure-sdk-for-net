// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Storage.Files.DataLake.Models
{
    /// <summary> The BlobHierarchyListSegment. </summary>
    internal partial class BlobHierarchyListSegment
    {
        /// <summary> Initializes a new instance of BlobHierarchyListSegment. </summary>
        /// <param name="blobItems"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="blobItems"/> is null. </exception>
        internal BlobHierarchyListSegment(IEnumerable<BlobItemInternal> blobItems)
        {
            if (blobItems == null)
            {
                throw new ArgumentNullException(nameof(blobItems));
            }

            BlobPrefixes = new ChangeTrackingList<BlobPrefix>();
            BlobItems = blobItems.ToList();
        }

        /// <summary> Initializes a new instance of BlobHierarchyListSegment. </summary>
        /// <param name="blobPrefixes"></param>
        /// <param name="blobItems"></param>
        internal BlobHierarchyListSegment(IReadOnlyList<BlobPrefix> blobPrefixes, IReadOnlyList<BlobItemInternal> blobItems)
        {
            BlobPrefixes = blobPrefixes;
            BlobItems = blobItems;
        }

        public IReadOnlyList<BlobPrefix> BlobPrefixes { get; }
        public IReadOnlyList<BlobItemInternal> BlobItems { get; }
    }
}
