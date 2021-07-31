// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Personalizer
{
    /// <summary> A counterfactual evaluation. </summary>
    public partial class PersonalizerEvaluationOptions
    {
        /// <summary> Initializes a new instance of PersonalizerEvaluationOptions. </summary>
        /// <param name="name"> The name of the evaluation. </param>
        /// <param name="startTime"> The start time of the evaluation. </param>
        /// <param name="endTime"> The end time of the evaluation. </param>
        /// <param name="policies"> Additional learning settings to evaluate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="policies"/> is null. </exception>
        public PersonalizerEvaluationOptions(string name, DateTimeOffset startTime, DateTimeOffset endTime, IEnumerable<PersonalizerPolicy> policies)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (policies == null)
            {
                throw new ArgumentNullException(nameof(policies));
            }

            Name = name;
            StartTime = startTime;
            EndTime = endTime;
            Policies = policies.ToList();
        }

        /// <summary> True if the evaluation should explore for a more optimal learning settings. </summary>
        public bool? EnableOfflineExperimentation { get; set; }
        /// <summary> The name of the evaluation. </summary>
        public string Name { get; }
        /// <summary> The start time of the evaluation. </summary>
        public DateTimeOffset StartTime { get; }
        /// <summary> The end time of the evaluation. </summary>
        public DateTimeOffset EndTime { get; }
        /// <summary> Additional learning settings to evaluate. </summary>
        public IList<PersonalizerPolicy> Policies { get; }
    }
}
