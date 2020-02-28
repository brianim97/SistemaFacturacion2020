﻿using System;
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
		private string AuxiliarNombreProducto;

		private void btnGuardar_Click_1(object sender, EventArgs e)
		{
			if(Editar == true)
			{
				if (Comprobar_Campos() == "")
				{ 
					MessageBox.Show(NProducto.Editar(Obtener_Id_Producto(AuxiliarNombreProducto), Obtener_Id_Categoria(cbCategoria.Text), tbNombre.Text, tbMarca.Text, int.Parse(tbStock.Text), decimal.Parse(tbPrecioCompra.Text), decimal.Parse(tbPrecioVenta.Text), dtpFecha_Vencimiento.Value, Obtener_Id_Categoria(cbProveedor.Text))); 
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
					MessageBox.Show(NProducto.Insertar(Obtener_Id_Categoria(cbCategoria.Text), tbNombre.Text, tbMarca.Text, int.Parse(tbStock.Text), decimal.Parse(tbPrecioCompra.Text), decimal.Parse(tbPrecioVenta.Text), dtpFecha_Vencimiento.Value, Obtener_Id_Categoria(cbProveedor.Text)));
				}
				else
				{
					MessageBox.Show(Comprobar_Campos());
				}
			}
			

		}

		private void frmCargarProducto_Load(object sender, EventArgs e)
		{
			Mostrar();
			Cargar_Categoria();
			Cargar_Proveedores();
			Habilitar_Editar_Eliminar(false);

		}
		
		//-------------------------------------------------------------METODOS AUXILIARES -------------------------------------------------------------------
		public void PrepararDatosDeProductoParaEditar()
		{
			AuxiliarNombreProducto = tbNombre.Text;
			tbNombre.Text = Convert.ToString(dgvVistaStock.CurrentRow.Cells["Nombre"].Value);
			cbCategoria.Text = Convert.ToString(dgvVistaStock.CurrentRow.Cells["Categoria"].Value);
			tbMarca.Text = Convert.ToString(dgvVistaStock.CurrentRow.Cells["Marca"].Value);
			tbStock.Text = Convert.ToString(dgvVistaStock.CurrentRow.Cells["Stock"].Value);
			tbPrecioCompra.Text = Convert.ToString(dgvVistaStock.CurrentRow.Cells["Precio Compra"].Value);
			tbPrecioVenta.Text = Convert.ToString(dgvVistaStock.CurrentRow.Cells["Precio Venta"].Value);
			dtpFecha_Vencimiento.Text = Convert.ToString(dgvVistaStock.CurrentRow.Cells["Fecha Vencimiento"].Value);
			cbProveedor.Text = Convert.ToString(dgvVistaStock.CurrentRow.Cells["Proveedor"].Value);
			tabProducto.SelectedIndex = 1;
			Editar = true;

		}
	
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
		private int Obtener_Id_Producto(string nombre)
		{
			Conexion conexion = new Conexion();
			SqlConnection conector = new SqlConnection(conexion.strConexion);
			SqlCommand cmd = new SqlCommand(string.Format("SELECT id_producto FROM Producto WHERE Nombre = '{0}'", nombre), conector);
			conector.Open();
			SqlDataReader registros = cmd.ExecuteReader();
			int id = 0;
			while (registros.Read())
			{
				id = Int16.Parse(registros["id_producto"].ToString());
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
		private void Mostrar()
		{
			NProducto.Mostrar(dgvVistaStock);
			lblTotalRegistros.Text = "Registros: " + dgvVistaStock.Rows.Count.ToString();
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

		private void dgvVistaStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Habilitar_Editar_Eliminar(true);
		}
		private void Habilitar_Editar_Eliminar(bool valor)
		{
			btnEditar.Enabled = valor;
			btnEliminar.Enabled = valor;
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			PrepararDatosDeProductoParaEditar();
		}
	}
}

