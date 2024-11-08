// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_CosmosDBPrivateEndpointConnectionCollection
    {
        // Gets private endpoint connection.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetsPrivateEndpointConnection()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBPrivateEndpointConnectionListGet.json
            // this example is just showing the usage of "PrivateEndpointConnections_ListByDatabaseAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBAccountResource created on azure
            // for more information of creating CosmosDBAccountResource, please refer to the document of CosmosDBAccountResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            ResourceIdentifier cosmosDBAccountResourceId = CosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CosmosDBAccountResource cosmosDBAccount = client.GetCosmosDBAccountResource(cosmosDBAccountResourceId);

            // get the collection of this CosmosDBPrivateEndpointConnectionResource
            CosmosDBPrivateEndpointConnectionCollection collection = cosmosDBAccount.GetCosmosDBPrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (CosmosDBPrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CosmosDBPrivateEndpointConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Gets private endpoint connection.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsPrivateEndpointConnection()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBPrivateEndpointConnectionGet.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBAccountResource created on azure
            // for more information of creating CosmosDBAccountResource, please refer to the document of CosmosDBAccountResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            ResourceIdentifier cosmosDBAccountResourceId = CosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CosmosDBAccountResource cosmosDBAccount = client.GetCosmosDBAccountResource(cosmosDBAccountResourceId);

            // get the collection of this CosmosDBPrivateEndpointConnectionResource
            CosmosDBPrivateEndpointConnectionCollection collection = cosmosDBAccount.GetCosmosDBPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            CosmosDBPrivateEndpointConnectionResource result = await collection.GetAsync(privateEndpointConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets private endpoint connection.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetsPrivateEndpointConnection()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBPrivateEndpointConnectionGet.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBAccountResource created on azure
            // for more information of creating CosmosDBAccountResource, please refer to the document of CosmosDBAccountResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            ResourceIdentifier cosmosDBAccountResourceId = CosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CosmosDBAccountResource cosmosDBAccount = client.GetCosmosDBAccountResource(cosmosDBAccountResourceId);

            // get the collection of this CosmosDBPrivateEndpointConnectionResource
            CosmosDBPrivateEndpointConnectionCollection collection = cosmosDBAccount.GetCosmosDBPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Gets private endpoint connection.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetsPrivateEndpointConnection()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBPrivateEndpointConnectionGet.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBAccountResource created on azure
            // for more information of creating CosmosDBAccountResource, please refer to the document of CosmosDBAccountResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            ResourceIdentifier cosmosDBAccountResourceId = CosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CosmosDBAccountResource cosmosDBAccount = client.GetCosmosDBAccountResource(cosmosDBAccountResourceId);

            // get the collection of this CosmosDBPrivateEndpointConnectionResource
            CosmosDBPrivateEndpointConnectionCollection collection = cosmosDBAccount.GetCosmosDBPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            NullableResponse<CosmosDBPrivateEndpointConnectionResource> response = await collection.GetIfExistsAsync(privateEndpointConnectionName);
            CosmosDBPrivateEndpointConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CosmosDBPrivateEndpointConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Approve or reject a private endpoint connection with a given name.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ApproveOrRejectAPrivateEndpointConnectionWithAGivenName()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBPrivateEndpointConnectionUpdate.json
            // this example is just showing the usage of "PrivateEndpointConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBAccountResource created on azure
            // for more information of creating CosmosDBAccountResource, please refer to the document of CosmosDBAccountResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            ResourceIdentifier cosmosDBAccountResourceId = CosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CosmosDBAccountResource cosmosDBAccount = client.GetCosmosDBAccountResource(cosmosDBAccountResourceId);

            // get the collection of this CosmosDBPrivateEndpointConnectionResource
            CosmosDBPrivateEndpointConnectionCollection collection = cosmosDBAccount.GetCosmosDBPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            CosmosDBPrivateEndpointConnectionData data = new CosmosDBPrivateEndpointConnectionData()
            {
                ConnectionState = new CosmosDBPrivateLinkServiceConnectionStateProperty()
                {
                    Status = "Approved",
                    Description = "Approved by johndoe@contoso.com",
                },
            };
            ArmOperation<CosmosDBPrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, data);
            CosmosDBPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
