using AppCore.IServices;
using AppCore.Services;
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
		

		}

		private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{
			FrmRegisterTask RegisterTask = new FrmRegisterTask();
			RegisterTask.Services = Services;
			RegisterTask.ShowDialog();

		}
	}
}
