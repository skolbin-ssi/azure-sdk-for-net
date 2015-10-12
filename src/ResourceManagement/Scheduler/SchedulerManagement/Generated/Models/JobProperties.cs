namespace Microsoft.Azure.Management.Scheduler.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// </summary>
    public partial class JobProperties
    {
        /// <summary>
        /// Gets or sets the job start time.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the job action.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public JobAction Action { get; set; }

        /// <summary>
        /// Gets or sets the job recurrence.
        /// </summary>
        [JsonProperty(PropertyName = "recurrence")]
        public JobRecurrence Recurrence { get; set; }

        /// <summary>
        /// Gets or set the job state. Possible values for this property
        /// include: 'Enabled', 'Disabled', 'Faulted', 'Completed'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public JobState? State { get; set; }

        /// <summary>
        /// Gets the job status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public JobStatus Status { get; private set; }

    }
}
