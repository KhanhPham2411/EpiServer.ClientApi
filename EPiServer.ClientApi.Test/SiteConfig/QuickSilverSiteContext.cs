using EpiServer.ClientApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer.ClientApi.Test.SiteConfig
{
	public class QuickSilverSiteContext : SiteContext
	{
		public QuickSilverSiteContext()
		{
			IntegrationUrl = "http://localhost:50244";
			UserName = "admin@example.com";
			Password = "store";
		}
	}
}
