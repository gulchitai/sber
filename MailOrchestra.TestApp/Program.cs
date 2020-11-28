using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MailOrchestra.TestApp
{
	class Program
	{
		private static List<InboxItem> items;

		public static void LoadJson()
		{
			items=new List<InboxItem>();


			using (StreamReader r = new StreamReader(@"C:\Users\Grigoriy\Desktop\hakaton\inbox.json"))
			{
				string json = r.ReadToEnd();
				//List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
				var array = JsonConvert.DeserializeObject<dynamic>(json);

				//var f = items.Take(1);

				var item = new InboxItem();

				foreach (var it in array)
				{
					item.owner = it.owner;
					item.from = it.from;
					item.subject = it.subject;
					item.message_id = it.message_id;
					item.text = it.text;

					//var toList = (string[]) it.to;


					if (it.to != null)
					{
						var toList = ((JArray) it.to).ToObject<List<string>>();
						item.to = new List<string>();
						item.to.AddRange(toList);
					}


					if (it.cc != null)
					{
						var ccList = ((JArray) it.cc).ToObject<List<string>>();
						item.cc = new List<string>();
						item.cc.AddRange(ccList);
					}


					if (it.forward != null)
					{
						item.forward = new Forward();
						item.forward.text = (((JArray) it.forward)[0] as dynamic).text;

						item.forward.fwdInfo = new ForwardInfo();
						item.forward.fwdInfo.text = (((JArray) it.forward)[1] as dynamic).text;
						item.forward.fwdInfo.message_id = (((JArray) it.forward)[1] as dynamic).message_id;
						item.forward.fwdInfo.clear_text = (((JArray) it.forward)[1] as dynamic).clear_text;
						item.forward.fwdInfo.clear_subject = (((JArray) it.forward)[1] as dynamic).clear_subject;
						item.forward.fwdInfo.owner = (((JArray) it.forward)[1] as dynamic).owner;
						item.forward.fwdInfo.owner_fio = (((JArray) it.forward)[1] as dynamic).owner_fio;
					}
					



					//foreach (var tlItem in toList)
					//{
					//	var fff = tlItem;
					//	item.to.Add(tlItem);
					//}

					items.Add(item);
				}
				

			}
		}


		public class ForwardInfo
		{
			public List<string> to;
			public List<string> from;
			public List<string> cc;
			public DateTime date;
			public string text; //+
			public string message_id; //+
			public string clear_text; //+
			public string clear_subject; //+
			public List<string> from_norm;
			public List<string> to_norm;
			public string owner; //+
			public List<string> from_fio;
			public List<string> to_fio;
			public string owner_fio; //+
		}
			

		public class Forward
		{
			public string text;
			public ForwardInfo fwdInfo;
		}


		public class InboxItem
		{
			public string owner;
			public string from;
			public List<string> to;
			public List<string> cc;
			public DateTime date;
			public string subject;
			public string message_id;
			public string text;
			public Forward forward;
		}



		static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			LoadJson();
			Console.ReadLine();
		}
	}
}
