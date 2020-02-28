using Negocio;
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
	public partial class FrmVistaStock : Form
	{
		public FrmVistaStock()
		{
			InitializeComponent();
		}

		private void FrmVistaStock_Load(object sender, EventArgs e)
		{
			Mostrar();
		}
		private void Mostrar()
		{
			NProducto.Mostrar(dgvVistaStock);
			lblTotalRegistros.Text = "Registros: " + dgvVistaStock.Rows.Count.ToString();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			NProducto.BuscarPorNombre(dgvVistaStock, tbBuscarProducto.Text);
		}
		
	}
}
