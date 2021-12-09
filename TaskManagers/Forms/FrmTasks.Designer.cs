
namespace TaskManagers.Forms
{
	partial class FrmTasks
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTasks));
			this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
			this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
			this.TasksN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Importancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.End = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
			this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2BorderlessForm1
			// 
			this.guna2BorderlessForm1.BorderRadius = 20;
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
			// guna2ImageButton1
			// 
			this.guna2ImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
			this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(59, 59);
			this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
			this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
			this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
			this.guna2ImageButton1.ImageRotate = 0F;
			this.guna2ImageButton1.Location = new System.Drawing.Point(775, 58);
			this.guna2ImageButton1.Name = "guna2ImageButton1";
			this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
			this.guna2ImageButton1.ShadowDecoration.Parent = this.guna2ImageButton1;
			this.guna2ImageButton1.Size = new System.Drawing.Size(88, 90);
			this.guna2ImageButton1.TabIndex = 3;
			this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 18;
			this.guna2Elipse1.TargetControl = this.guna2DataGridView1;
			// 
			// guna2DataGridView1
			// 
			this.guna2DataGridView1.AllowUserToAddRows = false;
			this.guna2DataGridView1.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.guna2DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.guna2DataGridView1.ColumnHeadersHeight = 59;
			this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TasksN,
            this.Descripcion,
            this.Importancia,
            this.State,
            this.Start,
            this.End});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			this.guna2DataGridView1.EnableHeadersVisualStyles = false;
			this.guna2DataGridView1.GridColor = System.Drawing.Color.White;
			this.guna2DataGridView1.Location = new System.Drawing.Point(13, 14);
			this.guna2DataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.guna2DataGridView1.Name = "guna2DataGridView1";
			this.guna2DataGridView1.ReadOnly = true;
			this.guna2DataGridView1.RowHeadersVisible = false;
			this.guna2DataGridView1.RowHeadersWidth = 62;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.guna2DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.guna2DataGridView1.RowTemplate.DividerHeight = 2;
			this.guna2DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.guna2DataGridView1.Size = new System.Drawing.Size(755, 483);
			this.guna2DataGridView1.TabIndex = 5;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.White;
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 59;
			this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
			this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
			this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
			// 
			// TasksN
			// 
			this.TasksN.FillWeight = 60F;
			this.TasksN.HeaderText = "Task N";
			this.TasksN.Name = "TasksN";
			this.TasksN.ReadOnly = true;
			// 
			// Descripcion
			// 
			this.Descripcion.FillWeight = 150F;
			this.Descripcion.HeaderText = "Description";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			// 
			// Importancia
			// 
			this.Importancia.HeaderText = "Importance";
			this.Importancia.Name = "Importancia";
			this.Importancia.ReadOnly = true;
			// 
			// State
			// 
			this.State.HeaderText = "State";
			this.State.Name = "State";
			this.State.ReadOnly = true;
			// 
			// Start
			// 
			this.Start.HeaderText = "Start";
			this.Start.Name = "Start";
			this.Start.ReadOnly = true;
			// 
			// End
			// 
			this.End.HeaderText = "End";
			this.End.Name = "End";
			this.End.ReadOnly = true;
			// 
			// guna2ImageButton2
			// 
			this.guna2ImageButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
			this.guna2ImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(59, 59);
			this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
			this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
			this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
			this.guna2ImageButton2.ImageRotate = 0F;
			this.guna2ImageButton2.Location = new System.Drawing.Point(761, 167);
			this.guna2ImageButton2.Name = "guna2ImageButton2";
			this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton2.PressedState.Parent = this.guna2ImageButton2;
			this.guna2ImageButton2.ShadowDecoration.Parent = this.guna2ImageButton2;
			this.guna2ImageButton2.Size = new System.Drawing.Size(110, 112);
			this.guna2ImageButton2.TabIndex = 4;
			// 
			// guna2ImageButton3
			// 
			this.guna2ImageButton3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton3.CheckedState.Parent = this.guna2ImageButton3;
			this.guna2ImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(59, 59);
			this.guna2ImageButton3.HoverState.Parent = this.guna2ImageButton3;
			this.guna2ImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.Image")));
			this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
			this.guna2ImageButton3.ImageRotate = 0F;
			this.guna2ImageButton3.Location = new System.Drawing.Point(761, 285);
			this.guna2ImageButton3.Name = "guna2ImageButton3";
			this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton3.PressedState.Parent = this.guna2ImageButton3;
			this.guna2ImageButton3.ShadowDecoration.Parent = this.guna2ImageButton3;
			this.guna2ImageButton3.Size = new System.Drawing.Size(110, 112);
			this.guna2ImageButton3.TabIndex = 6;
			// 
			// FrmTasks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(875, 511);
			this.Controls.Add(this.guna2ImageButton3);
			this.Controls.Add(this.guna2DataGridView1);
			this.Controls.Add(this.guna2ImageButton2);
			this.Controls.Add(this.guna2ImageButton1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmTasks";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.FrmTasks_Load);
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
		private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
		private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
		private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn TasksN;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Importancia;
		private System.Windows.Forms.DataGridViewTextBoxColumn State;
		private System.Windows.Forms.DataGridViewTextBoxColumn Start;
		private System.Windows.Forms.DataGridViewTextBoxColumn End;
		private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
	}
}