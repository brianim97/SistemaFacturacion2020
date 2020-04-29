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
	public partial class FrmReporte : Form
	{
		public FrmReporte()
		{
			InitializeComponent();
		}

		private void FrmReporte_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'DataSet1.DatosFactura' table. You can move, or remove it, as needed.
			//this.DatosFacturaTableAdapter.Fill(this.DataSet1.DatosFactura);
			// TODO: This line of code loads data into the 'DataSet1.DatosFactura' table. You can move, or remove it, as needed.
			//	this.DatosFacturaTableAdapter.Fill(this.DataSet1.DatosFactura);

			this.reportViewer1.RefreshReport();
		}
	}
}
