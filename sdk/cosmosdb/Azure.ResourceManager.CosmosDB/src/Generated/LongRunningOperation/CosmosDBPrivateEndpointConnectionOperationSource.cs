// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CosmosDB
{
    internal class CosmosDBPrivateEndpointConnectionOperationSource : IOperationSource<CosmosDBPrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal CosmosDBPrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        CosmosDBPrivateEndpointConnectionResource IOperationSource<CosmosDBPrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CosmosDBPrivateEndpointConnectionData.DeserializeCosmosDBPrivateEndpointConnectionData(document.RootElement);
            return new CosmosDBPrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<CosmosDBPrivateEndpointConnectionResource> IOperationSource<CosmosDBPrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CosmosDBPrivateEndpointConnectionData.DeserializeCosmosDBPrivateEndpointConnectionData(document.RootElement);
            return new CosmosDBPrivateEndpointConnectionResource(_client, data);
        }
    }
}
