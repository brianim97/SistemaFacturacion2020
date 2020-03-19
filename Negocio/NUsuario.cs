using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
	public class NUsuario
	{
		public static string Insertar(string nombre, string contraseña, string account)
		{
			DUsuario obj = new DUsuario();
			obj.Nombre = nombre;
			obj.Contraseña = contraseña;
			obj.Account = account;
			return obj.Insertar(obj);
		}

		public static string Editar(int id, string nombre, string contraseña, string account)
		{
			DUsuario obj = new DUsuario();
			obj.Id_Usuario = id;
			obj.Nombre = nombre;
			obj.Contraseña = contraseña;
			obj.Account = account;
			return obj.Editar(obj);
		}
		public static string Eliminar(int id)
		{
			DUsuario obj = new DUsuario();
			return obj.Eliminar(id);
		}
		public static void BuscarPorNombre(DataGridView dgv, string nombre)
		{
			DUsuario obj = new DUsuario();
			obj.BuscarPorNombre(dgv, nombre);
		}

		public static bool NombreExistente(string nombreNuevo)
		{
			DUsuario obj = new DUsuario();
			return obj.NombreExistente(nombreNuevo);
		}
		public static void Mostrar(DataGridView dgv)
		{
			DUsuario obj = new DUsuario();
			obj.Mostrar(dgv);
		}
	}
}
