using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;

namespace MailOrchestra.REST
{
	public class Program
	{
		public static void Main(string[] args)
		{

		


			CreateWebHostBuilder(args).Build().Run();
		}



		// recursively yield all children of json
		private static IEnumerable<JToken> AllChildren(JToken json)
		{
			foreach (var c in json.Children()) {
				yield return c;
				foreach (var cc in AllChildren(c)) {
					yield return cc;
				}
			}
		}

		public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>();
	}
}
