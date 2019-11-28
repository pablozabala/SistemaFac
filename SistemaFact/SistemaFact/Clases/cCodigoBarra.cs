using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SistemaFact.Clases
{
    public class cCodigoBarra
    {
        public void Insertar(PictureBox Cuadro,int Fila,int Columna)
        {
            SqlConnection con = new SqlConnection(Clases.cConexion.GetConexion());
            SqlCommand cmd = new SqlCommand();
            string sql = "Insert into CodigoBarra(Foto,Foto2,Foto3,Foto4,Foto5,Foto6)";
            sql = sql + "values(@Foto,@Foto2,@Foto3,@Foto4,@Foto5,@Foto6)";
            cmd.CommandText = sql;

        }
    }
}
