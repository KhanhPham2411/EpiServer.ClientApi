using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer.ClientApi.Test
{
    public class BaseTest
    {

		public static string GetAbsolutePath(string relativePath)
		{
			return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/" + relativePath;
		}
	}
}
