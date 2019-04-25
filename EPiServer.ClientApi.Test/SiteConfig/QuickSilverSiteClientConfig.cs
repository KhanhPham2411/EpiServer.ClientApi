using EpiServer.ClientApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer.ClientApi.Test.SiteConfig
{
	public class QuickSilverB2BSiteContext : SiteContext
	{
		public QuickSilverB2BSiteContext()
		{
			IntegrationUrl = "http://localhost:50211";
			UserName = "admin@episerver.com";
			Password = "store";
		}
	}
}
