
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
			this.components = new System.ComponentModel.Container();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStatistics));
			Guna.Charts.WinForms.ChartFont chartFont9 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.ChartFont chartFont10 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.ChartFont chartFont11 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.ChartFont chartFont12 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.Grid grid4 = new Guna.Charts.WinForms.Grid();
			Guna.Charts.WinForms.Tick tick4 = new Guna.Charts.WinForms.Tick();
			Guna.Charts.WinForms.ChartFont chartFont13 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.Grid grid5 = new Guna.Charts.WinForms.Grid();
			Guna.Charts.WinForms.Tick tick5 = new Guna.Charts.WinForms.Tick();
			Guna.Charts.WinForms.ChartFont chartFont14 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.Grid grid6 = new Guna.Charts.WinForms.Grid();
			Guna.Charts.WinForms.PointLabel pointLabel2 = new Guna.Charts.WinForms.PointLabel();
			Guna.Charts.WinForms.ChartFont chartFont15 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.Tick tick6 = new Guna.Charts.WinForms.Tick();
			Guna.Charts.WinForms.ChartFont chartFont16 = new Guna.Charts.WinForms.ChartFont();
			this.gunaChart1 = new Guna.Charts.WinForms.GunaChart();
			this.gunaDoughnutDataset1 = new Guna.Charts.WinForms.GunaDoughnutDataset();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
			this.btnClose = new System.Windows.Forms.PictureBox();
			this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.btnMinimize = new System.Windows.Forms.PictureBox();
			this.gunaChart2 = new Guna.Charts.WinForms.GunaChart();
			this.gunaBarDataset1 = new Guna.Charts.WinForms.GunaBarDataset();
			((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
			this.SuspendLayout();
			// 
			// gunaChart1
			// 
			this.gunaChart1.Animation.Duration = 1;
			this.gunaChart1.BackColor = System.Drawing.Color.White;
			this.gunaChart1.Datasets.AddRange(new Guna.Charts.Interfaces.IGunaDataset[] {
            this.gunaDoughnutDataset1});
			chartFont1.FontName = "Arial";
			this.gunaChart1.Legend.LabelFont = chartFont1;
			this.gunaChart1.Location = new System.Drawing.Point(394, 58);
			this.gunaChart1.Name = "gunaChart1";
			this.gunaChart1.Size = new System.Drawing.Size(396, 257);
			this.gunaChart1.TabIndex = 0;
			chartFont2.FontName = "Segoe UI";
			chartFont2.Size = 12;
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
			this.gunaDoughnutDataset1.Label = "Hola";
			this.gunaDoughnutDataset1.TargetChart = this.gunaChart1;
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 8;
			this.guna2Elipse1.TargetControl = this.gunaChart1;
			// 
			// guna2ShadowForm1
			// 
			this.guna2ShadowForm1.BorderRadius = 16;
			this.guna2ShadowForm1.TargetForm = this;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(766, 6);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(24, 22);
			this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnClose.TabIndex = 12;
			this.btnClose.TabStop = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// guna2BorderlessForm1
			// 
			this.guna2BorderlessForm1.AnimationInterval = 150;
			this.guna2BorderlessForm1.BorderRadius = 16;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			// 
			// btnMinimize
			// 
			this.btnMinimize.BackColor = System.Drawing.Color.White;
			this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
			this.btnMinimize.Location = new System.Drawing.Point(734, 6);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(24, 22);
			this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnMinimize.TabIndex = 13;
			this.btnMinimize.TabStop = false;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// gunaChart2
			// 
			this.gunaChart2.BackColor = System.Drawing.Color.White;
			this.gunaChart2.Datasets.AddRange(new Guna.Charts.Interfaces.IGunaDataset[] {
            this.gunaBarDataset1});
			chartFont9.FontName = "Arial";
			this.gunaChart2.Legend.LabelFont = chartFont9;
			this.gunaChart2.Location = new System.Drawing.Point(12, 58);
			this.gunaChart2.Name = "gunaChart2";
			this.gunaChart2.Size = new System.Drawing.Size(390, 260);
			this.gunaChart2.TabIndex = 14;
			chartFont10.FontName = "Arial";
			chartFont10.Size = 12;
			chartFont10.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
			this.gunaChart2.Title.Font = chartFont10;
			chartFont11.FontName = "Arial";
			this.gunaChart2.Tooltips.BodyFont = chartFont11;
			chartFont12.FontName = "Arial";
			chartFont12.Size = 9;
			chartFont12.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
			this.gunaChart2.Tooltips.TitleFont = chartFont12;
			this.gunaChart2.XAxes.GridLines = grid4;
			chartFont13.FontName = "Arial";
			tick4.Font = chartFont13;
			this.gunaChart2.XAxes.Ticks = tick4;
			this.gunaChart2.YAxes.Display = false;
			this.gunaChart2.YAxes.GridLines = grid5;
			chartFont14.FontName = "Arial";
			tick5.Font = chartFont14;
			this.gunaChart2.YAxes.Ticks = tick5;
			this.gunaChart2.ZAxes.GridLines = grid6;
			chartFont15.FontName = "Arial";
			pointLabel2.Font = chartFont15;
			this.gunaChart2.ZAxes.PointLabels = pointLabel2;
			chartFont16.FontName = "Arial";
			tick6.Font = chartFont16;
			this.gunaChart2.ZAxes.Ticks = tick6;
			this.gunaChart2.Load += new System.EventHandler(this.gunaChart2_Load);
			// 
			// gunaBarDataset1
			// 
			this.gunaBarDataset1.Label = "Bars";
			this.gunaBarDataset1.TargetChart = this.gunaChart2;
			// 
			// FrmStatistics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 465);
			this.Controls.Add(this.gunaChart2);
			this.Controls.Add(this.btnMinimize);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.gunaChart1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(800, 465);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 465);
			this.Name = "FrmStatistics";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmStatistics";
			this.Load += new System.EventHandler(this.FrmStatistics_Load);
			((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.Charts.WinForms.GunaChart gunaChart1;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
		private Guna.Charts.WinForms.GunaDoughnutDataset gunaDoughnutDataset1;
		private System.Windows.Forms.PictureBox btnClose;
		private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
		private System.Windows.Forms.PictureBox btnMinimize;
		private Guna.Charts.WinForms.GunaChart gunaChart2;
		private Guna.Charts.WinForms.GunaBarDataset gunaBarDataset1;
	}
}