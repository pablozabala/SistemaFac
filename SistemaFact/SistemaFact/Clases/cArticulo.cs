using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace SistemaFact.Clases
{
    public class cArticulo
    {
        public void Insertar(string Nombre,Double? Costo,Double? Precio,
            int? CodColor,string Ruta, int? CodTipoPrenda,string CodigoBarra)
        {
            string sql = "insert into Articulo(";
            sql = sql + "Nombre,Costo,Precio,CodColor,Ruta,CodTipoPrenda,CodigoBarra)";
            sql = sql + " Values(";
            sql = sql + "'" + Nombre + "'";
            if (Costo != null)
                sql = sql + "," + Costo.ToString().Replace(",",".");
            else
                sql = sql + ",null";
            if (Precio != null)
                sql = sql + "," + Precio.ToString().Replace(",",".");
            else
                sql = sql + ",null";
            if (CodColor != null)
                sql = sql + "," + CodColor.ToString();
            else
                sql = sql + ",null";
            sql = sql + "," + "'" + Ruta + "'";
            if (CodTipoPrenda  != null)
                sql = sql + "," + CodTipoPrenda.ToString();
            else
                sql = sql + ",null";
            if (CodigoBarra != null)
                sql = sql + "," + "'" + CodigoBarra + "'";
            else
                sql = sql + ",null";
            sql = sql + ")";
            cDb.Grabar(sql);
        }

        public DataTable GetArticulo(string Nombre,string CodigoBarra)
        {
            string sql = "select a.CodArticulo,a.Nombre,";
            sql = sql + "(select tp.Nombre from TipoPrenda tp where tp.CodTipoPrenda = a.CodTipoPrenda) as TipoPrenda";
            sql = sql + ", a.Costo,a.Precio";
            sql = sql + " from articulo a";
            if (Nombre !="")
            {
                sql = sql + " where a.Nombre like " + "'%" + Nombre + "%'";
            }
            if (CodigoBarra !="")
            {
                sql = sql + " where a.CodigoBarra =" + "'" + CodigoBarra +"'";
            }
            return cDb.GetDatatable(sql);
        }
    }
}
