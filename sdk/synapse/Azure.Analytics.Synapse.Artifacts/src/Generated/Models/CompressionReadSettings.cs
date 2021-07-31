// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Compression read settings. </summary>
    public partial class CompressionReadSettings
    {
        /// <summary> Initializes a new instance of CompressionReadSettings. </summary>
        public CompressionReadSettings()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
            Type = "CompressionReadSettings";
        }

        /// <summary> Initializes a new instance of CompressionReadSettings. </summary>
        /// <param name="type"> The Compression setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal CompressionReadSettings(string type, IDictionary<string, object> additionalProperties)
        {
            Type = type ?? "CompressionReadSettings";
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The Compression setting type. </summary>
        internal string Type { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
