
namespace TaskManagers.Forms
{
	partial class FrmStatistics
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Guna.Charts.WinForms.ChartFont chartFont1 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.ChartFont chartFont2 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.ChartFont chartFont3 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.ChartFont chartFont4 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.Grid grid1 = new Guna.Charts.WinForms.Grid();
			Guna.Charts.WinForms.Tick tick1 = new Guna.Charts.WinForms.Tick();
			Guna.Charts.WinForms.ChartFont chartFont5 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.Grid grid2 = new Guna.Charts.WinForms.Grid();
			Guna.Charts.WinForms.Tick tick2 = new Guna.Charts.WinForms.Tick();
			Guna.Charts.WinForms.ChartFont chartFont6 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.Grid grid3 = new Guna.Charts.WinForms.Grid();
			Guna.Charts.WinForms.PointLabel pointLabel1 = new Guna.Charts.WinForms.PointLabel();
			Guna.Charts.WinForms.ChartFont chartFont7 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.Tick tick3 = new Guna.Charts.WinForms.Tick();
			Guna.Charts.WinForms.ChartFont chartFont8 = new Guna.Charts.WinForms.ChartFont();
			this.gunaChart1 = new Guna.Charts.WinForms.GunaChart();
			this.gunaDoughnutDataset1 = new Guna.Charts.WinForms.GunaDoughnutDataset();
			this.SuspendLayout();
			// 
			// gunaChart1
			// 
			this.gunaChart1.BackColor = System.Drawing.Color.White;
			chartFont1.FontName = "Arial";
			this.gunaChart1.Legend.LabelFont = chartFont1;
			this.gunaChart1.Location = new System.Drawing.Point(56, 25);
			this.gunaChart1.Name = "gunaChart1";
			this.gunaChart1.Size = new System.Drawing.Size(419, 260);
			this.gunaChart1.TabIndex = 0;
			chartFont2.FontName = "Arial";
			chartFont2.Size = 12;
			chartFont2.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
			this.gunaChart1.Title.Font = chartFont2;
			chartFont3.FontName = "Arial";
			this.gunaChart1.Tooltips.BodyFont = chartFont3;
			chartFont4.FontName = "Arial";
			chartFont4.Size = 9;
			chartFont4.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
			this.gunaChart1.Tooltips.TitleFont = chartFont4;
			this.gunaChart1.XAxes.Display = false;
			this.gunaChart1.XAxes.GridLines = grid1;
			chartFont5.FontName = "Arial";
			tick1.Font = chartFont5;
			this.gunaChart1.XAxes.Ticks = tick1;
			this.gunaChart1.YAxes.Display = false;
			this.gunaChart1.YAxes.GridLines = grid2;
			chartFont6.FontName = "Arial";
			tick2.Font = chartFont6;
			this.gunaChart1.YAxes.Ticks = tick2;
			this.gunaChart1.ZAxes.GridLines = grid3;
			chartFont7.FontName = "Arial";
			pointLabel1.Font = chartFont7;
			this.gunaChart1.ZAxes.PointLabels = pointLabel1;
			chartFont8.FontName = "Arial";
			tick3.Font = chartFont8;
			this.gunaChart1.ZAxes.Ticks = tick3;
			this.gunaChart1.Load += new System.EventHandler(this.gunaChart1_Load);
			// 
			// gunaDoughnutDataset1
			// 
			this.gunaDoughnutDataset1.Label = "Doughnut1";
			// 
			// FrmStatistics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gunaChart1);
			this.Name = "FrmStatistics";
			this.Text = "FrmStatistics";
			this.Load += new System.EventHandler(this.FrmStatistics_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.Charts.WinForms.GunaChart gunaChart1;
		private Guna.Charts.WinForms.GunaDoughnutDataset gunaDoughnutDataset1;
	}
}