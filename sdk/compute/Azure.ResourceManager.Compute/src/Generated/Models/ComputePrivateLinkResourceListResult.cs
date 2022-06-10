// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> A list of private link resources. </summary>
    internal partial class ComputePrivateLinkResourceListResult
    {
        /// <summary> Initializes a new instance of ComputePrivateLinkResourceListResult. </summary>
        internal ComputePrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<PrivateLinkResourceData>();
        }

        /// <summary> Initializes a new instance of ComputePrivateLinkResourceListResult. </summary>
        /// <param name="value"> Array of private link resources. </param>
        internal ComputePrivateLinkResourceListResult(IReadOnlyList<PrivateLinkResourceData> value)
        {
            Value = value;
        }

        /// <summary> Array of private link resources. </summary>
        public IReadOnlyList<PrivateLinkResourceData> Value { get; }
    }
}
