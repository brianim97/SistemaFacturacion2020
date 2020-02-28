using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Datos
{
	public class DProducto { 
	
		public int Id_producto { get; set; }
		public int Id_categoria { get; set; }
		public string Nombre { get; set; }
		public string Marca { get; set; }
		public int Stock { get; set; }
		public Decimal Precio_compra { get; set; }
		public Decimal Precio_venta { get; set; }
		public DateTime Fecha_vencimiento { get; set; }
		public int Id_proveedor { get; set; }

		Conexion conexion = new Conexion();
		

		public DProducto()
		{

		}

		public DProducto(int id_producto, int id_categoria, String nombre, String marca,int stock, Decimal precio_compra, Decimal precio_venta, DateTime fecha_vencimiento, int id_proveedor)
		{
			Id_producto = Id_producto;
			Id_categoria = id_categoria;
			Nombre = nombre;
			Marca = marca;
			Stock = stock;
			Precio_compra = precio_compra;
			Precio_venta = precio_venta;
			Fecha_vencimiento = fecha_vencimiento;
			Id_proveedor = id_proveedor;
			
			
		}

		public string Insertar(DProducto producto)
		{
			string rpta = "";
			string query = "INSERT INTO Producto (id_categoria,nombre,marca,stock,precio_compra,precio_venta, fecha_vencimiento,id_proveedor) VALUES (@1,@2,@3,@4,@5,@6,@7,@8)";

			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("1", producto.Id_categoria));
				cmd.Parameters.Add(new SqlParameter("2", producto.Nombre));
				cmd.Parameters.Add(new SqlParameter("3", producto.Marca));
				cmd.Parameters.Add(new SqlParameter("4", producto.Stock));
				cmd.Parameters.Add(new SqlParameter("5", producto.Precio_compra));
				cmd.Parameters.Add(new SqlParameter("6", producto.Precio_venta));
				cmd.Parameters.Add(new SqlParameter("7", producto.Fecha_vencimiento));
				cmd.Parameters.Add(new SqlParameter("8", producto.Id_proveedor));

				conector.Open();
				rpta = cmd.ExecuteNonQuery() == 1 ? "Producto cargado correctamente" : "Error en la carga del producto";
				conector.Close();
				Console.WriteLine(rpta);
				return rpta;
				
			}
			catch (SqlException ex)
			{
				return rpta = ex.Message;
			}
			
		}
		public string Editar(DProducto producto)
		{
			string rpta = "";
			string query = "UPDATE INTO Producto SET id_categoria = @1,nombre = @2,marca = @3,stock = 4@,precio_compra = @5," +
						   "precio_venta = @6, fecha_vencimiento = @7,id_proveedor = @8";

			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("1", producto.Id_categoria));
				cmd.Parameters.Add(new SqlParameter("2", producto.Nombre));
				cmd.Parameters.Add(new SqlParameter("3", producto.Marca));
				cmd.Parameters.Add(new SqlParameter("4", producto.Stock));
				cmd.Parameters.Add(new SqlParameter("5", producto.Precio_compra));
				cmd.Parameters.Add(new SqlParameter("6", producto.Precio_venta));
				cmd.Parameters.Add(new SqlParameter("7", producto.Fecha_vencimiento));
				cmd.Parameters.Add(new SqlParameter("8", producto.Id_proveedor));

				conector.Open();
				rpta = cmd.ExecuteNonQuery() == 1 ? "Producto cargado correctamente" : "Error en la carga del producto";
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
			String sql = "SELECT Producto.nombre AS Nombre,Categoria.Nombre AS Categoria,marca AS Marca,stock AS Stock ,precio_compra AS 'Precio Compra'," +
						 "precio_venta AS 'Precio Venta',fecha_vencimiento AS 'Fecha Vencimiento',Proveedor.nombre AS Proveedor from " +
						 "Producto INNER JOIN Categoria	ON Producto.id_categoria = Categoria.id_categoria " +
					     "INNER JOIN Proveedor ON Producto.id_proveedor = Proveedor.id_proveedor";
			SqlConnection conector = new SqlConnection(conexion.strConexion);
			conector.Open();
			SqlDataAdapter da = new SqlDataAdapter(sql, conector);
			da.Fill(dtRes);
			dgv.DataSource = dtRes;
			conector.Close();
		}
		public void BuscarPorNombre(DataGridView dgv,string nombre_producto)
		{
			SqlConnection conector = new SqlConnection(conexion.strConexion);
			conector.Open();
			String sql = "SELECT Producto.nombre AS Nombre,Categoria.Nombre AS Categoria,marca AS Marca,stock AS Stock ,precio_compra AS 'Precio Compra'," +
						 "precio_venta AS 'Precio Venta',fecha_vencimiento AS 'Fecha Vencimiento',Proveedor.nombre AS Proveedor from " +
						 "Producto INNER JOIN Categoria	ON Producto.id_categoria = Categoria.id_categoria " +
						 "INNER JOIN Proveedor ON Producto.id_proveedor = Proveedor.id_proveedor WHERE Producto.nombre LIKE @nombre";
			SqlCommand cmd = new SqlCommand(sql, conector);
			cmd.Parameters.Add(new SqlParameter("@nombre", "%" + nombre_producto + "%"));
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dtRes = new DataTable("Producto");
			da.Fill(dtRes);
			dgv.DataSource = dtRes;
			conector.Close();
			
		}
		public string Eliminar(int id_producto)
		{
			string rpta = "";
			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				string query = "DELETE FROM Producto WHERE id_producto = ?";
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("@id_producto", id_producto));
				conector.Open();
				rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "NO SE ELIMINO EL REGISTRO";
				conector.Close();
			}
			catch (SqlException ex)
			{
				rpta = ex.Message;
			}
			return rpta;
		}

	}
}
