// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HDInsight.Containers.Models;

namespace Azure.ResourceManager.HDInsight.Containers.Samples
{
    public partial class Sample_HDInsightClusterCollection
    {
        // HDInsightClustersListByClusterPoolName
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_HDInsightClustersListByClusterPoolName()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/HDInsightOnAks/preview/2024-05-01-preview/examples/ListClustersByClusterPoolName.json
            // this example is just showing the usage of "Clusters_ListByClusterPoolName" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightClusterPoolResource created on azure
            // for more information of creating HDInsightClusterPoolResource, please refer to the document of HDInsightClusterPoolResource
            string subscriptionId = "10e32bab-26da-4cc4-a441-52b318f824e6";
            string resourceGroupName = "hiloResourcegroup";
            string clusterPoolName = "clusterpool1";
            ResourceIdentifier hdInsightClusterPoolResourceId = HDInsightClusterPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterPoolName);
            HDInsightClusterPoolResource hdInsightClusterPool = client.GetHDInsightClusterPoolResource(hdInsightClusterPoolResourceId);

            // get the collection of this HDInsightClusterResource
            HDInsightClusterCollection collection = hdInsightClusterPool.GetHDInsightClusters();

            // invoke the operation and iterate over the result
            await foreach (HDInsightClusterResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HDInsightClusterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // HDInsightClusterGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_HDInsightClusterGet()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/HDInsightOnAks/preview/2024-05-01-preview/examples/GetCluster.json
            // this example is just showing the usage of "Clusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightClusterPoolResource created on azure
            // for more information of creating HDInsightClusterPoolResource, please refer to the document of HDInsightClusterPoolResource
            string subscriptionId = "10e32bab-26da-4cc4-a441-52b318f824e6";
            string resourceGroupName = "hiloResourcegroup";
            string clusterPoolName = "clusterpool1";
            ResourceIdentifier hdInsightClusterPoolResourceId = HDInsightClusterPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterPoolName);
            HDInsightClusterPoolResource hdInsightClusterPool = client.GetHDInsightClusterPoolResource(hdInsightClusterPoolResourceId);

            // get the collection of this HDInsightClusterResource
            HDInsightClusterCollection collection = hdInsightClusterPool.GetHDInsightClusters();

            // invoke the operation
            string clusterName = "cluster1";
            HDInsightClusterResource result = await collection.GetAsync(clusterName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HDInsightClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // HDInsightClusterGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_HDInsightClusterGet()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/HDInsightOnAks/preview/2024-05-01-preview/examples/GetCluster.json
            // this example is just showing the usage of "Clusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightClusterPoolResource created on azure
            // for more information of creating HDInsightClusterPoolResource, please refer to the document of HDInsightClusterPoolResource
            string subscriptionId = "10e32bab-26da-4cc4-a441-52b318f824e6";
            string resourceGroupName = "hiloResourcegroup";
            string clusterPoolName = "clusterpool1";
            ResourceIdentifier hdInsightClusterPoolResourceId = HDInsightClusterPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterPoolName);
            HDInsightClusterPoolResource hdInsightClusterPool = client.GetHDInsightClusterPoolResource(hdInsightClusterPoolResourceId);

            // get the collection of this HDInsightClusterResource
            HDInsightClusterCollection collection = hdInsightClusterPool.GetHDInsightClusters();

            // invoke the operation
            string clusterName = "cluster1";
            bool result = await collection.ExistsAsync(clusterName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // HDInsightClusterGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_HDInsightClusterGet()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/HDInsightOnAks/preview/2024-05-01-preview/examples/GetCluster.json
            // this example is just showing the usage of "Clusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightClusterPoolResource created on azure
            // for more information of creating HDInsightClusterPoolResource, please refer to the document of HDInsightClusterPoolResource
            string subscriptionId = "10e32bab-26da-4cc4-a441-52b318f824e6";
            string resourceGroupName = "hiloResourcegroup";
            string clusterPoolName = "clusterpool1";
            ResourceIdentifier hdInsightClusterPoolResourceId = HDInsightClusterPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterPoolName);
            HDInsightClusterPoolResource hdInsightClusterPool = client.GetHDInsightClusterPoolResource(hdInsightClusterPoolResourceId);

            // get the collection of this HDInsightClusterResource
            HDInsightClusterCollection collection = hdInsightClusterPool.GetHDInsightClusters();

