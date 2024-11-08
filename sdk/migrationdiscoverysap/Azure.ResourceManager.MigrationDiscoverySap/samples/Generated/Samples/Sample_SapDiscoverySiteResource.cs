// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MigrationDiscoverySap.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MigrationDiscoverySap.Samples
{
    public partial class Sample_SapDiscoverySiteResource
    {
        // List SAP Migration discovery site resources in a subscription.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSapDiscoverySites_ListSAPMigrationDiscoverySiteResourcesInASubscription()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/SAPDiscoverySites/preview/2023-10-01-preview/examples/SAPDiscoverySites_ListBySubscription.json
            // this example is just showing the usage of "SapDiscoverySites_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "6d875e77-e412-4d7d-9af4-8895278b4443";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (SapDiscoverySiteResource item in subscriptionResource.GetSapDiscoverySitesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SapDiscoverySiteData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // GET a SAP Migration discovery site resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GETASAPMigrationDiscoverySiteResource()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/SAPDiscoverySites/preview/2023-10-01-preview/examples/SAPDiscoverySites_Get.json
            // this example is just showing the usage of "SapDiscoverySites_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapDiscoverySiteResource created on azure
            // for more information of creating SapDiscoverySiteResource, please refer to the document of SapDiscoverySiteResource
            string subscriptionId = "6d875e77-e412-4d7d-9af4-8895278b4443";
            string resourceGroupName = "test-rg";
            string sapDiscoverySiteName = "SampleSite";
            ResourceIdentifier sapDiscoverySiteResourceId = SapDiscoverySiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapDiscoverySiteName);
            SapDiscoverySiteResource sapDiscoverySite = client.GetSapDiscoverySiteResource(sapDiscoverySiteResourceId);

            // invoke the operation
            SapDiscoverySiteResource result = await sapDiscoverySite.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SapDiscoverySiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Updates a SAP Migration discovery site resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdatesASAPMigrationDiscoverySiteResource()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/SAPDiscoverySites/preview/2023-10-01-preview/examples/SAPDiscoverySites_Update.json
            // this example is just showing the usage of "SapDiscoverySites_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapDiscoverySiteResource created on azure
            // for more information of creating SapDiscoverySiteResource, please refer to the document of SapDiscoverySiteResource
            string subscriptionId = "6d875e77-e412-4d7d-9af4-8895278b4443";
            string resourceGroupName = "test-rg";
            string sapDiscoverySiteName = "SampleSite";
            ResourceIdentifier sapDiscoverySiteResourceId = SapDiscoverySiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapDiscoverySiteName);
            SapDiscoverySiteResource sapDiscoverySite = client.GetSapDiscoverySiteResource(sapDiscoverySiteResourceId);

            // invoke the operation
            SapDiscoverySitePatch patch = new SapDiscoverySitePatch()
            {
                Tags =
{
["tag1"] = "value1",
},
            };
            SapDiscoverySiteResource result = await sapDiscoverySite.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SapDiscoverySiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Deletes a SAP Migration discovery site resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletesASAPMigrationDiscoverySiteResource()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/SAPDiscoverySites/preview/2023-10-01-preview/examples/SAPDiscoverySites_Delete.json
            // this example is just showing the usage of "SapDiscoverySites_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapDiscoverySiteResource created on azure
            // for more information of creating SapDiscoverySiteResource, please refer to the document of SapDiscoverySiteResource
            string subscriptionId = "6d875e77-e412-4d7d-9af4-8895278b4443";
            string resourceGroupName = "test-rg";
            string sapDiscoverySiteName = "SampleSite";
            ResourceIdentifier sapDiscoverySiteResourceId = SapDiscoverySiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapDiscoverySiteName);
            SapDiscoverySiteResource sapDiscoverySite = client.GetSapDiscoverySiteResource(sapDiscoverySiteResourceId);

            // invoke the operation
            await sapDiscoverySite.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Import a SAP Migration discovery site resource and it's child resources.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ImportEntities_ImportASAPMigrationDiscoverySiteResourceAndItSChildResources()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/SAPDiscoverySites/preview/2023-10-01-preview/examples/SAPDiscoverySites_ImportEntities.json
            // this example is just showing the usage of "SapDiscoverySites_ImportEntities" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapDiscoverySiteResource created on azure
            // for more information of creating SapDiscoverySiteResource, please refer to the document of SapDiscoverySiteResource
            string subscriptionId = "6d875e77-e412-4d7d-9af4-8895278b4443";
            string resourceGroupName = "test-rg";
            string sapDiscoverySiteName = "SampleSite";
            ResourceIdentifier sapDiscoverySiteResourceId = SapDiscoverySiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapDiscoverySiteName);
            SapDiscoverySiteResource sapDiscoverySite = client.GetSapDiscoverySiteResource(sapDiscoverySiteResourceId);

            // invoke the operation
            ArmOperation<OperationStatusResult> lro = await sapDiscoverySite.ImportEntitiesAsync(WaitUntil.Completed);
            OperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
