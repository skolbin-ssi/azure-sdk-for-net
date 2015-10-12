// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Diagnostics for a hosting environment (App Service Environment)
    /// </summary>
    public partial class HostingEnvironmentDiagnostics
    {
        /// <summary>
        /// Name/identifier of the diagnostics
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Diagnostics output
        /// </summary>
        [JsonProperty(PropertyName = "diagnosicsOutput")]
        public string DiagnosicsOutput { get; set; }

    }
}
