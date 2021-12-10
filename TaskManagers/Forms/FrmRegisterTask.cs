using AppCore.IServices;
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
	public partial class FrmRegisterTask : Form
	{
		public ITaskServices Services { get; set; }
		public FrmRegisterTask()
		{

			InitializeComponent();
		}

		private void FrmRegisterTask_Load(object sender, EventArgs e)
		{
			dtpStart.Format = DateTimePickerFormat.Custom;
			dtpStart.CustomFormat = "hh:mm tt";
			dtpStart.Value = DateTime.Now;
			dtpEnd.Value = DateTime.Now;
			dtpEnd.Format = DateTimePickerFormat.Custom;
			dtpEnd.CustomFormat = "hh:mm tt";


		}

		private void guna2TextBox1_TextChanged(object sender, EventArgs e)
		{


		}

		private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
		{

		}

		

		private void guna2PictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			if(String.IsNullOrWhiteSpace(txtDescription.Text) || cmbImportance.SelectedIndex == -1)
			{
				MessageBox.Show("None of the fields can be empty.");
				return;
			}
			if (dtpStart.Value == dtpEnd.Value)
			{
				MessageBox.Show("You have to change the hours.");
				return;
			}
			Tasks Task = new Tasks()
			{
				Description=txtDescription.Text,
				Id=Services.GetLastId()+1,
				EndTime=dtpEnd.Value,
				Importance=(TaskImportance)cmbImportance.SelectedIndex,
				StarTime=dtpStart.Value,
				
			};
			Services.AssingState(Task);
			
			Services.Add(Task);
			Dispose();
			
		}
	}
}
