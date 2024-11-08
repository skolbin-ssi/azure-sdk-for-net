// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary>
    /// Base class for all triggers that support one to many model for trigger to pipeline.
    /// Please note <see cref="MultiplePipelineTrigger"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="BlobEventsTrigger"/>, <see cref="BlobTrigger"/>, <see cref="CustomEventsTrigger"/> and <see cref="ScheduleTrigger"/>.
    /// </summary>
    public partial class MultiplePipelineTrigger : Trigger
    {
        /// <summary> Initializes a new instance of <see cref="MultiplePipelineTrigger"/>. </summary>
        public MultiplePipelineTrigger()
        {
            Pipelines = new ChangeTrackingList<TriggerPipelineReference>();
            Type = "MultiplePipelineTrigger";
        }

        /// <summary> Initializes a new instance of <see cref="MultiplePipelineTrigger"/>. </summary>
        /// <param name="type"> Trigger type. </param>
        /// <param name="description"> Trigger description. </param>
        /// <param name="runtimeState"> Indicates if trigger is running or not. Updated when Start/Stop APIs are called on the Trigger. </param>
        /// <param name="annotations"> List of tags that can be used for describing the trigger. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="pipelines"> Pipelines that need to be started. </param>
        internal MultiplePipelineTrigger(string type, string description, TriggerRuntimeState? runtimeState, IList<object> annotations, IDictionary<string, object> additionalProperties, IList<TriggerPipelineReference> pipelines) : base(type, description, runtimeState, annotations, additionalProperties)
        {
            Pipelines = pipelines;
            Type = type ?? "MultiplePipelineTrigger";
        }

        /// <summary> Pipelines that need to be started. </summary>
        public IList<TriggerPipelineReference> Pipelines { get; }
    }
}
