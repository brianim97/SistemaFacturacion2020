﻿using System;
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
	public partial class MDIParent1 : Form
	{
		public string NombreUsuario { get; set; }
		
		public string TipoUsuario = "";

		public MDIParent1()
		{
			InitializeComponent();
		}

		private void ShowNewForm(object sender, EventArgs e)
		{
		
		}

		private void OpenFile(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = openFileDialog.FileName;
			}
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = saveFileDialog.FileName;
			}
		}

		private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (Form childForm in MdiChildren)
			{
				childForm.Close();
			}
		}

		private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmProducto frm = new frmProducto();
			frm.MdiParent = this;
			frm.Show();
		}

		private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
			Console.WriteLine("se toco el boton Categorias");
		}

		private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmProveedores frm = new FrmProveedores(); ;
			frm.MdiParent = this;
			frm.Show();
		}

		private void MDIParent1_Load(object sender, EventArgs e)
		{
		}

		private void loginToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmLogin frm = new FrmLogin();
			frm.MdiParent = this;
			frm.Show();
		}

		private void MDIParent1_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

		private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmLogin frm = new FrmLogin();
			frm.Show();
			this.Close();
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmUsuarios frm = new FrmUsuarios();
			frm.MdiParent = this;
			frm.Show();
		}

		private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmClientes frm = new FrmClientes();
			frm.MdiParent = this;
			frm.Show();
		}

		private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmFacturacion frm = new FrmFacturacion();
			frm.UsuarioNombre = NombreUsuario;
			frm.MdiParent = this;
			frm.Show();
		}

		private void btnCategorias_Click(object sender, EventArgs e)
		{
			FrmCategoria frm = new FrmCategoria();
			frm.MdiParent = this;
			frm.Show();
		}

		private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}
	}
}
