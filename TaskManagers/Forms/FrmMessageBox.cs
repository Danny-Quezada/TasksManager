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
	public partial class FrmMessageBox : Form
	{
		public FrmMessageBox()
		{
			InitializeComponent();
		}

		private void guna2PictureBox1_Click(object sender, EventArgs e)
		{
			Dispose();
			this.Close();
		}

		private void FrmMessageBox_Load(object sender, EventArgs e)
		{

		}

		private void FrmMessageBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.Close();
			}
		}

		private void FrmMessageBox_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
