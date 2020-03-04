using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
	public class Utilidades
	{
		public static DataSet Ejecutar(string query)
		{
			Conexion conexion = new Conexion();
			SqlConnection conector = new SqlConnection(conexion.strConexion);
			conector.Open();
			DataSet ds = new DataSet();
			SqlDataAdapter da = new SqlDataAdapter(query, conector);
			da.Fill(ds);
			conector.Close();
			return ds;

		}
	}
}
