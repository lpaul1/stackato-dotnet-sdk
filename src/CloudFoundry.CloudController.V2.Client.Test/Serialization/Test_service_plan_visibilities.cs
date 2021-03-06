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
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Test.Serialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ServicePlanVisibilitiesTest
    {

        [TestMethod]
        public void TestUpdateServicePlanVisibilityRequest()
        {
            string json = @"{
  ""service_plan_guid"": ""3b630269-e454-4f81-b135-4b9eea06e86a"",
  ""organization_guid"": ""1b26d786-cad1-4503-b215-587a0fbae134""
}";

            UpdateServicePlanVisibilityRequest request = new UpdateServicePlanVisibilityRequest();

            request.ServicePlanGuid = new Guid("3b630269-e454-4f81-b135-4b9eea06e86a");
            request.OrganizationGuid = new Guid("1b26d786-cad1-4503-b215-587a0fbae134");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestCreateServicePlanVisibilityRequest()
        {
            string json = @"{
  ""service_plan_guid"": ""3f0c3f84-ed58-485e-ad2c-6702241de1ed"",
  ""organization_guid"": ""b9a0eecd-f62f-4efd-8a1e-0357a60d290b""
}";

            CreateServicePlanVisibilityRequest request = new CreateServicePlanVisibilityRequest();

            request.ServicePlanGuid = new Guid("3f0c3f84-ed58-485e-ad2c-6702241de1ed");
            request.OrganizationGuid = new Guid("b9a0eecd-f62f-4efd-8a1e-0357a60d290b");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
