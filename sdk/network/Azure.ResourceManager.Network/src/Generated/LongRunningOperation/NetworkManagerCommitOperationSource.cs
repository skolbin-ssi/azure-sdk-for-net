// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal class NetworkManagerCommitOperationSource : IOperationSource<NetworkManagerCommit>
    {
        NetworkManagerCommit IOperationSource<NetworkManagerCommit>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return NetworkManagerCommit.DeserializeNetworkManagerCommit(document.RootElement);
        }

        async ValueTask<NetworkManagerCommit> IOperationSource<NetworkManagerCommit>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return NetworkManagerCommit.DeserializeNetworkManagerCommit(document.RootElement);
        }
    }
}
