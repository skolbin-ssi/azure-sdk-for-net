// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.ScVmm.Models;

namespace Azure.ResourceManager.ScVmm.Samples
{
    public partial class Sample_ScVmmVirtualMachineInstanceResource
    {
        // GetVirtualMachine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetVirtualMachine()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/GetVirtualMachineInstance.json
            // this example is just showing the usage of "VirtualMachineInstances_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmVirtualMachineInstanceResource created on azure
            // for more information of creating ScVmmVirtualMachineInstanceResource, please refer to the document of ScVmmVirtualMachineInstanceResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.HybridCompute/machines/DemoVM";
            ResourceIdentifier scVmmVirtualMachineInstanceResourceId = ScVmmVirtualMachineInstanceResource.CreateResourceIdentifier(resourceUri);
            ScVmmVirtualMachineInstanceResource scVmmVirtualMachineInstance = client.GetScVmmVirtualMachineInstanceResource(scVmmVirtualMachineInstanceResourceId);

            // invoke the operation
            ScVmmVirtualMachineInstanceResource result = await scVmmVirtualMachineInstance.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScVmmVirtualMachineInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CreateVirtualMachine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateVirtualMachine()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/CreateVirtualMachineInstance.json
            // this example is just showing the usage of "VirtualMachineInstances_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmVirtualMachineInstanceResource created on azure
            // for more information of creating ScVmmVirtualMachineInstanceResource, please refer to the document of ScVmmVirtualMachineInstanceResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.HybridCompute/machines/DemoVM";
            ResourceIdentifier scVmmVirtualMachineInstanceResourceId = ScVmmVirtualMachineInstanceResource.CreateResourceIdentifier(resourceUri);
            ScVmmVirtualMachineInstanceResource scVmmVirtualMachineInstance = client.GetScVmmVirtualMachineInstanceResource(scVmmVirtualMachineInstanceResourceId);

            // invoke the operation
            ScVmmVirtualMachineInstanceData data = new ScVmmVirtualMachineInstanceData(new ExtendedLocation()
            {
                Name = "/subscriptions/a5015e1c-867f-4533-8541-85cd470d0cfb/resourceGroups/demoRG/providers/Microsoft.ExtendedLocation/customLocations/contoso",
            })
            {
                HardwareProfile = new ScVmmHardwareProfile()
                {
                    MemoryMB = 4196,
                    CpuCount = 4,
                },
                InfrastructureProfile = new ScVmmInfrastructureProfile()
                {
                    VmmServerId = new ResourceIdentifier("/subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.SCVMM/VMMServers/ContosoVMMServer"),
                    CloudId = new ResourceIdentifier("/subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.SCVMM/Clouds/HRCloud"),
                    TemplateId = new ResourceIdentifier("/subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.SCVMM/VirtualMachineTemplates/HRVirtualMachineTemplate"),
                },
            };
            ArmOperation<ScVmmVirtualMachineInstanceResource> lro = await scVmmVirtualMachineInstance.CreateOrUpdateAsync(WaitUntil.Completed, data);
            ScVmmVirtualMachineInstanceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScVmmVirtualMachineInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // UpdateVirtualMachine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateVirtualMachine()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/UpdateVirtualMachineInstance.json
            // this example is just showing the usage of "VirtualMachineInstances_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmVirtualMachineInstanceResource created on azure
            // for more information of creating ScVmmVirtualMachineInstanceResource, please refer to the document of ScVmmVirtualMachineInstanceResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.HybridCompute/machines/DemoVM";
            ResourceIdentifier scVmmVirtualMachineInstanceResourceId = ScVmmVirtualMachineInstanceResource.CreateResourceIdentifier(resourceUri);
            ScVmmVirtualMachineInstanceResource scVmmVirtualMachineInstance = client.GetScVmmVirtualMachineInstanceResource(scVmmVirtualMachineInstanceResourceId);

