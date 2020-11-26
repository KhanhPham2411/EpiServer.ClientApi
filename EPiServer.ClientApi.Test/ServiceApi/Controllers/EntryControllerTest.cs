﻿using EpiServer.ClientApi;
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
	public class EntryControllerTest : ServiceApiClientTest
	{
		private string _routeEntry = "episerverapi/commerce/entries";

		public EntryControllerTest()
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
			var entry = _client.GetEntry(getRouteEntryCode("SKU-36127195"));

			// PUT IsActive=true,PublishStatuses= TRUE; RESULT: SUCCESS
			entry.SeoInformation[1].Title = "Title LV 2";
			var result1 = _client.PutEntry(getRouteEntryCode("P-39813617"), entry);
			var entry1 = _client.GetEntry(getRouteEntryCode("P-39813617"));

			////// PUT IsActive = false, PublishStatuses = TRUE; RESULT: SUCCESS
			//entry1.IsActive = false;
			//entry1.SeoInformation[1].Title = "Title LV 2";
			//var result2 = _client.PutEntry(getRouteEntryCode("SKU-36127195"), entry1);
			//var entry2 = _client.GetEntry(getRouteEntryCode("SKU-36127195"));

			//// PUT IsActive = false, PublishStatuses = TRUE; RESULT: ERROR => cannot reproduce
			//var result3 = _client.PutEntry(getRouteEntryCode("SKU-36127195"), entry2);
			//var entry3 = _client.GetEntry(getRouteEntryCode("SKU-36127195"));

			//// PUT IsActive = true, PublishStatuses = TRUE; RESULT: ERROR => cannot reproduce
			//var result4 = _client.PutEntry(getRouteEntryCode("SKU-36127195"), entry3);
			//var entry4 = _client.GetEntry(getRouteEntryCode("SKU-36127195"));

		}

		public string getRouteEntryCode(string code)
		{
			return _routeEntry + "/" + code;
		}

		[Test]
		public void Post_WithData()
		{
			var json = File.ReadAllText(GetAbsolutePath("data.json"));
			var result1 = _client.Post(_routeEntry, json);
		}

		[Test]
		public void Duplicate()
		{
			var entry = _client.GetEntry(getRouteEntryCode("SKU-36127195"));
			// 10.000 items take 21 min
			for (int i = 3; i < 9999; i++)
			{
				var jsonEntry = JsonConvert.SerializeObject(entry).Replace(entry.Code, $"{entry.Code}_{i}");
				var result = _client.Post(_routeEntry, jsonEntry);
			}
		}

	}
}
