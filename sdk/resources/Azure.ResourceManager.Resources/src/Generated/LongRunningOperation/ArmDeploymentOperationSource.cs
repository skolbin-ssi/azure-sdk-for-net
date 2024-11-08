// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Resources
{
    internal class ArmDeploymentOperationSource : IOperationSource<ArmDeploymentResource>
    {
        private readonly ArmClient _client;

        internal ArmDeploymentOperationSource(ArmClient client)
        {
            _client = client;
        }

        ArmDeploymentResource IOperationSource<ArmDeploymentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ArmDeploymentData.DeserializeArmDeploymentData(document.RootElement);
            return new ArmDeploymentResource(_client, data);
        }

        async ValueTask<ArmDeploymentResource> IOperationSource<ArmDeploymentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ArmDeploymentData.DeserializeArmDeploymentData(document.RootElement);
            return new ArmDeploymentResource(_client, data);
        }
    }
}
