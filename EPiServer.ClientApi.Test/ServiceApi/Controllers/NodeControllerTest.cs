using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer.ClientApi.Test.ServiceApi.Controllers
{
	public class NodeControllerTest : ServiceApiClientTest
	{
		[Test]
		public void Get_ReturnCorrectSortOrder()
		{
			var data = _client.Get("episerverapi/commerce/nodes/mens/");
		}
	}
}
