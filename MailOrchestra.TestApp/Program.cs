using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MailOrchestra.TestApp
{
	class Program
	{
		

		public class InboxItem
		{
		
			public int Num;
			public string From;
			public string To;
			public string Cc;
			public string Subj;
			public string Napical;
			public string Otvetil;
			public DateTime Date;
			public bool OnlyMe;
			public int CountMyName;
			public decimal Ves;
			public bool Strategy;

		}

		static void Main(string[] args)
		{
			string filepath = @"C:\Users\Grigoriy\Desktop\hakaton\sber\MailOrchestra.WebApp\Data\letters.csv";

			CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
			var csvParser = new CsvParser<Automobile>(csvParserOptions, new CsvAutomobileMapping());
			var records = csvParser.ReadFromFile("import.txt", Encoding.UTF8);


			using (StreamReader reader = new StreamReader(filepath))
			{
				var cont = reader.ReadToEnd();
				cont = cont.Replace("\r\n", ";");
				var items = cont.Split(";");

				var k = 0;
				foreach (var it in items.Skip(12))
				{
					var t = new InboxItem();

					if (k == 0)
					{
						t.Num = Convert.ToInt32(it);
					}

					if (k == 1)
					{
						t.From = it;
					}

					if (k == 2)
					{
						t.To = it;
					}

					if (k == 3)
					{
						t.Cc = it;
					}


					if (k == 4)
					{
						t.Subj = it;
					}

					if (k == 5)
					{
						t.Napical = it;
					}


					if (k == 6)
					{
						t.Otvetil = it;
					}

					if (k == 7)
					{
						t.Date = Convert.ToDateTime(it);
					}

					if (k == 8)
					{
						t.OnlyMe = Convert.ToBoolean(it);
					}

					if (k == 9)
					{
						t.CountMyName = Convert.ToInt32(it);
					}

					if (k == 10)
					{
						t.Ves = Convert.ToDecimal(it);
					}

					if (k == 11)
					{
						t.Strategy = Convert.ToBoolean(it);
					}

					if (k == 12)
					{
						k = 0;
					}

					else k++;
				}

				

			}
		}
	}
}
