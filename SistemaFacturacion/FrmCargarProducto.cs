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
using Datos;
using Negocio;

namespace SistemaFacturacion
{
	public partial class frmCargarProducto : Form
	{
		public frmCargarProducto()
		{
			InitializeComponent();
		}


		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			Limpiar_Campos();
		}


		private void btnGuardar_Click_1(object sender, EventArgs e)
		{
			if (Comprobar_Campos() == "")
			{
				MessageBox.Show(NProducto.Insertar(Obtener_Id_Categoria(cbCategoria.Text), tbNombre.Text, tbMarca.Text, int.Parse(tbStock.Text), decimal.Parse(tbPrecioCompra.Text), decimal.Parse(tbPrecioVenta.Text), dtpFecha_Vencimiento.Value, Obtener_Id_Categoria(cbProveedor.Text)));
			}
			else
			{
				MessageBox.Show(Comprobar_Campos());
			}

		}

		private void frmCargarProducto_Load(object sender, EventArgs e)
		{
			Cargar_Categoria();
			Cargar_Proveedores();
		}

		//-------------------------------------------------------------METODOS AUXILIARES -------------------------------------------------------------------

		private void Cargar_Categoria()
		{
			Conexion conexion = new Conexion();
			SqlConnection conector = new SqlConnection(conexion.strConexion);
			SqlCommand cmd = new SqlCommand("SELECT nombre FROM Categoria", conector);
			conector.Open();
			SqlDataReader registros = cmd.ExecuteReader();
			while (registros.Read())
			{
				cbCategoria.Items.Add(registros["nombre"].ToString());
			}
		}
		private void Cargar_Proveedores()
		{
			Conexion conexion = new Conexion();
			SqlConnection conector = new SqlConnection(conexion.strConexion);
			SqlCommand cmd = new SqlCommand("SELECT nombre FROM Proveedor", conector);
			conector.Open();
			SqlDataReader registros = cmd.ExecuteReader();
			while (registros.Read())
			{
				cbProveedor.Items.Add(registros["nombre"].ToString());
			}
		}
		private int Obtener_Id_Categoria(string nombre)
		{
			Conexion conexion = new Conexion();
			SqlConnection conector = new SqlConnection(conexion.strConexion);
			SqlCommand cmd = new SqlCommand(string.Format("SELECT id_categoria FROM Categoria WHERE Nombre = '{0}'", nombre), conector);
			conector.Open();
			SqlDataReader registros = cmd.ExecuteReader();
			int id = 0;
			while (registros.Read())
			{
				id = Int16.Parse(registros["id_categoria"].ToString());
			}

			conector.Close();
			return id;
		}
		private int Obtener_Id_Proveedor(string nombre)
		{
			Conexion conexion = new Conexion();
			SqlConnection conector = new SqlConnection(conexion.strConexion);
			SqlCommand cmd = new SqlCommand(string.Format("SELECT id_proveedor FROM Proveedor WHERE Nombre = '{0}'", nombre), conector);
			conector.Open();
			SqlDataReader registros = cmd.ExecuteReader();
			int id = 0;
			while (registros.Read())
			{
				id = Int16.Parse(registros["id_proveedor"].ToString());
			}

			conector.Close();
			return id;
		}

		private string Comprobar_Campos()
		{
			string rpta = "";
			if (tbNombre.Text == string.Empty)
			{
				rpta += "Error: campo 'Nombre' no puede estar vacio.\n";
			}
			if (cbCategoria.Text == string.Empty)
			{
				rpta += "Error: campo 'Categoria' no puede estar vacio.\n";
			}
			if (tbStock.Text == string.Empty)
			{
				rpta += "Error: campo 'Stock' no puede estar vacio.\n";
			}
			if (tbPrecioCompra.Text.Contains("."))
			{
				rpta += "Error: campo 'Precio Compra' no puede contener el caracter [.] solo permite [,].\n";
			}
			if (tbPrecioCompra.Text == string.Empty)
			{
				rpta += "Error: campo 'Precio Compra' no puede estar vacio.\n";
			}
			if (tbPrecioVenta.Text.Contains("."))
			{
				rpta += "Error: campo 'Precio Venta' no puede contener el caracter [.] solo permite [,].\n";
			}
			if (tbPrecioVenta.Text == string.Empty)
			{
				rpta += "Error: campo 'Precio Venta' no puede estar vacio.\n";
			}
			if (cbProveedor.Text == string.Empty)
			{
				rpta += "Error: campo 'Proveedor' no puede estar vacio.";
			}
			return rpta;
		}
		private void Limpiar_Campos()
		{
			tbNombre.Clear();
			cbCategoria.ResetText();
			tbMarca.Clear();
			tbStock.Clear();
			tbPrecioCompra.Clear();
			tbPrecioVenta.Clear();
			dtpFecha_Vencimiento.ResetText();
			cbProveedor.ResetText();
		}

		//------------------------------------------------------METODOS DE BLOQUEO DE CARACTERES-------------------------------------------------------

		private void tbStock_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsSeparator(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void tbPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
		{

			if (Char.IsDigit(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsSeparator(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsPunctuation(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void tbPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
		{

			if (Char.IsDigit(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsSeparator(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsPunctuation(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}


	}
}

