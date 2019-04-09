using EpiServer.ClientApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer.ClientApi.Test.SiteConfig
{
	public class AlloySiteClientConfig : ClientConfig
	{
		public AlloySiteClientConfig()
		{
			IntegrationUrl = "http://localhost:51481/";
			UserName = "epiadmin";
			Password = "3p!Pass";
		}
	}
}
