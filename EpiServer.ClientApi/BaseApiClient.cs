using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EpiServer.ClientApi
{
    public abstract class BaseApiClient
    {
		protected IClientConfig _config;
		protected HttpClient _client;
		public BaseApiClient(IClientConfig config)
		{
			_config = config;
		}

		protected HttpClient Client
		{
			get
			{
				if (_client == null)
				{
					RenewClient();
				}

				return _client;
			}
		}
		public void RenewClient()
		{
			string token = GetAccessToken();

			_client = new HttpClient();
			_client.BaseAddress = new Uri(_config.IntegrationUrl);
			_client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
		}
		public abstract string GetAccessToken();

		public string Get(string requestUri)
		{
			var result = Client.GetAsync(requestUri).Result.Content.ReadAsStringAsync().Result;
			return result;
		}
		public string Put(string requestUri, string content)
		{
			var result = Client.PutAsync(requestUri, new StringContent(content, Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result;
			return result;
		}
		public string Post(string requestUri, string content)
		{
			var result = Client.PostAsync(requestUri, new StringContent(content, Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result;
			return result;
		}
		public string Delete(string requestUri, string content)
		{
			var result = Client.DeleteAsync(requestUri).Result.Content.ReadAsStringAsync().Result;
			return result;
		}
	}
}
