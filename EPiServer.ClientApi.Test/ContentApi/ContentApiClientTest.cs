using EpiServer.ClientApi;
using EPiServer.ClientApi.Test.SiteConfig;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer.ClientApi.Test.ContentApi
{
	public class ContentApiClientTest : BaseTest
	{
		[Test]
		public void TestGetAccessToken()
		{
			ContentApiClient client = new ContentApiClient(new AlloySiteSiteContext());
			var token = client.GetAccessToken();
		}
	}
}
