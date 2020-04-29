using Datos;
using ExcelDataReader;
using Negocio;
using NMemory.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace SistemaFacturacion
{
	public partial class frmMantenimiento : Form
	{
		public Byte[] Logo { get; set; }
		public frmMantenimiento()
		{
			InitializeComponent();
		}
		List<string> AuxCategorias = new List<string>();
		List<string> AuxProveedores = new List<string>();
		List<ProductoImport> prodImports = new List<ProductoImport>();
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
			int CC = 0;
			int CP = 0;
			string rpta = "";
			try
			{
				if((AuxCategorias.Count > 0) || (AuxProveedores.Count > 0))
				{
					if (AuxCategorias.Count > 0)
					{
						for (int i = 0; i < AuxCategorias.Count; i++)
						{
							NCategoria.Eliminar(Obtener_Id_Categoria(AuxCategorias[i]));
							CC++;

						}
						rpta += string.Format("Se eliminaron {0} categorias pre-importadas.\n", CC);
					}
					if (AuxProveedores.Count > 0)
					{
						for (int i = 0; i < AuxProveedores.Count; i++)
						{
							NProveedor.Eliminar(Obtener_Id_Proveedor(AuxProveedores[i]));
							CP++;
						}
						rpta += string.Format("Se eliminaron {0} proveedores pre-importados.", CP);

					}
					MessageBox.Show(rpta);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
	

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

		private void btnSeleccionar_Click(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.Filter = "Archivo JPG (*.jpg)|*.jpg| Archivo PNG (*.png)|*.png| Archivo BMP (*.bmp)|*bmp";
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				//
				//Cargamos nuestro control PictureBox con el archivo de imagen seleccionado
				pbImg.Image = Image.FromFile(fileDialog.FileName);
			}
		}

		private void cbHojaExcel_SelectedIndexChanged(object sender, EventArgs e)
		{
			AuxCategorias.Clear();
			AuxProveedores.Clear();
			DataTable dt = tableCollection[cbHojaExcel.SelectedItem.ToString()];
			//dgvExcelImportar.DataSource = dt;
			try
			{
				if (dt != null)
				{
					
					for (int i = 0; i < dt.Rows.Count; i++)
					{
						ProductoImport pImp = new ProductoImport();
						pImp.Codigo = dt.Rows[i]["Codigo"].ToString();
						pImp.Nombre = dt.Rows[i]["Nombre"].ToString();
						pImp.Marca = dt.Rows[i]["Marca"].ToString();
						pImp.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
						pImp.Precio_compra = Convert.ToDecimal(dt.Rows[i]["Precio_Compra"].ToString());
						pImp.Precio_venta = Convert.ToDecimal(dt.Rows[i]["Precio_Venta"].ToString());
						if (NCategoria.NombreExistente(dt.Rows[i]["Categoria"].ToString()))
						{
							pImp.Categoria = dt.Rows[i]["Categoria"].ToString();
						}
						else
						{
							NCategoria.Insertar(dt.Rows[i]["Categoria"].ToString(),"");
							AuxCategorias.Add(dt.Rows[i]["Categoria"].ToString());
							pImp.Categoria = dt.Rows[i]["Categoria"].ToString();
						}
						if (NProveedor.NombreExistente(dt.Rows[i]["Proveedor"].ToString()))
						{
							pImp.Proveedor = dt.Rows[i]["Proveedor"].ToString();
						}
						else
						{
							NProveedor.Insertar(dt.Rows[i]["Proveedor"].ToString(), "");
							AuxProveedores.Add(dt.Rows[i]["Proveedor"].ToString());
							pImp.Proveedor = dt.Rows[i]["Proveedor"].ToString();
						}
						prodImports.Add(pImp);
					}
					MessageBox.Show("Se realizó una importacion parcial de categorias y proveedores," +
						"si no importa los datos y cierra el fomulario se eliminaran automaticamente los datos parcialmente cargados!");
					dgvExcelImportar.DataSource = prodImports;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
		DataTableCollection tableCollection;

		private void btnUbicacionImportar_Click(object sender, EventArgs e)
		{
			AuxCategorias.Clear();
			AuxProveedores.Clear();
			try
			{
				using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
				{
					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						tbUbicacionImportar.Text = openFileDialog.FileName;
						using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
						{
							using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
							{
								DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
								{
									ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
								});
								tableCollection = result.Tables;
								cbHojaExcel.Items.Clear();
								foreach (DataTable table in tableCollection)
								{
									cbHojaExcel.Items.Add(table.TableName);//agregar hoja al combobox;
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}

		private void btnImportar_Click(object sender, EventArgs e)
		{
			string rpta = "";
			int contInsertar = 0;
			int contProductosDuplicados = 0;
			try
			{
				if(cbHojaExcel.Text != string.Empty)
				{
					foreach (var item in prodImports)
					{
						if (NProducto.NombreExistente(item.Nombre))
						{
							contProductosDuplicados++;
							continue;
						}
						if (NProducto.CodigoExistente(item.Codigo))
						{
							contProductosDuplicados++;
							continue;
						}
						NProducto.Insertar(Obtener_Id_Categoria(item.Categoria), item.Nombre, item.Marca, item.Stock, item.Codigo, item.Precio_compra, item.Precio_venta, Obtener_Id_Proveedor(item.Proveedor));
						contInsertar++;
					}
					if (contInsertar > 0)
					{
						rpta += string.Format("Se importaron {0} Productos Correctamente!\n", contInsertar);
					}
					else
					{
						rpta += string.Format("Se importaron {0} Productos Correctamente!\n", contInsertar);
					}
					if (contProductosDuplicados > 0)
					{
						rpta += string.Format("Se encontraron {0} Productos coincidentes con los almacenados en la base de datos!", contProductosDuplicados);
					}
					if (rpta != string.Empty)
					{
						MessageBox.Show(rpta);
					}
					else
					{
						MessageBox.Show("No se realizaron acciones!");
					}
				}
				else
				{
					MessageBox.Show("Debe seleccionar una hoja!");
					cbHojaExcel.Focus();
				}
				
				
				
			//	DapperPlusManager.Entity<ProductoImport>().Table("Producto");
			//	List<ProductoImport> productoImports = dgvExcelImportar.DataSource as List<ProductoImport>;
			//	if(productoImports != null)
			//	{
			//		using(IDbConnection db = new SqlConnection(Conexion.copystrConexion))
			//		{
			//			db.BulkInsert(productoImports);
			//		}
			//		MessageBox.Show("Importacion Terminada");
			//	}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private int Obtener_Id_Categoria(string nombre)
		{
			int id = 0;
			try
			{
				Conexion conexion = new Conexion();
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				string query = string.Format("SELECT id_categoria FROM Categoria WHERE nombre = '{0}'", nombre);
				SqlCommand cmd = new SqlCommand(query, conector);
				conector.Open();
				SqlDataReader registro = cmd.ExecuteReader();

				while (registro.Read())
				{
					id = Int16.Parse(registro["id_categoria"].ToString());
					return id;
				}
				return id;
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message);
				return id;
			}

		}
		private int Obtener_Id_Proveedor(string nombre)
		{
			Conexion conexion = new Conexion();
			SqlConnection conector = new SqlConnection(conexion.strConexion);
			string query = string.Format("SELECT id_proveedor FROM Proveedor WHERE nombre = '{0}'", nombre);
			SqlCommand cmd = new SqlCommand(query, conector);
			conector.Open();
			SqlDataReader registro = cmd.ExecuteReader();
			int id = 0;
			while (registro.Read())
			{
				id = Int16.Parse(registro["id_proveedor"].ToString());
				return id;
			}
			return id;
		}
	}
}
