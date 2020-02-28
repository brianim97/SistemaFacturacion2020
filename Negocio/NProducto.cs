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
		public static string Insertar(int id_categoria, string nombre, string marca,int stock, Decimal precio_compra, Decimal precio_venta,DateTime fecha_vencimiento, int id_proveedor)
		{
			DProducto obj = new DProducto();
			obj.Id_categoria = id_categoria;
			obj.Nombre = nombre;
			obj.Marca = marca;
			obj.Stock = stock;
			obj.Precio_compra = precio_compra;
			obj.Precio_venta = precio_venta;
			obj.Fecha_vencimiento = fecha_vencimiento;
			obj.Id_proveedor = id_proveedor;

			return obj.Insertar(obj);
		}
		public static void Mostrar(DataGridView dgv)
		{
			DProducto obj = new DProducto();
			obj.Mostrar(dgv);
		}
		public static void BuscarPorNombre(DataGridView dgv,string nombre_producto)
		{
			DProducto obj = new DProducto();
			obj.BuscarPorNombre(dgv,nombre_producto);
		}

	}
}
