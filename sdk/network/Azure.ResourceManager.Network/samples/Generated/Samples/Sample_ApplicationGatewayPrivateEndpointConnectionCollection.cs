// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ApplicationGatewayPrivateEndpointConnectionCollection
    {
        // Update Application Gateway Private Endpoint Connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_UpdateApplicationGatewayPrivateEndpointConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ApplicationGatewayPrivateEndpointConnectionUpdate.json
            // this example is just showing the usage of "ApplicationGatewayPrivateEndpointConnections_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayResource created on azure
            // for more information of creating ApplicationGatewayResource, please refer to the document of ApplicationGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string applicationGatewayName = "appgw";
            ResourceIdentifier applicationGatewayResourceId = ApplicationGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGatewayName);
            ApplicationGatewayResource applicationGateway = client.GetApplicationGatewayResource(applicationGatewayResourceId);

            // get the collection of this ApplicationGatewayPrivateEndpointConnectionResource
            ApplicationGatewayPrivateEndpointConnectionCollection collection = applicationGateway.GetApplicationGatewayPrivateEndpointConnections();

            // invoke the operation
            string connectionName = "connection1";
            ApplicationGatewayPrivateEndpointConnectionData data = new ApplicationGatewayPrivateEndpointConnectionData()
            {
                ConnectionState = new NetworkPrivateLinkServiceConnectionState()
                {
                    Status = "Approved",
                    Description = "approved it for some reason.",
                },
                Name = "connection1",
            };
            ArmOperation<ApplicationGatewayPrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, connectionName, data);
            ApplicationGatewayPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApplicationGatewayPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Application Gateway Private Endpoint Connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetApplicationGatewayPrivateEndpointConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ApplicationGatewayPrivateEndpointConnectionGet.json
            // this example is just showing the usage of "ApplicationGatewayPrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayResource created on azure
            // for more information of creating ApplicationGatewayResource, please refer to the document of ApplicationGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string applicationGatewayName = "appgw";
            ResourceIdentifier applicationGatewayResourceId = ApplicationGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGatewayName);
            ApplicationGatewayResource applicationGateway = client.GetApplicationGatewayResource(applicationGatewayResourceId);

            // get the collection of this ApplicationGatewayPrivateEndpointConnectionResource
            ApplicationGatewayPrivateEndpointConnectionCollection collection = applicationGateway.GetApplicationGatewayPrivateEndpointConnections();

            // invoke the operation
            string connectionName = "connection1";
            ApplicationGatewayPrivateEndpointConnectionResource result = await collection.GetAsync(connectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApplicationGatewayPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Application Gateway Private Endpoint Connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetApplicationGatewayPrivateEndpointConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ApplicationGatewayPrivateEndpointConnectionGet.json
            // this example is just showing the usage of "ApplicationGatewayPrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayResource created on azure
            // for more information of creating ApplicationGatewayResource, please refer to the document of ApplicationGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string applicationGatewayName = "appgw";
            ResourceIdentifier applicationGatewayResourceId = ApplicationGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGatewayName);
            ApplicationGatewayResource applicationGateway = client.GetApplicationGatewayResource(applicationGatewayResourceId);

            // get the collection of this ApplicationGatewayPrivateEndpointConnectionResource
            ApplicationGatewayPrivateEndpointConnectionCollection collection = applicationGateway.GetApplicationGatewayPrivateEndpointConnections();

            // invoke the operation
            string connectionName = "connection1";
            bool result = await collection.ExistsAsync(connectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Application Gateway Private Endpoint Connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetApplicationGatewayPrivateEndpointConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ApplicationGatewayPrivateEndpointConnectionGet.json
            // this example is just showing the usage of "ApplicationGatewayPrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayResource created on azure
            // for more information of creating ApplicationGatewayResource, please refer to the document of ApplicationGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string applicationGatewayName = "appgw";
            ResourceIdentifier applicationGatewayResourceId = ApplicationGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGatewayName);
            ApplicationGatewayResource applicationGateway = client.GetApplicationGatewayResource(applicationGatewayResourceId);

            // get the collection of this ApplicationGatewayPrivateEndpointConnectionResource
            ApplicationGatewayPrivateEndpointConnectionCollection collection = applicationGateway.GetApplicationGatewayPrivateEndpointConnections();

            // invoke the operation
            string connectionName = "connection1";
            NullableResponse<ApplicationGatewayPrivateEndpointConnectionResource> response = await collection.GetIfExistsAsync(connectionName);
            ApplicationGatewayPrivateEndpointConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApplicationGatewayPrivateEndpointConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Lists all private endpoint connections on application gateway
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListsAllPrivateEndpointConnectionsOnApplicationGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ApplicationGatewayPrivateEndpointConnectionList.json
            // this example is just showing the usage of "ApplicationGatewayPrivateEndpointConnections_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayResource created on azure
            // for more information of creating ApplicationGatewayResource, please refer to the document of ApplicationGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string applicationGatewayName = "appgw";
            ResourceIdentifier applicationGatewayResourceId = ApplicationGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGatewayName);
            ApplicationGatewayResource applicationGateway = client.GetApplicationGatewayResource(applicationGatewayResourceId);

            // get the collection of this ApplicationGatewayPrivateEndpointConnectionResource
            ApplicationGatewayPrivateEndpointConnectionCollection collection = applicationGateway.GetApplicationGatewayPrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (ApplicationGatewayPrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApplicationGatewayPrivateEndpointConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
