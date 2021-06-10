using EpiServer.ClientApi;
using EPiServer.ClientApi.Test.SiteConfig;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer.ClientApi.Test.ServiceApi
{
	public class ServiceApiClientTest : BaseTest
	{
		protected ServiceApiClient _client;
		public ServiceApiClientTest()
		{
			//_client = new ServiceApiClient(new QuickSilverB2BSiteContext());

            _client = new ServiceApiClient(new SiteContext()
            {
                IntegrationUrl = "http://localhost:57244/",
                UserName = "admin@example.com",
                Password = "store"
            });
        }

		[Test]
		public void TestGetAccessToken()
		{
			var token = _client.GetAccessToken();
			Assert.IsFalse(String.IsNullOrEmpty(token));
		}
	}
}
