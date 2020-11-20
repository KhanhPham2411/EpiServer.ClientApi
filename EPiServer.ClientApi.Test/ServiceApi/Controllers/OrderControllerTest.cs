using EpiServer.ClientApi;
using EPiServer.ServiceApi.Commerce.Models.Order;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer.ClientApi.Test.ServiceApi.Controllers
{
	public class OrderControllerTest : ServiceApiClientTest
	{
		private string _routeEntry = "episerverapi/commerce/orders";

		public OrderControllerTest()
		{
			_client = new ServiceApiClient(new SiteContext()
			{
				IntegrationUrl = "http://localhost:52344/",
				UserName = "admin@example.com",
				Password = "store"
			});
		}

		[Test]
		public void Put_Return204()
		{
			var data = _client.Get(_routeEntry + "/1014");
			var order = JsonConvert.DeserializeObject<PurchaseOrderModel>(data.ContentString);
			order.TaxTotal = 55;

			var data_put = JsonConvert.SerializeObject(order);
			_client.Put(_routeEntry + "/1014", data_put);
		}

		[Test]
		public void Post_WithData()
		{
			var json = File.ReadAllText(GetAbsolutePath("data.json"));
			var result1 = _client.Post(_routeEntry, json);
		}
	}
}
