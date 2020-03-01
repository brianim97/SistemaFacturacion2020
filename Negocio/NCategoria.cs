using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
	public class NCategoria
	{
		public static string Insertar(string nombre, string descripcion)
		{
			DCategoria obj = new DCategoria();
			obj.Nombre = nombre;
			obj.Descripcion = descripcion;
			return obj.Insertar(obj);
		}

		public static string Editar(int id,string nombre, string descripcion)
		{
			DCategoria obj = new DCategoria();
			obj.Id_Categoria = id;
			obj.Nombre = nombre;
			obj.Descripcion = descripcion;
			return obj.Editar(obj);
		}
		public static string Eliminar(int id)
		{
			DCategoria obj = new DCategoria();
			return obj.Eliminar(id);
		}
		public static void BuscarPorNombre(DataGridView dgv,string nombre)
		{
			DCategoria obj = new DCategoria();
			obj.BuscarPorNombre(dgv,nombre);
		}

		public static bool NombreExistente(string nombreNuevo)
		{
			DCategoria obj = new DCategoria();
			return obj.NombreExistente(nombreNuevo);
		}
		public static void Mostrar(DataGridView dgv)
		{
			DCategoria obj = new DCategoria();
			obj.Mostrar(dgv);
		}
	}
}
