// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// Represents input files for a Job.
    /// Please note <see cref="MediaJobInputClip"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MediaJobInputAsset"/> and <see cref="MediaJobInputHttp"/>.
    /// </summary>
    public partial class MediaJobInputClip : MediaJobInputBasicProperties
    {
        /// <summary> Initializes a new instance of <see cref="MediaJobInputClip"/>. </summary>
        public MediaJobInputClip()
        {
            Files = new ChangeTrackingList<string>();
            InputDefinitions = new ChangeTrackingList<MediaJobInputDefinition>();
            OdataType = "#Microsoft.Media.JobInputClip";
        }

        /// <summary> Initializes a new instance of <see cref="MediaJobInputClip"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="files"> List of files. Required for JobInputHttp. Maximum of 4000 characters each. Query strings will not be returned in service responses to prevent sensitive data exposure. </param>
        /// <param name="start">
        /// Defines a point on the timeline of the input media at which processing will start. Defaults to the beginning of the input media.
        /// Please note <see cref="ClipTime"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AbsoluteClipTime"/> and <see cref="UtcClipTime"/>.
        /// </param>
        /// <param name="end">
        /// Defines a point on the timeline of the input media at which processing will end. Defaults to the end of the input media.
        /// Please note <see cref="ClipTime"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AbsoluteClipTime"/> and <see cref="UtcClipTime"/>.
        /// </param>
        /// <param name="label"> A label that is assigned to a JobInputClip, that is used to satisfy a reference used in the Transform. For example, a Transform can be authored so as to take an image file with the label 'xyz' and apply it as an overlay onto the input video before it is encoded. When submitting a Job, exactly one of the JobInputs should be the image file, and it should have the label 'xyz'. </param>
        /// <param name="inputDefinitions">
        /// Defines a list of InputDefinitions. For each InputDefinition, it defines a list of track selections and related metadata.
        /// Please note <see cref="MediaJobInputDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FromAllInputFile"/>, <see cref="FromEachInputFile"/> and <see cref="MediaJobInputFile"/>.
        /// </param>
        internal MediaJobInputClip(string odataType, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<string> files, ClipTime start, ClipTime end, string label, IList<MediaJobInputDefinition> inputDefinitions) : base(odataType, serializedAdditionalRawData)
        {
            Files = files;
            Start = start;
            End = end;
            Label = label;
            InputDefinitions = inputDefinitions;
            OdataType = odataType ?? "#Microsoft.Media.JobInputClip";
        }

        /// <summary> List of files. Required for JobInputHttp. Maximum of 4000 characters each. Query strings will not be returned in service responses to prevent sensitive data exposure. </summary>
        public IList<string> Files { get; }
        /// <summary>
        /// Defines a point on the timeline of the input media at which processing will start. Defaults to the beginning of the input media.
        /// Please note <see cref="ClipTime"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AbsoluteClipTime"/> and <see cref="UtcClipTime"/>.
        /// </summary>
        public ClipTime Start { get; set; }
        /// <summary>
        /// Defines a point on the timeline of the input media at which processing will end. Defaults to the end of the input media.
        /// Please note <see cref="ClipTime"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AbsoluteClipTime"/> and <see cref="UtcClipTime"/>.
        /// </summary>
        public ClipTime End { get; set; }
        /// <summary> A label that is assigned to a JobInputClip, that is used to satisfy a reference used in the Transform. For example, a Transform can be authored so as to take an image file with the label 'xyz' and apply it as an overlay onto the input video before it is encoded. When submitting a Job, exactly one of the JobInputs should be the image file, and it should have the label 'xyz'. </summary>
        public string Label { get; set; }
        /// <summary>
        /// Defines a list of InputDefinitions. For each InputDefinition, it defines a list of track selections and related metadata.
        /// Please note <see cref="MediaJobInputDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FromAllInputFile"/>, <see cref="FromEachInputFile"/> and <see cref="MediaJobInputFile"/>.
        /// </summary>
        public IList<MediaJobInputDefinition> InputDefinitions { get; }
    }
}
