using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion
{
	public class ProductoImport
	{
		
		public string Nombre { get; set; }
		public string Marca { get; set; }
		public int Stock { get; set; }
		public string Codigo { get; set; }
		public Decimal Precio_compra { get; set; }
		public Decimal Precio_venta { get; set; }
		public string Categoria { get; set; }
		public string Proveedor { get; set; }
	}
}
