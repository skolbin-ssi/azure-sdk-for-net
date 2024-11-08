// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> ExecAction describes a "run in container" action. </summary>
    public partial class AppInstanceExecAction : AppInstanceProbeAction
    {
        /// <summary> Initializes a new instance of <see cref="AppInstanceExecAction"/>. </summary>
        public AppInstanceExecAction()
        {
            Command = new ChangeTrackingList<string>();
            ProbeActionType = ProbeActionType.ExecAction;
        }

        /// <summary> Initializes a new instance of <see cref="AppInstanceExecAction"/>. </summary>
        /// <param name="probeActionType"> The type of the action to take to perform the health check. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="command"> Command is the command line to execute inside the container, the working directory for the command is root ('/') in the container's filesystem. The command is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy. </param>
        internal AppInstanceExecAction(ProbeActionType probeActionType, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<string> command) : base(probeActionType, serializedAdditionalRawData)
        {
            Command = command;
            ProbeActionType = probeActionType;
        }

        /// <summary> Command is the command line to execute inside the container, the working directory for the command is root ('/') in the container's filesystem. The command is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy. </summary>
        public IList<string> Command { get; }
    }
}
