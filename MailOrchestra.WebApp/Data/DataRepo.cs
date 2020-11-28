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
		}

		static void AddItem(InboxItem item)
		{
			LetterItems.Add(item);
		}
	}
}
