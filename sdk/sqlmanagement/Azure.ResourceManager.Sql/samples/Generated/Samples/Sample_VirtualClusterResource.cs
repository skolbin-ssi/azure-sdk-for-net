// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_VirtualClusterResource
    {
        // List virtualClusters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVirtualClusters_ListVirtualClusters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-05-01-preview/examples/VirtualClusterList.json
            // this example is just showing the usage of "VirtualClusters_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "20d7082a-0fc7-4468-82bd-542694d5042b";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (VirtualClusterResource item in subscriptionResource.GetVirtualClustersAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualClusterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Gets a virtual cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsAVirtualCluster()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-05-01-preview/examples/VirtualClusterGet.json
            // this example is just showing the usage of "VirtualClusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualClusterResource created on azure
            // for more information of creating VirtualClusterResource, please refer to the document of VirtualClusterResource
            string subscriptionId = "20d7082a-0fc7-4468-82bd-542694d5042b";
            string resourceGroupName = "testrg";
            string virtualClusterName = "vc-f769ed71-b3ad-491a-a9d5-26eeceaa6be2";
            ResourceIdentifier virtualClusterResourceId = VirtualClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualClusterName);
            VirtualClusterResource virtualCluster = client.GetVirtualClusterResource(virtualClusterResourceId);

            // invoke the operation
            VirtualClusterResource result = await virtualCluster.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete virtual cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteVirtualCluster()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-05-01-preview/examples/VirtualClusterDelete.json
            // this example is just showing the usage of "VirtualClusters_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualClusterResource created on azure
            // for more information of creating VirtualClusterResource, please refer to the document of VirtualClusterResource
            string subscriptionId = "20d7082a-0fc7-4468-82bd-542694d5042b";
            string resourceGroupName = "testrg";
            string virtualClusterName = "vc-subnet1-f769ed71-b3ad-491a-a9d5-26eeceaa6be2";
            ResourceIdentifier virtualClusterResourceId = VirtualClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualClusterName);
            VirtualClusterResource virtualCluster = client.GetVirtualClusterResource(virtualClusterResourceId);

            // invoke the operation
            await virtualCluster.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Update virtual cluster with tags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateVirtualClusterWithTags()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-05-01-preview/examples/VirtualClusterUpdate.json
            // this example is just showing the usage of "VirtualClusters_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualClusterResource created on azure
            // for more information of creating VirtualClusterResource, please refer to the document of VirtualClusterResource
            string subscriptionId = "20d7082a-0fc7-4468-82bd-542694d5042b";
            string resourceGroupName = "testrg";
            string virtualClusterName = "vc-subnet1-f769ed71-b3ad-491a-a9d5-26eeceaa6be2";
            ResourceIdentifier virtualClusterResourceId = VirtualClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualClusterName);
            VirtualClusterResource virtualCluster = client.GetVirtualClusterResource(virtualClusterResourceId);

            // invoke the operation
            VirtualClusterPatch patch = new VirtualClusterPatch()
            {
                Tags =
{
["tkey"] = "tvalue1",
},
            };
            ArmOperation<VirtualClusterResource> lro = await virtualCluster.UpdateAsync(WaitUntil.Completed, patch);
            VirtualClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Performs update of dns servers on managed instance.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task UpdateDnsServers_PerformsUpdateOfDnsServersOnManagedInstance()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-05-01-preview/examples/UpdateVirtualClusterDnsServers.json
            // this example is just showing the usage of "VirtualClusters_UpdateDnsServers" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualClusterResource created on azure
            // for more information of creating VirtualClusterResource, please refer to the document of VirtualClusterResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            string virtualClusterName = "VirtualCluster2b9a846b-2e37-43ef-a8e9-f2c6d645c1d7";
            ResourceIdentifier virtualClusterResourceId = VirtualClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualClusterName);
            VirtualClusterResource virtualCluster = client.GetVirtualClusterResource(virtualClusterResourceId);

            // invoke the operation
            ArmOperation<ManagedInstanceUpdateDnsServersOperationData> lro = await virtualCluster.UpdateDnsServersAsync(WaitUntil.Completed);
            ManagedInstanceUpdateDnsServersOperationData result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
