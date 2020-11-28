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

namespace MailOrchestra.WebApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateWebHostBuilder(args).Build().Run();



			var json = File.ReadAllText("../");
			var resultObjects = AllChildren(JObject.Parse(json))
				.First(c => c.Type == JTokenType.Array && c.Path.Contains("results"))
				.Children<JObject>();

			foreach (JObject result in resultObjects) {
				foreach (JProperty property in result.Properties()) {
					// do something with the property belonging to result
				}
			}
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
