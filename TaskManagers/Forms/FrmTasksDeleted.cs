using AppCore.IServices;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagers.Forms
{
	public partial class FrmTasksDeleted : Form
	{
		public ITaskServices Services { get; set; }

		private int Seleccion = -1;
		public FrmTasksDeleted()
		{
			InitializeComponent();
		}

		private void FrmTasksDeleted_Load(object sender, EventArgs e)
		{
			FillDGV();
		}
		private void FillDGV()
		{
			guna2DataGridView1.Rows.Clear();
			int i = 0;
			foreach(Tasks t in Services.Read(2))
			{
				guna2DataGridView1.Rows.Add(t.Id, t.Description, t.Importance, t.State, $"{t.StarTime.ToString("hh:mm tt", CultureInfo.InvariantCulture)}", $"{t.EndTime.ToString("hh:mm tt", CultureInfo.InvariantCulture)}");
				if (t.State == Domain.Enum.TaskStatus.Failed)
				{
					guna2DataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
				}
				else if (t.State == Domain.Enum.TaskStatus.Finished)
				{
					guna2DataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
				}
				i++;
			}
		}
		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{
			if (Seleccion >= 0)
			{
				Tasks Task = Services.FindTaskDeleted(Convert.ToInt32(guna2DataGridView1.Rows[Seleccion].Cells[0].Value));
				FrmRegisterTask Register = new FrmRegisterTask(1,Task);
				Register.Services = Services;
				Register.ShowDialog();
				FillDGV();
				Seleccion = -1;
			}
			else
			{
				MessageBox.Show("Choose the task to do again.");
			}
		
		
		}

		private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				Seleccion = e.RowIndex;
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
