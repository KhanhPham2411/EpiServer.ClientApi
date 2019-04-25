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
		[Test]
		public void TestGetAccessToken()
		{
			ServiceApiClient client = new ServiceApiClient(new QuickSilverB2BSiteContext());
			var token = client.GetAccessToken();
		}
	}
}
