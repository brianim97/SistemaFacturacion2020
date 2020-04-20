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
	public class Utilidades
	{
		public static DataSet Ejecutar(string query)
		{
			DataSet ds = new DataSet();
			try
			{
				Conexion conexion = new Conexion();
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				conector.Open();
				SqlDataAdapter da = new SqlDataAdapter(query, conector);
				da.Fill(ds);
				conector.Close();
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
			return ds;
		}
	}
}
