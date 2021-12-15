using AppCore.IServices;
using AppCore.Services;
using Domain;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Threading;
using Timer = System.Timers.Timer;

namespace TaskManagers.Forms
{
	public partial class FrmTasks : Form
	{
		private ITaskServices Services;
		private int Seleccion=-1;
		public FrmTasks(ITaskServices services)
		{

			InitializeComponent();
			Services = services;
		}
		Timer RemovalNotification = new System.Timers.Timer(1000);
		private void FrmTasks_Load(object sender, EventArgs e)
		{
			//AllocConsole();
			VisibleFilter();
			lblMesDia.Text = DateTime.Now.ToString("MMMM dd, yyyy"+".",CultureInfo.InvariantCulture);
			RemovalNotification.Elapsed += new ElapsedEventHandler(OnTimedEvent);
			RemovalNotification.Interval = 1000;
			RemovalNotification.AutoReset = true;
			RemovalNotification.Enabled = true;
		}

		//[DllImport("kernel32.dll", SetLastError = true)]
		//[return: MarshalAs(UnmanagedType.Bool)]
		//static extern bool AllocConsole();


		private void OnTimedEvent(object source, ElapsedEventArgs e)
		{


	
			foreach (Tasks t in Services.Read(1))
			{

				Console.WriteLine(t.EndTime.ToString("HH:mm:ss"));
				Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
				if (t.EndTime.ToString("HH:mm:ss").CompareTo(DateTime.Now.ToString("HH:mm:ss")) == 0)
				{

					Services.ChangeStatus(t, Domain.Enum.TaskStatus.Failed);
					Notification("Failed", $"Task: {t.Id} not done", "Not done");
					FillDGV();

				}
				RemovalNotification.Start();
		
				if (t.StarTime.ToString("HH:mm:ss").CompareTo(DateTime.Now.ToString("HH:mm:ss")) == 0)
				{
					Services.ChangeStatus(t, Domain.Enum.TaskStatus.Started);
					Notification("Started", $"Task {t.Id} already started", "It already started");
					FillDGV();
				}
				RemovalNotification.Start();
			}

		}



		private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				Seleccion = e.RowIndex;
			}
		}

		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{

			FrmRegisterTask RegisterTask = new FrmRegisterTask();
			RegisterTask.Services = Services;
			RegisterTask.ShowDialog();
			FillDGV();
			RemovalNotification.Start();
			VisibleFilter();


		}
		private void Notification(string text, string balloonTip, string title)
		{
			notifyIcon1.Text = text;
			notifyIcon1.Visible = true;
			notifyIcon1.BalloonTipText = balloonTip;
			notifyIcon1.BalloonTipTitle = title;
			notifyIcon1.ShowBalloonTip(50);
		}
		private void VisibleFilter()
		{
			if (Services.Read(1).Length > 0)
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
			RemovalNotification.Stop();

			this.Invoke(new Action(() => guna2DataGridView1.Rows.Clear()));

			int i = 0;
			foreach (Tasks p in Services.Read(1))
			{
				this.Invoke(new Action(() => guna2DataGridView1.Rows.Add(p.Id, p.Description, p.Importance, p.State, $"{p.StarTime.ToString("hh:mm tt", CultureInfo.InvariantCulture)}", $"{p.EndTime.ToString("hh:mm tt", CultureInfo.InvariantCulture)}")));
				if (p.State == Domain.Enum.TaskStatus.Failed)
				{
					guna2DataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
				}
				i++;
			}

		}
		private void FilterDGV(Func<Tasks, bool> Filter)
		{
			RemovalNotification.Stop();
			guna2DataGridView1.Rows.Clear();
			int i = 0;
			foreach (Tasks t in Services.OrderByChoise(Filter))
			{
				guna2DataGridView1.Rows.Add(t.Id, t.Description, t.Importance, t.State, $"{t.StarTime.Hour}:{t.StarTime.Minute}", $"{t.EndTime.Hour}:{t.EndTime.Minute}");
				if (t.State == Domain.Enum.TaskStatus.Failed)
				{
					guna2DataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
				}
				i++;
			}
		}

		private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbFilter.SelectedIndex <= 3)
			{
				FilterDGV(x => x.Importance == (TaskImportance)cmbFilter.SelectedIndex);
			}
			else
			{
				Services.OrderByHours();
				FillDGV();
			}
			RemovalNotification.Start();
		}

		private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
		{
			cmbFilter.SelectedIndex = -1;
			FillDGV();
			RemovalNotification.Start();
		}

		private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
		{
			this.WindowState = FormWindowState.Normal;
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{

		}

		private void guna2ImageButton2_Click(object sender, EventArgs e)
		{


			if (Seleccion >= 0)
			{
				Tasks Task = Services.FindTask(Convert.ToInt32(guna2DataGridView1.Rows[Seleccion].Cells[0].Value));
				Services.FinishTask(Task);
				FillDGV();
				VisibleFilter();
				RemovalNotification.Start();
				Seleccion = -1;
			}
			else
			{
				MessageBox.Show("You have to choose the task to eliminate.");
			}



		}

		private void guna2ImageButton3_Click(object sender, EventArgs e)
		{
			FrmStatistics frmStatistics = new FrmStatistics();
			frmStatistics.ShowDialog();
		}
		
		private void guna2ImageButton4_Click(object sender, EventArgs e)
		{
			FrmTasksDeleted frmDeleted = new FrmTasksDeleted();
			frmDeleted.Services = Services;
			frmDeleted.ShowDialog();
			FillDGV();
			RemovalNotification.Start();
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
