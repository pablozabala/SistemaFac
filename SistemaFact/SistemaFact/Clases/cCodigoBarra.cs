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
            cDb.Grabar("delete from CodigoBarra");
            SqlConnection con = new SqlConnection(Clases.cConexion.GetConexion());
            SqlCommand cmd = new SqlCommand();
            string sql = "Insert into CodigoBarra(Foto,Foto2,Foto3,Foto4,Foto5,Foto6)";
            sql = sql + "values(@Foto,@Foto2,@Foto3,@Foto4,@Foto5,@Foto6)";
            cmd.CommandText = sql;
            con.Open();
            for (int i=1;i< Fila + 1;i++)
            {
                if (i==Fila)
                {
                    cmd.Parameters["@Foto"].Value = null;
                    cmd.Parameters["@Foto2"].Value = null;
                    cmd.Parameters["@Foto3"].Value = null;
                    cmd.Parameters["@Foto4"].Value = null;
                    cmd.Parameters["@Foto5"].Value = null;
                    cmd.Parameters["@Foto6"].Value = null;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    Cuadro.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    switch(Columna)
                    {
                        case 1:
                            cmd.Parameters["@Foto"].Value = ms.GetBuffer();
                            break;
                        case 2:
                            cmd.Parameters["@Foto2"].Value = ms.GetBuffer();
                            break;
                        case 3:
                            cmd.Parameters["@Foto3"].Value = ms.GetBuffer();
                            break;
                        case 4:
                            cmd.Parameters["@Foto4"].Value = ms.GetBuffer();
                            break;
                        case 5:
                            cmd.Parameters["@Foto5"].Value = ms.GetBuffer();
                            break;
                        case 6:
                            cmd.Parameters["@Foto6"].Value = ms.GetBuffer();
                            break;                            
                    }
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string sql2 = "Insert into CodigoBarra(Foto,Foto2,Foto3,Foto4,Foto5,Foto6)";
                    sql2 = sql2 + "Values(null,null,null,nul,null,null)";
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.CommandText = sql2;
                    cmd2.Connection = con;
                    cmd2.ExecuteNonQuery();
                }
            }
            con.Close();

        }
    }
}
