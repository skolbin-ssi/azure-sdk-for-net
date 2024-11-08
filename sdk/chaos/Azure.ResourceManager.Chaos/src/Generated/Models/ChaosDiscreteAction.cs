// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model that represents a discrete action. </summary>
    public partial class ChaosDiscreteAction : ChaosExperimentAction
    {
        /// <summary> Initializes a new instance of <see cref="ChaosDiscreteAction"/>. </summary>
        /// <param name="name"> String that represents a Capability URN. </param>
        /// <param name="parameters"> List of key value pairs. </param>
        /// <param name="selectorId"> String that represents a selector. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="parameters"/> or <paramref name="selectorId"/> is null. </exception>
        public ChaosDiscreteAction(string name, IEnumerable<ChaosKeyValuePair> parameters, string selectorId) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(parameters, nameof(parameters));
            Argument.AssertNotNull(selectorId, nameof(selectorId));

            Parameters = parameters.ToList();
            SelectorId = selectorId;
            ActionType = "discrete";
        }

        /// <summary> Initializes a new instance of <see cref="ChaosDiscreteAction"/>. </summary>
        /// <param name="actionType"> Enum that discriminates between action models. </param>
        /// <param name="name"> String that represents a Capability URN. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="parameters"> List of key value pairs. </param>
        /// <param name="selectorId"> String that represents a selector. </param>
        internal ChaosDiscreteAction(string actionType, string name, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<ChaosKeyValuePair> parameters, string selectorId) : base(actionType, name, serializedAdditionalRawData)
        {
            Parameters = parameters;
            SelectorId = selectorId;
            ActionType = actionType ?? "discrete";
        }

        /// <summary> Initializes a new instance of <see cref="ChaosDiscreteAction"/> for deserialization. </summary>
        internal ChaosDiscreteAction()
        {
        }

        /// <summary> List of key value pairs. </summary>
        public IList<ChaosKeyValuePair> Parameters { get; }
        /// <summary> String that represents a selector. </summary>
        public string SelectorId { get; set; }
    }
}
