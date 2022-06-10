// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies information about the capacity reservation. Only tags and
    /// sku.capacity can be updated.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CapacityReservationUpdate : UpdateResource
    {
        /// <summary>
        /// Initializes a new instance of the CapacityReservationUpdate class.
        /// </summary>
        public CapacityReservationUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CapacityReservationUpdate class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        /// <param name="reservationId">A unique id generated and assigned to
        /// the capacity reservation by the platform which does not change
        /// throughout the lifetime of the resource.</param>
        /// <param name="virtualMachinesAssociated">A list of all virtual
        /// machine resource ids that are associated with the capacity
        /// reservation.</param>
        /// <param name="provisioningTime">The date time when the capacity
        /// reservation was last updated.</param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response.</param>
        /// <param name="instanceView">The Capacity reservation instance
        /// view.</param>
        /// <param name="timeCreated">Specifies the time at which the Capacity
        /// Reservation resource was created.&lt;br&gt;&lt;br&gt;Minimum
        /// api-version: 2022-03-01.</param>
        /// <param name="sku">SKU of the resource for which capacity needs be
        /// reserved. The SKU name and capacity is required to be set.
        /// Currently VM Skus with the capability called
        /// 'CapacityReservationSupported' set to true are supported. Refer to
        /// List Microsoft.Compute SKUs in a region
        /// (https://docs.microsoft.com/rest/api/compute/resourceskus/list) for
        /// supported values.</param>
        public CapacityReservationUpdate(IDictionary<string, string> tags = default(IDictionary<string, string>), string reservationId = default(string), IList<SubResourceReadOnly> virtualMachinesAssociated = default(IList<SubResourceReadOnly>), System.DateTime? provisioningTime = default(System.DateTime?), string provisioningState = default(string), CapacityReservationInstanceView instanceView = default(CapacityReservationInstanceView), System.DateTime? timeCreated = default(System.DateTime?), Sku sku = default(Sku))
            : base(tags)
        {
            ReservationId = reservationId;
            VirtualMachinesAssociated = virtualMachinesAssociated;
            ProvisioningTime = provisioningTime;
            ProvisioningState = provisioningState;
            InstanceView = instanceView;
            TimeCreated = timeCreated;
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a unique id generated and assigned to the capacity reservation
        /// by the platform which does not change throughout the lifetime of
        /// the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.reservationId")]
        public string ReservationId { get; private set; }

        /// <summary>
        /// Gets a list of all virtual machine resource ids that are associated
        /// with the capacity reservation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualMachinesAssociated")]
        public IList<SubResourceReadOnly> VirtualMachinesAssociated { get; private set; }

        /// <summary>
        /// Gets the date time when the capacity reservation was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningTime")]
        public System.DateTime? ProvisioningTime { get; private set; }

        /// <summary>
        /// Gets the provisioning state, which only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the Capacity reservation instance view.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceView")]
        public CapacityReservationInstanceView InstanceView { get; private set; }

        /// <summary>
        /// Gets specifies the time at which the Capacity Reservation resource
        /// was created.&amp;lt;br&amp;gt;&amp;lt;br&amp;gt;Minimum
        /// api-version: 2022-03-01.
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeCreated")]
        public System.DateTime? TimeCreated { get; private set; }

        /// <summary>
        /// Gets or sets SKU of the resource for which capacity needs be
        /// reserved. The SKU name and capacity is required to be set.
        /// Currently VM Skus with the capability called
        /// 'CapacityReservationSupported' set to true are supported. Refer to
        /// List Microsoft.Compute SKUs in a region
        /// (https://docs.microsoft.com/rest/api/compute/resourceskus/list) for
        /// supported values.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

    }
}
