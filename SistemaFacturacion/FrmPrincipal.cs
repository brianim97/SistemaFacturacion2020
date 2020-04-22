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
		public static string NombreUsuario { get; set; }
		public string TipoUsuario = "";
		public static bool abiertoFrmFacturacion = false;
		public static bool abiertoFrmClientes = false;
		public static bool abiertoFrmProductos = false;
		public static bool abiertoFrmProveedores = false;
		public static bool abiertoFrmUsuarios = false;
		public static bool abiertoFrmCategorias = false;
		public Form frmFacturacion;
		public Form frmClientes;
		public Form frmProductos;
		public Form frmProveedores;
		public Form frmUsuarios;
		public Form frmCategoria;


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
			if (abiertoFrmCategorias)
			{
				frmCategoria.BringToFront();
			}
			else
			{
				frmCategoria = new FrmCategoria();
				AbrirFrmHijo(frmCategoria);
				abiertoFrmCategorias = true;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (abiertoFrmClientes)
			{
				frmClientes.BringToFront();
			}
			else
			{
				frmClientes = new FrmClientes();
				AbrirFrmHijo(frmClientes);
				abiertoFrmClientes = true;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (abiertoFrmProductos)
			{
				frmProductos.BringToFront();
			}
			else
			{
				frmProductos = new frmProducto();
				AbrirFrmHijo(frmProductos);
				abiertoFrmProductos = true;
			}
		}

		private void btnProveedores_Click(object sender, EventArgs e)
		{
			if (abiertoFrmProveedores)
			{
				frmProveedores.BringToFront();
			}
			else
			{
				frmProveedores = new FrmProveedores();
				AbrirFrmHijo(frmProveedores);
				abiertoFrmProveedores = true;
			}
		}

		private void btnFacturacion_Click(object sender, EventArgs e)
		{
			if (abiertoFrmFacturacion)
			{
				frmFacturacion.BringToFront();
			}
			else
			{
				frmFacturacion = new FrmFacturacion();
				AbrirFrmHijo(frmFacturacion);
				abiertoFrmFacturacion = true;
				
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			FrmLoginPrincipal frm = new FrmLoginPrincipal();
			frm.Show();
			this.Close();
		}

		private void btnUsuarios_Click(object sender, EventArgs e)
		{
			if (abiertoFrmUsuarios)
			{
				frmUsuarios.BringToFront();
			}
			else
			{
				frmUsuarios = new FrmUsuarios();
				AbrirFrmHijo(frmUsuarios);
				abiertoFrmUsuarios = true;
			}
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
			Form fh = frmHijo as Form;
			fh.TopLevel = false;
			this.panelPrimario.Controls.Add(fh);
			this.panelPrimario.Tag = fh;
			fh.Show();
			fh.BringToFront();
		}

		

		private void AbrirOCerrarFrm(bool abiertoFrm, Form frm, Form frmLegal)
		{
			if (abiertoFrm)
			{
				frm.BringToFront();
			}
			else
			{
				frm = frmLegal;
				AbrirFrmHijo(frm);
				abiertoFrm = true;
			}
		}

		private void panelPrimario_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
