using EpiServer.ClientApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer.ClientApi.Test.SiteConfig
{
	public class AlloySiteSiteContext : SiteContext
	{
		public AlloySiteSiteContext()
		{
			IntegrationUrl = "http://localhost:51481/";
			UserName = "epiadmin";
			Password = "3p!Pass";
		}
	}
}
