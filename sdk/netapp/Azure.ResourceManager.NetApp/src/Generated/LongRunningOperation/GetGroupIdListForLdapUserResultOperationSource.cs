// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    internal class GetGroupIdListForLdapUserResultOperationSource : IOperationSource<GetGroupIdListForLdapUserResult>
    {
        GetGroupIdListForLdapUserResult IOperationSource<GetGroupIdListForLdapUserResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return GetGroupIdListForLdapUserResult.DeserializeGetGroupIdListForLdapUserResult(document.RootElement);
        }

        async ValueTask<GetGroupIdListForLdapUserResult> IOperationSource<GetGroupIdListForLdapUserResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return GetGroupIdListForLdapUserResult.DeserializeGetGroupIdListForLdapUserResult(document.RootElement);
        }
    }
}
