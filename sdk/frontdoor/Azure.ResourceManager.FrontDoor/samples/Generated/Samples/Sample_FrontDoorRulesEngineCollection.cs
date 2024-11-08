// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using System.Xml;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.FrontDoor.Models;

namespace Azure.ResourceManager.FrontDoor.Samples
{
    public partial class Sample_FrontDoorRulesEngineCollection
    {
        // List Rules Engine Configurations in a Front Door
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListRulesEngineConfigurationsInAFrontDoor()
        {
            // Generated from example definition: specification/frontdoor/resource-manager/Microsoft.Network/stable/2021-06-01/examples/FrontdoorRulesEngineList.json
            // this example is just showing the usage of "RulesEngines_ListByFrontDoor" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorResource created on azure
            // for more information of creating FrontDoorResource, please refer to the document of FrontDoorResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string frontDoorName = "frontDoor1";
            ResourceIdentifier frontDoorResourceId = FrontDoorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, frontDoorName);
            FrontDoorResource frontDoor = client.GetFrontDoorResource(frontDoorResourceId);

            // get the collection of this FrontDoorRulesEngineResource
            FrontDoorRulesEngineCollection collection = frontDoor.GetFrontDoorRulesEngines();

            // invoke the operation and iterate over the result
            await foreach (FrontDoorRulesEngineResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FrontDoorRulesEngineData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Rules Engine Configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRulesEngineConfiguration()
        {
            // Generated from example definition: specification/frontdoor/resource-manager/Microsoft.Network/stable/2021-06-01/examples/FrontdoorRulesEngineGet.json
            // this example is just showing the usage of "RulesEngines_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorResource created on azure
            // for more information of creating FrontDoorResource, please refer to the document of FrontDoorResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string frontDoorName = "frontDoor1";
            ResourceIdentifier frontDoorResourceId = FrontDoorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, frontDoorName);
            FrontDoorResource frontDoor = client.GetFrontDoorResource(frontDoorResourceId);

            // get the collection of this FrontDoorRulesEngineResource
            FrontDoorRulesEngineCollection collection = frontDoor.GetFrontDoorRulesEngines();

            // invoke the operation
            string rulesEngineName = "rulesEngine1";
            FrontDoorRulesEngineResource result = await collection.GetAsync(rulesEngineName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FrontDoorRulesEngineData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Rules Engine Configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetRulesEngineConfiguration()
        {
            // Generated from example definition: specification/frontdoor/resource-manager/Microsoft.Network/stable/2021-06-01/examples/FrontdoorRulesEngineGet.json
            // this example is just showing the usage of "RulesEngines_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorResource created on azure
            // for more information of creating FrontDoorResource, please refer to the document of FrontDoorResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string frontDoorName = "frontDoor1";
            ResourceIdentifier frontDoorResourceId = FrontDoorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, frontDoorName);
            FrontDoorResource frontDoor = client.GetFrontDoorResource(frontDoorResourceId);

            // get the collection of this FrontDoorRulesEngineResource
            FrontDoorRulesEngineCollection collection = frontDoor.GetFrontDoorRulesEngines();

            // invoke the operation
            string rulesEngineName = "rulesEngine1";
            bool result = await collection.ExistsAsync(rulesEngineName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Rules Engine Configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetRulesEngineConfiguration()
        {
            // Generated from example definition: specification/frontdoor/resource-manager/Microsoft.Network/stable/2021-06-01/examples/FrontdoorRulesEngineGet.json
            // this example is just showing the usage of "RulesEngines_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorResource created on azure
            // for more information of creating FrontDoorResource, please refer to the document of FrontDoorResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string frontDoorName = "frontDoor1";
            ResourceIdentifier frontDoorResourceId = FrontDoorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, frontDoorName);
            FrontDoorResource frontDoor = client.GetFrontDoorResource(frontDoorResourceId);

            // get the collection of this FrontDoorRulesEngineResource
            FrontDoorRulesEngineCollection collection = frontDoor.GetFrontDoorRulesEngines();

            // invoke the operation
            string rulesEngineName = "rulesEngine1";
            NullableResponse<FrontDoorRulesEngineResource> response = await collection.GetIfExistsAsync(rulesEngineName);
            FrontDoorRulesEngineResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FrontDoorRulesEngineData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create or update a specific Rules Engine Configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateASpecificRulesEngineConfiguration()
        {
            // Generated from example definition: specification/frontdoor/resource-manager/Microsoft.Network/stable/2021-06-01/examples/FrontdoorRulesEngineCreate.json
            // this example is just showing the usage of "RulesEngines_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorResource created on azure
            // for more information of creating FrontDoorResource, please refer to the document of FrontDoorResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string frontDoorName = "frontDoor1";
            ResourceIdentifier frontDoorResourceId = FrontDoorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, frontDoorName);
            FrontDoorResource frontDoor = client.GetFrontDoorResource(frontDoorResourceId);

            // get the collection of this FrontDoorRulesEngineResource
            FrontDoorRulesEngineCollection collection = frontDoor.GetFrontDoorRulesEngines();

            // invoke the operation
            string rulesEngineName = "rulesEngine1";
            FrontDoorRulesEngineData data = new FrontDoorRulesEngineData()
            {
                Rules =
{
new RulesEngineRule("Rule1",1,new RulesEngineAction()
{
RouteConfigurationOverride = new RedirectConfiguration()
{
RedirectType = FrontDoorRedirectType.Moved,
RedirectProtocol = FrontDoorRedirectProtocol.HttpsOnly,
CustomHost = "www.bing.com",
CustomPath = "/api",
CustomFragment = "fragment",
CustomQueryString = "a=b",
},
})
{
MatchConditions =
{
new RulesEngineMatchCondition(RulesEngineMatchVariable.RemoteAddr,RulesEngineOperator.GeoMatch,new string[]
{
"CH"
})
},
MatchProcessingBehavior = MatchProcessingBehavior.Stop,
},new RulesEngineRule("Rule2",2,new RulesEngineAction()
{
ResponseHeaderActions =
{
new RulesEngineHeaderAction(RulesEngineHeaderActionType.Overwrite,"Cache-Control")
{
Value = "public, max-age=31536000",
}
},
})
{
MatchConditions =
{
new RulesEngineMatchCondition(RulesEngineMatchVariable.RequestFilenameExtension,RulesEngineOperator.Equal,new string[]
{
"jpg"
})
{
Transforms =
{
RulesEngineMatchTransform.Lowercase
},
}
},
},new RulesEngineRule("Rule3",3,new RulesEngineAction()
{
RouteConfigurationOverride = new ForwardingConfiguration()
{
CustomForwardingPath = null,
ForwardingProtocol = FrontDoorForwardingProtocol.HttpsOnly,
CacheConfiguration = new FrontDoorCacheConfiguration()
{
QueryParameterStripDirective = FrontDoorQuery.StripOnly,
QueryParameters = "a=b,p=q",
DynamicCompression = DynamicCompressionEnabled.Disabled,
CacheDuration = XmlConvert.ToTimeSpan("P1DT12H20M30S"),
},
BackendPoolId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/frontDoors/frontDoor1/backendPools/backendPool1"),
},
})
{
MatchConditions =
{
new RulesEngineMatchCondition(RulesEngineMatchVariable.RequestHeader,RulesEngineOperator.Equal,new string[]
{
"allowoverride"
})
{
Selector = "Rules-Engine-Route-Forward",
IsNegateCondition = false,
Transforms =
{
RulesEngineMatchTransform.Lowercase
},
}
},
}
},
            };
            ArmOperation<FrontDoorRulesEngineResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, rulesEngineName, data);
            FrontDoorRulesEngineResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FrontDoorRulesEngineData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
