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
	public partial class VistaProductosFacturacion : Form
	{
		public IContract Contrato { get; set; }

		public VistaProductosFacturacion()
		{
			InitializeComponent();
		}

		private void tbBuscarProductosFacturacion_TextChanged(object sender, EventArgs e)
		{
			NProducto.BuscarPorNombreFacturacion(dgvVistaProdFact, tbBuscarProductosFacturacion.Text);
		}

		private void VistaProductosFacturacion_Load(object sender, EventArgs e)
		{
			NProducto.MostrarFacturacion(dgvVistaProdFact);
		}

		private void dgvVistaProdFact_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Contrato.EnviarDatos(Convert.ToString(dgvVistaProdFact.CurrentRow.Cells["Codigo"].Value));
			this.Close();
		}
	}
}
