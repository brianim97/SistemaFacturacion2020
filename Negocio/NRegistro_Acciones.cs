using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
	public class NRegistro_Acciones
	{
		public static string Insertar(string accion)
		{
			DRegistro_Acciones obj = new DRegistro_Acciones();
			return obj.Insertar(accion);
		}
		public static void Mostrar(DataGridView dgv)
		{
			DRegistro_Acciones obj = new DRegistro_Acciones();
			obj.Mostrar(dgv);
		}
	}
}
