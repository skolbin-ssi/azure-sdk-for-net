// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Storage.Common;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> The list of file ranges. </summary>
    internal partial class ShareFileRangeList
    {
        /// <summary> Initializes a new instance of <see cref="ShareFileRangeList"/>. </summary>
        internal ShareFileRangeList()
        {
            Ranges = new ChangeTrackingList<FileRange>();
            ClearRanges = new ChangeTrackingList<ClearRange>();
        }

        /// <summary> Initializes a new instance of <see cref="ShareFileRangeList"/>. </summary>
        /// <param name="ranges"></param>
        /// <param name="clearRanges"></param>
        internal ShareFileRangeList(IReadOnlyList<FileRange> ranges, IReadOnlyList<ClearRange> clearRanges)
        {
            Ranges = ranges;
            ClearRanges = clearRanges;
        }

        /// <summary> Gets the ranges. </summary>
        public IReadOnlyList<FileRange> Ranges { get; }
        /// <summary> Gets the clear ranges. </summary>
        public IReadOnlyList<ClearRange> ClearRanges { get; }
    }
}
