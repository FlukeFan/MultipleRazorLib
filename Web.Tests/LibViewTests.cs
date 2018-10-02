using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using NUnit.Framework;

namespace MultipleRazorLib.Web.Tests
{
    [TestFixture]
    public class LibViewTests
    {
        [Test]
        public async Task CanSeeViewFromLib1()
        {
            var client = CreateClient();

            var response = await client.GetAsync("/lib1");

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var responseText = await response.Content.ReadAsStringAsync();

            Assert.That(responseText, Is.EqualTo("View from Lib1"));
        }

        [Test]
        public async Task CanSeeViewFromLib2()
        {
            var client = CreateClient();

            var response = await client.GetAsync("/lib2");

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var responseText = await response.Content.ReadAsStringAsync();

            Assert.That(responseText, Is.EqualTo("View from Lib2"));
        }

        private HttpClient CreateClient()
        {
            var builder = new WebHostBuilder().UseStartup<TestStartup>();
            var server = new TestServer(builder);
            return server.CreateClient();
        }
    }
}