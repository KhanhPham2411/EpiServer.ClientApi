using EpiServer.ClientApi;
using EPiServer.ServiceApi.Commerce.Models.Catalog;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer.ClientApi.Test.ServiceApi.Controllers
{
	public class PriceControllerTest : ServiceApiClientTest
	{
		private string _routeEntry = "episerverapi/commerce/entries/kvc_sku_2030552/prices";

		public PriceControllerTest()
		{
			_client = new ServiceApiClient(new SiteContext()
			{
				IntegrationUrl = "https://vspl01mstry990sprep.azurewebsites.net/",
				UserName = "admin@episerver.com",
				Password = "3p1cDssc!"
			});
		}

		[Test]
		public void GetCatalogEntryPrices()
		{
			var data = _client.Get(_routeEntry);
			IEnumerable<Price> prices = JsonConvert.DeserializeObject<IEnumerable<Price>>(data.ContentString);

			var test = _client.Put(_routeEntry, data.ContentString);
		}
	}
}
