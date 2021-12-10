
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
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.cmbImportance = new Guna.UI2.WinForms.Guna2ComboBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.dtpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.dtpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
			this.guna2GradientPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2BorderlessForm1
			// 
			this.guna2BorderlessForm1.BorderRadius = 19;
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
			this.guna2GradientPanel1.Controls.Add(this.label1);
			this.guna2GradientPanel1.Controls.Add(this.pictureBox1);
			this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
			this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
			this.guna2GradientPanel1.Location = new System.Drawing.Point(-29, -30);
			this.guna2GradientPanel1.Name = "guna2GradientPanel1";
			this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
			this.guna2GradientPanel1.Size = new System.Drawing.Size(378, 165);
			this.guna2GradientPanel1.TabIndex = 1;
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 65;
			this.guna2Elipse1.TargetControl = this.guna2GradientPanel1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(135, 58);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(84, 65);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(221, 134);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Register";
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
			this.txtDescription.ForeColor = System.Drawing.Color.DarkGray;
			this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtDescription.HoverState.Parent = this.txtDescription;
			this.txtDescription.Location = new System.Drawing.Point(37, 156);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.PasswordChar = '\0';
			this.txtDescription.PlaceholderText = "Description";
			this.txtDescription.SelectedText = "";
			this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
			this.txtDescription.Size = new System.Drawing.Size(200, 84);
			this.txtDescription.TabIndex = 2;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(3, 182);
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
			this.cmbImportance.ForeColor = System.Drawing.Color.Silver;
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
			this.cmbImportance.Location = new System.Drawing.Point(37, 269);
			this.cmbImportance.Name = "cmbImportance";
			this.cmbImportance.ShadowDecoration.Parent = this.cmbImportance;
			this.cmbImportance.Size = new System.Drawing.Size(140, 36);
			this.cmbImportance.TabIndex = 4;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(3, 280);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(28, 25);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 5;
			this.pictureBox3.TabStop = false;
			// 
			// dtpStart
			// 
			this.dtpStart.Checked = true;
			this.dtpStart.CheckedState.Parent = this.dtpStart;
			this.dtpStart.FillColor = System.Drawing.Color.White;
			this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.dtpStart.HoverState.Parent = this.dtpStart;
			this.dtpStart.Location = new System.Drawing.Point(12, 357);
			this.dtpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtpStart.Name = "dtpStart";
			this.dtpStart.ShadowDecoration.Parent = this.dtpStart;
			this.dtpStart.Size = new System.Drawing.Size(100, 36);
			this.dtpStart.TabIndex = 6;
			this.dtpStart.Value = new System.DateTime(2021, 12, 9, 22, 35, 34, 285);
			// 
			// dtpEnd
			// 
			this.dtpEnd.Checked = true;
			this.dtpEnd.CheckedState.Parent = this.dtpEnd;
			this.dtpEnd.FillColor = System.Drawing.Color.White;
			this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.dtpEnd.HoverState.Parent = this.dtpEnd;
			this.dtpEnd.Location = new System.Drawing.Point(137, 357);
			this.dtpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtpEnd.Name = "dtpEnd";
			this.dtpEnd.ShadowDecoration.Parent = this.dtpEnd;
			this.dtpEnd.Size = new System.Drawing.Size(100, 36);
			this.dtpEnd.TabIndex = 7;
			this.dtpEnd.Value = new System.DateTime(2021, 12, 9, 22, 35, 34, 285);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkGray;
			this.label2.Location = new System.Drawing.Point(52, 338);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Start";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DarkGray;
			this.label3.Location = new System.Drawing.Point(172, 338);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "End";
			// 
			// btnAdd
			// 
			this.btnAdd.BorderRadius = 18;
			this.btnAdd.CheckedState.Parent = this.btnAdd;
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
			this.btnAdd.Location = new System.Drawing.Point(88, 438);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
			this.btnAdd.Size = new System.Drawing.Size(89, 38);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Add";
			this.btnAdd.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// FrmRegisterTask
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(268, 488);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtpEnd);
			this.Controls.Add(this.dtpStart);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.cmbImportance);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.guna2GradientPanel1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmRegisterTask";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FrmRegisterTask";
			this.Load += new System.EventHandler(this.FrmRegisterTask_Load);
			this.guna2GradientPanel1.ResumeLayout(false);
			this.guna2GradientPanel1.PerformLayout();
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
		private Guna.UI2.WinForms.Guna2DateTimePicker dtpEnd;
		private Guna.UI2.WinForms.Guna2DateTimePicker dtpStart;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2Button btnAdd;
	}
}