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
	public class DProveedor
	{

		public int Id_Proveedor { get; set; }
		public string Nombre { get; set; }
		public string Contacto { get; set; }

		Conexion conexion = new Conexion();

		public DProveedor()
		{

		}

		public DProveedor(int id, string nombre, string contacto)
		{
			Id_Proveedor = id;
			Nombre = nombre;
			Contacto = contacto;
		}

		public string Insertar(DProveedor proveedor)
		{
			string rpta = "";
			string query = "INSERT INTO Proveedor (nombre,contacto) VALUES (@nombre,@contacto)";

			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("nombre", proveedor.Nombre));
				cmd.Parameters.Add(new SqlParameter("contacto", proveedor.Contacto));
				conector.Open();
				rpta = cmd.ExecuteNonQuery() == 1 ? "Proveedor cargado correctamente" : "Error en la carga de proveedor";
				conector.Close();
				Console.WriteLine(rpta);
				return rpta;

			}
			catch (SqlException ex)
			{
				return rpta = ex.Message;
			}

		}
		public string Editar(DProveedor proveedor)
		{
			string rpta = "";
			string query = "UPDATE Proveedor SET nombre = @nombre, contacto = @contacto WHERE id_proveedor = @id_proveedor";

			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("nombre", proveedor.Nombre));
				cmd.Parameters.Add(new SqlParameter("contacto", proveedor.Contacto));
				cmd.Parameters.Add(new SqlParameter("id_proveedor", proveedor.Id_Proveedor));
				conector.Open();
				rpta = cmd.ExecuteNonQuery() == 1 ? "Proveedor editado correctamente" : "Error en editar proveedor";
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
			String sql = "SELECT nombre AS Nombre, contacto AS Contacto from Proveedor";
			SqlConnection conector = new SqlConnection(conexion.strConexion);
			conector.Open();
			SqlDataAdapter da = new SqlDataAdapter(sql, conector);
			da.Fill(dtRes);
			dgv.DataSource = dtRes;
			conector.Close();
		}
		public void BuscarPorNombre(DataGridView dgv, string nombre_proveedor)
		{
			SqlConnection conector = new SqlConnection(conexion.strConexion);
			conector.Open();
			String sql = "SELECT nombre AS Nombre, contacto AS Contacto from Proveedor WHERE nombre LIKE @nombre";
			SqlCommand cmd = new SqlCommand(sql, conector);
			cmd.Parameters.Add(new SqlParameter("@nombre", "%" + nombre_proveedor + "%"));
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dtRes = new DataTable("Proveedor");
			da.Fill(dtRes);
			dgv.DataSource = dtRes;
			conector.Close();

		}
		public string Eliminar(int id_proveedor)
		{
			string rpta = "";
			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				string query = "DELETE FROM Proveedor WHERE id_proveedor = @id_proveedor";
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("@id_proveedor", id_proveedor));
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
				string query = "SELECT nombre FROM Proveedor WHERE nombre LIKE @nombre";
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

