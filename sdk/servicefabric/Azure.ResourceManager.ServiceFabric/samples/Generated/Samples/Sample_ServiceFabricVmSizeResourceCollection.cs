// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ServiceFabric.Samples
{
    public partial class Sample_ServiceFabricVmSizeResourceCollection
    {
        // List unsupported vm sizes
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListUnsupportedVmSizes()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/UnsupportedVMSizesList_example.json
            // this example is just showing the usage of "UnsupportedVmSizes_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this ServiceFabricVmSizeResource
            AzureLocation location = new AzureLocation("eastus");
            ServiceFabricVmSizeResourceCollection collection = subscriptionResource.GetServiceFabricVmSizeResources(location);

            // invoke the operation and iterate over the result
            await foreach (ServiceFabricVmSizeResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceFabricVmSizeResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get unsupported vm sizes
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetUnsupportedVmSizes()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/UnsupportedVMSizesGet_example.json
            // this example is just showing the usage of "UnsupportedVmSizes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this ServiceFabricVmSizeResource
            AzureLocation location = new AzureLocation("eastus");
            ServiceFabricVmSizeResourceCollection collection = subscriptionResource.GetServiceFabricVmSizeResources(location);

            // invoke the operation
            string vmSize = "Standard_B1ls1";
            ServiceFabricVmSizeResource result = await collection.GetAsync(vmSize);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricVmSizeResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get unsupported vm sizes
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetUnsupportedVmSizes()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/UnsupportedVMSizesGet_example.json
            // this example is just showing the usage of "UnsupportedVmSizes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this ServiceFabricVmSizeResource
            AzureLocation location = new AzureLocation("eastus");
            ServiceFabricVmSizeResourceCollection collection = subscriptionResource.GetServiceFabricVmSizeResources(location);

            // invoke the operation
            string vmSize = "Standard_B1ls1";
            bool result = await collection.ExistsAsync(vmSize);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get unsupported vm sizes
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetUnsupportedVmSizes()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/UnsupportedVMSizesGet_example.json
            // this example is just showing the usage of "UnsupportedVmSizes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this ServiceFabricVmSizeResource
            AzureLocation location = new AzureLocation("eastus");
            ServiceFabricVmSizeResourceCollection collection = subscriptionResource.GetServiceFabricVmSizeResources(location);

            // invoke the operation
            string vmSize = "Standard_B1ls1";
            NullableResponse<ServiceFabricVmSizeResource> response = await collection.GetIfExistsAsync(vmSize);
            ServiceFabricVmSizeResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceFabricVmSizeResourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
