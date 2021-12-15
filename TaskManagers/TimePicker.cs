using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaCustom
{
	public partial class TimePicker : UserControl
	{
		//Properties 

		public int Horas { get; set; }
		public int Minutos { get; set; }

		private bool HoraNoche;
		public bool VerifarAMPM { get; set; }
		public bool VerificarHora { get; set; }
		public bool VerificarMinutos { get; set; }
	

		public TimePicker()
		{
		
			InitializeComponent();
		}

		private void UserControl1_Load(object sender, EventArgs e)
		{
			
		}

	
		private void lblAM_Click(object sender, EventArgs e)
		{
			lblAM.ForeColor = Color.LightGray;
			HoraNoche = false;
			VerificarHora = false;
			VerificarMinutos = false;
			lblMinutos.Text = "00";
			lblHora.Text = "00";
			lblPM.ForeColor = Color.White;
			this.VerifarAMPM = true;
			AbrirHoras();
			CerrarMinutos();
		}

		private void lblPM_Click(object sender, EventArgs e)
		{
			lblPM.ForeColor = Color.LightGray;
			lblAM.ForeColor = Color.White;
			VerificarMinutos = false;
			VerificarHora = false;
			lblMinutos.Text = "00";
			lblHora.Text = "00";
			HoraNoche = true;
			this.VerifarAMPM = true;
			AbrirHoras();
			CerrarMinutos();
		}

	

		private void btn1_Click(object sender, EventArgs e)
		{
			if (VerifarAMPM == true)
			{


				if (HoraNoche == false)
				{
					this.Horas = 1;
					lblHora.Text = $"0{this.Horas}";
				}
				else
				{
					this.Horas = 13;
					lblHora.Text = "01";
				}
				this.VerificarHora = true;
				CerrarHoras();
				AbrirMinutos();
			}
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			if (VerifarAMPM == true)
			{
				{
					if (HoraNoche == false)
					{
						this.Horas = 2;
						lblHora.Text = $"0{this.Horas}";
					}
					else
					{
						this.Horas = 14;
						lblHora.Text = "02";
					}
					this.VerificarHora = true;
					CerrarHoras();
					AbrirMinutos();
				}
			}		}

		private void btn3_Click(object sender, EventArgs e)
		{if (VerifarAMPM == true)
			{
				if (HoraNoche == false)
				{
					this.Horas = 3;
					lblHora.Text = $"0{this.Horas}";
				}
				else
				{
					this.Horas = 15;
					lblHora.Text = "03";
				}
				this.VerificarHora = true;
				CerrarHoras();
				AbrirMinutos();
			}		}

		private void btn4_Click(object sender, EventArgs e)
		{if (VerifarAMPM == true)
			{
				if (HoraNoche == false)
				{
					this.Horas = 4;
					lblHora.Text = $"0{this.Horas}";
				}
				else
				{
					this.Horas = 16;
					lblHora.Text = "04";
				}
				this.VerificarHora = true;
				CerrarHoras();
				AbrirMinutos();
			}		}

		private void btn5_Click(object sender, EventArgs e)
		{if (VerifarAMPM == true)
			{
				if (HoraNoche == false)
				{
					this.Horas = 5;
					lblHora.Text = $"0{this.Horas}";
				}
				else
				{
					this.Horas = 17;
					lblHora.Text = "05";
				}
				this.VerificarHora = true;
				CerrarHoras();
				AbrirMinutos();
			}		}

		private void btn6_Click(object sender, EventArgs e)
		{if (VerifarAMPM == true)
			{
				if (HoraNoche == false)
				{
					this.Horas = 6;
					lblHora.Text = $"0{this.Horas}";
				}
				else
				{
					this.Horas = 18;
					lblHora.Text = "06";
				}
				this.VerificarHora = true;
				CerrarHoras();
				AbrirMinutos();
			}		}

		private void btn7_Click(object sender, EventArgs e)
		{if (VerifarAMPM == true)
			{
				if (HoraNoche == false)
				{
					this.Horas = 7;
					lblHora.Text = $"0{this.Horas}";
				}
				else
				{
					this.Horas = 19;
					lblHora.Text = "07";
				}
				this.VerificarHora = true;
				CerrarHoras();
				AbrirMinutos();
			}		}

		private void btn8_Click(object sender, EventArgs e)
		{if (VerifarAMPM == true)
			{
				if (HoraNoche == false)
				{
					this.Horas = 8;
					lblHora.Text = $"0{this.Horas}";
				}
				else
				{
					this.Horas = 20;
					lblHora.Text = "08";
				}
				this.VerificarHora = true;
				
				CerrarHoras();
				AbrirMinutos();
			}		}

		private void btn9_Click(object sender, EventArgs e)
		{if (VerifarAMPM == true)
			{
				if (HoraNoche == false)
				{
					this.Horas = 9;
					lblHora.Text = $"0{this.Horas}";
				}
				else
				{
					this.Horas = 21;
					lblHora.Text = "09";
				}
				this.VerificarHora = true;
				CerrarHoras();
				AbrirMinutos();
			}		}

		private void btn10_Click(object sender, EventArgs e)
		{
			if (VerifarAMPM == true)
			{
				if (HoraNoche == false)
				{
					this.Horas = 10;
					lblHora.Text = $"{this.Horas}";
				}
				else
				{
					this.Horas = 22;
					lblHora.Text = "10";
				}
				this.VerificarHora = true;
				CerrarHoras();
				AbrirMinutos();
			}
		}

		private void btn11_Click(object sender, EventArgs e)
		{if (VerifarAMPM == true)
			{
				if (HoraNoche == false)
				{
					this.Horas = 11;
					lblHora.Text = $"{this.Horas}";
				}
				else
				{
					this.Horas = 23;
					lblHora.Text = "11";
				}
				this.VerificarHora = true;
				CerrarHoras();
				AbrirMinutos();
			}		}

		private void guna2GroupBox1_Click(object sender, EventArgs e)
		{

		}

		private void rjCircularPictureBox1_Click(object sender, EventArgs e)
		{
			
		}
		private void CerrarHoras()
		{
			
			btn1.Visible = false;
			btn2.Visible = false;
			btn3.Visible = false;
			btn4.Visible = false;
			btn5.Visible = false;
			btn6.Visible = false;
			btn7.Visible = false;
			btn8.Visible = false;
			btn9.Visible = false;
			btn10.Visible = false;
			btn11.Visible = false;
			btn12.Visible = false;
		}
		private void AbrirHoras()
		{

			btn1.Visible = true;
			btn2.Visible = true;
			btn3.Visible = true;
			btn4.Visible = true;
			btn5.Visible = true;
			btn6.Visible = true;
			btn7.Visible = true;
			btn8.Visible = true;
			btn9.Visible = true;
			btn10.Visible = true;
			btn11.Visible = true;
			btn12.Visible = true;
		}
		private void CerrarMinutos()
		{
			btn0Min.Visible = false;
			btn05Min.Visible = false;
			btn10Min.Visible = false;
			btn15Min.Visible = false;
			btn20Min.Visible = false;
			btn25Min.Visible = false;
			btn30Min.Visible = false;
			btn35Min.Visible = false;
			btn40Min.Visible = false;
			btn45Min.Visible = false;
			btn50Min.Visible = false;
			btn55Min.Visible = false;
			btn0Min.Visible = false;
		}
		private void AbrirMinutos()
		{
			btn0Min.Visible = true;
			btn05Min.Visible = true;
			btn10Min.Visible = true;
			btn15Min.Visible = true;
			btn20Min.Visible = true;
			btn25Min.Visible = true;
			btn30Min.Visible = true;
			btn35Min.Visible = true;
			btn40Min.Visible = true;
			btn45Min.Visible = true;
			btn50Min.Visible = true;
			btn50Min.Visible = true;
			btn55Min.Visible = true;
			btn0Min.Visible = true;
		}
		private void btn12_Click(object sender, EventArgs e)
		{

			if (VerifarAMPM == true)
			{


				if (HoraNoche == true)
				{
					this.Horas = 0;
					lblHora.Text = "12";
				}
				else
				{

					this.Horas = 12;
					lblHora.Text = "12";
				}
				this.VerificarHora = true;
				CerrarHoras();
				AbrirMinutos();
			}
		}

		private void lblHora_Click(object sender, EventArgs e)
		{
			AbrirHoras();
			CerrarMinutos();
		}

		private void guna2Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void lblMinutos_Click(object sender, EventArgs e)
		{
			CerrarHoras();
			AbrirMinutos();
		}

		private void btn0Min_Click(object sender, EventArgs e)
		{
			if (VerifarAMPM == true)
			{
				this.VerificarMinutos = true;
				this.Minutos = 0;
				lblMinutos.Text = "00";

			}
		}

		private void btn05Min_Click(object sender, EventArgs e)
		{

			if (VerifarAMPM == true)
			{
				this.VerificarMinutos = true;
				this.Minutos = 5;
				lblMinutos.Text = "05";

			}
		}

		private void btn10Min_Click(object sender, EventArgs e)
		{

			if (VerifarAMPM == true)
			{
				this.VerificarMinutos = true;
				this.Minutos = 10;
				lblMinutos.Text = "10";

			}
		}

		private void btn15Min_Click(object sender, EventArgs e)
		{

			if (VerifarAMPM == true)
			{
				this.VerificarMinutos = true;
				this.Minutos = 15;
				lblMinutos.Text = "15";

			}
		}

		private void btn20Min_Click(object sender, EventArgs e)
		{

			if (VerifarAMPM == true)
			{
				this.VerificarMinutos = true;
				this.Minutos = 20;
				lblMinutos.Text = "20";

			}
		}

		private void btn25Min_Click(object sender, EventArgs e)
		{

			if (VerifarAMPM == true)
			{
				this.VerificarMinutos = true;
				this.Minutos = 25;
				lblMinutos.Text = "25";

			}
		}

		private void btn30Min_Click(object sender, EventArgs e)
		{

			if (VerifarAMPM == true)
			{
				this.VerificarMinutos = true;
				this.Minutos = 30;
				lblMinutos.Text = "30";

			}
		}

		private void btn35Min_Click(object sender, EventArgs e)
		{

			if (VerifarAMPM == true)
			{
				this.VerificarMinutos = true;
				this.Minutos = 35;
				lblMinutos.Text = "35";

			}
		}

		private void btn40Min_Click(object sender, EventArgs e)
		{

			if (VerifarAMPM == true)
			{
				this.VerificarMinutos = true;
				this.Minutos = 40;
				lblMinutos.Text = "40";

			}
		}

		private void btn45Min_Click(object sender, EventArgs e)
		{

			if (VerifarAMPM == true)
			{
				this.VerificarMinutos = true;
				this.Minutos = 45;
				lblMinutos.Text = "45";

			}
		}

		private void btn50Min_Click(object sender, EventArgs e)
		{

			if (VerifarAMPM == true)
			{
				this.VerificarMinutos = true;
				this.Minutos = 50;
				lblMinutos.Text = "50";

			}
		}

		private void btn55Min_Click(object sender, EventArgs e)
		{

			if (VerifarAMPM == true)
			{
				this.VerificarMinutos = true;
				this.Minutos = 55;
				lblMinutos.Text = "55";

			}
		}

		private void guna2VSeparator1_Click(object sender, EventArgs e)
		{

		}
	}
}
