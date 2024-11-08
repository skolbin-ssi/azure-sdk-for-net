// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Azure virtual network function template. </summary>
    public partial class AzureCoreNetworkFunctionTemplate : VirtualNetworkFunctionTemplate
    {
        /// <summary> Initializes a new instance of <see cref="AzureCoreNetworkFunctionTemplate"/>. </summary>
        public AzureCoreNetworkFunctionTemplate()
        {
            NetworkFunctionApplications = new ChangeTrackingList<AzureCoreNetworkFunctionApplication>();
            NfviType = VirtualNetworkFunctionNfviType.AzureCore;
        }

        /// <summary> Initializes a new instance of <see cref="AzureCoreNetworkFunctionTemplate"/>. </summary>
        /// <param name="nfviType"> The network function type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="networkFunctionApplications">
        /// Network function applications.
        /// Please note <see cref="AzureCoreNetworkFunctionApplication"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureCoreNetworkFunctionArmTemplateApplication"/> and <see cref="AzureCoreNetworkFunctionVhdApplication"/>.
        /// </param>
        internal AzureCoreNetworkFunctionTemplate(VirtualNetworkFunctionNfviType nfviType, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<AzureCoreNetworkFunctionApplication> networkFunctionApplications) : base(nfviType, serializedAdditionalRawData)
        {
            NetworkFunctionApplications = networkFunctionApplications;
            NfviType = nfviType;
        }

        /// <summary>
        /// Network function applications.
        /// Please note <see cref="AzureCoreNetworkFunctionApplication"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureCoreNetworkFunctionArmTemplateApplication"/> and <see cref="AzureCoreNetworkFunctionVhdApplication"/>.
        /// </summary>
        public IList<AzureCoreNetworkFunctionApplication> NetworkFunctionApplications { get; }
    }
}
