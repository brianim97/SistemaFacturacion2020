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
	public partial class FrmPrincipal : Form
	{
		public string NombreUsuario { get; set; }
		public string TipoUsuario = "";

		public FrmPrincipal()
		{
			InitializeComponent();
		}
		private void FrmPrincipal_Load(object sender, EventArgs e)
		{
		}
		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnCateogrias_Click(object sender, EventArgs e)
		{
			AbrirFrmHijo(new FrmCategoria());
			
			//FrmCategoria frm = new FrmCategoria();

			//frm.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AbrirFrmHijo(new FrmClientes());
			//FrmClientes frm = new FrmClientes();

			//frm.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AbrirFrmHijo(new frmProducto());
			//frmProducto frm = new frmProducto();

			//frm.Show();
		}

		private void btnProveedores_Click(object sender, EventArgs e)
		{
			AbrirFrmHijo(new FrmProveedores());
			//FrmProveedores frm = new FrmProveedores(); ;

			//frm.Show();
		}

		private void btnFacturacion_Click(object sender, EventArgs e)
		{
			//FrmFacturacion frm = new FrmFacturacion();
			//frm.UsuarioNombre = NombreUsuario;
			//frm.Show();
			AbrirFrmHijo(new FrmFacturacion());
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			//FrmLoginPrincipal frm = new FrmLoginPrincipal();
			//frm.Show();
			AbrirFrmHijo(new FrmLoginPrincipal());
			this.Close();
		}

		private void btnUsuarios_Click(object sender, EventArgs e)
		{
			AbrirFrmHijo(new FrmUsuarios());
			//FrmUsuarios frm = new FrmUsuarios();

			//frm.Show();
		}

		

		private void FrmPrincipal_Load_1(object sender, EventArgs e)
		{
			lblUsuario.Text = NombreUsuario;
			timer1.Enabled = true;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblFechaHora.Text = "Fecha: "+DateTime.Now.ToString("dd/MM/yyyy") +" Hora: "+ DateTime.Now.ToString("h:mm:ss");
		}
		private void AbrirFrmHijo(Object frmHijo)
		{
			//if(this.panelPrimario.Controls.Count > 0)
			//{
			//	this.panelPrimario.Controls.RemoveAt(0);
			//}
			Form fh = frmHijo as Form;
			fh.TopLevel = false;
			this.panelPrimario.Controls.Add(fh);
			this.panelPrimario.Tag = fh;
			fh.Show();
			fh.BringToFront();
		}
	}
}
