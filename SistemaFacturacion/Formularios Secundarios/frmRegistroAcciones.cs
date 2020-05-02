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

namespace SistemaFacturacion.Formularios_Secundarios
{
	public partial class frmRegistroAcciones : Form
	{
		public frmRegistroAcciones()
		{
			InitializeComponent();
		}

		private void frmRegistroAcciones_Load(object sender, EventArgs e)
		{
			NRegistro_Acciones.Mostrar(dgvRegistroAcciones);
		}

		private void frmRegistroAcciones_FormClosing(object sender, FormClosingEventArgs e)
		{
			FrmPrincipal.abiertoFrmRegistro = false;
		}
	}
}
