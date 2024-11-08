// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Information about the azure function destination for an event subscription. </summary>
    public partial class AzureFunctionEventSubscriptionDestination : EventSubscriptionDestination
    {
        /// <summary> Initializes a new instance of <see cref="AzureFunctionEventSubscriptionDestination"/>. </summary>
        public AzureFunctionEventSubscriptionDestination()
        {
            DeliveryAttributeMappings = new ChangeTrackingList<DeliveryAttributeMapping>();
            EndpointType = EndpointType.AzureFunction;
        }

        /// <summary> Initializes a new instance of <see cref="AzureFunctionEventSubscriptionDestination"/>. </summary>
        /// <param name="endpointType"> Type of the endpoint for the event subscription destination. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="resourceId"> The Azure Resource Id that represents the endpoint of the Azure Function destination of an event subscription. </param>
        /// <param name="maxEventsPerBatch"> Maximum number of events per batch. </param>
        /// <param name="preferredBatchSizeInKilobytes"> Preferred batch size in Kilobytes. </param>
        /// <param name="deliveryAttributeMappings">
        /// Delivery attribute details.
        /// Please note <see cref="DeliveryAttributeMapping"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DynamicDeliveryAttributeMapping"/> and <see cref="StaticDeliveryAttributeMapping"/>.
        /// </param>
        internal AzureFunctionEventSubscriptionDestination(EndpointType endpointType, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier resourceId, int? maxEventsPerBatch, int? preferredBatchSizeInKilobytes, IList<DeliveryAttributeMapping> deliveryAttributeMappings) : base(endpointType, serializedAdditionalRawData)
        {
            ResourceId = resourceId;
            MaxEventsPerBatch = maxEventsPerBatch;
            PreferredBatchSizeInKilobytes = preferredBatchSizeInKilobytes;
            DeliveryAttributeMappings = deliveryAttributeMappings;
            EndpointType = endpointType;
        }

        /// <summary> The Azure Resource Id that represents the endpoint of the Azure Function destination of an event subscription. </summary>
        [WirePath("properties.resourceId")]
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> Maximum number of events per batch. </summary>
        [WirePath("properties.maxEventsPerBatch")]
        public int? MaxEventsPerBatch { get; set; }
        /// <summary> Preferred batch size in Kilobytes. </summary>
        [WirePath("properties.preferredBatchSizeInKilobytes")]
        public int? PreferredBatchSizeInKilobytes { get; set; }
        /// <summary>
        /// Delivery attribute details.
        /// Please note <see cref="DeliveryAttributeMapping"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DynamicDeliveryAttributeMapping"/> and <see cref="StaticDeliveryAttributeMapping"/>.
        /// </summary>
        [WirePath("properties.deliveryAttributeMappings")]
        public IList<DeliveryAttributeMapping> DeliveryAttributeMappings { get; }
    }
}