            // invoke the operation
            string clusterName = "cluster1";
            NullableResponse<HDInsightClusterResource> response = await collection.GetIfExistsAsync(clusterName);
            HDInsightClusterResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HDInsightClusterData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // HDInsightClusterPut
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_HDInsightClusterPut()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/HDInsightOnAks/preview/2024-05-01-preview/examples/CreateAutoscaleCluster.json
            // this example is just showing the usage of "Clusters_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightClusterPoolResource created on azure
            // for more information of creating HDInsightClusterPoolResource, please refer to the document of HDInsightClusterPoolResource
            string subscriptionId = "10e32bab-26da-4cc4-a441-52b318f824e6";
            string resourceGroupName = "hiloResourcegroup";
            string clusterPoolName = "clusterpool1";
            ResourceIdentifier hdInsightClusterPoolResourceId = HDInsightClusterPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterPoolName);
            HDInsightClusterPoolResource hdInsightClusterPool = client.GetHDInsightClusterPoolResource(hdInsightClusterPoolResourceId);

            // get the collection of this HDInsightClusterResource
            HDInsightClusterCollection collection = hdInsightClusterPool.GetHDInsightClusters();

            // invoke the operation
            string clusterName = "cluster1";
            HDInsightClusterData data = new HDInsightClusterData(new AzureLocation("West US 2"))
            {
                Properties = new HDInsightClusterProperties("Trino", new ClusterComputeProfile(new ClusterComputeNodeProfile[]
            {
new ClusterComputeNodeProfile("Head","Standard_E8as_v5",2),new ClusterComputeNodeProfile("Worker","Standard_E8as_v5",3)
            })
                {
                    AvailabilityZones =
{
"1","2","3"
},
                }, new ClusterProfile("1.0.6", "0.410.0", new AuthorizationProfile()
                {
                    UserIds =
{
"testuser1","testuser2"
},
                })
                {
                    IdentityList =
{
new HDInsightManagedIdentitySpec(HDInsightManagedIdentityType.Cluster,new ResourceIdentifier("/subscriptions/subid/resourceGroups/hiloResourcegroup/providers/Microsoft.ManagedIdentity/userAssignedIdentities/test-msi"),"de91f1d8-767f-460a-ac11-3cf103f74b34","40491351-c240-4042-91e0-f644a1d2b441")
},
                    SshProfile = new ClusterSshProfile(2)
                    {
                        VmSize = "Standard_E8as_v5",
                    },
                    AutoscaleProfile = new ClusterAutoscaleProfile(true)
                    {
                        GracefulDecommissionTimeout = 3600,
                        AutoscaleType = ClusterAutoscaleType.ScheduleBased,
                        ScheduleBasedConfig = new ScheduleBasedConfig("Cen. Australia Standard Time", 10, new AutoscaleSchedule[]
            {
new AutoscaleSchedule("00:00","12:00",20,new AutoscaleScheduleDay[]
{
AutoscaleScheduleDay.Monday
}),new AutoscaleSchedule("00:00","12:00",25,new AutoscaleScheduleDay[]
{
AutoscaleScheduleDay.Sunday
})
            }),
                        LoadBasedConfig = new LoadBasedConfig(10, 20, new ScalingRule[]
            {
new ScalingRule(ScaleActionType.ScaleUp,3,"cpu",new HDInsightComparisonRule(HDInsightComparisonOperator.GreaterThan,90)),new ScalingRule(ScaleActionType.ScaleDown,3,"cpu",new HDInsightComparisonRule(HDInsightComparisonOperator.LessThan,20))
            })
                        {
                            PollIntervalInSeconds = 60,
                            CooldownPeriod = 300,
                        },
                    },
                    TrinoProfile = new TrinoProfile(),
                }),
            };
            ArmOperation<HDInsightClusterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, clusterName, data);
            HDInsightClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HDInsightClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // HDInsightRangerClusterPut
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_HDInsightRangerClusterPut()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/HDInsightOnAks/preview/2024-05-01-preview/examples/CreateRangerCluster.json
            // this example is just showing the usage of "Clusters_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightClusterPoolResource created on azure
            // for more information of creating HDInsightClusterPoolResource, please refer to the document of HDInsightClusterPoolResource
            string subscriptionId = "10e32bab-26da-4cc4-a441-52b318f824e6";
            string resourceGroupName = "hiloResourcegroup";
            string clusterPoolName = "clusterpool1";
            ResourceIdentifier hdInsightClusterPoolResourceId = HDInsightClusterPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterPoolName);
            HDInsightClusterPoolResource hdInsightClusterPool = client.GetHDInsightClusterPoolResource(hdInsightClusterPoolResourceId);

            // get the collection of this HDInsightClusterResource
            HDInsightClusterCollection collection = hdInsightClusterPool.GetHDInsightClusters();

            // invoke the operation
            string clusterName = "cluster1";
            HDInsightClusterData data = new HDInsightClusterData(new AzureLocation("West US 2"))
            {
                Properties = new HDInsightClusterProperties("ranger", new ClusterComputeProfile(new ClusterComputeNodeProfile[]
            {
new ClusterComputeNodeProfile("head","Standard_D3_v2",2)
            })
                {
                    AvailabilityZones =
{
"1","2","3"
},
                }, new ClusterProfile("0.0.1", "2.2.3", new AuthorizationProfile()
                {
                    UserIds =
{
"testuser1","testuser2"
},
                })
                {
                    IdentityList =
{
new HDInsightManagedIdentitySpec(HDInsightManagedIdentityType.Cluster,new ResourceIdentifier("/subscriptions/subid/resourceGroups/hiloResourcegroup/providers/Microsoft.ManagedIdentity/userAssignedIdentities/test-msi"),"de91f1d8-767f-460a-ac11-3cf103f74b34","40491351-c240-4042-91e0-f644a1d2b441")
},
                    RangerProfile = new RangerProfile(new RangerAdminSpec(new string[]
            {
"testuser1@contoso.com","testuser2@contoso.com"
            }, new RangerAdminSpecDatabase("testsqlserver.database.windows.net", "testdb")
            {
                PasswordSecretRef = "https://testkv.vault.azure.net/secrets/mysecret/5df6584d9c25418c8d900240aa6c3452",
                Username = "admin",
            }), new RangerUsersyncSpec()
            {
                IsEnabled = true,
                Groups =
            {
"0a53828f-36c9-44c3-be3d-99a7fce977ad","13be6971-79db-4f33-9d41-b25589ca25ac"
            },
                Mode = RangerUsersyncMode.Automatic,
                Users =
            {
"testuser1@contoso.com","testuser2@contoso.com"
            },
            })
                    {
                        RangerAuditStorageAccount = "https://teststorage.blob.core.windows.net/testblob",
                    },
                }),
            };
            ArmOperation<HDInsightClusterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, clusterName, data);
            HDInsightClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HDInsightClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // HDInsightSparkClusterPut
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_HDInsightSparkClusterPut()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/HDInsightOnAks/preview/2024-05-01-preview/examples/CreateSparkCluster.json
            // this example is just showing the usage of "Clusters_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightClusterPoolResource created on azure
            // for more information of creating HDInsightClusterPoolResource, please refer to the document of HDInsightClusterPoolResource
            string subscriptionId = "10e32bab-26da-4cc4-a441-52b318f824e6";
            string resourceGroupName = "hiloResourcegroup";
            string clusterPoolName = "clusterpool1";
            ResourceIdentifier hdInsightClusterPoolResourceId = HDInsightClusterPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterPoolName);
            HDInsightClusterPoolResource hdInsightClusterPool = client.GetHDInsightClusterPoolResource(hdInsightClusterPoolResourceId);

            // get the collection of this HDInsightClusterResource
            HDInsightClusterCollection collection = hdInsightClusterPool.GetHDInsightClusters();

            // invoke the operation
            string clusterName = "cluster1";
            HDInsightClusterData data = new HDInsightClusterData(new AzureLocation("West US 2"))
            {
                Properties = new HDInsightClusterProperties("spark", new ClusterComputeProfile(new ClusterComputeNodeProfile[]
            {
new ClusterComputeNodeProfile("worker","Standard_D3_v2",4)
            })
                {
                    AvailabilityZones =
{
"1","2","3"
},
                }, new ClusterProfile("0.0.1", "2.2.3", new AuthorizationProfile()
                {
                    UserIds =
{
"testuser1","testuser2"
},
                })
                {
                    IdentityList =
{
new HDInsightManagedIdentitySpec(HDInsightManagedIdentityType.Cluster,new ResourceIdentifier("/subscriptions/subid/resourceGroups/hiloResourcegroup/providers/Microsoft.ManagedIdentity/userAssignedIdentities/test-msi"),"de91f1d8-767f-460a-ac11-3cf103f74b34","40491351-c240-4042-91e0-f644a1d2b441")
},
                    ServiceConfigsProfiles =
{
new ClusterServiceConfigsProfile("spark-service",new ClusterServiceConfig[]
{
new ClusterServiceConfig("spark-config",new ClusterConfigFile[]
{
new ClusterConfigFile("spark-defaults.conf")
{
Values =
{
["spark.eventLog.enabled"] = "true",
},
}
})
}),new ClusterServiceConfigsProfile("yarn-service",new ClusterServiceConfig[]
{
new ClusterServiceConfig("yarn-config",new ClusterConfigFile[]
{
new ClusterConfigFile("core-site.xml")
{
Values =
{
["fs.defaultFS"] = "wasb://testcontainer@teststorage.dfs.core.windows.net/",
["storage.container"] = "testcontainer",
["storage.key"] = "test key",
["storage.name"] = "teststorage",
["storage.protocol"] = "wasb",
},
},new ClusterConfigFile("yarn-site.xml")
{
Values =
{
["yarn.webapp.ui2.enable"] = "false",
},
}
})
})
},
                    SshProfile = new ClusterSshProfile(2)
                    {
                        VmSize = "Standard_D3_v2",
                    },
                    SparkProfile = new SparkProfile(),
                }),
            };
            ArmOperation<HDInsightClusterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, clusterName, data);
            HDInsightClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HDInsightClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // HDInsightSparkClusterPutWithInternalIngress
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_HDInsightSparkClusterPutWithInternalIngress()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/HDInsightOnAks/preview/2024-05-01-preview/examples/CreateSparkClusterWithInternalIngress.json
            // this example is just showing the usage of "Clusters_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightClusterPoolResource created on azure
            // for more information of creating HDInsightClusterPoolResource, please refer to the document of HDInsightClusterPoolResource
            string subscriptionId = "10e32bab-26da-4cc4-a441-52b318f824e6";
            string resourceGroupName = "hiloResourcegroup";
            string clusterPoolName = "clusterpool1";
            ResourceIdentifier hdInsightClusterPoolResourceId = HDInsightClusterPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterPoolName);
            HDInsightClusterPoolResource hdInsightClusterPool = client.GetHDInsightClusterPoolResource(hdInsightClusterPoolResourceId);

            // get the collection of this HDInsightClusterResource
            HDInsightClusterCollection collection = hdInsightClusterPool.GetHDInsightClusters();

            // invoke the operation
            string clusterName = "cluster1";
            HDInsightClusterData data = new HDInsightClusterData(new AzureLocation("West US 2"))
            {
                Properties = new HDInsightClusterProperties("spark", new ClusterComputeProfile(new ClusterComputeNodeProfile[]
            {
new ClusterComputeNodeProfile("worker","Standard_D3_v2",4)
            })
                {
                    AvailabilityZones =
{
"1","2","3"
},
                }, new ClusterProfile("0.0.1", "2.2.3", new AuthorizationProfile()
                {
                    UserIds =
{
"testuser1","testuser2"
},
                })
                {
                    IdentityList =
{
new HDInsightManagedIdentitySpec(HDInsightManagedIdentityType.Cluster,new ResourceIdentifier("/subscriptions/subid/resourceGroups/hiloResourcegroup/providers/Microsoft.ManagedIdentity/userAssignedIdentities/test-msi"),"de91f1d8-767f-460a-ac11-3cf103f74b34","40491351-c240-4042-91e0-f644a1d2b441")
},
                    ServiceConfigsProfiles =
{
new ClusterServiceConfigsProfile("spark-service",new ClusterServiceConfig[]
{
new ClusterServiceConfig("spark-config",new ClusterConfigFile[]
{
new ClusterConfigFile("spark-defaults.conf")
{
Values =
{
["spark.eventLog.enabled"] = "true",
},
}
})
}),new ClusterServiceConfigsProfile("yarn-service",new ClusterServiceConfig[]
{
new ClusterServiceConfig("yarn-config",new ClusterConfigFile[]
{
new ClusterConfigFile("core-site.xml")
{
Values =
{
["fs.defaultFS"] = "wasb://testcontainer@teststorage.dfs.core.windows.net/",
["storage.container"] = "testcontainer",
["storage.key"] = "test key",
["storage.name"] = "teststorage",
["storage.protocol"] = "wasb",
},
},new ClusterConfigFile("yarn-site.xml")
{
Values =
{
["yarn.webapp.ui2.enable"] = "false",
},
}
})
})
},
                    ClusterAccessProfile = new ClusterAccessProfile(true),
                    SshProfile = new ClusterSshProfile(2)
                    {
                        VmSize = "Standard_D3_v2",
                    },
                    SparkProfile = new SparkProfile(),
                }),
            };
            ArmOperation<HDInsightClusterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, clusterName, data);
            HDInsightClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HDInsightClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
