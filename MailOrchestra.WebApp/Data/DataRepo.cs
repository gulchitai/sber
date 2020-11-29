using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailOrchestra.WebApp.Data
{
	public static class DataRepo
	{
		public static List<InboxItem> LetterItems;

		static DataRepo()
		{
			LetterItems=new List<InboxItem>();
			var item1 = new InboxItem()
			{
				Num = 1,
				From = "from@from.ru",
				To = "to@to.ru",
				Cc = "cc@cc.ru",
				Subj = "subject",
				Napical = "napical",
				Otvetil = "otvetil",
				Date = DateTime.Now,
				OnlyMe = true,
				CountMyName = 1,
				Ves = 0.3,
				Strategy = true
			};
			AddItem(item1);
		}

		static void AddItem(InboxItem item)
		{
			LetterItems.Add(item);
		}
	}
}
