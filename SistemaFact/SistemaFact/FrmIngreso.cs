using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFact
{
    public partial class FrmIngreso : FormBase
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void FrmIngreso_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                string ruta = file.FileName;
                Imagen.Image = System.Drawing.Image.FromFile(ruta);
            }
        }

        private void txtCodigoBarra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
