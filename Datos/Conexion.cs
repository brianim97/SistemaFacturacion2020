using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Datos
{
	public class Conexion
	{
		public string strConexion = "server = 192.168.1.6 ; database = Prueba ; user Id = Admin ; Password = Admin";
		public void conexionDB()
		{
			try
			{
				SqlConnection conexion = new SqlConnection(strConexion);
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
			

			
		}
		
	}
}
