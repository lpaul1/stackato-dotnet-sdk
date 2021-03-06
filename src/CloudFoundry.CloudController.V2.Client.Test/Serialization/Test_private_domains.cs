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
    public class PrivateDomainsTest
    {

        [TestMethod]
        public void TestCreatePrivateDomainOwnedByGivenOrganizationRequest()
        {
            string json = @"{
  ""name"": ""exmaple.com"",
  ""owning_organization_guid"": ""26617dad-a614-4c3d-baf7-e0785b9b58e0""
}";

            CreatePrivateDomainOwnedByGivenOrganizationRequest request = new CreatePrivateDomainOwnedByGivenOrganizationRequest();

            request.Name = "exmaple.com";
            request.OwningOrganizationGuid = new Guid("26617dad-a614-4c3d-baf7-e0785b9b58e0");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
