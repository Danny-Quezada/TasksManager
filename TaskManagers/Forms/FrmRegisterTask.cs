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
				MessageBox.Show("None of the fields can be empty.", "General information",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			//if (dtpStart.Value == dtpEnd.Value)
			//{
			//	MessageBox.Show("You have to change the hours.", "Time information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//	return;
			//}
			//else if (dtpStart.Value > dtpEnd.Value)
			//{
			//	MessageBox.Show("You cannot put the end time less than the start time", "Time information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//	return;
			//}
			//else if (dtpEnd.Value < DateTime.Now)
			//{
			//	MessageBox.Show($"You cannot put a final hour less than the hour: {DateTime.Now.ToString("HH:mm:ss")}", "Time information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//	return;
			//}
			if (TPStart.VerifarAMPM == false || TPEnd.VerifarAMPM == false)
			{
				MessageBox.Show("Choose between AM or PM.");
				return;
			}
			else if(TPStart.VerificarHora==false || TPEnd.VerificarHora==false)
			{
				MessageBox.Show("Set the time on the 2 clocks.");
				return;
			}
			else if (TPEnd.VerificarMinutos==false || TPStart.VerificarMinutos==false)
			{
				MessageBox.Show("Put the minutes on the 2 clocks.");
				return;
			}
			DateTime Start = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,TPStart.Horas,TPStart.Minutos,00);
			DateTime End = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, TPEnd.Horas, TPEnd.Minutos, 00);
			if (Start == End)
			{
				MessageBox.Show("You cannot put the end time less than the start time", "Time information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			else if (Start > End)
			{
				MessageBox.Show("You cannot put the end time less than the start time", "Time information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			else if (End < DateTime.Now)
			{

				MessageBox.Show($"You cannot put a final hour less than the hour: {DateTime.Now.ToString("HH:mm:ss")}", "Time information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			Tasks Task = new Tasks()
			{
				Description=txtDescription.Text,
				Id=Services.GetLastId()+1,
				EndTime=End,
				Importance=(TaskImportance)cmbImportance.SelectedIndex,
				StarTime=Start
				
			};
			Services.AssingState(Task); 
			Services.Add(Task);
			Dispose();
			
		}

		private void txtDescription_TextChanged(object sender, EventArgs e)
		{

		}

		private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
