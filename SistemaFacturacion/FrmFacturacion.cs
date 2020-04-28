using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion
{
	public partial class FrmFacturacion : Form , IContract,IContractCliente
	{
		public static string CodigoAuxiliar { get; set; }
		
		public FrmFacturacion()
		{
			InitializeComponent();
		}

		private void FrmFacturacion_Load(object sender, EventArgs e)
		{
			lblAtiende.Text = FrmPrincipal.NombreUsuario;

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
		public int cont_fila = 0;
		public double total = 0;
		private void btnColocar_Click(object sender, EventArgs e)
		{
			if(tbCodigoProd.Text == string.Empty)
			{
				MessageBox.Show("Debe Ingresar un Codigo de Producto Primero!");
				return;
			}
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

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				
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

		

		

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void FrmFacturacion_FormClosing(object sender, FormClosingEventArgs e)
		{
			FrmPrincipal.abiertoFrmFacturacion = false;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			frmProducto frm = new frmProducto();
			frm.ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Nuevo();
		}
		private void Nuevo()
		{
			lblClienteNombre.Text = "";
			tbCodigoProd.Clear();
			tbDniCliente.Clear();
			dgvFacturacion.Rows.Clear();
			lblTotal.Text = "";
		}

		private void btnClientes_Click_1(object sender, EventArgs e)
		{
			FrmClientes frm = new FrmClientes();
			frm.ShowDialog();
		}

		private void btnBuscarClientes_Click(object sender, EventArgs e)
		{
			VistaClientesFacturacion vista = new VistaClientesFacturacion();
			vista.Contrato = this;
			vista.ShowDialog();
		}

		public void EnviarDatosCliente(string dni)
		{
			tbDniCliente.Text = dni;
			EnterBusquedaCliente();

		}
		private void EnterBusquedaCliente()
		{
			try
			{
					string query = string.Format("SELECT nombre FROM Cliente WHERE dni LIKE {0}", tbDniCliente.Text);

					DataSet ds = Utilidades.Ejecutar(query);

					lblClienteNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
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

		private void btnFacturar_Click(object sender, EventArgs e)
		{
			if(cont_fila != 0)
			{
				try
				{
					string cmd = string.Format("Exec ActualizarFacturas '{0}'", 3);
					DataSet ds = Utilidades.Ejecutar(cmd);
					string num_factura = ds.Tables[0].Rows[0]["num_factura"].ToString().Trim();

		

					foreach (DataGridViewRow fila in dgvFacturacion.Rows)
					{
						cmd = string.Format("Exec ActualizarDetalles '{0}','{1}','{2}','{3}','{4}'", Convert.ToInt32(num_factura),Convert.ToInt32(fila.Cells[0].Value.ToString()), fila.Cells[2].Value.ToString(),fila.Cells[3].Value.ToString(), fila.Cells[4].Value.ToString());
						ds = Utilidades.Ejecutar(cmd);
						//Convert.ToDouble(fila.Cells[2].Value.ToString()) Convert.ToDouble(fila.Cells[4].Value.ToString())
					}
					cmd = "Exec DatosFactura " + num_factura;
					ds = Utilidades.Ejecutar(cmd);

					FrmReporte rp = new FrmReporte();
					rp.reportViewer1.LocalReport.DataSources[0].Value = ds.Tables[0];
					
					rp.ShowDialog();
					Nuevo();
					cont_fila = 0;
				}
				catch (SqlException ex)
				{

					MessageBox.Show(ex.Message);
				}
			}
			
		}
	}
}
