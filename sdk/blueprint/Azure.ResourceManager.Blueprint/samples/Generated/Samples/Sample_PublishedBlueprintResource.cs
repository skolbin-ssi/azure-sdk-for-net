// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Blueprint.Samples
{
    public partial class Sample_PublishedBlueprintResource
    {
        // PublishedManagementGroupBlueprint_Publish
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PublishedManagementGroupBlueprintPublish()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPDef/SealedBlueprint_Publish.json
            // this example is just showing the usage of "PublishedBlueprints_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublishedBlueprintResource created on azure
            // for more information of creating PublishedBlueprintResource, please refer to the document of PublishedBlueprintResource
            string resourceScope = "providers/Microsoft.Management/managementGroups/ContosoOnlineGroup";
            string blueprintName = "simpleBlueprint";
            string versionId = "v2";
            ResourceIdentifier publishedBlueprintResourceId = PublishedBlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName, versionId);
            PublishedBlueprintResource publishedBlueprint = client.GetPublishedBlueprintResource(publishedBlueprintResourceId);

            // invoke the operation
            PublishedBlueprintData data = new PublishedBlueprintData();
            ArmOperation<PublishedBlueprintResource> lro = await publishedBlueprint.UpdateAsync(WaitUntil.Completed, data);
            PublishedBlueprintResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PublishedBlueprintData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PublishedSubscriptionBlueprint_Publish
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PublishedSubscriptionBlueprintPublish()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPDef/SealedBlueprint_Publish.json
            // this example is just showing the usage of "PublishedBlueprints_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublishedBlueprintResource created on azure
            // for more information of creating PublishedBlueprintResource, please refer to the document of PublishedBlueprintResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string blueprintName = "simpleBlueprint";
            string versionId = "v2";
            ResourceIdentifier publishedBlueprintResourceId = PublishedBlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName, versionId);
            PublishedBlueprintResource publishedBlueprint = client.GetPublishedBlueprintResource(publishedBlueprintResourceId);

            // invoke the operation
            PublishedBlueprintData data = new PublishedBlueprintData();
            ArmOperation<PublishedBlueprintResource> lro = await publishedBlueprint.UpdateAsync(WaitUntil.Completed, data);
            PublishedBlueprintResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PublishedBlueprintData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PublishedManagementGroupBlueprint
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PublishedManagementGroupBlueprint()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPDef/SealedBlueprint_Get.json
            // this example is just showing the usage of "PublishedBlueprints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublishedBlueprintResource created on azure
            // for more information of creating PublishedBlueprintResource, please refer to the document of PublishedBlueprintResource
            string resourceScope = "providers/Microsoft.Management/managementGroups/ContosoOnlineGroup";
            string blueprintName = "simpleBlueprint";
            string versionId = "v2";
            ResourceIdentifier publishedBlueprintResourceId = PublishedBlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName, versionId);
            PublishedBlueprintResource publishedBlueprint = client.GetPublishedBlueprintResource(publishedBlueprintResourceId);

            // invoke the operation
            PublishedBlueprintResource result = await publishedBlueprint.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PublishedBlueprintData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PublishedSubscriptionBlueprint
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PublishedSubscriptionBlueprint()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPDef/SealedBlueprint_Get.json
            // this example is just showing the usage of "PublishedBlueprints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublishedBlueprintResource created on azure
            // for more information of creating PublishedBlueprintResource, please refer to the document of PublishedBlueprintResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string blueprintName = "simpleBlueprint";
            string versionId = "v2";
            ResourceIdentifier publishedBlueprintResourceId = PublishedBlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName, versionId);
            PublishedBlueprintResource publishedBlueprint = client.GetPublishedBlueprintResource(publishedBlueprintResourceId);

            // invoke the operation
            PublishedBlueprintResource result = await publishedBlueprint.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PublishedBlueprintData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PublishedManagementGroupBlueprint
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_PublishedManagementGroupBlueprint()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPDef/SealedBlueprint_Delete.json
            // this example is just showing the usage of "PublishedBlueprints_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublishedBlueprintResource created on azure
            // for more information of creating PublishedBlueprintResource, please refer to the document of PublishedBlueprintResource
            string resourceScope = "providers/Microsoft.Management/managementGroups/ContosoOnlineGroup";
            string blueprintName = "simpleBlueprint";
            string versionId = "v2";
            ResourceIdentifier publishedBlueprintResourceId = PublishedBlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName, versionId);
            PublishedBlueprintResource publishedBlueprint = client.GetPublishedBlueprintResource(publishedBlueprintResourceId);

            // invoke the operation
            ArmOperation<PublishedBlueprintResource> lro = await publishedBlueprint.DeleteAsync(WaitUntil.Completed);
            PublishedBlueprintResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PublishedBlueprintData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PublishedSubscriptionBlueprint
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_PublishedSubscriptionBlueprint()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPDef/SealedBlueprint_Delete.json
            // this example is just showing the usage of "PublishedBlueprints_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublishedBlueprintResource created on azure
            // for more information of creating PublishedBlueprintResource, please refer to the document of PublishedBlueprintResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string blueprintName = "simpleBlueprint";
            string versionId = "v2";
            ResourceIdentifier publishedBlueprintResourceId = PublishedBlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName, versionId);
            PublishedBlueprintResource publishedBlueprint = client.GetPublishedBlueprintResource(publishedBlueprintResourceId);

            // invoke the operation
            ArmOperation<PublishedBlueprintResource> lro = await publishedBlueprint.DeleteAsync(WaitUntil.Completed);
            PublishedBlueprintResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PublishedBlueprintData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
