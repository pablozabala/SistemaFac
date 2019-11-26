using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFact.Clases
{
    public static class cConexion
    {
        public static string GetConexion()
        {
            //home
            //schol
            string cadena = "Data Source=SECRETARIA-2\\SQLEXPRESS;Initial Catalog=FACTURACION;Integrated Security=True";
            return cadena;
        }
    }
}
