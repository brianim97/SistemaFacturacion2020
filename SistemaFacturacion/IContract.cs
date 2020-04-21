using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion
{
	public interface IContract
	{
		void EnviarDatos(string codigo);
	}
}
