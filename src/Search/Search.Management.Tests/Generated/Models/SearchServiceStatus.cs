// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is

namespace Microsoft.Azure.Management.Search.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SearchServiceStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SearchServiceStatus
    {
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "provisioning")]
        Provisioning,
        [EnumMember(Value = "deleting")]
        Deleting,
        [EnumMember(Value = "degraded")]
        Degraded,
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "error")]
        Error
    }
}