            // invoke the operation
            ScVmmVirtualMachineInstancePatch patch = new ScVmmVirtualMachineInstancePatch()
            {
                HardwareProfile = new ScVmmHardwareProfileUpdate()
                {
                    MemoryMB = 4196,
                    CpuCount = 4,
                },
            };
            ArmOperation<ScVmmVirtualMachineInstanceResource> lro = await scVmmVirtualMachineInstance.UpdateAsync(WaitUntil.Completed, patch);
            ScVmmVirtualMachineInstanceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScVmmVirtualMachineInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DeleteVirtualMachine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteVirtualMachine()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/DeleteVirtualMachineInstance.json
            // this example is just showing the usage of "VirtualMachineInstances_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmVirtualMachineInstanceResource created on azure
            // for more information of creating ScVmmVirtualMachineInstanceResource, please refer to the document of ScVmmVirtualMachineInstanceResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.HybridCompute/machines/DemoVM";
            ResourceIdentifier scVmmVirtualMachineInstanceResourceId = ScVmmVirtualMachineInstanceResource.CreateResourceIdentifier(resourceUri);
            ScVmmVirtualMachineInstanceResource scVmmVirtualMachineInstance = client.GetScVmmVirtualMachineInstanceResource(scVmmVirtualMachineInstanceResourceId);

            // invoke the operation
            await scVmmVirtualMachineInstance.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // StopVirtualMachine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Stop_StopVirtualMachine()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/StopVirtualMachineInstance.json
            // this example is just showing the usage of "VirtualMachineInstances_Stop" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmVirtualMachineInstanceResource created on azure
            // for more information of creating ScVmmVirtualMachineInstanceResource, please refer to the document of ScVmmVirtualMachineInstanceResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.HybridCompute/machines/DemoVM";
            ResourceIdentifier scVmmVirtualMachineInstanceResourceId = ScVmmVirtualMachineInstanceResource.CreateResourceIdentifier(resourceUri);
            ScVmmVirtualMachineInstanceResource scVmmVirtualMachineInstance = client.GetScVmmVirtualMachineInstanceResource(scVmmVirtualMachineInstanceResourceId);

            // invoke the operation
            StopVirtualMachineContent content = new StopVirtualMachineContent()
            {
                SkipShutdown = SkipShutdown.True,
            };
            await scVmmVirtualMachineInstance.StopAsync(WaitUntil.Completed, content: content);

            Console.WriteLine($"Succeeded");
        }

        // StartVirtualMachine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Start_StartVirtualMachine()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/StartVirtualMachineInstance.json
            // this example is just showing the usage of "VirtualMachineInstances_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmVirtualMachineInstanceResource created on azure
            // for more information of creating ScVmmVirtualMachineInstanceResource, please refer to the document of ScVmmVirtualMachineInstanceResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.HybridCompute/machines/DemoVM";
            ResourceIdentifier scVmmVirtualMachineInstanceResourceId = ScVmmVirtualMachineInstanceResource.CreateResourceIdentifier(resourceUri);
            ScVmmVirtualMachineInstanceResource scVmmVirtualMachineInstance = client.GetScVmmVirtualMachineInstanceResource(scVmmVirtualMachineInstanceResourceId);

            // invoke the operation
            await scVmmVirtualMachineInstance.StartAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // RestartVirtualMachine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Restart_RestartVirtualMachine()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/RestartVirtualMachineInstance.json
            // this example is just showing the usage of "VirtualMachineInstances_Restart" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmVirtualMachineInstanceResource created on azure
            // for more information of creating ScVmmVirtualMachineInstanceResource, please refer to the document of ScVmmVirtualMachineInstanceResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.HybridCompute/machines/DemoVM";
            ResourceIdentifier scVmmVirtualMachineInstanceResourceId = ScVmmVirtualMachineInstanceResource.CreateResourceIdentifier(resourceUri);
            ScVmmVirtualMachineInstanceResource scVmmVirtualMachineInstance = client.GetScVmmVirtualMachineInstanceResource(scVmmVirtualMachineInstanceResourceId);

