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
	public partial class FrmClientes : Form
	{
		bool Editar = false;
		string AuxiliarDni = "";

		public FrmClientes()
		{
			InitializeComponent();
		}
		private void Clientes_Load(object sender, EventArgs e)
		{
			Mostrar();
			btnEditar.Enabled = false;
			btnEliminar.Enabled = false;
		}

		private void Mostrar()
		{
			NCliente.Mostrar(dgvVistaCliente);
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			Limpiar_Campos();
		}

		private void Limpiar_Campos()
		{
			tbDni.Clear();
			tbNombre.Clear();
			tbDireccion.Clear();
			tbTelefono.Clear();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (Editar == true)
			{
				if (Comprobar_Campos() == string.Empty)
				{
					if (Obtener_Id(AuxiliarDni) == 0)
					{
						MessageBox.Show("Error: id no encontrado!");
					}
					else
					{
						if (AuxiliarDni == tbDni.Text)
						{
							MessageBox.Show(NCliente.Editar(Obtener_Id(tbDni.Text), tbDni.Text, tbNombre.Text, tbDireccion.Text, tbTelefono.Text));
							Limpiar_Campos();
							Editar = false;
						}
						else if (DniExistente(tbDni.Text))
						{
							MessageBox.Show(string.Format("Error: el nombre '{0}' ya se encuentra en uso!", tbNombre.Text));
						}
						else
						{
							MessageBox.Show(NCliente.Editar(Obtener_Id(tbDni.Text), tbDni.Text, tbNombre.Text, tbDireccion.Text, tbTelefono.Text));
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
					if (DniExistente(tbDni.Text))
					{
						MessageBox.Show(string.Format("Error: el dni '{0}' ya se encuentra en uso!", tbDni.Text));
					}
					else
					{
						MessageBox.Show(NCliente.Insertar(tbDni.Text, tbNombre.Text, tbDireccion.Text, tbTelefono.Text));
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

		private bool DniExistente(string dni)
		{
			return NCategoria.NombreExistente(dni);
		}

		private string Comprobar_Campos()
		{
			string rpta = "";
			if (tbDni.Text == string.Empty)
			{
				rpta += "Error: el campo 'Dni' no puede estar vacio";
			} 
			if(tbDni.Text.Any(x => !char.IsNumber(x)))
				rpta += "\nError: campo 'Dni' solo soporta numeros";

			if (tbNombre.Text == string.Empty)
			{
				rpta += "\nError: el campo 'Nombre' no puede estar vacio";
			}
			if (tbDireccion.Text == string.Empty)
			{
				rpta += "\nError: el campo 'Direccion' no puede estar vacio";
			}
			return rpta;

		}
		private int Obtener_Id(string dni)
		{
			int id = 0;
			try
			{
				Conexion conexion = new Conexion();
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				string query = string.Format("SELECT id_cliente FROM Cliente WHERE dni = '{0}'", dni);
				SqlCommand cmd = new SqlCommand(query, conector);
				conector.Open();
				SqlDataReader registro = cmd.ExecuteReader();

				while (registro.Read())
				{
					id = Int16.Parse(registro["id_cliente"].ToString());
					return id;
				}
				return id;
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message);
				return id;
			}

		}

		private void dgvVistaCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			AuxiliarDni = Convert.ToString(dgvVistaCliente.CurrentRow.Cells["DNI/CUIT/CUIL"].Value);
			btnEditar.Enabled = true;
			btnEliminar.Enabled = true;
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			tbDni.Text = Convert.ToString(dgvVistaCliente.CurrentRow.Cells["DNI/CUIT/CUIL"].Value);
			tbNombre.Text = Convert.ToString(dgvVistaCliente.CurrentRow.Cells["Nombre"].Value);
			tbDireccion.Text = Convert.ToString(dgvVistaCliente.CurrentRow.Cells["Direccion"].Value);
			tbTelefono.Text = Convert.ToString(dgvVistaCliente.CurrentRow.Cells["Telefono"].Value);
			Editar = true;
			btnEditar.Enabled = false;
		}

		private void tbBuscarCliente_TextChanged(object sender, EventArgs e)
		{
			if (rbNombre.Checked)
			{
				NCliente.BuscarPorNombre(dgvVistaCliente, tbBuscarCliente.Text);
			}else if (rbDni.Checked)
			{
				NCliente.BuscarPorDni(dgvVistaCliente, tbBuscarCliente.Text);
			}

			
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			MessageBox.Show(NCliente.Eliminar(Convert.ToInt32(AuxiliarDni)));
			Mostrar();
		}

		private void FrmClientes_FormClosing(object sender, FormClosingEventArgs e)
		{
			FrmPrincipal.abiertoFrmClientes = false;
		}
	}
}
