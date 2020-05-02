using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
	public class DRegistro_Acciones
	{
		public int Id { get; set; }
		public string Accion_text { get; set; }
		#region Constructores
		public DRegistro_Acciones()
		{

		}

		public DRegistro_Acciones(int id, string accion_text)
		{
			this.Id = id;
			this.Accion_text = accion_text;
		}
		#endregion

		Conexion conexion = new Conexion();

		#region Metodos
		public string Insertar(string registro)
		{
			string rpta = "";
			string query = "INSERT INTO Registro_Acciones (accion_text) VALUES (@accion_text)";

			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("@accion_text", registro));
				conector.Open();
				rpta = cmd.ExecuteNonQuery() == 1 ? "Accion cargada correctamente" : "Error en la carga de accion";
				conector.Close();
				Console.WriteLine(rpta);
				return rpta;

			}
			catch (SqlException ex)
			{
				return rpta = ex.Message;
			}

		}

		public void Mostrar(DataGridView dgv)
		{
			DataTable dtRes = new DataTable();
			String sql = "SELECT accion_text AS Registro from Registro_Acciones";
			SqlConnection conector = new SqlConnection(conexion.strConexion);
			conector.Open();
			SqlDataAdapter da = new SqlDataAdapter(sql, conector);
			da.Fill(dtRes);
			dgv.DataSource = dtRes;
			conector.Close();
		}
		#endregion



	}
}
