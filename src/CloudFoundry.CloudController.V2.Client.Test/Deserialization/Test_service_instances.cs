//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

//
// This source code was auto-generated by cf-sdk-builder
//

using CloudFoundry.CloudController.V2.Client;
using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ServiceInstancesTest
    {


        [TestMethod]
        public void TestListAllServiceBindingsForServiceInstanceResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""a4f5f3d9-8e7f-4d76-a61b-664835d3d1fb"",
        ""url"": ""/v2/service_bindings/a4f5f3d9-8e7f-4d76-a61b-664835d3d1fb"",
        ""created_at"": ""2016-02-09T10:21:51Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_guid"": ""dbd09550-3768-4103-8a1d-f5a05265bab3"",
        ""service_instance_guid"": ""842673bc-05fa-4e86-a024-535936997c09"",
        ""credentials"": {
          ""creds-key-386"": ""creds-val-386""
        },
        ""binding_options"": {

        },
        ""gateway_data"": null,
        ""gateway_name"": """",
        ""syslog_drain_url"": null,
        ""app_url"": ""/v2/apps/dbd09550-3768-4103-8a1d-f5a05265bab3"",
        ""service_instance_url"": ""/v2/service_instances/842673bc-05fa-4e86-a024-535936997c09""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceBindingsForServiceInstanceResponse> page = Utilities.DeserializePage<ListAllServiceBindingsForServiceInstanceResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("a4f5f3d9-8e7f-4d76-a61b-664835d3d1fb", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_bindings/a4f5f3d9-8e7f-4d76-a61b-664835d3d1fb", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-09T10:21:51Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("dbd09550-3768-4103-8a1d-f5a05265bab3", TestUtil.ToTestableString(page[0].AppGuid), true);
            Assert.AreEqual("842673bc-05fa-4e86-a024-535936997c09", TestUtil.ToTestableString(page[0].ServiceInstanceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayName), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].SyslogDrainUrl), true);
            Assert.AreEqual("/v2/apps/dbd09550-3768-4103-8a1d-f5a05265bab3", TestUtil.ToTestableString(page[0].AppUrl), true);
            Assert.AreEqual("/v2/service_instances/842673bc-05fa-4e86-a024-535936997c09", TestUtil.ToTestableString(page[0].ServiceInstanceUrl), true);
        }

        [TestMethod]
        public void TestMigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimentalResponse()
        {
            string json = @"{""changed_count"":1}";

            MigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimentalResponse obj = Utilities.DeserializeJson<MigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimentalResponse>(json);

            Assert.AreEqual("1", TestUtil.ToTestableString(obj.ChangedCount), true);
        }

        [TestMethod]
        public void TestRetrievingPermissionsOnServiceInstanceResponse()
        {
            string json = @"{""manage"":true}";

            RetrievingPermissionsOnServiceInstanceResponse obj = Utilities.DeserializeJson<RetrievingPermissionsOnServiceInstanceResponse>(json);

            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Manage), true);
        }

        [TestMethod]
        public void TestUpdateServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""de65d6fe-affa-454f-9aa7-f631e90a5611"",
    ""url"": ""/v2/service_instances/de65d6fe-affa-454f-9aa7-f631e90a5611"",
    ""created_at"": ""2016-02-09T10:21:52Z"",
    ""updated_at"": ""2016-02-09T10:21:52Z""
  },
  ""entity"": {
    ""name"": ""name-1695"",
    ""credentials"": {
      ""creds-key-398"": ""creds-val-398""
    },
    ""service_plan_guid"": ""5a40630c-f222-47a5-a3ee-dc204775c725"",
    ""space_guid"": ""37a0cb99-f067-4c5e-95a8-e842583c1384"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""last_operation"": {
      ""type"": ""update"",
      ""state"": ""in progress"",
      ""description"": """",
      ""updated_at"": ""2016-02-09T10:21:52Z""
    },
    ""space_url"": ""/v2/spaces/37a0cb99-f067-4c5e-95a8-e842583c1384"",
    ""service_plan_url"": ""/v2/service_plans/5a40630c-f222-47a5-a3ee-dc204775c725"",
    ""service_bindings_url"": ""/v2/service_instances/de65d6fe-affa-454f-9aa7-f631e90a5611/service_bindings""
  }
}";

            UpdateServiceInstanceResponse obj = Utilities.DeserializeJson<UpdateServiceInstanceResponse>(json);

            Assert.AreEqual("de65d6fe-affa-454f-9aa7-f631e90a5611", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/de65d6fe-affa-454f-9aa7-f631e90a5611", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-09T10:21:52Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-02-09T10:21:52Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1695", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("5a40630c-f222-47a5-a3ee-dc204775c725", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("37a0cb99-f067-4c5e-95a8-e842583c1384", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("/v2/spaces/37a0cb99-f067-4c5e-95a8-e842583c1384", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/5a40630c-f222-47a5-a3ee-dc204775c725", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/de65d6fe-affa-454f-9aa7-f631e90a5611/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
        }

        [TestMethod]
        public void TestListAllServiceInstancesResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""e7924cd4-e470-467c-bb23-064b36e7419a"",
        ""url"": ""/v2/service_instances/e7924cd4-e470-467c-bb23-064b36e7419a"",
        ""created_at"": ""2016-02-09T10:21:51Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1683"",
        ""credentials"": {
          ""creds-key-392"": ""creds-val-392""
        },
        ""service_plan_guid"": ""d1bb2077-6719-494e-9ef0-f27e8ae9302a"",
        ""space_guid"": ""a9227261-da31-40a8-9f70-d5ac73e05d62"",
        ""gateway_data"": null,
        ""dashboard_url"": null,
        ""type"": ""managed_service_instance"",
        ""last_operation"": {
          ""type"": ""create"",
          ""state"": ""succeeded"",
          ""description"": ""service broker-provided description"",
          ""updated_at"": ""2016-02-09T10:21:51Z""
        },
        ""space_url"": ""/v2/spaces/a9227261-da31-40a8-9f70-d5ac73e05d62"",
        ""service_plan_url"": ""/v2/service_plans/d1bb2077-6719-494e-9ef0-f27e8ae9302a"",
        ""service_bindings_url"": ""/v2/service_instances/e7924cd4-e470-467c-bb23-064b36e7419a/service_bindings""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceInstancesResponse> page = Utilities.DeserializePage<ListAllServiceInstancesResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("e7924cd4-e470-467c-bb23-064b36e7419a", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/e7924cd4-e470-467c-bb23-064b36e7419a", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-09T10:21:51Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1683", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("d1bb2077-6719-494e-9ef0-f27e8ae9302a", TestUtil.ToTestableString(page[0].ServicePlanGuid), true);
            Assert.AreEqual("a9227261-da31-40a8-9f70-d5ac73e05d62", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(page[0].Type), true);
            Assert.AreEqual("/v2/spaces/a9227261-da31-40a8-9f70-d5ac73e05d62", TestUtil.ToTestableString(page[0].SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/d1bb2077-6719-494e-9ef0-f27e8ae9302a", TestUtil.ToTestableString(page[0].ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/e7924cd4-e470-467c-bb23-064b36e7419a/service_bindings", TestUtil.ToTestableString(page[0].ServiceBindingsUrl), true);
        }

        [TestMethod]
        public void TestDeleteServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""68b25c7c-279c-4687-98c3-d9d3ae72477b"",
    ""url"": ""/v2/service_instances/68b25c7c-279c-4687-98c3-d9d3ae72477b"",
    ""created_at"": ""2016-02-09T10:21:52Z"",
    ""updated_at"": ""2016-02-09T10:21:52Z""
  },
  ""entity"": {
    ""name"": ""name-1689"",
    ""credentials"": {
      ""creds-key-395"": ""creds-val-395""
    },
    ""service_plan_guid"": ""60b1b037-e6c2-4a01-b6b7-4ce6dd33f470"",
    ""space_guid"": ""a388a476-9528-43c8-a743-e7347d330944"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""last_operation"": {
      ""type"": ""delete"",
      ""state"": ""in progress"",
      ""description"": """",
      ""updated_at"": ""2016-02-09T10:21:52Z""
    },
    ""space_url"": ""/v2/spaces/a388a476-9528-43c8-a743-e7347d330944"",
    ""service_plan_url"": ""/v2/service_plans/60b1b037-e6c2-4a01-b6b7-4ce6dd33f470"",
    ""service_bindings_url"": ""/v2/service_instances/68b25c7c-279c-4687-98c3-d9d3ae72477b/service_bindings""
  }
}";

            DeleteServiceInstanceResponse obj = Utilities.DeserializeJson<DeleteServiceInstanceResponse>(json);

            Assert.AreEqual("68b25c7c-279c-4687-98c3-d9d3ae72477b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/68b25c7c-279c-4687-98c3-d9d3ae72477b", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-09T10:21:52Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-02-09T10:21:52Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1689", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("60b1b037-e6c2-4a01-b6b7-4ce6dd33f470", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("a388a476-9528-43c8-a743-e7347d330944", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("/v2/spaces/a388a476-9528-43c8-a743-e7347d330944", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/60b1b037-e6c2-4a01-b6b7-4ce6dd33f470", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/68b25c7c-279c-4687-98c3-d9d3ae72477b/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
        }

        [TestMethod]
        public void TestRetrieveServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""32e29b45-a238-4100-bb8f-5a8c12fec7fc"",
    ""url"": ""/v2/service_instances/32e29b45-a238-4100-bb8f-5a8c12fec7fc"",
    ""created_at"": ""2016-02-09T10:21:51Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-1677"",
    ""credentials"": {
      ""creds-key-389"": ""creds-val-389""
    },
    ""service_plan_guid"": ""1cb93f78-6ada-494a-b494-73ba4ca847b8"",
    ""space_guid"": ""503a1f4c-d596-4b70-9034-88d37b001687"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""last_operation"": {
      ""type"": ""create"",
      ""state"": ""succeeded"",
      ""description"": ""service broker-provided description"",
      ""updated_at"": ""2016-02-09T10:21:51Z""
    },
    ""space_url"": ""/v2/spaces/503a1f4c-d596-4b70-9034-88d37b001687"",
    ""service_plan_url"": ""/v2/service_plans/1cb93f78-6ada-494a-b494-73ba4ca847b8"",
    ""service_bindings_url"": ""/v2/service_instances/32e29b45-a238-4100-bb8f-5a8c12fec7fc/service_bindings""
  }
}";

            RetrieveServiceInstanceResponse obj = Utilities.DeserializeJson<RetrieveServiceInstanceResponse>(json);

            Assert.AreEqual("32e29b45-a238-4100-bb8f-5a8c12fec7fc", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/32e29b45-a238-4100-bb8f-5a8c12fec7fc", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-09T10:21:51Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1677", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("1cb93f78-6ada-494a-b494-73ba4ca847b8", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("503a1f4c-d596-4b70-9034-88d37b001687", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("/v2/spaces/503a1f4c-d596-4b70-9034-88d37b001687", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/1cb93f78-6ada-494a-b494-73ba4ca847b8", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/32e29b45-a238-4100-bb8f-5a8c12fec7fc/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
        }

        [TestMethod]
        public void TestCreateServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""8c2f47ae-5abe-4c40-a9e4-25c9ba80a37f"",
    ""url"": ""/v2/service_instances/8c2f47ae-5abe-4c40-a9e4-25c9ba80a37f"",
    ""created_at"": ""2016-02-09T10:21:52Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""my-service-instance"",
    ""credentials"": {

    },
    ""service_plan_guid"": ""09cd60d3-b423-4670-9196-dba607d4cce7"",
    ""space_guid"": ""9191d45d-534a-440b-b7b0-9dccd7d0a22d"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""last_operation"": {
      ""type"": ""create"",
      ""state"": ""in progress"",
      ""description"": """",
      ""updated_at"": ""2016-02-09T10:21:52Z""
    },
    ""space_url"": ""/v2/spaces/9191d45d-534a-440b-b7b0-9dccd7d0a22d"",
    ""service_plan_url"": ""/v2/service_plans/09cd60d3-b423-4670-9196-dba607d4cce7"",
    ""service_bindings_url"": ""/v2/service_instances/8c2f47ae-5abe-4c40-a9e4-25c9ba80a37f/service_bindings""
  }
}";

            CreateServiceInstanceResponse obj = Utilities.DeserializeJson<CreateServiceInstanceResponse>(json);

            Assert.AreEqual("8c2f47ae-5abe-4c40-a9e4-25c9ba80a37f", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/8c2f47ae-5abe-4c40-a9e4-25c9ba80a37f", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-09T10:21:52Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("my-service-instance", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("09cd60d3-b423-4670-9196-dba607d4cce7", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("9191d45d-534a-440b-b7b0-9dccd7d0a22d", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("/v2/spaces/9191d45d-534a-440b-b7b0-9dccd7d0a22d", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/09cd60d3-b423-4670-9196-dba607d4cce7", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/8c2f47ae-5abe-4c40-a9e4-25c9ba80a37f/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
        }
    }
}
