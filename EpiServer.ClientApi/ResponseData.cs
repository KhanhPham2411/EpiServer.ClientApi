using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EpiServer.ClientApi
{
	public class ResponseData
	{
		public HttpResponseMessage Result { get; }

		public string ContentString {
			get
			{
				return Result.Content.ReadAsStringAsync().Result;
			}
		}

		public ResponseData(HttpResponseMessage result)
		{
			Result = result;
		}
	}
}
