// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.HybridNetwork.Models;

namespace Azure.ResourceManager.HybridNetwork
{
    internal class NetworkFunctionDefinitionVersionUpdateStateOperationSource : IOperationSource<NetworkFunctionDefinitionVersionUpdateState>
    {
        NetworkFunctionDefinitionVersionUpdateState IOperationSource<NetworkFunctionDefinitionVersionUpdateState>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return NetworkFunctionDefinitionVersionUpdateState.DeserializeNetworkFunctionDefinitionVersionUpdateState(document.RootElement);
        }

        async ValueTask<NetworkFunctionDefinitionVersionUpdateState> IOperationSource<NetworkFunctionDefinitionVersionUpdateState>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return NetworkFunctionDefinitionVersionUpdateState.DeserializeNetworkFunctionDefinitionVersionUpdateState(document.RootElement);
        }
    }
}
