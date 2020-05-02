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
	public class DCategoria
	{
		public int Id_Categoria { get; set; }
		public string Nombre { get; set; }
		public string Descripcion { get; set; }

		Conexion conexion = new Conexion();
		DRegistro_Acciones registro = new DRegistro_Acciones();
		public DCategoria()
		{

		}

		public DCategoria(int id,string nombre, string descripcion)
		{
			Id_Categoria = id;
			Nombre = nombre;
			Descripcion = descripcion;
		}

		public string Insertar(DCategoria categoria)
		{
			string rpta = "";
			string query = "INSERT INTO Categoria (nombre,descripcion) VALUES (@nombre,@descripcion)";

			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("nombre", categoria.Nombre));
				cmd.Parameters.Add(new SqlParameter("descripcion", categoria.Descripcion));
				conector.Open();
				rpta = cmd.ExecuteNonQuery() == 1 ? "Categoria cargada correctamente" : "Error en la carga de categoria";
				conector.Close();
				Console.WriteLine(rpta);
				registro.Insertar(rpta);
				return rpta;

			}
			catch (SqlException ex)
			{
				registro.Insertar(rpta);
				return rpta = ex.Message;
			}


		}
		public string Editar(DCategoria categoria)
		{
			string rpta = "";
			string query = "UPDATE Categoria SET nombre = @nombre, descripcion = @descripcion WHERE id_categoria = @id_categoria";

			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("nombre", categoria.Nombre));
				cmd.Parameters.Add(new SqlParameter("descripcion", categoria.Descripcion));
				cmd.Parameters.Add(new SqlParameter("id_categoria", categoria.Id_Categoria));
				conector.Open();
				rpta = cmd.ExecuteNonQuery() == 1 ? "Categoria editada correctamente" : "Error en editar categoria";
				conector.Close();
				Console.WriteLine(rpta);
				registro.Insertar(rpta);
				return rpta;

			}
			catch (SqlException ex)
			{
				registro.Insertar(rpta);
				return rpta = ex.Message;
			}

		}
		public void Mostrar(DataGridView dgv)
		{
			DataTable dtRes = new DataTable();
			String sql = "SELECT nombre AS Nombre, descripcion AS Descripcion from Categoria";
			SqlConnection conector = new SqlConnection(conexion.strConexion);
			conector.Open();
			SqlDataAdapter da = new SqlDataAdapter(sql, conector);
			da.Fill(dtRes);
			dgv.DataSource = dtRes;
			conector.Close();
		}
		public void BuscarPorNombre(DataGridView dgv, string nombre_categoria)
		{
			SqlConnection conector = new SqlConnection(conexion.strConexion);
			conector.Open();
			String sql = "SELECT nombre AS Nombre, descripcion AS Descripcion from Categoria WHERE nombre LIKE @nombre";
			SqlCommand cmd = new SqlCommand(sql, conector);
			cmd.Parameters.Add(new SqlParameter("@nombre", "%" + nombre_categoria + "%"));
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dtRes = new DataTable("Categoria");
			da.Fill(dtRes);
			dgv.DataSource = dtRes;
			conector.Close();

		}
		public string Eliminar(int id_categoria)
		{
			string rpta = "";
			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				string query = "DELETE FROM Categoria WHERE id_categoria = @id_categoria";
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("@id_categoria", id_categoria));
				conector.Open();
				rpta = cmd.ExecuteNonQuery() == 1 ? "Registro Eliminado Correctamente" : "ERROR: no se elimino el registro";
				conector.Close();
				
			}
			catch (SqlException ex)
			{
				rpta = ex.Message;
			}
			registro.Insertar(rpta);
			return rpta;
		}
		public bool NombreExistente(string nombreNuevo)
		{
			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				string query = "SELECT nombre FROM Categoria WHERE nombre LIKE @nombre";
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("@nombre", nombreNuevo));
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
