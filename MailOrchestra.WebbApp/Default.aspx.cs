using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MailOrchestra.WebbApp.Data;
using OfficeOpenXml;

namespace MailOrchestra.WebbApp
{



	public partial class _Default : Page
	{

		public List<InboxItem> MailItems;
		public string SelectedGroupName { get; set; }

		protected void Page_Load(object sender, EventArgs e)
		{
			
			var filter = 1;
			if (Request["filter"] != null)
				filter = int.Parse(Request["filter"]);

			if (filter == 0)
			{
				
				MailItems = DataRepo.MailItems.Where(t => t.Strategy).OrderByDescending(t=>t.Date).Take(20).ToList();
				SelectedGroupName = "Стратегия(" + MailItems.Count() + ")";

			}
			if (filter == 1)
			{
				
				MailItems = DataRepo.MailItems.OrderByDescending(t=>t.Ves).ThenBy(t=>t.Date).Take(15).ToList();
				SelectedGroupName = "Важные(" + MailItems.Count() + ")";
			}
			if (filter == 2)
			{
				MailItems = DataRepo.MailItems.Where(t=>t.OnlyMe).OrderByDescending(t=>t.CountMyName).ThenBy(t=>t.Date).Take(10).ToList();
				SelectedGroupName = "Срочные("+ MailItems.Count() + ")";
			}
			if (filter == 3)
			{
				SelectedGroupName = "Шаблонный ответ";
			}

			if (filter == 4)
			{
				MailItems = DataRepo.MailItems.Where(t=>t.Problem).OrderByDescending(t=>t.Date).Take(5).ToList();
				SelectedGroupName = "Сообщения с проблемой(" + MailItems.Count() + ")";
			}

		}


		
	}
}