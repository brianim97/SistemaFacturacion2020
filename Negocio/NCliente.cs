using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
	public class NCliente
	{
		public static string Insertar(string dni,string nombre, string direccion, string telefono)
		{
			DCliente obj = new DCliente();
			obj.Dni = dni;
			obj.Nombre = nombre;
			obj.Direccion = direccion;
			obj.Telefono = telefono;
			return obj.Insertar(obj);
		}

		public static string Editar(int id, string dni, string nombre, string direccion, string telefono)
		{
			DCliente obj = new DCliente();
			obj.Id = id;
			obj.Dni = dni;
			obj.Nombre = nombre;
			obj.Direccion = direccion;
			obj.Telefono = telefono;
			return obj.Editar(obj);
		}
		public static string Eliminar(int id)
		{
			DCliente obj = new DCliente();
			return obj.Eliminar(id);
		}
		public static void BuscarPorNombre(DataGridView dgv, string nombre)
		{
			DCliente obj = new DCliente();
			obj.BuscarPorNombre(dgv, nombre);
		}
		public static void BuscarPorDni(DataGridView dgv, string dni)
		{
			DCliente obj = new DCliente();
			obj.BuscarPorDni(dgv, dni);
		}

		public static bool DniExistente(string dniNuevo)
		{
			DCliente obj = new DCliente();
			return obj.DniExistente(dniNuevo);
		}
		public static void Mostrar(DataGridView dgv)
		{
			DCliente obj = new DCliente();
			obj.Mostrar(dgv);
		}
	}
}
