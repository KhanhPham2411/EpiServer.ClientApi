using EpiServer.ClientApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer.ClientApi.Test.SiteConfig
{
	public class QuickSilverB2BSiteClientConfig : ClientConfig
	{
		public QuickSilverB2BSiteClientConfig()
		{
			IntegrationUrl = "http://localhost:50211";
			UserName = "admin@episerver.com";
			Password = "store";
		}
	}
}
