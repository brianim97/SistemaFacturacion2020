using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Negocio
{
	public class NProducto
	{
		public static string Insertar(int id_categoria, string nombre, string marca,int stock,string codigo, Decimal precio_compra, Decimal precio_venta, int id_proveedor)
		{
			DProducto obj = new DProducto();
			obj.Id_categoria = id_categoria;
			obj.Nombre = nombre;
			obj.Marca = marca;
			obj.Stock = stock;
			obj.Codigo = codigo;
			obj.Precio_compra = precio_compra;
			obj.Precio_venta = precio_venta;	
			obj.Id_proveedor = id_proveedor;

			return obj.Insertar(obj);
		}
		public static string Editar(int id_producto,int id_categoria, string nombre, string marca, int stock, string codigo, Decimal precio_compra, Decimal precio_venta, int id_proveedor)
		{
			DProducto obj = new DProducto();
			obj.Id_producto = id_producto;
			obj.Id_categoria = id_categoria;
			obj.Nombre = nombre;
			obj.Marca = marca;
			obj.Stock = stock;
			obj.Codigo = codigo;
			obj.Precio_compra = precio_compra;
			obj.Precio_venta = precio_venta;
			obj.Id_proveedor = id_proveedor;
			return obj.Editar(obj);
		}

		public static bool Mostrar(DataGridView dgv)
		{
			DProducto obj = new DProducto();
			return obj.Mostrar(dgv);
		}
		public static bool MostrarFacturacion(DataGridView dgv)
		{
			DProducto obj = new DProducto();
			return obj.MostrarFacturacion(dgv);
		}
		public static void BuscarPorNombre(DataGridView dgv,string nombre_producto)
		{
			DProducto obj = new DProducto();
			obj.BuscarPorNombre(dgv,nombre_producto);
		}
		public static void BuscarPorNombreFacturacion(DataGridView dgv, string nombre_producto)
		{
			DProducto obj = new DProducto();
			obj.BuscarPorNombreFacturacion(dgv, nombre_producto);
		}
		public static void BuscarPorCodigoFacturacion(DataGridView dgv, string codigo_producto)
		{
			DProducto obj = new DProducto();
			obj.BuscarPorCodigoFacturacion(dgv, codigo_producto);
		}
		public static string Eliminar(int id)
		{
			DProducto obj = new DProducto();
			return obj.Eliminar(id);
		}
		public static bool NombreExistente(string nombreNuevo)
		{
			DProducto obj = new DProducto();
			return obj.NombreExistente(nombreNuevo);
		}
		public static bool CodigoExistente(string codigoExistente)
		{
			DProducto obj = new DProducto();
			return obj.CodigoExistente(codigoExistente);
		}
		public static bool StockDisponible(int id_producto,int cantidad)
		{
			DProducto obj = new DProducto();
			return obj.StockDisponible(id_producto, cantidad);
		}
	}
}
