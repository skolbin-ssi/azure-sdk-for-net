// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> The status of the search service. Possible values include: 'running': The search service is running and no provisioning operations are underway. 'provisioning': The search service is being provisioned or scaled up or down. 'deleting': The search service is being deleted. 'degraded': The search service is degraded. This can occur when the underlying search units are not healthy. The search service is most likely operational, but performance might be slow and some requests might be dropped. 'disabled': The search service is disabled. In this state, the service will reject all API requests. 'error': The search service is in an error state. 'stopped': The search service is in a subscription that's disabled. If your service is in the degraded, disabled, or error states, it means the Azure AI Search team is actively investigating the underlying issue. Dedicated services in these states are still chargeable based on the number of search units provisioned. </summary>
    public enum SearchServiceStatus
    {
        /// <summary> The search service is running and no provisioning operations are underway. </summary>
        Running,
        /// <summary> The search service is being provisioned or scaled up or down. </summary>
        Provisioning,
        /// <summary> The search service is being deleted. </summary>
        Deleting,
        /// <summary> The search service is degraded because underlying search units are not healthy. </summary>
        Degraded,
        /// <summary> The search service is disabled and all API requests will be rejected. </summary>
        Disabled,
        /// <summary> The search service is in error state, indicating either a failure to provision or to be deleted. </summary>
        Error
    }
}
