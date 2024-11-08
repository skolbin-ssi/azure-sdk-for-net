// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure.ResourceManager.ChangeAnalysis.Mocking;
using Azure.ResourceManager.ChangeAnalysis.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ChangeAnalysis
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ChangeAnalysis. </summary>
    public static partial class ChangeAnalysisExtensions
    {
        private static MockableChangeAnalysisResourceGroupResource GetMockableChangeAnalysisResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableChangeAnalysisResourceGroupResource(client, resource.Id));
        }

        private static MockableChangeAnalysisSubscriptionResource GetMockableChangeAnalysisSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableChangeAnalysisSubscriptionResource(client, resource.Id));
        }

        private static MockableChangeAnalysisTenantResource GetMockableChangeAnalysisTenantResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableChangeAnalysisTenantResource(client, resource.Id));
        }

        /// <summary>
        /// List the changes of a resource group within the specified time range. Customer data will always be masked.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ChangeAnalysis/changes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Changes_ListChangesByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-04-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChangeAnalysisResourceGroupResource.GetChangesByResourceGroup(DateTimeOffset,DateTimeOffset,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="startTime"> Specifies the start time of the changes request. </param>
        /// <param name="endTime"> Specifies the end time of the changes request. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="DetectedChangeData"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DetectedChangeData> GetChangesByResourceGroupAsync(this ResourceGroupResource resourceGroupResource, DateTimeOffset startTime, DateTimeOffset endTime, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableChangeAnalysisResourceGroupResource(resourceGroupResource).GetChangesByResourceGroupAsync(startTime, endTime, skipToken, cancellationToken);
        }

        /// <summary>
        /// List the changes of a resource group within the specified time range. Customer data will always be masked.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ChangeAnalysis/changes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Changes_ListChangesByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-04-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChangeAnalysisResourceGroupResource.GetChangesByResourceGroup(DateTimeOffset,DateTimeOffset,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="startTime"> Specifies the start time of the changes request. </param>
        /// <param name="endTime"> Specifies the end time of the changes request. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> A collection of <see cref="DetectedChangeData"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DetectedChangeData> GetChangesByResourceGroup(this ResourceGroupResource resourceGroupResource, DateTimeOffset startTime, DateTimeOffset endTime, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableChangeAnalysisResourceGroupResource(resourceGroupResource).GetChangesByResourceGroup(startTime, endTime, skipToken, cancellationToken);
        }

        /// <summary>
        /// List the changes of a subscription within the specified time range. Customer data will always be masked.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ChangeAnalysis/changes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Changes_ListChangesBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-04-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChangeAnalysisSubscriptionResource.GetChangesBySubscription(DateTimeOffset,DateTimeOffset,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="startTime"> Specifies the start time of the changes request. </param>
        /// <param name="endTime"> Specifies the end time of the changes request. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="DetectedChangeData"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DetectedChangeData> GetChangesBySubscriptionAsync(this SubscriptionResource subscriptionResource, DateTimeOffset startTime, DateTimeOffset endTime, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableChangeAnalysisSubscriptionResource(subscriptionResource).GetChangesBySubscriptionAsync(startTime, endTime, skipToken, cancellationToken);
        }

        /// <summary>
        /// List the changes of a subscription within the specified time range. Customer data will always be masked.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ChangeAnalysis/changes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Changes_ListChangesBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-04-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChangeAnalysisSubscriptionResource.GetChangesBySubscription(DateTimeOffset,DateTimeOffset,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="startTime"> Specifies the start time of the changes request. </param>
        /// <param name="endTime"> Specifies the end time of the changes request. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="DetectedChangeData"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DetectedChangeData> GetChangesBySubscription(this SubscriptionResource subscriptionResource, DateTimeOffset startTime, DateTimeOffset endTime, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableChangeAnalysisSubscriptionResource(subscriptionResource).GetChangesBySubscription(startTime, endTime, skipToken, cancellationToken);
        }

        /// <summary>
        /// List the changes of a resource within the specified time range. Customer data will be masked if the user doesn't have access.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.ChangeAnalysis/resourceChanges</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceChanges_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-04-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChangeAnalysisTenantResource.GetResourceChanges(string,DateTimeOffset,DateTimeOffset,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="startTime"> Specifies the start time of the changes request. </param>
        /// <param name="endTime"> Specifies the end time of the changes request. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> or <paramref name="resourceId"/> is null. </exception>
        /// <returns> An async collection of <see cref="DetectedChangeData"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DetectedChangeData> GetResourceChangesAsync(this TenantResource tenantResource, string resourceId, DateTimeOffset startTime, DateTimeOffset endTime, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockableChangeAnalysisTenantResource(tenantResource).GetResourceChangesAsync(resourceId, startTime, endTime, skipToken, cancellationToken);
        }

        /// <summary>
        /// List the changes of a resource within the specified time range. Customer data will be masked if the user doesn't have access.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.ChangeAnalysis/resourceChanges</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceChanges_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-04-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChangeAnalysisTenantResource.GetResourceChanges(string,DateTimeOffset,DateTimeOffset,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="startTime"> Specifies the start time of the changes request. </param>
        /// <param name="endTime"> Specifies the end time of the changes request. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> or <paramref name="resourceId"/> is null. </exception>
        /// <returns> A collection of <see cref="DetectedChangeData"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DetectedChangeData> GetResourceChanges(this TenantResource tenantResource, string resourceId, DateTimeOffset startTime, DateTimeOffset endTime, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockableChangeAnalysisTenantResource(tenantResource).GetResourceChanges(resourceId, startTime, endTime, skipToken, cancellationToken);
        }
    }
}
