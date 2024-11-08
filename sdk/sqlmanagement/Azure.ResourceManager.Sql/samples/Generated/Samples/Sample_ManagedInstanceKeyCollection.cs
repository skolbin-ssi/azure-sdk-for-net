// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_ManagedInstanceKeyCollection
    {
        // List the keys for a managed instance.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListTheKeysForAManagedInstance()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedInstanceKeyList.json
            // this example is just showing the usage of "ManagedInstanceKeys_ListByInstance" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            string managedInstanceName = "sqlcrudtest-4645";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedInstanceKeyResource
            ManagedInstanceKeyCollection collection = managedInstance.GetManagedInstanceKeys();

            // invoke the operation and iterate over the result
            await foreach (ManagedInstanceKeyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedInstanceKeyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get the managed instance key
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetTheManagedInstanceKey()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedInstanceKeyGet.json
            // this example is just showing the usage of "ManagedInstanceKeys_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            string managedInstanceName = "sqlcrudtest-4645";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedInstanceKeyResource
            ManagedInstanceKeyCollection collection = managedInstance.GetManagedInstanceKeys();

            // invoke the operation
            string keyName = "someVault_someKey_01234567890123456789012345678901";
            ManagedInstanceKeyResource result = await collection.GetAsync(keyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedInstanceKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get the managed instance key
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetTheManagedInstanceKey()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedInstanceKeyGet.json
            // this example is just showing the usage of "ManagedInstanceKeys_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            string managedInstanceName = "sqlcrudtest-4645";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedInstanceKeyResource
            ManagedInstanceKeyCollection collection = managedInstance.GetManagedInstanceKeys();

            // invoke the operation
            string keyName = "someVault_someKey_01234567890123456789012345678901";
            bool result = await collection.ExistsAsync(keyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get the managed instance key
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetTheManagedInstanceKey()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedInstanceKeyGet.json
            // this example is just showing the usage of "ManagedInstanceKeys_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            string managedInstanceName = "sqlcrudtest-4645";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedInstanceKeyResource
            ManagedInstanceKeyCollection collection = managedInstance.GetManagedInstanceKeys();

            // invoke the operation
            string keyName = "someVault_someKey_01234567890123456789012345678901";
            NullableResponse<ManagedInstanceKeyResource> response = await collection.GetIfExistsAsync(keyName);
            ManagedInstanceKeyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedInstanceKeyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Creates or updates a managed instance key
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreatesOrUpdatesAManagedInstanceKey()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedInstanceKeyCreateOrUpdate.json
            // this example is just showing the usage of "ManagedInstanceKeys_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            string managedInstanceName = "sqlcrudtest-4645";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedInstanceKeyResource
            ManagedInstanceKeyCollection collection = managedInstance.GetManagedInstanceKeys();

            // invoke the operation
            string keyName = "someVault_someKey_01234567890123456789012345678901";
            ManagedInstanceKeyData data = new ManagedInstanceKeyData()
            {
                ServerKeyType = SqlServerKeyType.AzureKeyVault,
                Uri = new Uri("https://someVault.vault.azure.net/keys/someKey/01234567890123456789012345678901"),
            };
            ArmOperation<ManagedInstanceKeyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, keyName, data);
            ManagedInstanceKeyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedInstanceKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
