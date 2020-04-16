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
	public class DCliente
	{
		public int Id { get; set; }
		public string Dni { get; set; }
		public string Nombre { get; set; }
		public string  Direccion { get; set; }
		public string Telefono { get; set; }

		Conexion conexion = new Conexion();

		public DCliente()
		{

		}

		public DCliente(int id, string dni, string nombre, string direccion, string telefono)
		{
			Id = id;
			Dni = dni;
			Nombre = nombre;
			Direccion = direccion;
			Telefono = telefono;
		}

		public string Insertar(DCliente cliente)
		{
			string rpta = "";
			string query = "INSERT INTO Cliente (dni,nombre,direccion,telefono) VALUES (@dni,@nombre,@direccion,@telefono)";

			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("dni", cliente.Dni));
				cmd.Parameters.Add(new SqlParameter("nombre", cliente.Nombre));
				cmd.Parameters.Add(new SqlParameter("direccion", cliente.Direccion));
				cmd.Parameters.Add(new SqlParameter("telefono", cliente.Telefono));
				conector.Open();
				rpta = cmd.ExecuteNonQuery() == 1 ? "Cliente cargado correctamente" : "Error en la carga de cliente";
				conector.Close();
				Console.WriteLine(rpta);
				return rpta;

			}
			catch (SqlException ex)
			{
				return rpta = ex.Message;
			}

		}
		public string Editar(DCliente cliente)
		{
			string rpta = "";
			string query = "UPDATE Cliente SET dni = @dni, nombre = @nombre, direccion = @direccion, telefono = @telefono WHERE id_cliente = @id";

			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("dni", cliente.Dni));
				cmd.Parameters.Add(new SqlParameter("nombre", cliente.Nombre));
				cmd.Parameters.Add(new SqlParameter("direccion", cliente.Direccion));
				cmd.Parameters.Add(new SqlParameter("telefono", cliente.Telefono));
				cmd.Parameters.Add(new SqlParameter("id_cliente", cliente.Id));
				conector.Open();
				rpta = cmd.ExecuteNonQuery() == 1 ? "Cliente editado correctamente" : "Error en editar cliente";
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
			String sql = "SELECT dni AS DNI ,nombre AS Nombre, direccion AS Direccion, telefono AS Telefono from Cliente";
			SqlConnection conector = new SqlConnection(conexion.strConexion);
			conector.Open();
			SqlDataAdapter da = new SqlDataAdapter(sql, conector);
			da.Fill(dtRes);
			dgv.DataSource = dtRes;
			conector.Close();
		}
		public void BuscarPorNombre(DataGridView dgv, string nombre_cliente)
		{
			SqlConnection conector = new SqlConnection(conexion.strConexion);
			conector.Open();
			String sql = "SELECT dni AS DNI ,nombre AS Nombre, direccion AS Direccion, telefono AS Telefono from Cliente WHERE nombre LIKE @nombre";
			SqlCommand cmd = new SqlCommand(sql, conector);
			cmd.Parameters.Add(new SqlParameter("@nombre", "%" + nombre_cliente + "%"));
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dtRes = new DataTable("Cliente");
			da.Fill(dtRes);
			dgv.DataSource = dtRes;
			conector.Close();

		}
		public void BuscarPorDni(DataGridView dgv, string dni_cliente)
		{
			SqlConnection conector = new SqlConnection(conexion.strConexion);
			conector.Open();
			String sql = "SELECT dni AS DNI ,nombre AS Nombre, direccion AS Direccion, telefono AS Telefono from Cliente WHERE dni LIKE @dni";
			SqlCommand cmd = new SqlCommand(sql, conector);
			cmd.Parameters.Add(new SqlParameter("@dni", "%" + dni_cliente + "%"));
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dtRes = new DataTable("Cliente");
			da.Fill(dtRes);
			dgv.DataSource = dtRes;
			conector.Close();

		}
		public string Eliminar(int dni)
		{
			string rpta = "";
			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				string query = "DELETE FROM Cliente WHERE dni = @dni";
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("@id", dni));
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
		public bool DniExistente(string dniNuevo)
		{
			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				string query = "SELECT dni FROM Cliente WHERE dni LIKE @dni";
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("@dni", dniNuevo));
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
}
