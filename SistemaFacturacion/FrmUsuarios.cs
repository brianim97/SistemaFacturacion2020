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
	public partial class FrmUsuarios : Form
	{
		public FrmUsuarios()
		{
			InitializeComponent();
		}

		private void FrmUsuarios_Load(object sender, EventArgs e)
		{
			HabilitarCampos(false);
			HabilitarGuardarLimpiar(false);
			HablitiarEliminarEditar(false);
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			HabilitarCampos(true);
			HabilitarGuardarLimpiar(true);
		}
		private void btnEditar_Click(object sender, EventArgs e)
		{

		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{

		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{

		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			ComprobarCampos();
		}

		private void tbBuscarUsuario_TextChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{

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
		private void HablitiarEliminarEditar(bool value)
		{
			btnEliminar.Enabled = value;
			btnEditar.Enabled = value;
		}
		private bool ComprobarCampos()
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
			if(rpta == "")
			{
				return true;
			}
			else
			{
				MessageBox.Show(rpta);
				return false;
			}

		}
	}
}
