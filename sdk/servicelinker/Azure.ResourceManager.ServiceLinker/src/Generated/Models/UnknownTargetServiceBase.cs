// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> Unknown version of TargetServiceBase. </summary>
    internal partial class UnknownTargetServiceBase : TargetServiceBaseInfo
    {
        /// <summary> Initializes a new instance of <see cref="UnknownTargetServiceBase"/>. </summary>
        /// <param name="targetServiceType"> The target service type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownTargetServiceBase(TargetServiceType targetServiceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(targetServiceType, serializedAdditionalRawData)
        {
            TargetServiceType = targetServiceType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownTargetServiceBase"/> for deserialization. </summary>
        internal UnknownTargetServiceBase()
        {
        }
    }
}
