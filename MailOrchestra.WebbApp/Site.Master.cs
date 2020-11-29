using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MailOrchestra.WebbApp
{
	public partial class SiteMaster : MasterPage
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			var filter = 1;
			if (Request["filter"] != null)
				filter = int.Parse(Request["filter"]);
			
			if (filter == 0)
			{
				StrategyMenuText = "<b>Стратегия</b>";
			}
			else
			{
				StrategyMenuText = "Стратегия";
			}

			if (filter == 1)
			{
				AttenMenuText = "<b>Важные сообщения</b>";
			}
			else
			{
				AttenMenuText = "Важные сообщения";
			}

			if (filter == 2)
			{
				FastMenuText = "<b>Срочные сообщения</b>";
			}
			else
			{
				FastMenuText = "Срочные сообщения";
			}

			if (filter == 3)
			{
				TemplMenuText = "<b>Шаблонные сообщения</b>";
			}
			else
			{
				TemplMenuText = "Шаблонные сообщения";
			}

			if (filter == 4)
			{
				TrabMenuText = "<b>Сообщения с проблемой</b>";
			}
			else
			{
				TrabMenuText = "Сообщения с проблемой";
			}

		}

		public string StrategyMenuText { get; set; }
		public object AttenMenuText { get; set; }
		public object FastMenuText { get; set; }
		public object TemplMenuText  { get; set; }
		public object TrabMenuText { get; set; }
	}
}