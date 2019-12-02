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
using BarcodeLib;
namespace SistemaFact
{
    public partial class FrmAbmArticulocs : FormBase
    {
        public FrmAbmArticulocs()
        {
            InitializeComponent();
            
        }

        private void FrmAbmArticulocs_Load(object sender, EventArgs e)
        {
            Botonera(1);
            Grupo.Enabled = false;
            cFunciones fun = new cFunciones();
            fun.LlenarCombo(cmb_CodTipoPrenda, "TipoPrenda", "Nombre", "CodTipoPrenda");
            fun.LlenarCombo(cmb_CodOrigen, "Origen", "Nombre", "CodOrigen");
            fun.LlenarCombo(cmb_CodColor, "Color", "Nombre", "CodColor");
        }

        private void Botonera(int Jugada)
        {
            switch (Jugada)
            {
                //estado inicial
                case 1:
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;
                    break;
                case 2:
                    btnNuevo.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnAceptar.Enabled = true;
                    btnCancelar.Enabled = true;
                    break;
                case 3:
                    //viene del buscador
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;
                    break;
            }


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Botonera(2);
            Grupo.Enabled = true;
            Clases.cFunciones fun = new Clases.cFunciones();
            fun.LimpiarGenerico(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Botonera(2);
            Grupo.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Clases.cFunciones fun = new Clases.cFunciones();
            if (txtCodigo.Text == "")
                fun.GuardarNuevoGenerico(this, "Articulo");
            else
                fun.ModificarGenerico(this, "Articulo", "CodArticulo", txtCodigo.Text);
            Mensaje("Datos grabados correctamente");
            if (txt_Ruta.Text !="")
            {
                Imagen.Image.Save(txt_Ruta.Text);
                
            }
            
            if (txt_CodigoBarra.Text !="")
            {
                var result = MessageBox.Show("Desea Imprimir", "Información",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                if (result == DialogResult.Yes )
                {
                    cCodigoBarra objCodBarra = new cCodigoBarra();
                    objCodBarra.Insertar(ImagenCodigo, 1, 2);
                    FrmVerReporteBarra frm = new FrmVerReporteBarra();
                    frm.Show();
                }
            }

            Botonera(1);
            fun.LimpiarGenerico(this);
            Imagen.Image = null;
            ImagenCodigo.Image = null;
            txtCodigo.Text = "";
            Grupo.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cFunciones fun = new Clases.cFunciones();
            txtCodigo.Text = "";
            txt_Nombre.Text = "";
            Botonera(1);
            Grupo.Enabled = false;
            fun.LimpiarGenerico(this);
            ImagenCodigo.Image = null;
            Imagen.Image = null;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Principal.OpcionesdeBusqueda = "Nombre;ApCodigoBarra";
            Principal.TablaPrincipal = "Articulo";
            Principal.OpcionesColumnasGrilla = "CodArticulo;Nombre;Precio";
            Principal.ColumnasVisibles = "0;1;1";
            Principal.ColumnasAncho = "0;390;190";
            FrmBuscadorGenerico form = new FrmBuscadorGenerico();
            form.FormClosing += new FormClosingEventHandler(form_FormClosing);
            form.ShowDialog();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevaTipoPrenda_Click(object sender, EventArgs e)
        {
            Principal.CampoIdSecundario = "CodTipoPrenda";
            Principal.CampoNombreSecundario = "Nombre";
            Principal.NombreTablaSecundario = "TipoPrenda";
            Principal.CampoIdSecundarioGenerado = "";
            FrmAltaBasica form = new FrmAltaBasica();
            form.FormClosing += new FormClosingEventHandler(form_FormClosing);
            form.ShowDialog();
        }

        private void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Principal.CampoIdSecundarioGenerado != "")
            {  
                Clases.cFunciones fun = new Clases.cFunciones();
                switch (Principal.NombreTablaSecundario)
                { 
                    case "TipoPrenda":
                        fun.LlenarCombo(cmb_CodTipoPrenda, "TipoPrenda", "Nombre", "CodTipoPrenda");
                        cmb_CodTipoPrenda.SelectedValue = Principal.CampoIdSecundarioGenerado;
                        break;
                    case "Origen":
                        fun.LlenarCombo(cmb_CodOrigen, "Origen", "Nombre", "CodOrigen");
                        cmb_CodOrigen.SelectedValue = Principal.CampoIdSecundarioGenerado;
                        break;
                    case "Color":  
                        fun.LlenarCombo(cmb_CodColor, "Color", "Nombre", "CodColor");
                        cmb_CodColor.SelectedValue = Principal.CampoIdSecundarioGenerado;
                        break;
                }
            }
            if (Principal.CodigoPrincipalAbm !=null)
            {
                Botonera(3);
                txtCodigo.Text = Principal.CodigoPrincipalAbm.ToString();
                cFunciones fun = new Clases.cFunciones();
                fun.CargarControles(this, "Articulo","CodArticulo", txtCodigo.Text);
                if (txt_CodigoBarra.Text !="")
                {
                    BarcodeLib.Barcode CodBar = new BarcodeLib.Barcode();                    
                    ImagenCodigo.Image = CodBar.Encode(BarcodeLib.TYPE.CODE128, txt_CodigoBarra.Text , Color.Black, Color.White, 300, 300);
                }
            }

        }

        private void btnAgregarOrigen_Click(object sender, EventArgs e)
        {    
            Principal.CampoIdSecundario = "CodOrigen";
            Principal.CampoNombreSecundario = "Nombre";
            Principal.NombreTablaSecundario = "Origen";
            Principal.CampoIdSecundarioGenerado = "";
            FrmAltaBasica form = new FrmAltaBasica();
            form.FormClosing += new FormClosingEventHandler(form_FormClosing);
            form.ShowDialog();
        }

        private void btnGenerarCodigoBarra_Click(object sender, EventArgs e)
        {
            int c = 0;
            Random r = new Random();
            int nro = 0;
            string codigo = "";
            while (c < 10)
            {
                nro = r.Next(0, 10);
                if (c == 0)
                    codigo = nro.ToString();
                else
                    codigo = codigo + nro.ToString();
                c++;
            }
            txt_CodigoBarra.Text = codigo;
            BarcodeLib.Barcode CodBar = new BarcodeLib.Barcode();
            //panel1.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, "12345678988877744521", Color.Black, Color.White, 300, 300);
            ImagenCodigo.Image = CodBar.Encode(BarcodeLib.TYPE.CODE128, codigo, Color.Black, Color.White, 300, 300);
        }

        private void btnAbrirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                string ruta = ""; //file.FileName;
                ruta = file.FileName;
                Imagen.Image = System.Drawing.Image.FromFile(ruta);
                string RutaGrabar = "e:\\ARCHIVO\\" + file.SafeFileName.ToString();
                txt_Ruta.Text = RutaGrabar;
            }
            else
            {
                txt_Ruta.Text = "";
            }
        }

        private void btnIGregarColor_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarColor_Click(object sender, EventArgs e)
        {
            Principal.CampoIdSecundario = "CodColor";
            Principal.CampoNombreSecundario = "Nombre";
            Principal.NombreTablaSecundario = "Color";
            Principal.CampoIdSecundarioGenerado = "";
            FrmAltaBasica form = new FrmAltaBasica();
            form.FormClosing += new FormClosingEventHandler(form_FormClosing);
            form.ShowDialog();
        }
    }
}
