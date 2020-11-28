using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MailOrchestra.WebApp
{
	public class Program
	{


		public static void Main(string[] args)
		{

			//string json = "{'results':[{'SwiftCode':'','City':'','BankName':'Deutsche    Bank','Bankkey':'10020030','Bankcountry':'DE'},{'SwiftCode':'','City':'10891    Berlin','BankName':'Commerzbank Berlin (West)','Bankkey':'10040000','Bankcountry':'DE'}]}";
			//StringBuilder json = new StringBuilder();
			//json.Append(File.ReadAllText(@"C:\Users\Grigoriy\Desktop\hakaton\inbox.json"));


			//var resultObjects = AllChildren(JObject.Parse(json.ToString()))
			//	.First(c => c.Type == JTokenType.Array && c.Path.Contains("results"))
			//	.Children<JObject>();

			//foreach (JObject result in resultObjects)
			//{
			//	foreach (JProperty property in result.Properties())
			//	{
			//		// do something with the property belonging to result
			//	}
			//}


			//LoadJson();

			string filepath = @"C:\Users\Grigoriy\Desktop\hakaton\sber\MailOrchestra.WebApp\Data\letters.csv";
			DataTable res = ConvertCSVtoDataTable(filepath);

			foreach (var row in res.Rows)
			{
				var t = row;
			}


			CreateWebHostBuilder(args).Build().Run();


			
		}


		public static DataTable ConvertCSVtoDataTable(string strFilePath)
		{
			StreamReader sr = new StreamReader(strFilePath);
			string[] headers = sr.ReadLine().Split(',');
			DataTable dt = new DataTable();
			foreach (string header in headers)
			{
				dt.Columns.Add(header);
			}
			while (!sr.EndOfStream)
			{
				string[] rows = Regex.Split(sr.ReadLine(), ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
				DataRow dr = dt.NewRow();
				for (int i = 0; i < headers.Length; i++)
				{
					dr[i] = rows[i];
				}
				dt.Rows.Add(dr);
			}
			return dt;
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
