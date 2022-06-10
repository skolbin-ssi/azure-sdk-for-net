// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Output of check name availability API. </summary>
    public partial class EndpointNameAvailabilityResult
    {
        /// <summary> Initializes a new instance of EndpointNameAvailabilityResult. </summary>
        internal EndpointNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of EndpointNameAvailabilityResult. </summary>
        /// <param name="nameAvailable"> Indicates whether the name is available. </param>
        /// <param name="availableHostname"> Returns the available hostname generated based on the AutoGeneratedDomainNameLabelScope when the name is available, otherwise it returns empty string. </param>
        /// <param name="reason"> The reason why the name is not available. </param>
        /// <param name="message"> The detailed error message describing why the name is not available. </param>
        internal EndpointNameAvailabilityResult(bool? nameAvailable, string availableHostname, string reason, string message)
        {
            NameAvailable = nameAvailable;
            AvailableHostname = availableHostname;
            Reason = reason;
            Message = message;
        }

        /// <summary> Indicates whether the name is available. </summary>
        public bool? NameAvailable { get; }
        /// <summary> Returns the available hostname generated based on the AutoGeneratedDomainNameLabelScope when the name is available, otherwise it returns empty string. </summary>
        public string AvailableHostname { get; }
        /// <summary> The reason why the name is not available. </summary>
        public string Reason { get; }
        /// <summary> The detailed error message describing why the name is not available. </summary>
        public string Message { get; }
    }
}
