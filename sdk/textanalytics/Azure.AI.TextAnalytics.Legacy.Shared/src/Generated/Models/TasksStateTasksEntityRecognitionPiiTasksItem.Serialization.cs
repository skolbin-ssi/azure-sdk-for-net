// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;

namespace Azure.AI.TextAnalytics.Legacy.Models
{
    internal partial class TasksStateTasksEntityRecognitionPiiTasksItem
    {
        internal static TasksStateTasksEntityRecognitionPiiTasksItem DeserializeTasksStateTasksEntityRecognitionPiiTasksItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PiiResult results = default;
            DateTimeOffset lastUpdateDateTime = default;
            string taskName = default;
            State status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    results = PiiResult.DeserializePiiResult(property.Value);
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"u8))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("taskName"u8))
                {
                    taskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString().ToState();
                    continue;
                }
            }
            return new TasksStateTasksEntityRecognitionPiiTasksItem(lastUpdateDateTime, taskName, status, results);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new TasksStateTasksEntityRecognitionPiiTasksItem FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTasksStateTasksEntityRecognitionPiiTasksItem(document.RootElement);
        }
    }
}
