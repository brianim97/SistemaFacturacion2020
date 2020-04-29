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
	public partial class VistaClientesFacturacion : Form
	{
		public IContractCliente Contrato { get; set; }
		public VistaClientesFacturacion()
		{
			InitializeComponent();
		}

		private void tbBuscarClientesFacturacion_TextChanged(object sender, EventArgs e)
		{
			if (rbNombre.Checked)
				NCliente.BuscarPorNombre(dgvVistaClienteFact, tbBuscarClientesFacturacion.Text);
			else if(rbDNI.Checked)
				NCliente.BuscarPorDni(dgvVistaClienteFact, tbBuscarClientesFacturacion.Text);
		}

		private void dgvVistaClienteFact_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Contrato.EnviarDatosCliente(Convert.ToString(dgvVistaClienteFact.CurrentRow.Cells["DNI/CUIT/CUIL"].Value));
			this.Close();
		}

		private void VistaClientesFacturacion_Load(object sender, EventArgs e)
		{
			Mostrar();
		}
		private void Mostrar()
		{
			NCliente.Mostrar(dgvVistaClienteFact);
		}
	}
}
