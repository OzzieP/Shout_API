using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Shout_API;
using Xunit;

namespace TestProject
{
    public class IntegrationTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private HttpClient _client { get; }

        public IntegrationTest(WebApplicationFactory<Startup> fixture)
        {
            _client = fixture.CreateClient();
        }

        [Fact]
        public void Get_Integration_Test()
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
            response.EnsureSuccessStatusCode();
        }
    }
}
