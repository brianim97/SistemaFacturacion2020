using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion
{
	public partial class FrmFacturacion : Form
	{
		public string UsuarioNombre { get; set; }
		public FrmFacturacion()
		{
			InitializeComponent();
		}

		private void FrmFacturacion_Load(object sender, EventArgs e)
		{
			lblAtiende.Text = UsuarioNombre;
		}
		private void tbDniCliente_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if ((int)e.KeyChar == (int)Keys.Enter)
				{
					string query = string.Format("SELECT nombre FROM Cliente WHERE dni LIKE {0}", tbDniCliente.Text);

					DataSet ds = Utilidades.Ejecutar(query);

					lblClienteNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
				}
			}
			catch (Exception)
			{
				DialogResult dialogResult = MessageBox.Show("Usuario no encontrado, ¿Desea agregar uno nuevo?", "",MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					FrmClientes frm = new FrmClientes();
					frm.ShowDialog();
				}
				else if (dialogResult == DialogResult.No)
				{
					tbDniCliente.Clear();
				}
			}
			
		}

		private void tbCodigoProd_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if ((int)e.KeyChar == (int)Keys.Enter)
				{
					string query = string.Format("SELECT codigo,nombre, precio_venta FROM Cliente WHERE codigo LIKE {0}", tbCodigoProd.Text);

					DataSet ds = Utilidades.Ejecutar(query);

					string codigo = ds.Tables[0].Rows[0]["codigo"].ToString();
					string descripcion = ds.Tables[0].Rows[0]["nombre"].ToString();
					string precio = ds.Tables[0].Rows[0]["precio_venta"].ToString();

					dgvFacturacion.Rows.Add(codigo, descripcion, precio);
				}
			}
			catch (Exception)
			{
				DialogResult dialogResult = MessageBox.Show("Usuario no encontrado, ¿Desea agregar uno nuevo?", "", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					FrmClientes frm = new FrmClientes();
					frm.ShowDialog();
				}
				else if (dialogResult == DialogResult.No)
				{
					tbDniCliente.Clear();
				}
			}
		}
	}
}