            // invoke the operation
            await scVmmVirtualMachineInstance.RestartAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // CreateCheckpointVirtualMachine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateCheckpoint_CreateCheckpointVirtualMachine()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/CreateCheckpointVirtualMachineInstance.json
            // this example is just showing the usage of "VirtualMachineInstances_CreateCheckpoint" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmVirtualMachineInstanceResource created on azure
            // for more information of creating ScVmmVirtualMachineInstanceResource, please refer to the document of ScVmmVirtualMachineInstanceResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.HybridCompute/machines/DemoVM";
            ResourceIdentifier scVmmVirtualMachineInstanceResourceId = ScVmmVirtualMachineInstanceResource.CreateResourceIdentifier(resourceUri);
            ScVmmVirtualMachineInstanceResource scVmmVirtualMachineInstance = client.GetScVmmVirtualMachineInstanceResource(scVmmVirtualMachineInstanceResourceId);

            // invoke the operation
            VirtualMachineCreateCheckpointContent content = new VirtualMachineCreateCheckpointContent()
            {
                Name = "Demo Checkpoint name",
                Description = "Demo Checkpoint description",
            };
            await scVmmVirtualMachineInstance.CreateCheckpointAsync(WaitUntil.Completed, content: content);

            Console.WriteLine($"Succeeded");
        }

        // DeleteCheckpointVirtualMachine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task DeleteCheckpoint_DeleteCheckpointVirtualMachine()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/DeleteCheckpointVirtualMachineInstance.json
            // this example is just showing the usage of "VirtualMachineInstances_DeleteCheckpoint" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmVirtualMachineInstanceResource created on azure
            // for more information of creating ScVmmVirtualMachineInstanceResource, please refer to the document of ScVmmVirtualMachineInstanceResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.HybridCompute/machines/DemoVM";
            ResourceIdentifier scVmmVirtualMachineInstanceResourceId = ScVmmVirtualMachineInstanceResource.CreateResourceIdentifier(resourceUri);
            ScVmmVirtualMachineInstanceResource scVmmVirtualMachineInstance = client.GetScVmmVirtualMachineInstanceResource(scVmmVirtualMachineInstanceResourceId);

            // invoke the operation
            VirtualMachineDeleteCheckpointContent content = new VirtualMachineDeleteCheckpointContent()
            {
                Id = "Demo CheckpointID",
            };
            await scVmmVirtualMachineInstance.DeleteCheckpointAsync(WaitUntil.Completed, content: content);

            Console.WriteLine($"Succeeded");
        }

        // RestoreCheckpointVirtualMachine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RestoreCheckpoint_RestoreCheckpointVirtualMachine()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/RestoreCheckpointVirtualMachineInstance.json
            // this example is just showing the usage of "VirtualMachineInstances_RestoreCheckpoint" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmVirtualMachineInstanceResource created on azure
            // for more information of creating ScVmmVirtualMachineInstanceResource, please refer to the document of ScVmmVirtualMachineInstanceResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.HybridCompute/machines/DemoVM";
            ResourceIdentifier scVmmVirtualMachineInstanceResourceId = ScVmmVirtualMachineInstanceResource.CreateResourceIdentifier(resourceUri);
            ScVmmVirtualMachineInstanceResource scVmmVirtualMachineInstance = client.GetScVmmVirtualMachineInstanceResource(scVmmVirtualMachineInstanceResourceId);

            // invoke the operation
            VirtualMachineRestoreCheckpointContent content = new VirtualMachineRestoreCheckpointContent()
            {
                Id = "Demo CheckpointID",
            };
            await scVmmVirtualMachineInstance.RestoreCheckpointAsync(WaitUntil.Completed, content: content);

            Console.WriteLine($"Succeeded");
        }
    }
}
