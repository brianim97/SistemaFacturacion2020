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
	public partial class frmProducto : Form
	{
		public frmProducto()
		{
			InitializeComponent();
		}
		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			Limpiar_Campos();
		}
		private bool Editar = false;
		private string AuxiliarNombreProducto = "";

		private void btnGuardar_Click_1(object sender, EventArgs e)
		{
			if(Editar == true)
			{
				if (Comprobar_Campos() == "")
				{
					if (AuxiliarNombreProducto.Equals(tbNombre.Text))
					{
						MessageBox.Show(NProducto.Editar(Obtener_Id_Producto(AuxiliarNombreProducto), Obtener_Id_Categoria(cbCategoria.Text), tbNombre.Text, tbMarca.Text, int.Parse(tbStock.Text), tbCodigo.Text, decimal.Parse(tbPrecioCompra.Text), decimal.Parse(tbPrecioVenta.Text), dtpFecha_Vencimiento.Value, Obtener_Id_Categoria(cbProveedor.Text)));
						Limpiar_Campos();
						Editar = false;
						Mostrar();
						return;
					}
					else
					{
						if (NProducto.NombreExistente(tbNombre.Text))
						{
							MessageBox.Show(string.Format("El nombre: '{0}' ya se encuentra en uso!", tbNombre.Text));
						}
					}
					MessageBox.Show(NProducto.Editar(Obtener_Id_Producto(AuxiliarNombreProducto), Obtener_Id_Categoria(cbCategoria.Text), tbNombre.Text, tbMarca.Text, int.Parse(tbStock.Text), tbCodigo.Text, decimal.Parse(tbPrecioCompra.Text), decimal.Parse(tbPrecioVenta.Text), dtpFecha_Vencimiento.Value, Obtener_Id_Categoria(cbProveedor.Text)));
					Limpiar_Campos();
					Editar = false;
					Mostrar();
				}
				
				else
				{
					MessageBox.Show(Comprobar_Campos());
				}
			}
			else
			{
				if (Comprobar_Campos() == "")
				{
					if (NProducto.NombreExistente(tbNombre.Text))
					{
						MessageBox.Show(string.Format("El nombre: '{0}' ya se encuentra en uso!", tbNombre.Text));
					}
					else
					{
						MessageBox.Show(NProducto.Insertar(Obtener_Id_Categoria(cbCategoria.Text), tbNombre.Text, tbMarca.Text, int.Parse(tbStock.Text), tbCodigo.Text, decimal.Parse(tbPrecioCompra.Text), decimal.Parse(tbPrecioVenta.Text), dtpFecha_Vencimiento.Value, Obtener_Id_Proveedor(cbProveedor.Text)));
						Limpiar_Campos();
						Mostrar();
					}
					
				}
				else
				{
					MessageBox.Show(Comprobar_Campos());
				}
			}
			

		}

		private void frmCargarProducto_Load(object sender, EventArgs e)
		{
			if(Mostrar())
			{
				Cargar_Categoria();
				Cargar_Proveedores();
				Habilitar_Editar_Eliminar(false);
			}
			
			

		}
		
		//-------------------------------------------------------------METODOS AUXILIARES -------------------------------------------------------------------
		public void PrepararDatosDeProductoParaEditar()
		{
			AuxiliarNombreProducto = Convert.ToString(dgvVistaStock.CurrentRow.Cells["Nombre"].Value);
			tbNombre.Text = Convert.ToString(dgvVistaStock.CurrentRow.Cells["Nombre"].Value);
			cbCategoria.Text = Convert.ToString(dgvVistaStock.CurrentRow.Cells["Categoria"].Value);
			tbMarca.Text = Convert.ToString(dgvVistaStock.CurrentRow.Cells["Marca"].Value);
			tbStock.Text = Convert.ToString(dgvVistaStock.CurrentRow.Cells["Stock"].Value);
			tbCodigo.Text = Convert.ToString(dgvVistaStock.CurrentRow.Cells["Codigo"].Value);
			tbPrecioCompra.Text = Convert.ToString(dgvVistaStock.CurrentRow.Cells["Precio Compra"].Value);
			tbPrecioVenta.Text = Convert.ToString(dgvVistaStock.CurrentRow.Cells["Precio Venta"].Value);
			dtpFecha_Vencimiento.Text = Convert.ToString(dgvVistaStock.CurrentRow.Cells["Fecha Vencimiento"].Value);
			cbProveedor.Text = Convert.ToString(dgvVistaStock.CurrentRow.Cells["Proveedor"].Value);
			tabProducto.SelectedIndex = 1;
			Editar = true;

		}
	
		private void Cargar_Categoria()
		{
			try
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
				conector.Close();
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
		private void Cargar_Proveedores()
		{
			try
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
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
		private int Obtener_Id_Categoria(string nombre)
		{
			int id = 0;
			try
			{
				Conexion conexion = new Conexion();
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				SqlCommand cmd = new SqlCommand(string.Format("SELECT id_categoria FROM Categoria WHERE Nombre = '{0}'", nombre), conector);
				conector.Open();
				SqlDataReader registros = cmd.ExecuteReader();
				while (registros.Read())
				{
					id = Int16.Parse(registros["id_categoria"].ToString());
				}

				conector.Close();
				return id;
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message);
				return id;
			}			
		}
		private int Obtener_Id_Producto(string nombre)
		{
			int id = 0;
			try
			{
				Conexion conexion = new Conexion();
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				SqlCommand cmd = new SqlCommand(string.Format("SELECT id_producto FROM Producto WHERE Nombre = '{0}'", nombre), conector);
				conector.Open();
				SqlDataReader registros = cmd.ExecuteReader();
				while (registros.Read())
				{
					id = Int16.Parse(registros["id_producto"].ToString());
				}
				conector.Close();
				return id;
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message);
				return id;
			}
			
		}
		private int Obtener_Id_Proveedor(string nombre)
		{
			int id = 0;
			try
			{
				Conexion conexion = new Conexion();
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				SqlCommand cmd = new SqlCommand(string.Format("SELECT id_proveedor FROM Proveedor WHERE Nombre = '{0}'", nombre), conector);
				conector.Open();
				SqlDataReader registros = cmd.ExecuteReader();
			
				while (registros.Read())
				{
					id = Int16.Parse(registros["id_proveedor"].ToString());
				}

				conector.Close();
				return id;
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message);
				return id;
			}
			
		}
		private bool Comprobar_Id_Proveedor_Categoria()
		{
			bool bandera = true;
			if(Obtener_Id_Categoria(cbCategoria.Text) == 0)
			{
				MessageBox.Show("Error: 'ID' de categoria no encontrado!");
				bandera = false;
			}
			if (Obtener_Id_Proveedor(cbProveedor.Text) == 0)
			{
				MessageBox.Show("Error: 'ID' de proveedor no encontrado!");
				bandera = false;
			}
			return bandera;
		}
		private bool Comprobar_Id_Producto()
		{
			if (Obtener_Id_Producto(AuxiliarNombreProducto) == 0)
			{
				MessageBox.Show("Error: 'ID' de categoria no encontrado!");
				return false;
			}
			return true;
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
			}else if (tbStock.Text.Any(x => !char.IsNumber(x)))
				rpta+="Error: campo 'Stock' no soporta letras\n";

			if (tbCodigo.Text == string.Empty)
			{
				rpta += "Error: campo 'Codigo' no puede estar vacio.\n";
			}
		//------------------------------------------------------------------------------------------------------------
			if (tbPrecioCompra.Text.Contains("."))
			{
				rpta += "Error: campo 'Precio Compra' no puede contener el caracter [.] solo permite [,].\n";
			}
			if (tbPrecioCompra.Text == string.Empty)
			{
				rpta += "Error: campo 'Precio Compra' no puede estar vacio.\n";
			}
			else if (!tbPrecioCompra.Text.Any(x => !char.IsNumber(x)) || tbPrecioCompra.Text.Contains(",")) 
			{ }
			else if (tbPrecioCompra.Text.Any(x => !char.IsNumber(x)))
			{
				rpta += "Error: campo 'Precio Compra' no soporta letras\n";
			}

			if (tbPrecioVenta.Text.Contains("."))
			{
				rpta += "Error: campo 'Precio Venta' no puede contener el caracter [.] solo permite [,].\n";
			}

			if (tbPrecioVenta.Text == string.Empty)
			{
				rpta += "Error: campo 'Precio Venta' no puede estar vacio.\n";
			}
			else if (!tbPrecioVenta.Text.Any(x => !char.IsNumber(x)) || tbPrecioVenta.Text.Contains(","))
			{
			}
			else if (tbPrecioVenta.Text.Any(x => !char.IsNumber(x))){
				rpta += "Error: campo 'Precio Venta' no soporta letras\n";
			}
		//--------------------------------------------------------------------------------------------------------------

			if (cbProveedor.Text == string.Empty)
			{
				rpta += "Error: campo 'Proveedor' no puede estar vacio.";
			}
			return rpta;
		}
		private void Comprobar_Nombres_En_DB(string nombreNuevo)
		{

		}
		private void Limpiar_Campos()
		{
			tbNombre.Clear();
			cbCategoria.ResetText();
			tbMarca.Clear();
			tbStock.Clear();
			tbCodigo.Clear();
			tbPrecioCompra.Clear();
			tbPrecioVenta.Clear();
			dtpFecha_Vencimiento.ResetText();
			cbProveedor.ResetText();
			AuxiliarNombreProducto = "";
		}
		private bool Mostrar()
		{
			if (NProducto.Mostrar(dgvVistaStock))
			{
				lblTotalRegistros.Text = "Registros: " + dgvVistaStock.Rows.Count.ToString();
				return true;
			}
			return false;
			
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


		private void tbBuscarProducto_TextChanged(object sender, EventArgs e)
		{
			NProducto.BuscarPorNombre(dgvVistaStock, tbBuscarProducto.Text);
		}
		private void Habilitar_Editar_Eliminar(bool valor)
		{
			btnEditar.Enabled = valor;
			btnEliminar.Enabled = valor;
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			PrepararDatosDeProductoParaEditar();
			Habilitar_Editar_Eliminar(false);
		}

		private void dgvVistaStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Habilitar_Editar_Eliminar(true);
			AuxiliarNombreProducto = Convert.ToString(dgvVistaStock.CurrentRow.Cells["Nombre"].Value);
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			Habilitar_Editar_Eliminar(false);
			DialogResult result = MessageBox.Show(string.Format("¿Esta seguro de eliminar '{0}' permamentemente? ",AuxiliarNombreProducto), "Advertencia!", MessageBoxButtons.YesNo);
			if(result == DialogResult.Yes)
			{
				MessageBox.Show(NProducto.Eliminar(Obtener_Id_Producto(AuxiliarNombreProducto)));
				Mostrar();
			}
		}

		private void btnPrueba_Click(object sender, EventArgs e)
		{
			tbNombre.Text = "Prueba";
			cbCategoria.Text = "VARIOS";
			tbMarca.Text = "una";
			tbStock.Text = "10";
			tbCodigo.Text = "10001";
			tbPrecioCompra.Text = "15,5";
			tbPrecioVenta.Text = "20,5";
			cbProveedor.Text = "VARIOS";
			
		}

		private void btnPruebaError_Click(object sender, EventArgs e)
		{
			tbNombre.Text = "aa";
			cbCategoria.Text = "aa";
			tbMarca.Text = "aa";
			tbStock.Text = "aa";
			tbCodigo.Text = "aa";
			tbPrecioCompra.Text = "aa";
			tbPrecioVenta.Text = "aa";
			cbProveedor.Text = "aa";
		}

		private void frmProducto_FormClosing(object sender, FormClosingEventArgs e)
		{
			FrmPrincipal.abiertoFrmProductos = false;
		}
	}
}

