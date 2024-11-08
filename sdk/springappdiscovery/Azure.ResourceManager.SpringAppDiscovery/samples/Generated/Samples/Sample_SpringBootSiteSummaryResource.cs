// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.SpringAppDiscovery.Samples
{
    public partial class Sample_SpringBootSiteSummaryResource
    {
        // Summaries_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SummariesGetMaximumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/Summaries_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "Summaries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteSummaryResource created on azure
            // for more information of creating SpringBootSiteSummaryResource, please refer to the document of SpringBootSiteSummaryResource
            string subscriptionId = "libzegdqkcxmhqhhhcxm";
            string resourceGroupName = "rgspringbootdiscovery";
            string siteName = "xxkzlvbihwxunadjcpjpjmghmhxrqyvghtpfps";
            string summaryName = "vjB";
            ResourceIdentifier springBootSiteSummaryResourceId = SpringBootSiteSummaryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, summaryName);
            SpringBootSiteSummaryResource springBootSiteSummary = client.GetSpringBootSiteSummaryResource(springBootSiteSummaryResourceId);

            // invoke the operation
            SpringBootSiteSummaryResource result = await springBootSiteSummary.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SpringBootSiteSummaryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Summaries_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SummariesGetMinimumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/Summaries_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "Summaries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteSummaryResource created on azure
            // for more information of creating SpringBootSiteSummaryResource, please refer to the document of SpringBootSiteSummaryResource
            string subscriptionId = "libzegdqkcxmhqhhhcxm";
            string resourceGroupName = "rgspringbootdiscovery";
            string siteName = "xxkzlvbihwxunadjcpjpjmghmhxrqyvghtpfps";
            string summaryName = "vjB";
            ResourceIdentifier springBootSiteSummaryResourceId = SpringBootSiteSummaryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, summaryName);
            SpringBootSiteSummaryResource springBootSiteSummary = client.GetSpringBootSiteSummaryResource(springBootSiteSummaryResourceId);

            // invoke the operation
            SpringBootSiteSummaryResource result = await springBootSiteSummary.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SpringBootSiteSummaryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
