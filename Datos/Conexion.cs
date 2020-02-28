using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
	public class Conexion
	{
		public string strConexion = "server = DESKTOP-0GEH8R9\\SQLEXPRESS ; database = Prueba ; integrated security = true";
		public void conexionDB()
		{
			SqlConnection conexion = new SqlConnection(strConexion);

			
		}
		
	}
}
