using AppCore.IServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagers.Forms
{
	public partial class FrmStatistics : Form
	{
		public ITaskServices Services { get; set; }
		public FrmStatistics()
		{
	
			InitializeComponent();


		}

		private void FrmStatistics_Load(object sender, EventArgs e)
			
		{
		}

		private void gunaChart1_Load(object sender, EventArgs e)
		{

			GeneratePieChart();

		}
		private void GeneratePieChart()
		{
			
			gunaChart1.Title.Text= $"Tasks: { Services.Read(1).Length + Services.Read(2).Length} ";
			gunaDoughnutDataset1.DataPoints.Add("Tasks done", Services.Read(2).Count(x => x.State == Domain.Enum.TaskStatus.Finished));
			gunaDoughnutDataset1.DataPoints.Add("Tasks not Done", Services.Read(2).Count(x => x.State == Domain.Enum.TaskStatus.Failed)+ Services.Read(1).Count(x => x.State == Domain.Enum.TaskStatus.Failed));
			gunaDoughnutDataset1.DataPoints.Add("Tasks Started", Services.Read(1).Count(x => x.State == Domain.Enum.TaskStatus.Started));
			gunaDoughnutDataset1.DataPoints.Add("Tasks without starting", Services.Read(1).Count(x => x.State == Domain.Enum.TaskStatus.WithoutStarting));
		}
		
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void gunaChart2_Load(object sender, EventArgs e)
		{
			GunaBarCreate();
		}
		private void GunaBarCreate()
		{
			gunaChart2.Misc.BarCornerRadius = 10;
			gunaChart2.Title.Text = $"Import statistics ";
			gunaBarDataset1.Label = "";
			gunaBarDataset1.DataPoints.Add("Important", Services.Read(1).Count(x => x.Importance == Domain.Enum.TaskImportance.Important) + Services.Read(2).Count(x => x.Importance == Domain.Enum.TaskImportance.Important));
			gunaBarDataset1.DataPoints.Add("Very Important", Services.Read(1).Count(x => x.Importance == Domain.Enum.TaskImportance.VeryImportant) + Services.Read(2).Count(x => x.Importance == Domain.Enum.TaskImportance.VeryImportant));
			gunaBarDataset1.DataPoints.Add("Secondary", Services.Read(1).Count(x => x.Importance == Domain.Enum.TaskImportance.Secondary) + Services.Read(2).Count(x => x.Importance == Domain.Enum.TaskImportance.Secondary));
			gunaBarDataset1.DataPoints.Add("Not important", Services.Read(1).Count(x => x.Importance == Domain.Enum.TaskImportance.NotImportant) + Services.Read(2).Count(x => x.Importance == Domain.Enum.TaskImportance.NotImportant));
		}
	}
}
