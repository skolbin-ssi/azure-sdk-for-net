// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Billing.Samples
{
    public partial class Sample_BillingCustomerRoleAssignmentCollection
    {
        // BillingRoleAssignmentGetByCustomer
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_BillingRoleAssignmentGetByCustomer()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingRoleAssignmentGetByCustomer.json
            // this example is just showing the usage of "BillingRoleAssignments_GetByCustomer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileCustomerResource created on azure
            // for more information of creating BillingProfileCustomerResource, please refer to the document of BillingProfileCustomerResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2018-09-30";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            string customerName = "703ab484-dda2-4402-827b-a74513b61e2d";
            ResourceIdentifier billingProfileCustomerResourceId = BillingProfileCustomerResource.CreateResourceIdentifier(billingAccountName, billingProfileName, customerName);
            BillingProfileCustomerResource billingProfileCustomer = client.GetBillingProfileCustomerResource(billingProfileCustomerResourceId);

            // get the collection of this BillingCustomerRoleAssignmentResource
            BillingCustomerRoleAssignmentCollection collection = billingProfileCustomer.GetBillingCustomerRoleAssignments();

            // invoke the operation
            string billingRoleAssignmentName = "30000000-aaaa-bbbb-cccc-100000000000_6fd330f6-7d26-4aff-b9cf-7bd699f965b9";
            BillingCustomerRoleAssignmentResource result = await collection.GetAsync(billingRoleAssignmentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingRoleAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // BillingRoleAssignmentGetByCustomer
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_BillingRoleAssignmentGetByCustomer()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingRoleAssignmentGetByCustomer.json
            // this example is just showing the usage of "BillingRoleAssignments_GetByCustomer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileCustomerResource created on azure
            // for more information of creating BillingProfileCustomerResource, please refer to the document of BillingProfileCustomerResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2018-09-30";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            string customerName = "703ab484-dda2-4402-827b-a74513b61e2d";
            ResourceIdentifier billingProfileCustomerResourceId = BillingProfileCustomerResource.CreateResourceIdentifier(billingAccountName, billingProfileName, customerName);
            BillingProfileCustomerResource billingProfileCustomer = client.GetBillingProfileCustomerResource(billingProfileCustomerResourceId);

            // get the collection of this BillingCustomerRoleAssignmentResource
            BillingCustomerRoleAssignmentCollection collection = billingProfileCustomer.GetBillingCustomerRoleAssignments();

            // invoke the operation
            string billingRoleAssignmentName = "30000000-aaaa-bbbb-cccc-100000000000_6fd330f6-7d26-4aff-b9cf-7bd699f965b9";
            bool result = await collection.ExistsAsync(billingRoleAssignmentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // BillingRoleAssignmentGetByCustomer
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_BillingRoleAssignmentGetByCustomer()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingRoleAssignmentGetByCustomer.json
            // this example is just showing the usage of "BillingRoleAssignments_GetByCustomer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileCustomerResource created on azure
            // for more information of creating BillingProfileCustomerResource, please refer to the document of BillingProfileCustomerResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2018-09-30";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            string customerName = "703ab484-dda2-4402-827b-a74513b61e2d";
            ResourceIdentifier billingProfileCustomerResourceId = BillingProfileCustomerResource.CreateResourceIdentifier(billingAccountName, billingProfileName, customerName);
            BillingProfileCustomerResource billingProfileCustomer = client.GetBillingProfileCustomerResource(billingProfileCustomerResourceId);

            // get the collection of this BillingCustomerRoleAssignmentResource
            BillingCustomerRoleAssignmentCollection collection = billingProfileCustomer.GetBillingCustomerRoleAssignments();

            // invoke the operation
            string billingRoleAssignmentName = "30000000-aaaa-bbbb-cccc-100000000000_6fd330f6-7d26-4aff-b9cf-7bd699f965b9";
            NullableResponse<BillingCustomerRoleAssignmentResource> response = await collection.GetIfExistsAsync(billingRoleAssignmentName);
            BillingCustomerRoleAssignmentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingRoleAssignmentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // BillingRoleAssignmentListByCustomer
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_BillingRoleAssignmentListByCustomer()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingRoleAssignmentListByCustomer.json
            // this example is just showing the usage of "BillingRoleAssignments_ListByCustomer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileCustomerResource created on azure
            // for more information of creating BillingProfileCustomerResource, please refer to the document of BillingProfileCustomerResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2018-09-30";
            string billingProfileName = "BKM6-54VH-BG7-PGB";
            string customerName = "703ab484-dda2-4402-827b-a74513b61e2d";
            ResourceIdentifier billingProfileCustomerResourceId = BillingProfileCustomerResource.CreateResourceIdentifier(billingAccountName, billingProfileName, customerName);
            BillingProfileCustomerResource billingProfileCustomer = client.GetBillingProfileCustomerResource(billingProfileCustomerResourceId);

            // get the collection of this BillingCustomerRoleAssignmentResource
            BillingCustomerRoleAssignmentCollection collection = billingProfileCustomer.GetBillingCustomerRoleAssignments();

            // invoke the operation and iterate over the result
            await foreach (BillingCustomerRoleAssignmentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingRoleAssignmentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
