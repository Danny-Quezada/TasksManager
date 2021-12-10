using AppCore.IServices;
using AppCore.Services;
using Domain;
using Domain.Enum;
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
	public partial class FrmTasks : Form
	{
		private ITaskServices Services;
		public FrmTasks(ITaskServices services)
		{
			Services = services;
			InitializeComponent();
		}

		private void FrmTasks_Load(object sender, EventArgs e)
		{
			VisibleFilter();

		}

		private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{
			FrmRegisterTask RegisterTask = new FrmRegisterTask();
			RegisterTask.Services = Services;
			RegisterTask.ShowDialog();
			FillDGV();
			VisibleFilter();

		}
		private void VisibleFilter()
		{
			if (Services.Read().Length > 0)
			{
				cmbFilter.Visible = true;
				pbChoose.Visible = true;
			}
			else
			{
				cmbFilter.Visible = false;
				pbChoose.Visible = false;
			}
		}
		private void FillDGV()
		{
			guna2DataGridView1.Rows.Clear();
			foreach(Tasks t in Services.Read())
			{
				guna2DataGridView1.Rows.Add(t.Id,t.Description,t.Importance,t.State,$"{t.StarTime.Hour}:{t.StarTime.Minute}", $"{t.EndTime.Hour}:{t.EndTime.Minute}");
			}
		}
		private void FilterDGV(Func<Tasks, bool> Filter)
		{
			guna2DataGridView1.Rows.Clear();
			foreach(Tasks t in Services.OrderByChoise(Filter))
			{
				guna2DataGridView1.Rows.Add(t.Id, t.Description, t.Importance, t.State, $"{t.StarTime.Hour}:{t.StarTime.Minute}", $"{t.EndTime.Hour}:{t.EndTime.Minute}");
			}
		}

		private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			FilterDGV(x => x.Importance == (TaskImportance)cmbFilter.SelectedIndex);
		}
	}
}
