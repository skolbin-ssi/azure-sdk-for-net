// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> A Sequence contains an ordered list of Clips where each clip is a JobInput.  The Sequence will be treated as a single input. </summary>
    public partial class MediaJobInputSequence : MediaJobInputBasicProperties
    {
        /// <summary> Initializes a new instance of <see cref="MediaJobInputSequence"/>. </summary>
        public MediaJobInputSequence()
        {
            Inputs = new ChangeTrackingList<MediaJobInputClip>();
            OdataType = "#Microsoft.Media.JobInputSequence";
        }

        /// <summary> Initializes a new instance of <see cref="MediaJobInputSequence"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="inputs">
        /// JobInputs that make up the timeline.
        /// Please note <see cref="MediaJobInputClip"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MediaJobInputAsset"/> and <see cref="MediaJobInputHttp"/>.
        /// </param>
        internal MediaJobInputSequence(string odataType, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<MediaJobInputClip> inputs) : base(odataType, serializedAdditionalRawData)
        {
            Inputs = inputs;
            OdataType = odataType ?? "#Microsoft.Media.JobInputSequence";
        }

        /// <summary>
        /// JobInputs that make up the timeline.
        /// Please note <see cref="MediaJobInputClip"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MediaJobInputAsset"/> and <see cref="MediaJobInputHttp"/>.
        /// </summary>
        public IList<MediaJobInputClip> Inputs { get; }
    }
}
