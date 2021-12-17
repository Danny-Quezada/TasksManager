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
			GeneratePieChart();
			
		}

		private void gunaChart1_Load(object sender, EventArgs e)
		{
			
		}
		private void GeneratePieChart()
		{
			
			gunaChart1.Title.Text= $"Tasks: { Services.Read(1).Length + Services.Read(2).Length} ";
			
			gunaDoughnutDataset1.DataPoints.Add("Tasks not Done", Services.Read(2).Count(x => x.State == Domain.Enum.TaskStatus.Failed));
			gunaDoughnutDataset1.DataPoints.Add("Tasks done", Services.Read(2).Count(x => x.State == Domain.Enum.TaskStatus.Finished));
			gunaDoughnutDataset1.DataPoints.Add("Tasks Started", Services.Read(1).Count(x => x.State == Domain.Enum.TaskStatus.Started));
			gunaDoughnutDataset1.DataPoints.Add("Tasks without starting", Services.Read(1).Count(x => x.State == Domain.Enum.TaskStatus.WithoutStarting));
		}
		public class TransparentPanel : Panel
		{
			protected override CreateParams CreateParams
			{
				get
				{
					CreateParams cp = base.CreateParams;
					cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
					return cp;
				}
			}
		
		}
	}
}
