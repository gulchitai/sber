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
				AttenMenuText = "<b>Важно</b>";
			}
			else
			{
				AttenMenuText = "Важно";
			}

			if (filter == 2)
			{
				FastMenuText = "<b>Срочно</b>";
			}
			else
			{
				FastMenuText = "Срочно";
			}

			if (filter == 3)
			{
				TemplMenuText = "<b>Шаблонные</b>";
			}
			else
			{
				TemplMenuText = "Шаблонные";
			}

			if (filter == 4)
			{
				TrabMenuText = "<b>Проблемы</b>";
			}
			else
			{
				TrabMenuText = "Проблемы";
			}

		}

		public string StrategyMenuText { get; set; }
		public object AttenMenuText { get; set; }
		public object FastMenuText { get; set; }
		public object TemplMenuText  { get; set; }
		public object TrabMenuText { get; set; }
	}
}