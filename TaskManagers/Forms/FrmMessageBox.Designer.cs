
namespace TaskManagers.Forms
{
	partial class FrmMessageBox
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMessageBox));
			this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2BorderlessForm1
			// 
			this.guna2BorderlessForm1.BorderRadius = 30;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockForm = false;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			// 
			// guna2ShadowForm1
			// 
			this.guna2ShadowForm1.BorderRadius = 20;
			this.guna2ShadowForm1.TargetForm = this;
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(-123, -44);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
			this.guna2PictureBox1.Size = new System.Drawing.Size(538, 270);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 0;
			this.guna2PictureBox1.TabStop = false;
			this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
			// 
			// guna2AnimateWindow1
			// 
			this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_NEGATIVE;
			this.guna2AnimateWindow1.Interval = 300;
			this.guna2AnimateWindow1.TargetForm = this;
			// 
			// FrmMessageBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(308, 179);
			this.Controls.Add(this.guna2PictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmMessageBox";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FrmMessageBox";
			this.Load += new System.EventHandler(this.FrmMessageBox_Load);
			this.Click += new System.EventHandler(this.FrmMessageBox_Click);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMessageBox_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
		private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
	}
}