using Datos;
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
	public partial class FrmLoginPrincipal : Form
	{
		public FrmLoginPrincipal()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnIniciar_Click(object sender, EventArgs e)
		{
			try
			{

				string query = string.Format("SELECT name,password,account FROM Usuarios WHERE name = '{0}' AND password = '{1}'", tbUsuario.Text, tbContraseña.Text);
				DataSet ds = Utilidades.Ejecutar(query);
				string usuarioNombre = ds.Tables[0].Rows[0]["name"].ToString();
				string contraseña = ds.Tables[0].Rows[0]["password"].ToString();
				string account = ds.Tables[0].Rows[0]["account"].ToString();

				if (usuarioNombre == tbUsuario.Text)
				{
					if (contraseña == tbContraseña.Text)
					{
						MessageBox.Show(string.Format("Inicio de sesion correcto!\nBienvenido: '{0}' Tipo de cuenta '{1}'", usuarioNombre, account), "Aviso");
						FrmPrincipal frm = new FrmPrincipal();
						frm.TipoUsuario = account;
						FrmPrincipal.NombreUsuario = tbUsuario.Text;
						this.Hide();
						frm.Show();
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Error: Usuario o Contraseña incorrecta!");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void FrmLoginPrincipal_Load(object sender, EventArgs e)
		{
			this.AcceptButton = btnIngresar;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			tbUsuario.Text = "Admin";
			tbContraseña.Text = "sis20";
		}
	}
}
