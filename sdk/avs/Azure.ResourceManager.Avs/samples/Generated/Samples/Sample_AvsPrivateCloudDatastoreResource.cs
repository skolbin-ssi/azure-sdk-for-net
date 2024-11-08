// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Avs.Samples
{
    public partial class Sample_AvsPrivateCloudDatastoreResource
    {
        // Datastores_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DatastoresGet()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/Datastores_Get.json
            // this example is just showing the usage of "Datastores_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudDatastoreResource created on azure
            // for more information of creating AvsPrivateCloudDatastoreResource, please refer to the document of AvsPrivateCloudDatastoreResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string clusterName = "cluster1";
            string datastoreName = "datastore1";
            ResourceIdentifier avsPrivateCloudDatastoreResourceId = AvsPrivateCloudDatastoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, clusterName, datastoreName);
            AvsPrivateCloudDatastoreResource avsPrivateCloudDatastore = client.GetAvsPrivateCloudDatastoreResource(avsPrivateCloudDatastoreResourceId);

            // invoke the operation
            AvsPrivateCloudDatastoreResource result = await avsPrivateCloudDatastore.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AvsPrivateCloudDatastoreData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Datastores_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_DatastoresCreateOrUpdate()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/Datastores_CreateOrUpdate.json
            // this example is just showing the usage of "Datastores_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudDatastoreResource created on azure
            // for more information of creating AvsPrivateCloudDatastoreResource, please refer to the document of AvsPrivateCloudDatastoreResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string clusterName = "cluster1";
            string datastoreName = "datastore1";
            ResourceIdentifier avsPrivateCloudDatastoreResourceId = AvsPrivateCloudDatastoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, clusterName, datastoreName);
            AvsPrivateCloudDatastoreResource avsPrivateCloudDatastore = client.GetAvsPrivateCloudDatastoreResource(avsPrivateCloudDatastoreResourceId);

            // invoke the operation
            AvsPrivateCloudDatastoreData data = new AvsPrivateCloudDatastoreData()
            {
                NetAppVolumeId = new ResourceIdentifier("/subscriptions/11111111-1111-1111-1111-111111111111/resourceGroups/ResourceGroup1/providers/Microsoft.NetApp/netAppAccounts/NetAppAccount1/capacityPools/CapacityPool1/volumes/NFSVol1"),
            };
            ArmOperation<AvsPrivateCloudDatastoreResource> lro = await avsPrivateCloudDatastore.UpdateAsync(WaitUntil.Completed, data);
            AvsPrivateCloudDatastoreResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AvsPrivateCloudDatastoreData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Datastores_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DatastoresDelete()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/Datastores_Delete.json
            // this example is just showing the usage of "Datastores_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudDatastoreResource created on azure
            // for more information of creating AvsPrivateCloudDatastoreResource, please refer to the document of AvsPrivateCloudDatastoreResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string clusterName = "cluster1";
            string datastoreName = "datastore1";
            ResourceIdentifier avsPrivateCloudDatastoreResourceId = AvsPrivateCloudDatastoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, clusterName, datastoreName);
            AvsPrivateCloudDatastoreResource avsPrivateCloudDatastore = client.GetAvsPrivateCloudDatastoreResource(avsPrivateCloudDatastoreResourceId);

            // invoke the operation
            await avsPrivateCloudDatastore.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
