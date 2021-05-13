using EpiServer.ClientApi;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer.ClientApi.Test.ServiceApi.Controllers
{
	public class NodeControllerTest : ServiceApiClientTest
	{
		private string _routeEntry = "episerverapi/commerce/nodes";

		public NodeControllerTest()
		{
			_client = new ServiceApiClient(new SiteContext()
			{
				IntegrationUrl = "http://localhost:57244/",
				UserName = "admin@example.com",
				Password = "store"
			});
		}
		public string getRouteEntryCode(string code)
		{
			return _routeEntry + "/" + code;
		}

		[Test]
		public void Get_ReturnCorrectSortOrder()
		{
			var data = _client.Get("episerverapi/commerce/nodes/mens/");
		}

		[Test]
		public void Get()
		{
			var data = _client.Get(getRouteEntryCode("Test2_1"));
		}

		[Test]
		public void Post()
		{
			var json = File.ReadAllText(GetAbsolutePath("data/node_test.json"));
			var data = _client.Post(_routeEntry, json);
		}

		[Test]
		public void Put()
		{
			var json = File.ReadAllText(GetAbsolutePath("data/node_test.json"));
			var data = _client.Put(getRouteEntryCode("Test2_1"), json);
		}
	}
}
