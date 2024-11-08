// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Quantum.Jobs.Models
{
    public partial class JobDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("containerUri"u8);
            writer.WriteStringValue(ContainerUri);
            if (Optional.IsDefined(InputDataUri))
            {
                writer.WritePropertyName("inputDataUri"u8);
                writer.WriteStringValue(InputDataUri);
            }
            writer.WritePropertyName("inputDataFormat"u8);
            writer.WriteStringValue(InputDataFormat);
            if (Optional.IsDefined(InputParams))
            {
                writer.WritePropertyName("inputParams"u8);
                writer.WriteObjectValue<object>(InputParams);
            }
            writer.WritePropertyName("providerId"u8);
            writer.WriteStringValue(ProviderId);
            writer.WritePropertyName("target"u8);
            writer.WriteStringValue(Target);
            if (Optional.IsCollectionDefined(Metadata))
            {
                if (Metadata != null)
                {
                    writer.WritePropertyName("metadata"u8);
                    writer.WriteStartObject();
                    foreach (var item in Metadata)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("metadata");
                }
            }
            if (Optional.IsDefined(OutputDataUri))
            {
                writer.WritePropertyName("outputDataUri"u8);
                writer.WriteStringValue(OutputDataUri);
            }
            if (Optional.IsDefined(OutputDataFormat))
            {
                writer.WritePropertyName("outputDataFormat"u8);
                writer.WriteStringValue(OutputDataFormat);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags != null)
                {
                    writer.WritePropertyName("tags"u8);
                    writer.WriteStartArray();
                    foreach (var item in Tags)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("tags");
                }
            }
            writer.WriteEndObject();
        }

        internal static JobDetails DeserializeJobDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string name = default;
            string containerUri = default;
            string inputDataUri = default;
            string inputDataFormat = default;
            object inputParams = default;
            string providerId = default;
            string target = default;
            IDictionary<string, string> metadata = default;
            string outputDataUri = default;
            string outputDataFormat = default;
            JobStatus? status = default;
            DateTimeOffset? creationTime = default;
            DateTimeOffset? beginExecutionTime = default;
            DateTimeOffset? endExecutionTime = default;
            DateTimeOffset? cancellationTime = default;
            CostEstimate costEstimate = default;
            ErrorData errorData = default;
            IList<string> tags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerUri"u8))
                {
                    containerUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputDataUri"u8))
                {
                    inputDataUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputDataFormat"u8))
                {
                    inputDataFormat = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputParams"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inputParams = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("providerId"u8))
                {
                    providerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    metadata = dictionary;
                    continue;
                }
                if (property.NameEquals("outputDataUri"u8))
                {
                    outputDataUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outputDataFormat"u8))
                {
                    outputDataFormat = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new JobStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("beginExecutionTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        beginExecutionTime = null;
                        continue;
                    }
                    beginExecutionTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endExecutionTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endExecutionTime = null;
                        continue;
                    }
                    endExecutionTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cancellationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cancellationTime = null;
                        continue;
                    }
                    cancellationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("costEstimate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        costEstimate = null;
                        continue;
                    }
                    costEstimate = CostEstimate.DeserializeCostEstimate(property.Value);
                    continue;
                }
                if (property.NameEquals("errorData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        errorData = null;
                        continue;
                    }
                    errorData = ErrorData.DeserializeErrorData(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tags = array;
                    continue;
                }
            }
            return new JobDetails(
                id,
                name,
                containerUri,
                inputDataUri,
                inputDataFormat,
                inputParams,
                providerId,
                target,
                metadata ?? new ChangeTrackingDictionary<string, string>(),
                outputDataUri,
                outputDataFormat,
                status,
                creationTime,
                beginExecutionTime,
                endExecutionTime,
                cancellationTime,
                costEstimate,
                errorData,
                tags ?? new ChangeTrackingList<string>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static JobDetails FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeJobDetails(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
