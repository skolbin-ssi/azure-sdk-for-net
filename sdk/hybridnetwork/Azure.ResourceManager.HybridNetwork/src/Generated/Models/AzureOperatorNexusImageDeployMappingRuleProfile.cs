// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Azure Operator Distributed Services image deploy mapping rule profile. </summary>
    public partial class AzureOperatorNexusImageDeployMappingRuleProfile : MappingRuleProfile
    {
        /// <summary> Initializes a new instance of <see cref="AzureOperatorNexusImageDeployMappingRuleProfile"/>. </summary>
        public AzureOperatorNexusImageDeployMappingRuleProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureOperatorNexusImageDeployMappingRuleProfile"/>. </summary>
        /// <param name="applicationEnablement"> The application enablement. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="imageMappingRuleProfile"> The vhd mapping rule profile. </param>
        internal AzureOperatorNexusImageDeployMappingRuleProfile(ApplicationEnablement? applicationEnablement, IDictionary<string, BinaryData> serializedAdditionalRawData, ImageMappingRuleProfile imageMappingRuleProfile) : base(applicationEnablement, serializedAdditionalRawData)
        {
            ImageMappingRuleProfile = imageMappingRuleProfile;
        }

        /// <summary> The vhd mapping rule profile. </summary>
        internal ImageMappingRuleProfile ImageMappingRuleProfile { get; set; }
        /// <summary> List of values. </summary>
        public string ImageMappingRuleUserConfiguration
        {
            get => ImageMappingRuleProfile is null ? default : ImageMappingRuleProfile.UserConfiguration;
            set
            {
                if (ImageMappingRuleProfile is null)
                    ImageMappingRuleProfile = new ImageMappingRuleProfile();
                ImageMappingRuleProfile.UserConfiguration = value;
            }
        }
    }
}
