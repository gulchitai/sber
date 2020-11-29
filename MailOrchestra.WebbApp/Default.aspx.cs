using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OfficeOpenXml;

namespace MailOrchestra.WebbApp
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
		public double Ves;
		public bool Strategy;

	}

	public partial class _Default : Page
	{

		public List<InboxItem> MailItems;
		public string SelectedGroupName { get; set; }

		protected void Page_Load(object sender, EventArgs e)
		{
			string path = @"C:\Users\Grigoriy\Desktop\hakaton\sber\MailOrchestra.WebbApp\Content\letters.xlsx";
			if (File.Exists(path))
			{
				ExcelPackage excel = new ExcelPackage(new FileInfo(path));
				var firstWorkSheet = excel.Workbook.Worksheets[1];

				var row = 2;
				var allOk = true;

				MailItems = new List<InboxItem>(); 

				while (allOk)
				{
					

					var strNum = firstWorkSheet.Cells[row, 1].Value?.ToString().Trim();
					var strFrom = firstWorkSheet.Cells[row, 2].Value?.ToString().Trim();
					var strTo = firstWorkSheet.Cells[row, 3].Value?.ToString().Trim();
					var strCc = firstWorkSheet.Cells[row, 4].Value?.ToString().Trim();
					var strSubj = firstWorkSheet.Cells[row, 5].Value?.ToString().Trim();
					var strNapic = firstWorkSheet.Cells[row, 6].Value?.ToString().Trim();
					var strOtvet = firstWorkSheet.Cells[row, 7].Value?.ToString().Trim();
					var strDate = firstWorkSheet.Cells[row, 8].Value?.ToString().Trim();
					var strOnlyMe = firstWorkSheet.Cells[row, 9].Value?.ToString().Trim();
					var strCountMyName = firstWorkSheet.Cells[row, 10].Value?.ToString().Trim();
					var strVes = firstWorkSheet.Cells[row, 11].Value?.ToString().Trim();
					var strStrategy = firstWorkSheet.Cells[row, 12].Value?.ToString().Trim();

					var item = new InboxItem()
					{
						Num = Convert.ToInt32(strNum),
						From = strFrom,
						To = strTo,
						Cc = strCc,
						Subj = strSubj,
						Napical = strNapic,
						Otvetil = strOtvet,
						Date = Convert.ToDateTime(strDate),
						OnlyMe = Convert.ToBoolean(Convert.ToInt32(strOnlyMe)),
						CountMyName = Convert.ToInt32(strCountMyName),
						Ves = Convert.ToDouble(strVes),
						Strategy = Convert.ToBoolean(Convert.ToInt32(strStrategy))
					};
					MailItems.Add(item);

					
					
					allOk = (!string.IsNullOrEmpty(strNum));
					row += 1;
				}
			}


			var filter = 1;
			if (Request["filter"] != null)
				filter = int.Parse(Request["filter"]);

			if (filter == 0)
			{
				
				MailItems = MailItems.Where(t => t.Strategy).OrderByDescending(t=>t.Date).Take(20).ToList();
				SelectedGroupName = "Стратегия(" + MailItems.Count() + ")";

			}
			if (filter == 1)
			{
				
				MailItems = MailItems.OrderByDescending(t=>t.Ves).ThenBy(t=>t.Date).Take(15).ToList();
				SelectedGroupName = "Важные(" + MailItems.Count() + ")";
			}
			if (filter == 2)
			{
				SelectedGroupName = "Срочные";
			}
			if (filter == 3)
			{
				SelectedGroupName = "Шаблонный ответ";
			}

		}


		
	}
}