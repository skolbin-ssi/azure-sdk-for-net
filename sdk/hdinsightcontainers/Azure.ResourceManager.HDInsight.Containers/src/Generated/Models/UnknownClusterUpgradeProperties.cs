// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Unknown version of ClusterUpgradeProperties. </summary>
    internal partial class UnknownClusterUpgradeProperties : ClusterUpgradeProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownClusterUpgradeProperties"/>. </summary>
        /// <param name="upgradeType"> Type of upgrade. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownClusterUpgradeProperties(ClusterUpgradeType upgradeType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(upgradeType, serializedAdditionalRawData)
        {
            UpgradeType = upgradeType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownClusterUpgradeProperties"/> for deserialization. </summary>
        internal UnknownClusterUpgradeProperties()
        {
        }
    }
}
