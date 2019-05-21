using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer.ClientApi.Test.ServiceApi.Controllers
{
	public class EntryControllerTest : ServiceApiClientTest
	{
		private string _routeEntry = "episerverapi/commerce/entries";

		[Test]
		public void Put_Return204()
		{
			var entry = _client.GetEntry(getRouteEntryCode("SKU-36127195"));

			// PUT IsActive=true,PublishStatuses= TRUE; RESULT: SUCCESS
			entry.IsActive = true;
			entry.PublishStatuses[0].IsPublished = true;
			var result1 = _client.PutEntry(getRouteEntryCode("SKU-36127195"), entry);

			// PUT IsActive = false, PublishStatuses = TRUE; RESULT: SUCCESS
			entry.IsActive = false;
			entry.PublishStatuses[0].IsPublished = true;
			var result2 = _client.PutEntry(getRouteEntryCode("SKU-36127195"), entry);

			// PUT IsActive = false, PublishStatuses = TRUE; RESULT: ERROR => cannot reproduce
			entry.IsActive = false;
			entry.PublishStatuses[0].IsPublished = true;
			var result3 = _client.PutEntry(getRouteEntryCode("SKU-36127195"), entry);

			// PUT IsActive = true, PublishStatuses = TRUE; RESULT: ERROR => cannot reproduce
			entry.IsActive = true;
			entry.PublishStatuses[0].IsPublished = true;
			var result4 = _client.PutEntry(getRouteEntryCode("SKU-36127195"), entry);

		}

		public string getRouteEntryCode(string code)
		{
			return _routeEntry + "/" + code;
		}
	}
}
