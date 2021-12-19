
namespace TaskManagers.Forms
{
	partial class FrmRegisterTask
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegisterTask));
			this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
			this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.btnClose = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.cmbImportance = new Guna.UI2.WinForms.Guna2ComboBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TPEnd = new PruebaCustom.TimePicker();
			this.TPStart = new PruebaCustom.TimePicker();
			this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
			this.guna2GradientPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2BorderlessForm1
			// 
			this.guna2BorderlessForm1.BorderRadius = 18;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockForm = false;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			// 
			// guna2ShadowForm1
			// 
			this.guna2ShadowForm1.BorderRadius = 5;
			this.guna2ShadowForm1.TargetForm = this;
			// 
			// guna2AnimateWindow1
			// 
			this.guna2AnimateWindow1.Interval = 450;
			this.guna2AnimateWindow1.TargetForm = this;
			// 
			// guna2GradientPanel1
			// 
			this.guna2GradientPanel1.BorderRadius = 100;
			this.guna2GradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
			this.guna2GradientPanel1.BorderThickness = 29;
			this.guna2GradientPanel1.Controls.Add(this.btnClose);
			this.guna2GradientPanel1.Controls.Add(this.label1);
			this.guna2GradientPanel1.Controls.Add(this.pictureBox1);
			this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
			this.guna2GradientPanel1.Location = new System.Drawing.Point(-29, -30);
			this.guna2GradientPanel1.Name = "guna2GradientPanel1";
			this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
			this.guna2GradientPanel1.Size = new System.Drawing.Size(426, 134);
			this.guna2GradientPanel1.TabIndex = 1;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Transparent;
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(360, 39);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(24, 19);
			this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnClose.TabIndex = 14;
			this.btnClose.TabStop = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(297, 103);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Register";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(180, 42);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(84, 65);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 29;
			this.guna2Elipse1.TargetControl = this.guna2GradientPanel1;
			// 
			// txtDescription
			// 
			this.txtDescription.Animated = true;
			this.txtDescription.BorderColor = System.Drawing.Color.LightGray;
			this.txtDescription.BorderRadius = 10;
			this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtDescription.DefaultText = "";
			this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtDescription.DisabledState.Parent = this.txtDescription;
			this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.LightGray;
			this.txtDescription.FocusedState.Parent = this.txtDescription;
			this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtDescription.ForeColor = System.Drawing.Color.Gray;
			this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtDescription.HoverState.Parent = this.txtDescription;
			this.txtDescription.Location = new System.Drawing.Point(78, 119);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.PasswordChar = '\0';
			this.txtDescription.PlaceholderText = "Description";
			this.txtDescription.SelectedText = "";
			this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
			this.txtDescription.Size = new System.Drawing.Size(232, 96);
			this.txtDescription.TabIndex = 2;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(44, 150);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(28, 25);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// cmbImportance
			// 
			this.cmbImportance.BackColor = System.Drawing.Color.Transparent;
			this.cmbImportance.BorderColor = System.Drawing.Color.LightGray;
			this.cmbImportance.BorderRadius = 10;
			this.cmbImportance.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbImportance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbImportance.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbImportance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbImportance.FocusedState.Parent = this.cmbImportance;
			this.cmbImportance.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbImportance.ForeColor = System.Drawing.Color.Gray;
			this.cmbImportance.HoverState.BorderColor = System.Drawing.Color.LightGray;
			this.cmbImportance.HoverState.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbImportance.HoverState.ForeColor = System.Drawing.Color.Silver;
			this.cmbImportance.HoverState.Parent = this.cmbImportance;
			this.cmbImportance.ItemHeight = 30;
			this.cmbImportance.Items.AddRange(new object[] {
            "Important",
            "Very Important",
            "Secondary",
            "Not Important"});
			this.cmbImportance.ItemsAppearance.Parent = this.cmbImportance;
			this.cmbImportance.Location = new System.Drawing.Point(112, 225);
			this.cmbImportance.Name = "cmbImportance";
			this.cmbImportance.ShadowDecoration.Parent = this.cmbImportance;
			this.cmbImportance.Size = new System.Drawing.Size(150, 36);
			this.cmbImportance.TabIndex = 4;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(78, 232);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(28, 25);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 5;
			this.pictureBox3.TabStop = false;
			// 
			// btnAdd
			// 
			this.btnAdd.BorderRadius = 18;
			this.btnAdd.CheckedState.Parent = this.btnAdd;
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.CustomImages.Parent = this.btnAdd;
			this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnAdd.DisabledState.Parent = this.btnAdd;
			this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.HoverState.Parent = this.btnAdd;
			this.btnAdd.Location = new System.Drawing.Point(133, 493);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
			this.btnAdd.Size = new System.Drawing.Size(89, 38);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Add";
			this.btnAdd.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DarkGray;
			this.label3.Location = new System.Drawing.Point(269, 267);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "End";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkGray;
			this.label2.Location = new System.Drawing.Point(75, 267);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Start";
			// 
			// TPEnd
			// 
			this.TPEnd.AutoSize = true;
			this.TPEnd.BackColor = System.Drawing.Color.White;
			this.TPEnd.Horas = 0;
			this.TPEnd.Location = new System.Drawing.Point(192, 283);
			this.TPEnd.Minutos = 0;
			this.TPEnd.Name = "TPEnd";
			this.TPEnd.Size = new System.Drawing.Size(161, 211);
			this.TPEnd.TabIndex = 12;
			this.TPEnd.VerifarAMPM = false;
			this.TPEnd.VerificarHora = false;
			this.TPEnd.VerificarMinutos = false;
			// 
			// TPStart
			// 
			this.TPStart.AutoSize = true;
			this.TPStart.BackColor = System.Drawing.Color.White;
			this.TPStart.Horas = 0;
			this.TPStart.Location = new System.Drawing.Point(2, 283);
			this.TPStart.Minutos = 0;
			this.TPStart.Name = "TPStart";
			this.TPStart.Size = new System.Drawing.Size(161, 211);
			this.TPStart.TabIndex = 11;
			this.TPStart.VerifarAMPM = false;
			this.TPStart.VerificarHora = false;
			this.TPStart.VerificarMinutos = false;
			// 
			// guna2HtmlToolTip1
			// 
			this.guna2HtmlToolTip1.AllowLinksHandling = true;
			this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
			// 
			// FrmRegisterTask
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(365, 537);
			this.Controls.Add(this.TPEnd);
			this.Controls.Add(this.TPStart);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.cmbImportance);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.guna2GradientPanel1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(365, 537);
			this.MinimumSize = new System.Drawing.Size(365, 537);
			this.Name = "FrmRegisterTask";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FrmRegisterTask";
			this.Load += new System.EventHandler(this.FrmRegisterTask_Load);
			this.guna2GradientPanel1.ResumeLayout(false);
			this.guna2GradientPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
		private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
		private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
		private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Guna.UI2.WinForms.Guna2TextBox txtDescription;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private Guna.UI2.WinForms.Guna2ComboBox cmbImportance;
		private Guna.UI2.WinForms.Guna2Button btnAdd;
		private PruebaCustom.TimePicker TPEnd;
		private PruebaCustom.TimePicker TPStart;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox btnClose;
		private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
	}
}