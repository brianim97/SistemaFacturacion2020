using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion
{
	public partial class frmMantenimiento : Form
	{
		public frmMantenimiento()
		{
			InitializeComponent();
		}
		SqlConnection cn = new SqlConnection(Conexion.copystrConexion);
		string DataBase = Conexion.dataBaseMantenimiento;

		private void frmMantenimiento_Load(object sender, EventArgs e)
		{
			btnRealizarBackup.Enabled = false;
			btnRealizarRestore.Enabled = false;
		}

		private void btnBuscarBackup_Click(object sender, EventArgs e)
		{

			FolderBrowserDialog dlg = new FolderBrowserDialog();
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				tbUbicacionBackup.Text = dlg.SelectedPath;
				btnRealizarBackup.Enabled = true;
			}
		}

		private void btnBuscarRestore_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "SQL SERVER database backup files|*.bak";
			dlg.Title = "Database restore";
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				tbUbicacionRestore.Text = dlg.FileName;
				btnRealizarRestore.Enabled = true;
			}
		}

		private void btnRealizarBackup_Click(object sender, EventArgs e)
		{
			{
				try
				{
					if (tbUbicacionBackup.Text == string.Empty)
					{
						MessageBox.Show("Por favor ingrese la ubicación del archivo de respaldo");
					}
					else
					{
						string query = "BACKUP DATABASE [" + DataBase + "] TO DISK=N'" + tbUbicacionBackup.Text + "\\" + "SistemaWakedb" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
						SqlCommand cmd = new SqlCommand(query, cn);
						cn.Open();
						cmd.ExecuteNonQuery();
						cn.Close();
						MessageBox.Show("Backup Creado Correctamente");
						tbUbicacionBackup.Clear();
						btnRealizarBackup.Enabled = false;
					}
					}
				catch(Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
		}

		private void frmMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
		{
			FrmPrincipal.abiertoFrmMantenimiento = false;
		}

		private void btnRealizarRestore_Click(object sender, EventArgs e)
		{
		
			try
			{
				if (tbUbicacionRestore.Text == string.Empty)
				{
					MessageBox.Show("Por favor ingrese la ubicación del archivo de respaldo");
				}
				else
				{
					cn.Open();
					string sqlStmt2 = string.Format("ALTER DATABASE [" + DataBase + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
					SqlCommand bu2 = new SqlCommand(sqlStmt2, cn);
					bu2.ExecuteNonQuery();

					string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + DataBase + "] FROM DISK='" + tbUbicacionRestore.Text + "'WITH REPLACE;";
					SqlCommand bu3 = new SqlCommand(sqlStmt3, cn);
					bu3.ExecuteNonQuery();

					string sqlStmt4 = string.Format("ALTER DATABASE [" + DataBase + "] SET MULTI_USER");
					SqlCommand bu4 = new SqlCommand(sqlStmt4, cn);
					bu4.ExecuteNonQuery();

					MessageBox.Show("Restauración de la base de datos hecha exitosamente");
					cn.Close();
					tbUbicacionRestore.Clear();
					btnRealizarRestore.Enabled = false;

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		
	}
}
