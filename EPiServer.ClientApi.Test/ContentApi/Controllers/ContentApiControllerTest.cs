﻿using EpiServer.ClientApi;
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
		public void Search_ShouldReturn200()
		{
			ContentApiClient client = new ContentApiClient(new AlloySiteContext());

			var result = client.Get(RoutePrefix + "/311");
		}
	}
}
