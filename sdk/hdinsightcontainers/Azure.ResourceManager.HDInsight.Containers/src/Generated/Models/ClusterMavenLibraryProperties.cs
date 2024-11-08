// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Properties of a Maven library in the cluster. </summary>
    public partial class ClusterMavenLibraryProperties : ClusterLibraryProperties
    {
        /// <summary> Initializes a new instance of <see cref="ClusterMavenLibraryProperties"/>. </summary>
        /// <param name="groupId"> GroupId of the Maven package. </param>
        /// <param name="name"> ArtifactId of the Maven package. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> or <paramref name="name"/> is null. </exception>
        public ClusterMavenLibraryProperties(string groupId, string name)
        {
            Argument.AssertNotNull(groupId, nameof(groupId));
            Argument.AssertNotNull(name, nameof(name));

            GroupId = groupId;
            Name = name;
            LibraryType = Type.Maven;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterMavenLibraryProperties"/>. </summary>
        /// <param name="libraryType"> Type of the library. </param>
        /// <param name="remarks"> Remark of the latest library management operation. </param>
        /// <param name="timestamp"> Timestamp of the latest library management operation. </param>
        /// <param name="status"> Status of the library. </param>
        /// <param name="message"> Error message of the library operation when a failure occurs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="groupId"> GroupId of the Maven package. </param>
        /// <param name="name"> ArtifactId of the Maven package. </param>
        /// <param name="version"> Version of the Maven package. </param>
        internal ClusterMavenLibraryProperties(Type libraryType, string remarks, DateTimeOffset? timestamp, Status? status, string message, IDictionary<string, BinaryData> serializedAdditionalRawData, string groupId, string name, string version) : base(libraryType, remarks, timestamp, status, message, serializedAdditionalRawData)
        {
            GroupId = groupId;
            Name = name;
            Version = version;
            LibraryType = libraryType;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterMavenLibraryProperties"/> for deserialization. </summary>
        internal ClusterMavenLibraryProperties()
        {
        }

        /// <summary> GroupId of the Maven package. </summary>
        [WirePath("groupId")]
        public string GroupId { get; set; }
        /// <summary> ArtifactId of the Maven package. </summary>
        [WirePath("name")]
        public string Name { get; set; }
        /// <summary> Version of the Maven package. </summary>
        [WirePath("version")]
        public string Version { get; set; }
    }
}
