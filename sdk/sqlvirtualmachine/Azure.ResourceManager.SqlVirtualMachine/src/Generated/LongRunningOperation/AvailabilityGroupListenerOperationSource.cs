// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine
{
    internal class AvailabilityGroupListenerOperationSource : IOperationSource<AvailabilityGroupListenerResource>
    {
        private readonly ArmClient _client;

        internal AvailabilityGroupListenerOperationSource(ArmClient client)
        {
            _client = client;
        }

        AvailabilityGroupListenerResource IOperationSource<AvailabilityGroupListenerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AvailabilityGroupListenerData.DeserializeAvailabilityGroupListenerData(document.RootElement);
            return new AvailabilityGroupListenerResource(_client, data);
        }

        async ValueTask<AvailabilityGroupListenerResource> IOperationSource<AvailabilityGroupListenerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AvailabilityGroupListenerData.DeserializeAvailabilityGroupListenerData(document.RootElement);
            return new AvailabilityGroupListenerResource(_client, data);
        }
    }
}
