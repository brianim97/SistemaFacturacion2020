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
	public partial class FrmCategorias : Form
	{
		bool Editar = false;
		string AuxiliarNombre = "";
		public FrmCategorias()
		{
			InitializeComponent();
		}

		private void FrmCategorias_Load(object sender, EventArgs e)
		{
			Mostrar();
			btnEditar.Enabled = false;
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if(Editar == true)
			{
				if (Comprobar_Campos()==string.Empty)
				{
					if (Obtener_Id(AuxiliarNombre) == 0)
					{
						MessageBox.Show("Error: id no encontrado!");
					}
					else
					{
						if(AuxiliarNombre == tbNombreCat.Text)
						{
							MessageBox.Show(NCategoria.Editar(Obtener_Id(tbNombreCat.Text), tbNombreCat.Text, tbDescripcioCat.Text));
							Limpiar_Campos();
							Editar = false;
						}
						else if (NombreExistente(tbNombreCat.Text))
						{
							MessageBox.Show(string.Format("Error: el nombre '{0}' ya se encuentra en uso!", tbNombreCat.Text));
						}else
						{
							MessageBox.Show(NCategoria.Editar(Obtener_Id(AuxiliarNombre), tbNombreCat.Text, tbDescripcioCat.Text));
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
					if (NombreExistente(tbNombreCat.Text))
					{
						MessageBox.Show(string.Format("Error: el nombre '{0}' ya se encuentra en uso!", tbNombreCat.Text));
					}
					else
					{
						MessageBox.Show(NCategoria.Insertar(tbNombreCat.Text, tbDescripcioCat.Text));
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
			if(tbNombreCat.Text == string.Empty)
			{
				rpta += "Error: el campo 'Nombre' no puede estar vacio";
			}
			return rpta;
			
		}
		private int Obtener_Id(string nombre)
		{
			int id = 0;
			try
			{
				Conexion conexion = new Conexion();
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				string query = string.Format("SELECT id_categoria FROM Categoria WHERE nombre = '{0}'", nombre);
				SqlCommand cmd = new SqlCommand(query, conector);
				conector.Open();
				SqlDataReader registro = cmd.ExecuteReader();
				
				while (registro.Read())
				{
					id = Int16.Parse(registro["id_categoria"].ToString());
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
		private bool NombreExistente(string nombre)
		{
			return NCategoria.NombreExistente(nombre);
		}
		private void Limpiar_Campos()
		{
			tbNombreCat.Clear();
			tbDescripcioCat.Clear();
		}
		private void Mostrar()
		{
			NCategoria.Mostrar(dgvVistaCategorias);
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			Limpiar_Campos();
		}

		private void dgvVistaCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			AuxiliarNombre = Convert.ToString(dgvVistaCategorias.CurrentRow.Cells["Nombre"].Value);
			btnEditar.Enabled = true;
			
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			tbNombreCat.Text = Convert.ToString(dgvVistaCategorias.CurrentRow.Cells["Nombre"].Value);
			tbDescripcioCat.Text = Convert.ToString(dgvVistaCategorias.CurrentRow.Cells["Descripcion"].Value);
			tabCategorias.SelectedIndex = 1;
			Editar = true;
			btnEditar.Enabled = false;

		}

		private void tbVistaCategorias_TextChanged(object sender, EventArgs e)
		{
			NCategoria.BuscarPorNombre(dgvVistaCategorias, tbVistaCategorias.Text);
		}

		
	}
}
