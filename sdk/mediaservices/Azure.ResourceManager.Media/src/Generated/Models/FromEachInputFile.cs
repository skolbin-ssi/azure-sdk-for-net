// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> An InputDefinition that looks at each input file provided to select tracks specified by the IncludedTracks property. Generally used with the AudioTrackByAttribute and VideoTrackByAttribute to select tracks from each file given. </summary>
    public partial class FromEachInputFile : MediaJobInputDefinition
    {
        /// <summary> Initializes a new instance of <see cref="FromEachInputFile"/>. </summary>
        public FromEachInputFile()
        {
            OdataType = "#Microsoft.Media.FromEachInputFile";
        }

        /// <summary> Initializes a new instance of <see cref="FromEachInputFile"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="includedTracks">
        /// The list of TrackDescriptors which define the metadata and selection of tracks in the input.
        /// Please note <see cref="TrackDescriptor"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AudioTrackDescriptor"/>, <see cref="SelectAudioTrackByAttribute"/>, <see cref="SelectAudioTrackById"/>, <see cref="SelectVideoTrackByAttribute"/>, <see cref="SelectVideoTrackById"/> and <see cref="VideoTrackDescriptor"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FromEachInputFile(string odataType, IList<TrackDescriptor> includedTracks, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(odataType, includedTracks, serializedAdditionalRawData)
        {
            OdataType = odataType ?? "#Microsoft.Media.FromEachInputFile";
        }
    }
}
