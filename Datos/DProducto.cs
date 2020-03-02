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
		public string Codigo { get; set; }
		public Decimal Precio_compra { get; set; }
		public Decimal Precio_venta { get; set; }
		public DateTime Fecha_vencimiento { get; set; }
		public int Id_proveedor { get; set; }

		Conexion conexion = new Conexion();
		

		public DProducto()
		{

		}

		public DProducto(int id_producto, int id_categoria, String nombre, String marca,int stock,string codigo, Decimal precio_compra, Decimal precio_venta, DateTime fecha_vencimiento, int id_proveedor)
		{
			Id_producto = id_producto;
			Id_categoria = id_categoria;
			Nombre = nombre;
			Marca = marca;
			Stock = stock;
			Codigo = codigo;
			Precio_compra = precio_compra;
			Precio_venta = precio_venta;
			Fecha_vencimiento = fecha_vencimiento;
			Id_proveedor = id_proveedor;
			
			
		}

		public string Insertar(DProducto producto)
		{
			string rpta = "";
			string query = "INSERT INTO Producto (id_categoria,nombre,marca,stock,codigo,precio_compra,precio_venta, fecha_vencimiento,id_proveedor) VALUES (@id_categoria,@nombre,@marca,@stock,@codigo,@precio_compra,@precio_venta,@fecha_vencimiento,@id_proveedor)";

			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("id_categoria", producto.Id_categoria));
				cmd.Parameters.Add(new SqlParameter("nombre", producto.Nombre));
				cmd.Parameters.Add(new SqlParameter("marca", producto.Marca));
				cmd.Parameters.Add(new SqlParameter("stock", producto.Stock));
				cmd.Parameters.Add(new SqlParameter("codigo", producto.Codigo));
				cmd.Parameters.Add(new SqlParameter("precio_compra", producto.Precio_compra));
				cmd.Parameters.Add(new SqlParameter("precio_venta", producto.Precio_venta));
				cmd.Parameters.Add(new SqlParameter("fecha_vencimiento", producto.Fecha_vencimiento));
				cmd.Parameters.Add(new SqlParameter("id_proveedor", producto.Id_proveedor));

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
			string query = "UPDATE Producto SET id_categoria = @id_categoria,nombre = @nombre,marca = @marca,stock = @stock,codigo = @codigo,precio_compra = @precio_compra," +
						   "precio_venta = @precio_venta, fecha_vencimiento = @fecha_vencimiento,id_proveedor = @id_proveedor WHERE id_producto = @id";

			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("id_categoria", producto.Id_categoria));
				cmd.Parameters.Add(new SqlParameter("nombre", producto.Nombre));
				cmd.Parameters.Add(new SqlParameter("marca", producto.Marca));
				cmd.Parameters.Add(new SqlParameter("stock", producto.Stock));
				cmd.Parameters.Add(new SqlParameter("codigo", producto.Codigo));
				cmd.Parameters.Add(new SqlParameter("precio_compra", producto.Precio_compra));
				cmd.Parameters.Add(new SqlParameter("precio_venta", producto.Precio_venta));
				cmd.Parameters.Add(new SqlParameter("fecha_vencimiento", producto.Fecha_vencimiento));
				cmd.Parameters.Add(new SqlParameter("id_proveedor", producto.Id_proveedor));
				cmd.Parameters.Add(new SqlParameter("id", producto.Id_producto));

				conector.Open();
				rpta = cmd.ExecuteNonQuery() == 1 ? "Producto editado correctamente" : "Error en editar producto";
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
			try
			{
				DataTable dtRes = new DataTable();
				String sql = "SELECT Producto.nombre AS Nombre,Categoria.Nombre AS Categoria,marca AS Marca,stock AS Stock,codigo as Codigo ,precio_compra AS 'Precio Compra'," +
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
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
		public void BuscarPorNombre(DataGridView dgv,string nombre_producto)
		{
			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				conector.Open();
				String sql = "SELECT Producto.nombre AS Nombre,Categoria.Nombre AS Categoria,marca AS Marca,stock AS Stock, codigo AS Codigo ,precio_compra AS 'Precio Compra'," +
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
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			
		}
		public string Eliminar(int id_producto)
		{
			string rpta = "";
			try
			{
				SqlConnection conector = new SqlConnection(conexion.strConexion);
				string query = "DELETE FROM Producto WHERE id_producto = @id_producto";
				SqlCommand cmd = new SqlCommand(query, conector);
				cmd.Parameters.Add(new SqlParameter("@id_producto", id_producto));
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
				string query = "SELECT nombre FROM Producto WHERE nombre LIKE @nombre";
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
				MessageBox.Show(ex.Message);
				return false;
			}
		}
	}
}
