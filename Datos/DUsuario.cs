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
	public class DUsuario
	{
		public int Id_Usuario { get; set; }
		public string Nombre { get; set; }
		public string Contraseña { get; set; }
		public string Account { get; set; }

		Conexion conexion = new Conexion();

		public DUsuario()
		{

		}

		public DUsuario(int id, string nombre, string contraseña,string account)
		{
			Id_Usuario = id;
			Nombre = nombre;
			Contraseña = contraseña;
			Account = account;
		}
		public string Insertar(DUsuario usuario)
		{
			string rpta = "";
			string query = "INSERT INTO Usuarios (name, password,account) VALUES (@name,@password,@account)";

			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("name", usuario.Nombre));
				cmd.Parameters.Add(new SqlParameter("password", usuario.Contraseña));
				cmd.Parameters.Add(new SqlParameter("account", usuario.Account));
				conector.Open();
				rpta = cmd.ExecuteNonQuery() == 1 ? "Usuario cargado correctamente" : "Error en la carga de usuario";
				conector.Close();
				Console.WriteLine(rpta);
				return rpta;

			}
			catch (SqlException ex)
			{
				return rpta = ex.Message;
			}

		}
		public string Editar(DUsuario usuario)
		{
			string rpta = "";
			string query = "UPDATE Usuarios SET name = @name, password = @password, account = @account WHERE id_usuario = @id_usuario";

			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("name", usuario.Nombre));
				cmd.Parameters.Add(new SqlParameter("password", usuario.Contraseña));
				cmd.Parameters.Add(new SqlParameter("account", usuario.Account));
				cmd.Parameters.Add(new SqlParameter("id_usuario", usuario.Id_Usuario));
				conector.Open();
				rpta = cmd.ExecuteNonQuery() == 1 ? "Usuario editado correctamente" : "Error en editar usuario";
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
			String sql = "SELECT name AS Nombre, password AS Contraseña, Account AS 'Nivel de Acceso' from Usuarios";
			SqlConnection conector = new SqlConnection(conexion.strConexion);
			conector.Open();
			SqlDataAdapter da = new SqlDataAdapter(sql, conector);
			da.Fill(dtRes);
			dgv.DataSource = dtRes;
			conector.Close();
		}
		public void BuscarPorNombre(DataGridView dgv, string nombre_usuario)
		{
			SqlConnection conector = new SqlConnection(conexion.strConexion);
			conector.Open();
			String sql = "SELECT name AS Nombre, password AS Contraseña, Account AS Nivel de Acceso from Usuarios WHERE name LIKE @name";
			SqlCommand cmd = new SqlCommand(sql, conector);
			cmd.Parameters.Add(new SqlParameter("@name", "%" + nombre_usuario + "%"));
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dtRes = new DataTable("Usuario");
			da.Fill(dtRes);
			dgv.DataSource = dtRes;
			conector.Close();

		}
		public string Eliminar(int id_usuario)
		{
			string rpta = "";
			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				string query = "DELETE FROM Usuarios WHERE id_usuario = @id_usuario";
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("@id_usuario", id_usuario));
				conector.Open();
				rpta = cmd.ExecuteNonQuery() == 1 ? "Registro Eliminado Correctamente" : "ERROR: no se elimino el registro";
				conector.Close();
			}
			catch (SqlException ex)
			{
				rpta = ex.Message;
			}
			return rpta;
		}
		public bool NombreExistente(string nombreNuevo)
		{
			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				string query = "SELECT name FROM Usuarios WHERE name LIKE @name";
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("@name", nombreNuevo));
				conector.Open();
				SqlDataReader registros = cmd.ExecuteReader();
				while (registros.Read())
				{
					conector.Close();
					return true;
				}
				conector.Close();
				return false;
			}
			catch (SqlException ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}

	}
}

