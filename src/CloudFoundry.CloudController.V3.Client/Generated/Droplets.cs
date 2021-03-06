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

using CloudFoundry.CloudController.Common;
using CloudFoundry.CloudController.V3.Client.Data;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V3.Client
{
    /// <summary>
    /// Droplets Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class DropletsEndpoint : CloudFoundry.CloudController.V3.Client.Base.AbstractDropletsEndpoint
    {
        internal DropletsEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V3.Client.Base
{
    /// <summary>
    /// Base abstract class for Droplets Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractDropletsEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractDropletsEndpoint()
        {
        }

        /// <summary>
        /// List all Droplets
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/droplets__experimental_/list_all_droplets.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllDropletsResponse>> ListAllDroplets()
        {
            return await ListAllDroplets(new RequestOptions());
        }

        /// <summary>
        /// List all Droplets
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/droplets__experimental_/list_all_droplets.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllDropletsResponse>> ListAllDroplets(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v3/droplets";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllDropletsResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Delete a Droplet
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/droplets__experimental_/delete_a_droplet.html"</para>
        /// </summary>
        public async Task DeleteDroplet(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v3/droplets/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Get a Droplet
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/droplets__experimental_/get_a_droplet.html"</para>
        /// </summary>
        public async Task<GetDropletResponse> GetDroplet(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v3/droplets/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<GetDropletResponse>(await response.ReadContentAsStringAsync());
        }
    }
}
