using EpiServer.ClientApi;
using EPiServer.ClientApi.Test.SiteConfig;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer.ClientApi.Test.ContentApi.Controllers
{
	public class ContentApiControllerTest
	{
		public const string BaseContentApiRoute = "api/episerver/v2.0/";
		public const string RoutePrefix = BaseContentApiRoute + "content";


		[Test]
		public void GetProduct_ShouldReturn200()
		{
			ContentApiClient client = new ContentApiClient(new QuickSilverB2BSiteContext());

			var result = client.Get(RoutePrefix + "/d77217f2-2b64-44aa-a5e6-6ff1d9b5e518");
		}

		[Test]
		public void GetPage_ShouldReturn200()
		{
			ContentApiClient client = new ContentApiClient(new QuickSilverB2BSiteContext());

			var result = client.Get(RoutePrefix + "/1989");
		}
	}
}
