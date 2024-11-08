// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_PublicIPAddressCollection
    {
        // Get public IP address
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPublicIPAddress()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/PublicIpAddressGet.json
            // this example is just showing the usage of "PublicIPAddresses_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this PublicIPAddressResource
            PublicIPAddressCollection collection = resourceGroupResource.GetPublicIPAddresses();

            // invoke the operation
            string publicIPAddressName = "testDNS-ip";
            PublicIPAddressResource result = await collection.GetAsync(publicIPAddressName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PublicIPAddressData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get public IP address
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetPublicIPAddress()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/PublicIpAddressGet.json
            // this example is just showing the usage of "PublicIPAddresses_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this PublicIPAddressResource
            PublicIPAddressCollection collection = resourceGroupResource.GetPublicIPAddresses();

            // invoke the operation
            string publicIPAddressName = "testDNS-ip";
            bool result = await collection.ExistsAsync(publicIPAddressName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get public IP address
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetPublicIPAddress()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/PublicIpAddressGet.json
            // this example is just showing the usage of "PublicIPAddresses_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this PublicIPAddressResource
            PublicIPAddressCollection collection = resourceGroupResource.GetPublicIPAddresses();

            // invoke the operation
            string publicIPAddressName = "testDNS-ip";
            NullableResponse<PublicIPAddressResource> response = await collection.GetIfExistsAsync(publicIPAddressName);
            PublicIPAddressResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PublicIPAddressData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create public IP address DNS
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreatePublicIPAddressDNS()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/PublicIpAddressCreateDns.json
            // this example is just showing the usage of "PublicIPAddresses_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this PublicIPAddressResource
            PublicIPAddressCollection collection = resourceGroupResource.GetPublicIPAddresses();

            // invoke the operation
            string publicIPAddressName = "test-ip";
            PublicIPAddressData data = new PublicIPAddressData()
            {
                DnsSettings = new PublicIPAddressDnsSettings()
                {
                    DomainNameLabel = "dnslbl",
                },
                Location = new AzureLocation("eastus"),
            };
            ArmOperation<PublicIPAddressResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, publicIPAddressName, data);
            PublicIPAddressResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PublicIPAddressData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create public IP address DNS with Domain Name Label Scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreatePublicIPAddressDNSWithDomainNameLabelScope()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/PublicIpAddressCreateDnsWithDomainNameLabelScope.json
            // this example is just showing the usage of "PublicIPAddresses_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this PublicIPAddressResource
            PublicIPAddressCollection collection = resourceGroupResource.GetPublicIPAddresses();

            // invoke the operation
            string publicIPAddressName = "test-ip";
            PublicIPAddressData data = new PublicIPAddressData()
            {
                DnsSettings = new PublicIPAddressDnsSettings()
                {
                    DomainNameLabel = "dnslbl",
                    DomainNameLabelScope = PublicIPAddressDnsSettingsDomainNameLabelScope.TenantReuse,
                },
                Location = new AzureLocation("eastus"),
            };
            ArmOperation<PublicIPAddressResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, publicIPAddressName, data);
            PublicIPAddressResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PublicIPAddressData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create public IP address allocation method
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreatePublicIPAddressAllocationMethod()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/PublicIpAddressCreateCustomizedValues.json
            // this example is just showing the usage of "PublicIPAddresses_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this PublicIPAddressResource
            PublicIPAddressCollection collection = resourceGroupResource.GetPublicIPAddresses();

            // invoke the operation
            string publicIPAddressName = "test-ip";
            PublicIPAddressData data = new PublicIPAddressData()
            {
                Sku = new PublicIPAddressSku()
                {
                    Name = PublicIPAddressSkuName.Standard,
                    Tier = PublicIPAddressSkuTier.Global,
                },
                PublicIPAllocationMethod = NetworkIPAllocationMethod.Static,
                PublicIPAddressVersion = NetworkIPVersion.IPv4,
                IdleTimeoutInMinutes = 10,
                Location = new AzureLocation("eastus"),
            };
            ArmOperation<PublicIPAddressResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, publicIPAddressName, data);
            PublicIPAddressResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PublicIPAddressData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create public IP address defaults
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreatePublicIPAddressDefaults()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/PublicIpAddressCreateDefaults.json
            // this example is just showing the usage of "PublicIPAddresses_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this PublicIPAddressResource
            PublicIPAddressCollection collection = resourceGroupResource.GetPublicIPAddresses();

            // invoke the operation
            string publicIPAddressName = "test-ip";
            PublicIPAddressData data = new PublicIPAddressData()
            {
                Location = new AzureLocation("eastus"),
            };
            ArmOperation<PublicIPAddressResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, publicIPAddressName, data);
            PublicIPAddressResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PublicIPAddressData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List resource group public IP addresses
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListResourceGroupPublicIPAddresses()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/PublicIpAddressList.json
            // this example is just showing the usage of "PublicIPAddresses_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this PublicIPAddressResource
            PublicIPAddressCollection collection = resourceGroupResource.GetPublicIPAddresses();

            // invoke the operation and iterate over the result
            await foreach (PublicIPAddressResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PublicIPAddressData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
