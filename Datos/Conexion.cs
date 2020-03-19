using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace Datos
{
	public class Conexion
	{
		string server;
		string database;
		string userId;
		string password;
		public string strConexion;
		//"server = 192.168.1.6 ; database = Prueba ; user Id = EscritorioServer ; Password = adrian97"
		public Conexion()
		{
			try
			{
				string[] lineas = File.ReadAllLines(Application.StartupPath + "/DataBaseConnection.txt");
				server = lineas[0];
				database = lineas[1];
				userId = lineas[2];
				password = lineas[3];
				strConexion = string.Format("server = {0} ; database = {1} ; user Id = {2} ; Password = {3}", server, database,userId,password);
			}
			catch (IOException ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
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
