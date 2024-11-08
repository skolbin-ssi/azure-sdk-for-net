// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Analytics.Purview.Workflows.Samples
{
    public partial class Samples_WorkflowRunsClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetWorkflowRuns_ShortVersion()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            WorkflowRunsClient client = new WorkflowRunsClient(endpoint, credential);

            foreach (BinaryData item in client.GetWorkflowRuns(null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("workflowId").ToString());
                Console.WriteLine(result.GetProperty("startTime").ToString());
                Console.WriteLine(result.GetProperty("requestor").ToString());
                Console.WriteLine(result.GetProperty("runPayload").GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("runPayload").GetProperty("targetValue").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetWorkflowRuns_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            WorkflowRunsClient client = new WorkflowRunsClient(endpoint, credential);

            await foreach (BinaryData item in client.GetWorkflowRunsAsync(null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("workflowId").ToString());
                Console.WriteLine(result.GetProperty("startTime").ToString());
                Console.WriteLine(result.GetProperty("requestor").ToString());
                Console.WriteLine(result.GetProperty("runPayload").GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("runPayload").GetProperty("targetValue").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetWorkflowRuns_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            WorkflowRunsClient client = new WorkflowRunsClient(endpoint, credential);

            foreach (BinaryData item in client.GetWorkflowRuns("<viewMode>", "1d", "status desc", new string[] { "InProgress" }, new string[] { "<workflowIds>" }, new string[] { "<requestors>" }, 1234, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("workflowId").ToString());
                Console.WriteLine(result.GetProperty("startTime").ToString());
                Console.WriteLine(result.GetProperty("requestor").ToString());
                Console.WriteLine(result.GetProperty("userRequestId").ToString());
                Console.WriteLine(result.GetProperty("runPayload").GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("runPayload").GetProperty("targetValue").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("endTime").ToString());
                Console.WriteLine(result.GetProperty("cancelTime").ToString());
                Console.WriteLine(result.GetProperty("cancelComment").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetWorkflowRuns_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            WorkflowRunsClient client = new WorkflowRunsClient(endpoint, credential);

            await foreach (BinaryData item in client.GetWorkflowRunsAsync("<viewMode>", "1d", "status desc", new string[] { "InProgress" }, new string[] { "<workflowIds>" }, new string[] { "<requestors>" }, 1234, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("workflowId").ToString());
                Console.WriteLine(result.GetProperty("startTime").ToString());
                Console.WriteLine(result.GetProperty("requestor").ToString());
                Console.WriteLine(result.GetProperty("userRequestId").ToString());
                Console.WriteLine(result.GetProperty("runPayload").GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("runPayload").GetProperty("targetValue").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("endTime").ToString());
                Console.WriteLine(result.GetProperty("cancelTime").ToString());
                Console.WriteLine(result.GetProperty("cancelComment").ToString());
            }
        }
    }
}
