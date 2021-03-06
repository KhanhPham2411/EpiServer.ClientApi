﻿using System;
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
		protected SiteContext _context;
		protected string _tokenEndpoint;
		protected HttpClient _client;
		public BaseApiClient(SiteContext context)
		{
			_context = context;
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
			_client.BaseAddress = new Uri(_context.IntegrationUrl);
			_client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
		}
		public abstract string GetAccessToken();

		public ResponseData Get(string requestUri)
		{
			var result = Client.GetAsync(requestUri).Result;

			return new ResponseData(result);
		}
		public ResponseData Put(string requestUri, string content)
		{
			var result = Client.PutAsync(requestUri, new StringContent(content, Encoding.UTF8, "application/json")).Result;

			return new ResponseData(result);
		}
		public ResponseData Post(string requestUri, string content)
		{
			var result = Client.PostAsync(requestUri, new StringContent(content, Encoding.UTF8, "application/json")).Result;

			return new ResponseData(result);
		}
		public ResponseData Delete(string requestUri, string content)
		{
			var result = Client.DeleteAsync(requestUri).Result;

			return new ResponseData(result);
		}
	}
}
