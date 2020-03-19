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
	public partial class FrmUsuarios : Form
	{
		public FrmUsuarios()
		{
			InitializeComponent();
		}
		bool Editar = false;
		string AuxiliarNombre = "";
		string AuxnivelAcceso;

		private void FrmUsuarios_Load(object sender, EventArgs e)
		{
			HabilitarCampos(false);
			HabilitarGuardarLimpiar(false);
			HabilitarEliminarEditar(false);
			Mostrar();

		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			HabilitarCampos(true);
			HabilitarGuardarLimpiar(true);

		}
		private void btnEditar_Click(object sender, EventArgs e)
		{
			tbUsuario.Text = Convert.ToString(dgvUsuarios.CurrentRow.Cells["Nombre"].Value);
			tbContraseña.Text = Convert.ToString(dgvUsuarios.CurrentRow.Cells["Contraseña"].Value);
			cbNivelAcceso.Text = Convert.ToString(dgvUsuarios.CurrentRow.Cells["Nivel de Acceso"].Value);
			HabilitarEliminarEditar(false);
			HabilitarCampos(true);
			HabilitarGuardarLimpiar(true);
			Editar = true;
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if(AuxnivelAcceso != "administrador")
			{
				HabilitarEliminarEditar(false);
				DialogResult result = MessageBox.Show(string.Format("¿Esta seguro de eliminar '{0}' permamentemente? ", AuxiliarNombre), "Advertencia!", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					MessageBox.Show(NUsuario.Eliminar(Obtener_Id(AuxiliarNombre)));
					Mostrar();
				}
			}
			else
			{
				MessageBox.Show("Por motivos de seguridad no esta permitido ELIMINAR un usuario con nivel de ADMINISTRADOR!");
			}
			
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			Limpiar_Campos();
			Editar = false;
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (Editar == true)
			{
				if (Comprobar_Campos())
				{
					if (Obtener_Id(AuxiliarNombre) == 0)
					{
						MessageBox.Show("Error: id no encontrado!");
					}
					else
					{
						if (AuxiliarNombre == tbUsuario.Text)
						{
							MessageBox.Show(NUsuario.Editar(Obtener_Id(tbUsuario.Text), tbUsuario.Text, tbContraseña.Text, cbNivelAcceso.Text));
							Limpiar_Campos();
							Editar = false;
							HabilitarCampos(false);
							HabilitarGuardarLimpiar(false);
						}
						else if (NombreExistente(tbUsuario.Text))
						{
							MessageBox.Show(string.Format("Error: el nombre '{0}' ya se encuentra en uso!", tbUsuario.Text));
						}
						else
						{
							MessageBox.Show(NUsuario.Editar(Obtener_Id(AuxiliarNombre), tbUsuario.Text, tbContraseña.Text, cbNivelAcceso.Text));
							Limpiar_Campos();
							Editar = false;
							HabilitarCampos(false);
							HabilitarGuardarLimpiar(false);
						}

					}

				}
				else
				{
				
				}
			}
			else
			{
				if (Comprobar_Campos())
				{
					if (NombreExistente(tbUsuario.Text))
					{
						MessageBox.Show(string.Format("Error: el nombre '{0}' ya se encuentra en uso!", tbUsuario.Text));
					}
					else
					{
						MessageBox.Show(NUsuario.Insertar(tbUsuario.Text, tbContraseña.Text, cbNivelAcceso.Text));
						Limpiar_Campos();
						HabilitarCampos(false);
						HabilitarGuardarLimpiar(false);
					}

				}
				else
				{
					Comprobar_Campos();
				}

			}
			Mostrar();
		}
	

		private void tbBuscarUsuario_TextChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			HabilitarEliminarEditar(true);
			AuxiliarNombre = Convert.ToString(dgvUsuarios.CurrentRow.Cells["Nombre"].Value);
			AuxnivelAcceso = Convert.ToString(dgvUsuarios.CurrentRow.Cells["Nivel de Acceso"].Value);

		}
		private void HabilitarCampos(bool value)
		{
			tbContraseña.Enabled = value;
			tbUsuario.Enabled = value;
			cbNivelAcceso.Enabled = value;
		}
		private void HabilitarGuardarLimpiar(bool value)
		{
			btnGuardar.Enabled = value;
			btnLimpiar.Enabled = value;
		}
		private void HabilitarEliminarEditar(bool value)
		{
			btnEliminar.Enabled = value;
			btnEditar.Enabled = value;
		}
		private bool Comprobar_Campos()
		{
			string rpta = "";
			if(tbUsuario.Text == string.Empty)
			{
				rpta += "El campo 'Usuario' no puede estar vacio\n";
			}
			if (tbContraseña.Text == string.Empty)
			{
				rpta += "El campo 'Contraseña' no puede estar vacio\n";
			}
			if (cbNivelAcceso.Text == string.Empty)
			{
				rpta += "El campo 'Nivel de Acceso' no puede estar vacio\n";
			}
			if (rpta == "")
			{
				return true;
			}
			else
			{
				MessageBox.Show(rpta);
				return false;
			}

		}
		private int Obtener_Id(string nombre)
		{
			int id = 0;
			try
			{
				Conexion conexion = new Conexion();
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				string query = string.Format("SELECT id_usuario FROM Usuarios WHERE name = '{0}'", nombre);
				SqlCommand cmd = new SqlCommand(query, conector);
				conector.Open();
				SqlDataReader registro = cmd.ExecuteReader();
				while (registro.Read())
				{
					id = Int16.Parse(registro["id_usuario"].ToString());
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
		private void Limpiar_Campos()
		{
			tbUsuario.Clear();
			tbContraseña.Clear();
			cbNivelAcceso.ResetText();
		}
		private bool NombreExistente(string nombre)
		{
			return NUsuario.NombreExistente(nombre);
		}
		private void Mostrar()
		{
			NUsuario.Mostrar(dgvUsuarios);
		}
	}
}
