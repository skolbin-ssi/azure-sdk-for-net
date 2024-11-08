// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MigrationDiscoverySap
{
    internal class OperationStatusResultOperationSource : IOperationSource<OperationStatusResult>
    {
        OperationStatusResult IOperationSource<OperationStatusResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return JsonSerializer.Deserialize<OperationStatusResult>(document.RootElement.GetRawText());
        }

        async ValueTask<OperationStatusResult> IOperationSource<OperationStatusResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return JsonSerializer.Deserialize<OperationStatusResult>(document.RootElement.GetRawText());
        }
    }
}
