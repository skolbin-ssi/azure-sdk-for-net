// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.AppPlatform.Samples
{
    public partial class Sample_AppPlatformGatewayCustomDomainCollection
    {
        // GatewayCustomDomains_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GatewayCustomDomainsGet()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/GatewayCustomDomains_Get.json
            // this example is just showing the usage of "GatewayCustomDomains_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformGatewayResource created on azure
            // for more information of creating AppPlatformGatewayResource, please refer to the document of AppPlatformGatewayResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string gatewayName = "default";
            ResourceIdentifier appPlatformGatewayResourceId = AppPlatformGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, gatewayName);
            AppPlatformGatewayResource appPlatformGateway = client.GetAppPlatformGatewayResource(appPlatformGatewayResourceId);

            // get the collection of this AppPlatformGatewayCustomDomainResource
            AppPlatformGatewayCustomDomainCollection collection = appPlatformGateway.GetAppPlatformGatewayCustomDomains();

            // invoke the operation
            string domainName = "myDomainName";
            AppPlatformGatewayCustomDomainResource result = await collection.GetAsync(domainName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppPlatformGatewayCustomDomainData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GatewayCustomDomains_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GatewayCustomDomainsGet()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/GatewayCustomDomains_Get.json
            // this example is just showing the usage of "GatewayCustomDomains_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformGatewayResource created on azure
            // for more information of creating AppPlatformGatewayResource, please refer to the document of AppPlatformGatewayResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string gatewayName = "default";
            ResourceIdentifier appPlatformGatewayResourceId = AppPlatformGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, gatewayName);
            AppPlatformGatewayResource appPlatformGateway = client.GetAppPlatformGatewayResource(appPlatformGatewayResourceId);

            // get the collection of this AppPlatformGatewayCustomDomainResource
            AppPlatformGatewayCustomDomainCollection collection = appPlatformGateway.GetAppPlatformGatewayCustomDomains();

            // invoke the operation
            string domainName = "myDomainName";
            bool result = await collection.ExistsAsync(domainName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GatewayCustomDomains_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GatewayCustomDomainsGet()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/GatewayCustomDomains_Get.json
            // this example is just showing the usage of "GatewayCustomDomains_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformGatewayResource created on azure
            // for more information of creating AppPlatformGatewayResource, please refer to the document of AppPlatformGatewayResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string gatewayName = "default";
            ResourceIdentifier appPlatformGatewayResourceId = AppPlatformGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, gatewayName);
            AppPlatformGatewayResource appPlatformGateway = client.GetAppPlatformGatewayResource(appPlatformGatewayResourceId);

            // get the collection of this AppPlatformGatewayCustomDomainResource
            AppPlatformGatewayCustomDomainCollection collection = appPlatformGateway.GetAppPlatformGatewayCustomDomains();

            // invoke the operation
            string domainName = "myDomainName";
            NullableResponse<AppPlatformGatewayCustomDomainResource> response = await collection.GetIfExistsAsync(domainName);
            AppPlatformGatewayCustomDomainResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppPlatformGatewayCustomDomainData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // GatewayCustomDomains_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_GatewayCustomDomainsCreateOrUpdate()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/GatewayCustomDomains_CreateOrUpdate.json
            // this example is just showing the usage of "GatewayCustomDomains_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformGatewayResource created on azure
            // for more information of creating AppPlatformGatewayResource, please refer to the document of AppPlatformGatewayResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string gatewayName = "default";
            ResourceIdentifier appPlatformGatewayResourceId = AppPlatformGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, gatewayName);
            AppPlatformGatewayResource appPlatformGateway = client.GetAppPlatformGatewayResource(appPlatformGatewayResourceId);

            // get the collection of this AppPlatformGatewayCustomDomainResource
            AppPlatformGatewayCustomDomainCollection collection = appPlatformGateway.GetAppPlatformGatewayCustomDomains();

            // invoke the operation
            string domainName = "myDomainName";
            AppPlatformGatewayCustomDomainData data = new AppPlatformGatewayCustomDomainData()
            {
                GatewayCustomDomainThumbprint = "*",
            };
            ArmOperation<AppPlatformGatewayCustomDomainResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, domainName, data);
            AppPlatformGatewayCustomDomainResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppPlatformGatewayCustomDomainData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GatewayCustomDomains_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GatewayCustomDomainsList()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/GatewayCustomDomains_List.json
            // this example is just showing the usage of "GatewayCustomDomains_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformGatewayResource created on azure
            // for more information of creating AppPlatformGatewayResource, please refer to the document of AppPlatformGatewayResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string gatewayName = "default";
            ResourceIdentifier appPlatformGatewayResourceId = AppPlatformGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, gatewayName);
            AppPlatformGatewayResource appPlatformGateway = client.GetAppPlatformGatewayResource(appPlatformGatewayResourceId);

            // get the collection of this AppPlatformGatewayCustomDomainResource
            AppPlatformGatewayCustomDomainCollection collection = appPlatformGateway.GetAppPlatformGatewayCustomDomains();

            // invoke the operation and iterate over the result
            await foreach (AppPlatformGatewayCustomDomainResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppPlatformGatewayCustomDomainData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
