// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork
{
    internal class ArtifactManifestOperationSource : IOperationSource<ArtifactManifestResource>
    {
        private readonly ArmClient _client;

        internal ArtifactManifestOperationSource(ArmClient client)
        {
            _client = client;
        }

        ArtifactManifestResource IOperationSource<ArtifactManifestResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ArtifactManifestData.DeserializeArtifactManifestData(document.RootElement);
            return new ArtifactManifestResource(_client, data);
        }

        async ValueTask<ArtifactManifestResource> IOperationSource<ArtifactManifestResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ArtifactManifestData.DeserializeArtifactManifestData(document.RootElement);
            return new ArtifactManifestResource(_client, data);
        }
    }
}
