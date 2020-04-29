using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion
{
	public partial class FrmAccesoProgramador : Form
	{
		public FrmAccesoProgramador()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnIngresar_Click(object sender, EventArgs e)
		{
			if(tbContraseña.Text == "RocoIriarte2020")
			{
				FrmPrincipal frm = new FrmPrincipal();
				frm.Show();
				this.Close();
			}
			else
			{
				MessageBox.Show("Datos Incorrectos");
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			FrmLoginPrincipal frm = new FrmLoginPrincipal();
			frm.Show();
			this.Close();
		}

		private void tbContraseña_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == (int)Keys.Enter)
			{
				if (tbContraseña.Text == "RocoIriarte2020")
				{
					FrmPrincipal frm = new FrmPrincipal();
					frm.Show();
					this.Close();
				}
				else
				{
					MessageBox.Show("Datos Incorrectos");
				}
			}
		}
	}
}
