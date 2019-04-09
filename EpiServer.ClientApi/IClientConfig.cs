using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiServer.ClientApi
{
	public interface IClientConfig
	{
		string IntegrationUrl { get; }
		string UserName { get; }
		string Password { get; }
		string TokenEndpoint { get; }
	}
}
