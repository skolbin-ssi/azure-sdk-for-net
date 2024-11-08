// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.IotHub.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.IotHub.Samples
{
    public partial class Sample_SubscriptionResourceExtensions
    {
        // ResourceProviderCommon_GetSubscriptionQuota
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIotHubUserSubscriptionQuota_ResourceProviderCommonGetSubscriptionQuota()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_usages.json
            // this example is just showing the usage of "ResourceProviderCommon_GetSubscriptionQuota" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (IotHubUserSubscriptionQuota item in subscriptionResource.GetIotHubUserSubscriptionQuotaAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
