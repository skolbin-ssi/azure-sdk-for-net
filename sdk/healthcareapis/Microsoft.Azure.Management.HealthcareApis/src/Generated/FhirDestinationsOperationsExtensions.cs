// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HealthcareApis
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FhirDestinationsOperations.
    /// </summary>
    public static partial class FhirDestinationsOperationsExtensions
    {
            /// <summary>
            /// Lists all FHIR destinations for the given IoT Connector
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of workspace resource.
            /// </param>
            /// <param name='iotConnectorName'>
            /// The name of IoT Connector resource.
            /// </param>
            public static IPage<IotFhirDestination> ListByIotConnector(this IFhirDestinationsOperations operations, string resourceGroupName, string workspaceName, string iotConnectorName)
            {
                return operations.ListByIotConnectorAsync(resourceGroupName, workspaceName, iotConnectorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all FHIR destinations for the given IoT Connector
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of workspace resource.
            /// </param>
            /// <param name='iotConnectorName'>
            /// The name of IoT Connector resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IotFhirDestination>> ListByIotConnectorAsync(this IFhirDestinationsOperations operations, string resourceGroupName, string workspaceName, string iotConnectorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByIotConnectorWithHttpMessagesAsync(resourceGroupName, workspaceName, iotConnectorName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all FHIR destinations for the given IoT Connector
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<IotFhirDestination> ListByIotConnectorNext(this IFhirDestinationsOperations operations, string nextPageLink)
            {
                return operations.ListByIotConnectorNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all FHIR destinations for the given IoT Connector
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
            public static async Task<IPage<IotFhirDestination>> ListByIotConnectorNextAsync(this IFhirDestinationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByIotConnectorNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
