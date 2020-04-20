using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion
{
	public partial class FrmLogin : Form
	{

		public FrmLogin()
		{
			InitializeComponent();
		}

		private void FrmLogin_Load(object sender, EventArgs e)
		{
			this.AcceptButton = btnIngresar;
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnIngresar_Click(object sender, EventArgs e)
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
						MessageBox.Show(string.Format("Inicio de sesion correcto!\nBienvenido: '{0}' Tipo de cuenta '{1}'", usuarioNombre, account),"Aviso");
						MDIParent1 frm = new MDIParent1();
						frm.TipoUsuario = account;
						frm.NombreUsuario = tbUsuario.Text;
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

		private void button1_Click(object sender, EventArgs e)
		{
			tbUsuario.Text = "Admin";
			tbContraseña.Text = "sis20";
		}
	}
}
