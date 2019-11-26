using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFact.Clases;

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
            cFunciones fun = new cFunciones();
            fun.LlenarCombo(CmbTipoPrenda, "TipoPrenda", "Nombre", "CodTipoPrenda");
            fun.LlenarCombo(cmbColor , "Color", "Nombre", "CodColor");
            fun.LlenarCombo(cmbOrigen , "Origen", "Nombre", "CodOrigen");
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

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text =="")
            {
                Mensaje("Ingresar descripcion");
                return;
            }
            string Nombre = txtDescripcion.Text;
            Double? Costo = null;
            Double? Precio = null;
            int? CodColor = null;
            cArticulo art = new Clases.cArticulo();

            if (txtPrecioVenta.Text != "")
                Precio = Convert.ToDouble(txtPrecioVenta.Text);
            if (cmbColor.SelectedIndex > 0)
                CodColor = Convert.ToInt32(cmbColor.SelectedValue);
            art.Insertar(Nombre, Costo, Precio, CodColor);
            Mensaje("Datos grabados correctamente");
            Limpiar();

        }

        private void Limpiar()
        {
            txtDescripcion.Text = "";
            txtPrecioVenta.Text = "";
        }
    }
}
