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
	public partial class FrmFacturacion : Form , IContract
	{
		public string UsuarioNombre { get; set; }
		public static string CodigoAuxiliar { get; set; }
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
			
		}

		private void tbCodigoProd_TextChanged(object sender, EventArgs e)
		{

		}

		private void tbDescripcion_KeyPress(object sender, KeyPressEventArgs e)
		{

			if ((int)e.KeyChar == (int)Keys.Enter)
			{

			}
		}

		private void btnBuscarDescr_Click(object sender, EventArgs e)
		{
			VistaProductosFacturacion vista = new VistaProductosFacturacion();
			vista.Contrato = this;
			vista.ShowDialog();
		}

		public void EnviarDatos(string codigo)
		{
			tbCodigoProd.Text = codigo;
		}
		public static int cont_fila = 0;
		public static double total = 0;
		private void btnColocar_Click(object sender, EventArgs e)
		{
			try
			{
					if (tbCantidad.Text != string.Empty)
					{
						string query = string.Format("SELECT codigo,nombre, precio_venta FROM Producto WHERE codigo LIKE {0}", tbCodigoProd.Text);

						DataSet ds = Utilidades.Ejecutar(query);

						string codigo = ds.Tables[0].Rows[0]["codigo"].ToString();
						string descripcion = ds.Tables[0].Rows[0]["nombre"].ToString();
						string precio = ds.Tables[0].Rows[0]["precio_venta"].ToString();

						bool existe = false;
						int num_fila = 0;

						if (cont_fila == 0)
						{

							dgvFacturacion.Rows.Add(codigo, descripcion, precio, tbCantidad.Text);

							double importe = Convert.ToDouble(dgvFacturacion.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dgvFacturacion.Rows[cont_fila].Cells[3].Value);
							dgvFacturacion.Rows[cont_fila].Cells[4].Value = importe;

							cont_fila++;
						}
						else
						{
							foreach (DataGridViewRow fila in dgvFacturacion.Rows)
							{
								if (fila.Cells[0].Value.ToString() == tbCodigoProd.Text)
								{
									existe = true;
									num_fila = fila.Index;
								}

							}
							if (existe)
							{
								dgvFacturacion.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(tbCantidad.Text) + Convert.ToDouble(dgvFacturacion.Rows[num_fila].Cells[3].Value)).ToString();
								double importe = Convert.ToDouble(dgvFacturacion.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dgvFacturacion.Rows[num_fila].Cells[3].Value);

								dgvFacturacion.Rows[num_fila].Cells[4].Value = importe;
							}
							else
							{
								dgvFacturacion.Rows.Add(codigo, descripcion, precio, tbCantidad.Text);

								double importe = Convert.ToDouble(dgvFacturacion.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dgvFacturacion.Rows[cont_fila].Cells[3].Value);
								dgvFacturacion.Rows[cont_fila].Cells[4].Value = importe;

								cont_fila++;
							}
						}
					total = 0;
					foreach (DataGridViewRow fila in dgvFacturacion.Rows)
					{
						total += Convert.ToDouble(fila.Cells[4].Value);
					}
					lblTotal.Text = "$ "+total.ToString();



				}//,"110","100"
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				//DialogResult dialogResult = MessageBox.Show("Usuario no encontrado, ¿Desea agregar uno nuevo?", "", MessageBoxButtons.YesNo);
				//if (dialogResult == DialogResult.Yes)
				//{
				//	FrmClientes frm = new FrmClientes();
				//	frm.ShowDialog();
				//}
				//else if (dialogResult == DialogResult.No)
				//{
				//	tbDniCliente.Clear();
				//}
			}
		}

		private void BtnEliminar_Click(object sender, EventArgs e)
		{
			if(cont_fila > 0)
			{
				total = total - (Convert.ToDouble(dgvFacturacion.Rows[dgvFacturacion.CurrentRow.Index].Cells[4].Value));
				lblTotal.Text = "$ " + total.ToString();

				dgvFacturacion.Rows.RemoveAt(dgvFacturacion.CurrentRow.Index);

				cont_fila--;
			}
		}

		private void btnClientes_Click(object sender, EventArgs e)
		{
			FrmClientes frm = new FrmClientes();
			frm.ShowDialog();
		}
	}
}
