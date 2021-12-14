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
		public FrmStatistics()
		{
			InitializeComponent();
		}

		private void FrmStatistics_Load(object sender, EventArgs e)
		{
			
		}

		private void gunaChart1_Load(object sender, EventArgs e)
		{
			for(int i=0; i<10; i++)
			{
				gunaDoughnutDataset1.DataPoints.Add($"Pepe {i}",i);
			}
		}
	}
}
