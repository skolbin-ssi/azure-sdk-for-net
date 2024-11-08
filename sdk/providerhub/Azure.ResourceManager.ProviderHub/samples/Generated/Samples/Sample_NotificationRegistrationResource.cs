// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ProviderHub.Models;

namespace Azure.ResourceManager.ProviderHub.Samples
{
    public partial class Sample_NotificationRegistrationResource
    {
        // NotificationRegistrations_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_NotificationRegistrationsGet()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/stable/2020-11-20/examples/NotificationRegistrations_Get.json
            // this example is just showing the usage of "NotificationRegistrations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NotificationRegistrationResource created on azure
            // for more information of creating NotificationRegistrationResource, please refer to the document of NotificationRegistrationResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string notificationRegistrationName = "fooNotificationRegistration";
            ResourceIdentifier notificationRegistrationResourceId = NotificationRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace, notificationRegistrationName);
            NotificationRegistrationResource notificationRegistration = client.GetNotificationRegistrationResource(notificationRegistrationResourceId);

            // invoke the operation
            NotificationRegistrationResource result = await notificationRegistration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NotificationRegistrationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NotificationRegistrations_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_NotificationRegistrationsCreateOrUpdate()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/stable/2020-11-20/examples/NotificationRegistrations_CreateOrUpdate.json
            // this example is just showing the usage of "NotificationRegistrations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NotificationRegistrationResource created on azure
            // for more information of creating NotificationRegistrationResource, please refer to the document of NotificationRegistrationResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string notificationRegistrationName = "fooNotificationRegistration";
            ResourceIdentifier notificationRegistrationResourceId = NotificationRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace, notificationRegistrationName);
            NotificationRegistrationResource notificationRegistration = client.GetNotificationRegistrationResource(notificationRegistrationResourceId);

            // invoke the operation
            NotificationRegistrationData data = new NotificationRegistrationData()
            {
                Properties = new NotificationRegistrationProperties()
                {
                    NotificationMode = NotificationMode.EventHub,
                    MessageScope = MessageScope.RegisteredSubscriptions,
                    IncludedEvents =
{
"*/write","Microsoft.Contoso/employees/delete"
},
                    NotificationEndpoints =
{
new NotificationEndpoint()
{
NotificationDestination = new ResourceIdentifier("/subscriptions/ac6bcfb5-3dc1-491f-95a6-646b89bf3e88/resourceGroups/mgmtexp-eastus/providers/Microsoft.EventHub/namespaces/unitedstates-mgmtexpint/eventhubs/armlinkednotifications"),
Locations =
{
new AzureLocation(""),new AzureLocation("East US")
},
},new NotificationEndpoint()
{
NotificationDestination = new ResourceIdentifier("/subscriptions/ac6bcfb5-3dc1-491f-95a6-646b89bf3e88/resourceGroups/mgmtexp-northeurope/providers/Microsoft.EventHub/namespaces/europe-mgmtexpint/eventhubs/armlinkednotifications"),
Locations =
{
new AzureLocation("North Europe")
},
}
},
                },
            };
            ArmOperation<NotificationRegistrationResource> lro = await notificationRegistration.UpdateAsync(WaitUntil.Completed, data);
            NotificationRegistrationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NotificationRegistrationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NotificationRegistrations_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_NotificationRegistrationsDelete()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/stable/2020-11-20/examples/NotificationRegistrations_Delete.json
            // this example is just showing the usage of "NotificationRegistrations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NotificationRegistrationResource created on azure
            // for more information of creating NotificationRegistrationResource, please refer to the document of NotificationRegistrationResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string notificationRegistrationName = "fooNotificationRegistration";
            ResourceIdentifier notificationRegistrationResourceId = NotificationRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace, notificationRegistrationName);
            NotificationRegistrationResource notificationRegistration = client.GetNotificationRegistrationResource(notificationRegistrationResourceId);

            // invoke the operation
            await notificationRegistration.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
