// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class SparkBatchJob
    {
        internal static SparkBatchJob DeserializeSparkBatchJob(JsonElement element)
        {
            Optional<SparkBatchJobState> livyInfo = default;
            Optional<string> name = default;
            Optional<string> workspaceName = default;
            Optional<string> sparkPoolName = default;
            Optional<string> submitterName = default;
            Optional<string> submitterId = default;
            Optional<string> artifactId = default;
            Optional<SparkJobType> jobType = default;
            Optional<SparkBatchJobResultType> result = default;
            Optional<SparkScheduler> schedulerInfo = default;
            Optional<SparkServicePlugin> pluginInfo = default;
            Optional<IReadOnlyList<SparkServiceError>> errorInfo = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            int id = default;
            Optional<string> appId = default;
            Optional<IReadOnlyDictionary<string, string>> appInfo = default;
            Optional<string> state = default;
            Optional<IReadOnlyList<string>> log = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("livyInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    livyInfo = SparkBatchJobState.DeserializeSparkBatchJobState(property.Value);
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceName"))
                {
                    workspaceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sparkPoolName"))
                {
                    sparkPoolName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("submitterName"))
                {
                    submitterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("submitterId"))
                {
                    submitterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactId"))
                {
                    artifactId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    jobType = new SparkJobType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("result"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    result = new SparkBatchJobResultType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("schedulerInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schedulerInfo = SparkScheduler.DeserializeSparkScheduler(property.Value);
                    continue;
                }
                if (property.NameEquals("pluginInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    pluginInfo = SparkServicePlugin.DeserializeSparkServicePlugin(property.Value);
                    continue;
                }
                if (property.NameEquals("errorInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SparkServiceError> array = new List<SparkServiceError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SparkServiceError.DeserializeSparkServiceError(item));
                    }
                    errorInfo = array;
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("appId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        appId = null;
                        continue;
                    }
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        appInfo = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    appInfo = dictionary;
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("log"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        log = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    log = array;
                    continue;
                }
            }
            return new SparkBatchJob(livyInfo.Value, name.Value, workspaceName.Value, sparkPoolName.Value, submitterName.Value, submitterId.Value, artifactId.Value, Optional.ToNullable(jobType), Optional.ToNullable(result), schedulerInfo.Value, pluginInfo.Value, Optional.ToList(errorInfo), Optional.ToDictionary(tags), id, appId.Value, Optional.ToDictionary(appInfo), state.Value, Optional.ToList(log));
        }
    }
}
