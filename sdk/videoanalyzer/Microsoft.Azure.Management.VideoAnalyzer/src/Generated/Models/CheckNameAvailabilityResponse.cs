// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The check availability result.
    /// </summary>
    public partial class CheckNameAvailabilityResponse
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityResponse
        /// class.
        /// </summary>
        public CheckNameAvailabilityResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityResponse
        /// class.
        /// </summary>
        /// <param name="nameAvailable">Indicates if the resource name is
        /// available.</param>
        /// <param name="reason">The reason why the given name is not
        /// available. Possible values include: 'Invalid',
        /// 'AlreadyExists'</param>
        /// <param name="message">Detailed reason why the given name is
        /// available.</param>
        public CheckNameAvailabilityResponse(bool? nameAvailable = default(bool?), CheckNameAvailabilityReason? reason = default(CheckNameAvailabilityReason?), string message = default(string))
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates if the resource name is available.
        /// </summary>
        [JsonProperty(PropertyName = "nameAvailable")]
        public bool? NameAvailable { get; set; }

        /// <summary>
        /// Gets or sets the reason why the given name is not available.
        /// Possible values include: 'Invalid', 'AlreadyExists'
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public CheckNameAvailabilityReason? Reason { get; set; }

        /// <summary>
        /// Gets or sets detailed reason why the given name is available.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
