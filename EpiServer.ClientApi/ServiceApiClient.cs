using EPiServer.ServiceApi.Commerce.Models.Catalog;
using Newtonsoft.Json;
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
	public class ServiceApiClient : BaseApiClient
	{
		public ServiceApiClient(SiteContext context) : base(context)
		{
			_tokenEndpoint = "/episerverapi/token";
		}

		public Entry GetEntry(string requestUri)
		{
			var result = Get(requestUri);
			return JsonConvert.DeserializeObject<Entry>(result);
		}
		public string PutEntry(string requestUri, Entry entry)
		{
			return Put(requestUri, JsonConvert.SerializeObject(entry));
		}
		public string PostEntry(string requestUri, Entry entry)
		{
			return Post(requestUri, JsonConvert.SerializeObject(entry));
		}

		public override string GetAccessToken()
		{
			string token = "";
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri(_context.IntegrationUrl);

				var fields = new Dictionary<string, string>
				{
					{ "grant_type", "password" },
					{ "username", _context.UserName },
					{ "password", _context.Password }
				};

				var response = client.PostAsync(_tokenEndpoint, new FormUrlEncodedContent(fields)).Result;
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
