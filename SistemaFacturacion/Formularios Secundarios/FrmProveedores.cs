using Datos;
using Negocio;
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
	public partial class FrmProveedores : Form
	{
		string AuxiliarNombre = "";
		bool Editar = false;

		public FrmProveedores()
		{
			InitializeComponent();
		}

		private void dgvVistaProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			AuxiliarNombre = Convert.ToString(dgvVistaProveedor.CurrentRow.Cells["Nombre"].Value);
			btnEditar.Enabled = true;
			btnEliminar.Enabled = true;
		}

		private void tbVistaProveedor_TextChanged(object sender, EventArgs e)
		{
			NProveedor.BuscarPorNombre(dgvVistaProveedor, tbVistaProveedor.Text);
		}

		private void FrmProveedores_Load(object sender, EventArgs e)
		{
			Mostrar();
			btnEditar.Enabled = false;
			btnEliminar.Enabled = false;
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (Editar == true)
			{
				if (Comprobar_Campos() == string.Empty)
				{
					if (Obtener_Id(AuxiliarNombre) == 0)
					{
						MessageBox.Show("Error: id no encontrado!");
					}
					else
					{
						if (AuxiliarNombre == tbNombreProveedor.Text)
						{
							MessageBox.Show(NProveedor.Editar(Obtener_Id(tbNombreProveedor.Text), tbNombreProveedor.Text, tbContactoProveedor.Text));
							Limpiar_Campos();
							Editar = false;
						}
						else if (NombreExistente(tbNombreProveedor.Text))
						{
							MessageBox.Show(string.Format("Error: el nombre '{0}' ya se encuentra en uso!", tbNombreProveedor.Text));
						}
						else
						{
							MessageBox.Show(NProveedor.Editar(Obtener_Id(AuxiliarNombre), tbNombreProveedor.Text, tbContactoProveedor.Text));
							Limpiar_Campos();
							Editar = false;
						}

					}

				}
				else
				{
					MessageBox.Show(Comprobar_Campos());
				}
			}
			else
			{
				if (Comprobar_Campos() == string.Empty)
				{
					if (NombreExistente(tbNombreProveedor.Text))
					{
						MessageBox.Show(string.Format("Error: el nombre '{0}' ya se encuentra en uso!", tbNombreProveedor.Text));
					}
					else
					{
						MessageBox.Show(NProveedor.Insertar(tbNombreProveedor.Text, tbContactoProveedor.Text));
						Limpiar_Campos();
					}

				}
				else
				{
					MessageBox.Show(Comprobar_Campos());
				}

			}
			Mostrar();
		}
		private string Comprobar_Campos()
		{
			string rpta = "";
			if (tbNombreProveedor.Text == string.Empty)
			{
				rpta += "Error: el campo 'Nombre' no puede estar vacio";
			}
			return rpta;

		}
		private int Obtener_Id(string nombre)
		{
			Conexion conexion = new Conexion();
			SqlConnection conector = new SqlConnection(conexion.strConexion);
			string query = string.Format("SELECT id_proveedor FROM Proveedor WHERE nombre = '{0}'", nombre);
			SqlCommand cmd = new SqlCommand(query, conector);
			conector.Open();
			SqlDataReader registro = cmd.ExecuteReader();
			int id = 0;
			while (registro.Read())
			{
				id = Int16.Parse(registro["id_proveedor"].ToString());
				return id;
			}
			return id;
		}
		private bool NombreExistente(string nombre)
		{
			return NProveedor.NombreExistente(nombre);
		}
		private void Limpiar_Campos()
		{
			tbNombreProveedor.Clear();
			tbContactoProveedor.Clear();
		}
		private void Mostrar()
		{
			NProveedor.Mostrar(dgvVistaProveedor);
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			Limpiar_Campos();
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			tbNombreProveedor.Text = Convert.ToString(dgvVistaProveedor.CurrentRow.Cells["Nombre"].Value);
			tbContactoProveedor.Text = Convert.ToString(dgvVistaProveedor.CurrentRow.Cells["Contacto"].Value);
			tabProveedor.SelectedIndex = 1;
			Editar = true;
			btnEditar.Enabled = false;
			btnEliminar.Enabled = false;
		}

		private void FrmProveedores_FormClosing(object sender, FormClosingEventArgs e)
		{
			FrmPrincipal.abiertoFrmProveedores = false;
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			MessageBox.Show(NProveedor.Eliminar(Obtener_Id(AuxiliarNombre)));
			Mostrar();
			btnEliminar.Enabled = false;
			btnEditar.Enabled = false;
		}
	}

}
