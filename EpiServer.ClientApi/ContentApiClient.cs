using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EpiServer.ClientApi
{
	public class ContentApiClient : BaseApiClient
	{
		public ContentApiClient(ClientConfig config) : base(config)
		{
			_tokenEndpoint = "/api/EPiServer/auth/token";
		}

		public override string GetAccessToken()
		{
			string token = "";
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri(_config.IntegrationUrl);

				var fields = new Dictionary<string, string>
				{
					{ "grant_type", "password" },
					{ "username", _config.UserName },
					{ "password", _config.Password },
					{ "client_id", "Default" }
				};

				var response = client.PostAsync(_config.TokenEndpoint, new FormUrlEncodedContent(fields)).Result;

				if (response.StatusCode == HttpStatusCode.OK)
				{
					var content = response.Content.ReadAsStringAsync().Result;
					token = JObject.Parse(content).GetValue("access_token").ToString();
				}
				else
				{
					throw new Exception(String.Format("Cannot get access token, the server return {0} with message:\n {1}", response.StatusCode, response.Content.ReadAsStringAsync().Result));
				}
			}

			return token;
		}
	}
}
