using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
	public class NProveedor
	{
		public static string Insertar(string nombre, string contacto)
		{
			DProveedor obj = new DProveedor();
			obj.Nombre = nombre;
			obj.Contacto = contacto;
			return obj.Insertar(obj);
		}

		public static string Editar(int id, string nombre, string contacto)
		{
			DProveedor obj = new DProveedor();
			obj.Id_Proveedor = id;
			obj.Nombre = nombre;
			obj.Contacto = contacto;
			return obj.Editar(obj);
		}
		public static string Eliminar(int id)
		{
			DProveedor obj = new DProveedor();
			return obj.Eliminar(id);
		}
		public static void BuscarPorNombre(DataGridView dgv, string nombre)
		{
			DProveedor obj = new DProveedor();
			obj.BuscarPorNombre(dgv, nombre);
		}

		public static bool NombreExistente(string nombreNuevo)
		{
			DProveedor obj = new DProveedor();
			return obj.NombreExistente(nombreNuevo);
		}
		public static void Mostrar(DataGridView dgv)
		{
			DProveedor obj = new DProveedor();
			obj.Mostrar(dgv);
		}
	}
}
