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
	public partial class FrmRegisterTask : Form
	{
		public ITaskServices Services { get; set; }
		public FrmRegisterTask()
		{
			InitializeComponent();
		}

		private void FrmRegisterTask_Load(object sender, EventArgs e)
		{

		}

		private void guna2TextBox1_TextChanged(object sender, EventArgs e)
		{


		}

		private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			FrmMessageBox messageBox = new FrmMessageBox();
			messageBox.ShowDialog();
		}
	}
}
