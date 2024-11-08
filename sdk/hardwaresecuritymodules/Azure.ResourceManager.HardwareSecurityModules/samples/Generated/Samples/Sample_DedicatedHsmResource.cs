// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HardwareSecurityModules.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HardwareSecurityModules.Samples
{
    public partial class Sample_DedicatedHsmResource
    {
        // Update an existing dedicated HSM
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAnExistingDedicatedHSM()
        {
            // Generated from example definition: specification/hardwaresecuritymodules/resource-manager/Microsoft.HardwareSecurityModules/preview/2024-06-30-preview/examples/DedicatedHsm_Update.json
            // this example is just showing the usage of "DedicatedHsm_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DedicatedHsmResource created on azure
            // for more information of creating DedicatedHsmResource, please refer to the document of DedicatedHsmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "hsm-group";
            string name = "hsm1";
            ResourceIdentifier dedicatedHsmResourceId = DedicatedHsmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            DedicatedHsmResource dedicatedHsm = client.GetDedicatedHsmResource(dedicatedHsmResourceId);

            // invoke the operation
            DedicatedHsmPatch patch = new DedicatedHsmPatch()
            {
                Tags =
{
["Dept"] = "hsm",
["Environment"] = "dogfood",
["Slice"] = "A",
},
            };
            ArmOperation<DedicatedHsmResource> lro = await dedicatedHsm.UpdateAsync(WaitUntil.Completed, patch);
            DedicatedHsmResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DedicatedHsmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update an existing payment HSM
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAnExistingPaymentHSM()
        {
            // Generated from example definition: specification/hardwaresecuritymodules/resource-manager/Microsoft.HardwareSecurityModules/preview/2024-06-30-preview/examples/PaymentHsm_Update.json
            // this example is just showing the usage of "DedicatedHsm_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DedicatedHsmResource created on azure
            // for more information of creating DedicatedHsmResource, please refer to the document of DedicatedHsmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "hsm-group";
            string name = "hsm1";
            ResourceIdentifier dedicatedHsmResourceId = DedicatedHsmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            DedicatedHsmResource dedicatedHsm = client.GetDedicatedHsmResource(dedicatedHsmResourceId);

            // invoke the operation
            DedicatedHsmPatch patch = new DedicatedHsmPatch()
            {
                Tags =
{
["Dept"] = "hsm",
["Environment"] = "dogfood",
["Slice"] = "A",
},
            };
            ArmOperation<DedicatedHsmResource> lro = await dedicatedHsm.UpdateAsync(WaitUntil.Completed, patch);
            DedicatedHsmResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DedicatedHsmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a dedicated HSM
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteADedicatedHSM()
        {
            // Generated from example definition: specification/hardwaresecuritymodules/resource-manager/Microsoft.HardwareSecurityModules/preview/2024-06-30-preview/examples/DedicatedHsm_Delete.json
            // this example is just showing the usage of "DedicatedHsm_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DedicatedHsmResource created on azure
            // for more information of creating DedicatedHsmResource, please refer to the document of DedicatedHsmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "hsm-group";
            string name = "hsm1";
            ResourceIdentifier dedicatedHsmResourceId = DedicatedHsmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            DedicatedHsmResource dedicatedHsm = client.GetDedicatedHsmResource(dedicatedHsmResourceId);

            // invoke the operation
            await dedicatedHsm.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get a dedicated HSM
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetADedicatedHSM()
        {
            // Generated from example definition: specification/hardwaresecuritymodules/resource-manager/Microsoft.HardwareSecurityModules/preview/2024-06-30-preview/examples/DedicatedHsm_Get.json
            // this example is just showing the usage of "DedicatedHsm_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DedicatedHsmResource created on azure
            // for more information of creating DedicatedHsmResource, please refer to the document of DedicatedHsmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "hsm-group";
            string name = "hsm1";
            ResourceIdentifier dedicatedHsmResourceId = DedicatedHsmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            DedicatedHsmResource dedicatedHsm = client.GetDedicatedHsmResource(dedicatedHsmResourceId);

            // invoke the operation
            DedicatedHsmResource result = await dedicatedHsm.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DedicatedHsmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a payment HSM
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAPaymentHSM()
        {
            // Generated from example definition: specification/hardwaresecuritymodules/resource-manager/Microsoft.HardwareSecurityModules/preview/2024-06-30-preview/examples/PaymentHsm_Get.json
            // this example is just showing the usage of "DedicatedHsm_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DedicatedHsmResource created on azure
            // for more information of creating DedicatedHsmResource, please refer to the document of DedicatedHsmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "hsm-group";
            string name = "hsm1";
            ResourceIdentifier dedicatedHsmResourceId = DedicatedHsmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            DedicatedHsmResource dedicatedHsm = client.GetDedicatedHsmResource(dedicatedHsmResourceId);

            // invoke the operation
            DedicatedHsmResource result = await dedicatedHsm.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DedicatedHsmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a payment HSM with 2018-10-31Preview api version
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAPaymentHSMWith20181031PreviewApiVersion()
        {
            // Generated from example definition: specification/hardwaresecuritymodules/resource-manager/Microsoft.HardwareSecurityModules/preview/2024-06-30-preview/examples/PaymentHsm_Get_With_2018-10-31Preview_Version.json
            // this example is just showing the usage of "DedicatedHsm_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DedicatedHsmResource created on azure
            // for more information of creating DedicatedHsmResource, please refer to the document of DedicatedHsmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "hsm-group";
            string name = "hsm1";
            ResourceIdentifier dedicatedHsmResourceId = DedicatedHsmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            DedicatedHsmResource dedicatedHsm = client.GetDedicatedHsmResource(dedicatedHsmResourceId);

            // invoke the operation
            DedicatedHsmResource result = await dedicatedHsm.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DedicatedHsmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List dedicated HSM devices in a subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetDedicatedHsms_ListDedicatedHSMDevicesInASubscription()
        {
            // Generated from example definition: specification/hardwaresecuritymodules/resource-manager/Microsoft.HardwareSecurityModules/preview/2024-06-30-preview/examples/DedicatedHsm_ListBySubscription.json
            // this example is just showing the usage of "DedicatedHsm_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (DedicatedHsmResource item in subscriptionResource.GetDedicatedHsmsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DedicatedHsmData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List dedicated HSM devices in a subscription including payment HSM
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetDedicatedHsms_ListDedicatedHSMDevicesInASubscriptionIncludingPaymentHSM()
        {
            // Generated from example definition: specification/hardwaresecuritymodules/resource-manager/Microsoft.HardwareSecurityModules/preview/2024-06-30-preview/examples/PaymentHsm_ListBySubscription.json
            // this example is just showing the usage of "DedicatedHsm_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (DedicatedHsmResource item in subscriptionResource.GetDedicatedHsmsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DedicatedHsmData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List OutboundNetworkDependenciesEndpoints by Managed Cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetOutboundNetworkDependenciesEndpoints_ListOutboundNetworkDependenciesEndpointsByManagedCluster()
        {
            // Generated from example definition: specification/hardwaresecuritymodules/resource-manager/Microsoft.HardwareSecurityModules/preview/2024-06-30-preview/examples/GetOutboundNetworkDependenciesEndpointsList.json
            // this example is just showing the usage of "DedicatedHsm_ListOutboundNetworkDependenciesEndpoints" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DedicatedHsmResource created on azure
            // for more information of creating DedicatedHsmResource, please refer to the document of DedicatedHsmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "hsm-group";
            string name = "hsm1";
            ResourceIdentifier dedicatedHsmResourceId = DedicatedHsmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            DedicatedHsmResource dedicatedHsm = client.GetDedicatedHsmResource(dedicatedHsmResourceId);

            // invoke the operation and iterate over the result
            await foreach (DedicatedHsmEgressEndpoint item in dedicatedHsm.GetOutboundNetworkDependenciesEndpointsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
