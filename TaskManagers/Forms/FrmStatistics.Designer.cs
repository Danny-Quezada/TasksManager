
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
			Guna.Charts.WinForms.ChartFont chartFont49 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.ChartFont chartFont50 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.ChartFont chartFont51 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.ChartFont chartFont52 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.Grid grid19 = new Guna.Charts.WinForms.Grid();
			Guna.Charts.WinForms.Tick tick19 = new Guna.Charts.WinForms.Tick();
			Guna.Charts.WinForms.ChartFont chartFont53 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.Grid grid20 = new Guna.Charts.WinForms.Grid();
			Guna.Charts.WinForms.Tick tick20 = new Guna.Charts.WinForms.Tick();
			Guna.Charts.WinForms.ChartFont chartFont54 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.Grid grid21 = new Guna.Charts.WinForms.Grid();
			Guna.Charts.WinForms.PointLabel pointLabel7 = new Guna.Charts.WinForms.PointLabel();
			Guna.Charts.WinForms.ChartFont chartFont55 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.Tick tick21 = new Guna.Charts.WinForms.Tick();
			Guna.Charts.WinForms.ChartFont chartFont56 = new Guna.Charts.WinForms.ChartFont();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStatistics));
			Guna.Charts.WinForms.ChartFont chartFont57 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.ChartFont chartFont58 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.ChartFont chartFont59 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.ChartFont chartFont60 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.Grid grid22 = new Guna.Charts.WinForms.Grid();
			Guna.Charts.WinForms.Tick tick22 = new Guna.Charts.WinForms.Tick();
			Guna.Charts.WinForms.ChartFont chartFont61 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.Grid grid23 = new Guna.Charts.WinForms.Grid();
			Guna.Charts.WinForms.Tick tick23 = new Guna.Charts.WinForms.Tick();
			Guna.Charts.WinForms.ChartFont chartFont62 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.Grid grid24 = new Guna.Charts.WinForms.Grid();
			Guna.Charts.WinForms.PointLabel pointLabel8 = new Guna.Charts.WinForms.PointLabel();
			Guna.Charts.WinForms.ChartFont chartFont63 = new Guna.Charts.WinForms.ChartFont();
			Guna.Charts.WinForms.Tick tick24 = new Guna.Charts.WinForms.Tick();
			Guna.Charts.WinForms.ChartFont chartFont64 = new Guna.Charts.WinForms.ChartFont();
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
			chartFont49.FontName = "Arial";
			this.gunaChart1.Legend.LabelFont = chartFont49;
			this.gunaChart1.Location = new System.Drawing.Point(394, 58);
			this.gunaChart1.Name = "gunaChart1";
			this.gunaChart1.Size = new System.Drawing.Size(396, 257);
			this.gunaChart1.TabIndex = 0;
			chartFont50.FontName = "Segoe UI";
			chartFont50.Size = 12;
			this.gunaChart1.Title.Font = chartFont50;
			chartFont51.FontName = "Arial";
			this.gunaChart1.Tooltips.BodyFont = chartFont51;
			chartFont52.FontName = "Arial";
			chartFont52.Size = 9;
			chartFont52.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
			this.gunaChart1.Tooltips.TitleFont = chartFont52;
			this.gunaChart1.XAxes.Display = false;
			this.gunaChart1.XAxes.GridLines = grid19;
			chartFont53.FontName = "Arial";
			tick19.Font = chartFont53;
			this.gunaChart1.XAxes.Ticks = tick19;
			this.gunaChart1.YAxes.Display = false;
			this.gunaChart1.YAxes.GridLines = grid20;
			chartFont54.FontName = "Arial";
			tick20.Font = chartFont54;
			this.gunaChart1.YAxes.Ticks = tick20;
			this.gunaChart1.ZAxes.GridLines = grid21;
			chartFont55.FontName = "Arial";
			pointLabel7.Font = chartFont55;
			this.gunaChart1.ZAxes.PointLabels = pointLabel7;
			chartFont56.FontName = "Arial";
			tick21.Font = chartFont56;
			this.gunaChart1.ZAxes.Ticks = tick21;
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
			this.guna2BorderlessForm1.BorderRadius = 16;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			// 
			// btnMinimize
			// 
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
			chartFont57.FontName = "Arial";
			this.gunaChart2.Legend.LabelFont = chartFont57;
			this.gunaChart2.Location = new System.Drawing.Point(12, 58);
			this.gunaChart2.Name = "gunaChart2";
			this.gunaChart2.Size = new System.Drawing.Size(390, 260);
			this.gunaChart2.TabIndex = 14;
			chartFont58.FontName = "Arial";
			chartFont58.Size = 12;
			chartFont58.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
			this.gunaChart2.Title.Font = chartFont58;
			chartFont59.FontName = "Arial";
			this.gunaChart2.Tooltips.BodyFont = chartFont59;
			chartFont60.FontName = "Arial";
			chartFont60.Size = 9;
			chartFont60.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
			this.gunaChart2.Tooltips.TitleFont = chartFont60;
			this.gunaChart2.XAxes.GridLines = grid22;
			chartFont61.FontName = "Arial";
			tick22.Font = chartFont61;
			this.gunaChart2.XAxes.Ticks = tick22;
			this.gunaChart2.YAxes.Display = false;
			this.gunaChart2.YAxes.GridLines = grid23;
			chartFont62.FontName = "Arial";
			tick23.Font = chartFont62;
			this.gunaChart2.YAxes.Ticks = tick23;
			this.gunaChart2.ZAxes.GridLines = grid24;
			chartFont63.FontName = "Arial";
			pointLabel8.Font = chartFont63;
			this.gunaChart2.ZAxes.PointLabels = pointLabel8;
			chartFont64.FontName = "Arial";
			tick24.Font = chartFont64;
			this.gunaChart2.ZAxes.Ticks = tick24;
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
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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