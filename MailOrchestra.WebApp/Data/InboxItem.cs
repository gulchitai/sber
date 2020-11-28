using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailOrchestra.WebApp.Data
{
	public class InboxItem
	{
		public class Item
		{
			public int millis;
			public string stamp;
			public DateTime datetime;
			public string light;
			public float temp;
			public float vcc;
		}
	}
}
