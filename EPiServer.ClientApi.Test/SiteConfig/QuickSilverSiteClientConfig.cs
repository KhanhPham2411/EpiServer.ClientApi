using EpiServer.ClientApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer.ClientApi.Test.SiteConfig
{
	public class QuickSilverSiteClientConfig : ClientConfig
	{
		public QuickSilverSiteClientConfig()
		{
			IntegrationUrl = "http://localhost:50211";
			UserName = "admin@example.com";
			Password = "store";
		}
	}
}
