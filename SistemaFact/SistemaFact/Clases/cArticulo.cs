using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFact.Clases
{
    public class cArticulo
    {
        public void Insertar(string Nombre,Double? Costo,Double? Precio,int? CodColor)
        {
            string sql = "insert into Articulo(";
            sql = sql + "Nombre,Costo,Precio,CodColor)";
            sql = sql + " Values(";
            sql = sql + "'" + Nombre + "'";
            if (Costo != null)
                sql = sql + "," + Costo.ToString().Replace(",".".");
            else
                sql = sql + ",null";
            if (Precio != null)
                sql = sql + "," + Precio.ToString().Replace(",".".");
            else
                sql = sql + ",null";
            if (CodColor != null)
                sql = sql + "," + CodColor.ToString();
            else
                sql = sql + ",null";
            sql = sql + ")";
            cDb.Grabar(sql);
        }
    }
}
