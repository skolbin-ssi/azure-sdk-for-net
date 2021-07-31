// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Live pipeline resource representation. </summary>
    internal partial class LivePipelineSetRequestBody : MethodRequest
    {
        /// <summary> Initializes a new instance of LivePipelineSetRequestBody. </summary>
        /// <param name="name"> Live pipeline unique identifier. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public LivePipelineSetRequestBody(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            MethodName = "LivePipelineSetRequestBody";
        }

        /// <summary> Initializes a new instance of LivePipelineSetRequestBody. </summary>
        /// <param name="methodName"> Direct method method name. </param>
        /// <param name="apiVersion"> Video Analyzer API version. </param>
        /// <param name="name"> Live pipeline unique identifier. </param>
        /// <param name="systemData"> Read-only system metadata associated with this object. </param>
        /// <param name="properties"> Live pipeline properties. </param>
        internal LivePipelineSetRequestBody(string methodName, string apiVersion, string name, SystemData systemData, LivePipelineProperties properties) : base(methodName, apiVersion)
        {
            Name = name;
            SystemData = systemData;
            Properties = properties;
            MethodName = methodName ?? "LivePipelineSetRequestBody";
        }

        /// <summary> Live pipeline unique identifier. </summary>
        public string Name { get; set; }
        /// <summary> Read-only system metadata associated with this object. </summary>
        public SystemData SystemData { get; set; }
        /// <summary> Live pipeline properties. </summary>
        public LivePipelineProperties Properties { get; set; }
    }
}
