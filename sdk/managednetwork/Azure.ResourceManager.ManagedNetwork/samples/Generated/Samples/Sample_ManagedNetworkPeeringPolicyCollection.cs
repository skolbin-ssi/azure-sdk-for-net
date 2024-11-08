// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ManagedNetwork.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ManagedNetwork.Samples
{
    public partial class Sample_ManagedNetworkPeeringPolicyCollection
    {
        // ManagedNetworkPeeringPoliciesGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ManagedNetworkPeeringPoliciesGet()
        {
            // Generated from example definition: specification/managednetwork/resource-manager/Microsoft.ManagedNetwork/preview/2019-06-01-preview/examples/ManagedNetworkPeeringPolicy/ManagedNetworkPeeringPoliciesGet.json
            // this example is just showing the usage of "ManagedNetworkPeeringPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedNetworkResource created on azure
            // for more information of creating ManagedNetworkResource, please refer to the document of ManagedNetworkResource
            string subscriptionId = "subscriptionA";
            string resourceGroupName = "myResourceGroup";
            string managedNetworkName = "myManagedNetwork";
            ResourceIdentifier managedNetworkResourceId = ManagedNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedNetworkName);
            ManagedNetworkResource managedNetwork = client.GetManagedNetworkResource(managedNetworkResourceId);

            // get the collection of this ManagedNetworkPeeringPolicyResource
            ManagedNetworkPeeringPolicyCollection collection = managedNetwork.GetManagedNetworkPeeringPolicies();

            // invoke the operation
            string managedNetworkPeeringPolicyName = "myHubAndSpoke";
            ManagedNetworkPeeringPolicyResource result = await collection.GetAsync(managedNetworkPeeringPolicyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedNetworkPeeringPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ManagedNetworkPeeringPoliciesGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ManagedNetworkPeeringPoliciesGet()
        {
            // Generated from example definition: specification/managednetwork/resource-manager/Microsoft.ManagedNetwork/preview/2019-06-01-preview/examples/ManagedNetworkPeeringPolicy/ManagedNetworkPeeringPoliciesGet.json
            // this example is just showing the usage of "ManagedNetworkPeeringPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedNetworkResource created on azure
            // for more information of creating ManagedNetworkResource, please refer to the document of ManagedNetworkResource
            string subscriptionId = "subscriptionA";
            string resourceGroupName = "myResourceGroup";
            string managedNetworkName = "myManagedNetwork";
            ResourceIdentifier managedNetworkResourceId = ManagedNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedNetworkName);
            ManagedNetworkResource managedNetwork = client.GetManagedNetworkResource(managedNetworkResourceId);

            // get the collection of this ManagedNetworkPeeringPolicyResource
            ManagedNetworkPeeringPolicyCollection collection = managedNetwork.GetManagedNetworkPeeringPolicies();

            // invoke the operation
            string managedNetworkPeeringPolicyName = "myHubAndSpoke";
            bool result = await collection.ExistsAsync(managedNetworkPeeringPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ManagedNetworkPeeringPoliciesGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ManagedNetworkPeeringPoliciesGet()
        {
            // Generated from example definition: specification/managednetwork/resource-manager/Microsoft.ManagedNetwork/preview/2019-06-01-preview/examples/ManagedNetworkPeeringPolicy/ManagedNetworkPeeringPoliciesGet.json
            // this example is just showing the usage of "ManagedNetworkPeeringPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedNetworkResource created on azure
            // for more information of creating ManagedNetworkResource, please refer to the document of ManagedNetworkResource
            string subscriptionId = "subscriptionA";
            string resourceGroupName = "myResourceGroup";
            string managedNetworkName = "myManagedNetwork";
            ResourceIdentifier managedNetworkResourceId = ManagedNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedNetworkName);
            ManagedNetworkResource managedNetwork = client.GetManagedNetworkResource(managedNetworkResourceId);

            // get the collection of this ManagedNetworkPeeringPolicyResource
            ManagedNetworkPeeringPolicyCollection collection = managedNetwork.GetManagedNetworkPeeringPolicies();

            // invoke the operation
            string managedNetworkPeeringPolicyName = "myHubAndSpoke";
            NullableResponse<ManagedNetworkPeeringPolicyResource> response = await collection.GetIfExistsAsync(managedNetworkPeeringPolicyName);
            ManagedNetworkPeeringPolicyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedNetworkPeeringPolicyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ManagedNetworkPeeringPoliciesPut
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ManagedNetworkPeeringPoliciesPut()
        {
            // Generated from example definition: specification/managednetwork/resource-manager/Microsoft.ManagedNetwork/preview/2019-06-01-preview/examples/ManagedNetworkPeeringPolicy/ManagedNetworkPeeringPoliciesPut.json
            // this example is just showing the usage of "ManagedNetworkPeeringPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedNetworkResource created on azure
            // for more information of creating ManagedNetworkResource, please refer to the document of ManagedNetworkResource
            string subscriptionId = "subscriptionA";
            string resourceGroupName = "myResourceGroup";
            string managedNetworkName = "myManagedNetwork";
            ResourceIdentifier managedNetworkResourceId = ManagedNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedNetworkName);
            ManagedNetworkResource managedNetwork = client.GetManagedNetworkResource(managedNetworkResourceId);

            // get the collection of this ManagedNetworkPeeringPolicyResource
            ManagedNetworkPeeringPolicyCollection collection = managedNetwork.GetManagedNetworkPeeringPolicies();

            // invoke the operation
            string managedNetworkPeeringPolicyName = "myHubAndSpoke";
            ManagedNetworkPeeringPolicyData data = new ManagedNetworkPeeringPolicyData()
            {
                Properties = new ManagedNetworkPeeringPolicyProperties(ConnectivityType.HubAndSpokeTopology)
                {
                    HubId = new ResourceIdentifier("/subscriptionB/resourceGroups/myResourceGroup/providers/Microsoft.Network/virtualNetworks/myHubVnet"),
                    Spokes =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptionB/resourceGroups/myResourceGroup/providers/Microsoft.ManagedNetwork/managedNetworks/myManagedNetwork/managedNetworkGroups/myManagedNetworkGroup1"),
}
},
                },
            };
            ArmOperation<ManagedNetworkPeeringPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, managedNetworkPeeringPolicyName, data);
            ManagedNetworkPeeringPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedNetworkPeeringPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ManagedNetworkPeeringPoliciesListByManagedNetwork
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ManagedNetworkPeeringPoliciesListByManagedNetwork()
        {
            // Generated from example definition: specification/managednetwork/resource-manager/Microsoft.ManagedNetwork/preview/2019-06-01-preview/examples/ManagedNetworkPeeringPolicy/ManagedNetworkPeeringPoliciesListByManagedNetwork.json
            // this example is just showing the usage of "ManagedNetworkPeeringPolicies_ListByManagedNetwork" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedNetworkResource created on azure
            // for more information of creating ManagedNetworkResource, please refer to the document of ManagedNetworkResource
            string subscriptionId = "subscriptionA";
            string resourceGroupName = "myResourceGroup";
            string managedNetworkName = "myManagedNetwork";
            ResourceIdentifier managedNetworkResourceId = ManagedNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedNetworkName);
            ManagedNetworkResource managedNetwork = client.GetManagedNetworkResource(managedNetworkResourceId);

            // get the collection of this ManagedNetworkPeeringPolicyResource
            ManagedNetworkPeeringPolicyCollection collection = managedNetwork.GetManagedNetworkPeeringPolicies();

            // invoke the operation and iterate over the result
            await foreach (ManagedNetworkPeeringPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedNetworkPeeringPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
