// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RecoveryPointsOperations.
    /// </summary>
    public static partial class RecoveryPointsOperationsExtensions
    {
            /// <summary>
            /// Returns a list of Recovery Points for a DataSource in a vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='backupInstanceName'>
            /// The name of the backup instance
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='skipToken'>
            /// skipToken Filter.
            /// </param>
            public static IPage<AzureBackupRecoveryPointResource> GetList(this IRecoveryPointsOperations operations, string vaultName, string resourceGroupName, string backupInstanceName, ODataQuery<RecoveryPointsFilters> odataQuery = default(ODataQuery<RecoveryPointsFilters>), string skipToken = default(string))
            {
                return operations.GetListAsync(vaultName, resourceGroupName, backupInstanceName, odataQuery, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of Recovery Points for a DataSource in a vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='backupInstanceName'>
            /// The name of the backup instance
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='skipToken'>
            /// skipToken Filter.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AzureBackupRecoveryPointResource>> GetListAsync(this IRecoveryPointsOperations operations, string vaultName, string resourceGroupName, string backupInstanceName, ODataQuery<RecoveryPointsFilters> odataQuery = default(ODataQuery<RecoveryPointsFilters>), string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetListWithHttpMessagesAsync(vaultName, resourceGroupName, backupInstanceName, odataQuery, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of Recovery Points for a DataSource in a vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<AzureBackupRecoveryPointResource> GetListNext(this IRecoveryPointsOperations operations, string nextPageLink)
            {
                return operations.GetListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of Recovery Points for a DataSource in a vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AzureBackupRecoveryPointResource>> GetListNextAsync(this IRecoveryPointsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
