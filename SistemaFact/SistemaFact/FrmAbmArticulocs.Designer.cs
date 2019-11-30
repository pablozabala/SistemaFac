namespace SistemaFact
{
    partial class FrmAbmArticulocs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbmArticulocs));
            this.BarraBotones = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnAceptar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnAbrir = new System.Windows.Forms.ToolStripButton();
            this.btnIGregarColor = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.Grupo = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.ImagenCodigo = new System.Windows.Forms.PictureBox();
            this.btnGenerarCodigoBarra = new System.Windows.Forms.Button();
            this.btnAgregarOrigen = new System.Windows.Forms.Button();
            this.btnNuevaTipoPrenda = new System.Windows.Forms.Button();
            this.txt_Ruta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_CodigoBarra = new System.Windows.Forms.TextBox();
            this.btnAbrirImagen = new System.Windows.Forms.Button();
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.cmb_CodOrigen = new System.Windows.Forms.ComboBox();
            this.cmb_CodColor = new System.Windows.Forms.ComboBox();
            this.cmb_CodTipoPrenda = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarColor = new System.Windows.Forms.Button();
            this.BarraBotones.SuspendLayout();
            this.Grupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraBotones
            // 
            this.BarraBotones.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.BarraBotones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnEditar,
            this.btnEliminar,
            this.btnAceptar,
            this.btnCancelar,
            this.btnAbrir,
            this.btnIGregarColor,
            this.btnSalir});
            this.BarraBotones.Location = new System.Drawing.Point(0, 0);
            this.BarraBotones.Name = "BarraBotones";
            this.BarraBotones.Size = new System.Drawing.Size(671, 39);
            this.BarraBotones.TabIndex = 17;
            this.BarraBotones.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(36, 36);
            this.btnNuevo.Text = "toolStripButton1";
            this.btnNuevo.ToolTipText = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(36, 36);
            this.btnEditar.Text = "toolStripButton2";
            this.btnEditar.ToolTipText = "Modificar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(36, 36);
            this.btnEliminar.Text = "toolStripButton3";
            this.btnEliminar.ToolTipText = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(36, 36);
            this.btnAceptar.Text = "Grabar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(36, 36);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrir.Image")));
            this.btnAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(36, 36);
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnIGregarColor
            // 
            this.btnIGregarColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIGregarColor.Image = ((System.Drawing.Image)(resources.GetObject("btnIGregarColor.Image")));
            this.btnIGregarColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIGregarColor.Name = "btnIGregarColor";
            this.btnIGregarColor.Size = new System.Drawing.Size(36, 36);
            this.btnIGregarColor.Text = "toolStripButton1";
            this.btnIGregarColor.ToolTipText = "Imprimir";
            this.btnIGregarColor.Click += new System.EventHandler(this.btnIGregarColor_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(36, 36);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Grupo
            // 
            this.Grupo.Controls.Add(this.btnAgregarColor);
            this.Grupo.Controls.Add(this.txtCodigo);
            this.Grupo.Controls.Add(this.ImagenCodigo);
            this.Grupo.Controls.Add(this.btnGenerarCodigoBarra);
            this.Grupo.Controls.Add(this.btnAgregarOrigen);
            this.Grupo.Controls.Add(this.btnNuevaTipoPrenda);
            this.Grupo.Controls.Add(this.txt_Ruta);
            this.Grupo.Controls.Add(this.label8);
            this.Grupo.Controls.Add(this.txt_CodigoBarra);
            this.Grupo.Controls.Add(this.btnAbrirImagen);
            this.Grupo.Controls.Add(this.Imagen);
            this.Grupo.Controls.Add(this.label7);
            this.Grupo.Controls.Add(this.txtStock);
            this.Grupo.Controls.Add(this.txt_Precio);
            this.Grupo.Controls.Add(this.txt_Nombre);
            this.Grupo.Controls.Add(this.cmb_CodOrigen);
            this.Grupo.Controls.Add(this.cmb_CodColor);
            this.Grupo.Controls.Add(this.cmb_CodTipoPrenda);
            this.Grupo.Controls.Add(this.label6);
            this.Grupo.Controls.Add(this.label5);
            this.Grupo.Controls.Add(this.label4);
            this.Grupo.Controls.Add(this.label3);
            this.Grupo.Controls.Add(this.label2);
            this.Grupo.Controls.Add(this.label1);
            this.Grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo.Location = new System.Drawing.Point(13, 55);
            this.Grupo.Name = "Grupo";
            this.Grupo.Size = new System.Drawing.Size(646, 465);
            this.Grupo.TabIndex = 18;
            this.Grupo.TabStop = false;
            this.Grupo.Text = "Información del artículo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(465, 141);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(41, 23);
            this.txtCodigo.TabIndex = 23;
            this.txtCodigo.Visible = false;
            // 
            // ImagenCodigo
            // 
            this.ImagenCodigo.Location = new System.Drawing.Point(158, 199);
            this.ImagenCodigo.Name = "ImagenCodigo";
            this.ImagenCodigo.Size = new System.Drawing.Size(240, 50);
            this.ImagenCodigo.TabIndex = 22;
            this.ImagenCodigo.TabStop = false;
            // 
            // btnGenerarCodigoBarra
            // 
            this.btnGenerarCodigoBarra.Image = global::SistemaFact.Properties.Resources.CodigoBarra;
            this.btnGenerarCodigoBarra.Location = new System.Drawing.Point(402, 199);
            this.btnGenerarCodigoBarra.Name = "btnGenerarCodigoBarra";
            this.btnGenerarCodigoBarra.Size = new System.Drawing.Size(26, 26);
            this.btnGenerarCodigoBarra.TabIndex = 21;
            this.btnGenerarCodigoBarra.UseVisualStyleBackColor = true;
            this.btnGenerarCodigoBarra.Click += new System.EventHandler(this.btnGenerarCodigoBarra_Click);
            // 
            // btnAgregarOrigen
            // 
            this.btnAgregarOrigen.Image = global::SistemaFact.Properties.Resources.add;
            this.btnAgregarOrigen.Location = new System.Drawing.Point(512, 80);
            this.btnAgregarOrigen.Name = "btnAgregarOrigen";
            this.btnAgregarOrigen.Size = new System.Drawing.Size(26, 26);
            this.btnAgregarOrigen.TabIndex = 20;
            this.btnAgregarOrigen.UseVisualStyleBackColor = true;
            this.btnAgregarOrigen.Click += new System.EventHandler(this.btnAgregarOrigen_Click);
            // 
            // btnNuevaTipoPrenda
            // 
            this.btnNuevaTipoPrenda.Image = global::SistemaFact.Properties.Resources.add;
            this.btnNuevaTipoPrenda.Location = new System.Drawing.Point(512, 20);
            this.btnNuevaTipoPrenda.Name = "btnNuevaTipoPrenda";
            this.btnNuevaTipoPrenda.Size = new System.Drawing.Size(26, 26);
            this.btnNuevaTipoPrenda.TabIndex = 19;
            this.btnNuevaTipoPrenda.UseVisualStyleBackColor = true;
            this.btnNuevaTipoPrenda.Click += new System.EventHandler(this.btnNuevaTipoPrenda_Click);
            // 
            // txt_Ruta
            // 
            this.txt_Ruta.Location = new System.Drawing.Point(296, 167);
            this.txt_Ruta.Name = "txt_Ruta";
            this.txt_Ruta.Size = new System.Drawing.Size(132, 23);
            this.txt_Ruta.TabIndex = 18;
            this.txt_Ruta.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Código Barra";
            // 
            // txt_CodigoBarra
            // 
            this.txt_CodigoBarra.Location = new System.Drawing.Point(434, 199);
            this.txt_CodigoBarra.Name = "txt_CodigoBarra";
            this.txt_CodigoBarra.Size = new System.Drawing.Size(132, 23);
            this.txt_CodigoBarra.TabIndex = 15;
            // 
            // btnAbrirImagen
            // 
            this.btnAbrirImagen.Location = new System.Drawing.Point(296, 273);
            this.btnAbrirImagen.Name = "btnAbrirImagen";
            this.btnAbrirImagen.Size = new System.Drawing.Size(102, 34);
            this.btnAbrirImagen.TabIndex = 14;
            this.btnAbrirImagen.Text = "Seleccionar";
            this.btnAbrirImagen.UseVisualStyleBackColor = true;
            this.btnAbrirImagen.Click += new System.EventHandler(this.btnAbrirImagen_Click);
            // 
            // Imagen
            // 
            this.Imagen.Location = new System.Drawing.Point(158, 273);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(132, 117);
            this.Imagen.TabIndex = 13;
            this.Imagen.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Imagen";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(158, 170);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(132, 23);
            this.txtStock.TabIndex = 11;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(158, 141);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(132, 23);
            this.txt_Precio.TabIndex = 10;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(158, 112);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(348, 23);
            this.txt_Nombre.TabIndex = 9;
            // 
            // cmb_CodOrigen
            // 
            this.cmb_CodOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CodOrigen.FormattingEnabled = true;
            this.cmb_CodOrigen.Location = new System.Drawing.Point(158, 82);
            this.cmb_CodOrigen.Name = "cmb_CodOrigen";
            this.cmb_CodOrigen.Size = new System.Drawing.Size(348, 24);
            this.cmb_CodOrigen.TabIndex = 8;
            // 
            // cmb_CodColor
            // 
            this.cmb_CodColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CodColor.FormattingEnabled = true;
            this.cmb_CodColor.Location = new System.Drawing.Point(158, 52);
            this.cmb_CodColor.Name = "cmb_CodColor";
            this.cmb_CodColor.Size = new System.Drawing.Size(348, 24);
            this.cmb_CodColor.TabIndex = 7;
            // 
            // cmb_CodTipoPrenda
            // 
            this.cmb_CodTipoPrenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CodTipoPrenda.FormattingEnabled = true;
            this.cmb_CodTipoPrenda.Location = new System.Drawing.Point(158, 22);
            this.cmb_CodTipoPrenda.Name = "cmb_CodTipoPrenda";
            this.cmb_CodTipoPrenda.Size = new System.Drawing.Size(348, 24);
            this.cmb_CodTipoPrenda.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stock Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio de Venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color de prenda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origen de prenda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de prenda";
            // 
            // btnAgregarColor
            // 
            this.btnAgregarColor.Image = global::SistemaFact.Properties.Resources.add;
            this.btnAgregarColor.Location = new System.Drawing.Point(512, 52);
            this.btnAgregarColor.Name = "btnAgregarColor";
            this.btnAgregarColor.Size = new System.Drawing.Size(26, 26);
            this.btnAgregarColor.TabIndex = 24;
            this.btnAgregarColor.UseVisualStyleBackColor = true;
            this.btnAgregarColor.Click += new System.EventHandler(this.btnAgregarColor_Click);
            // 
            // FrmAbmArticulocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 524);
            this.Controls.Add(this.Grupo);
            this.Controls.Add(this.BarraBotones);
            this.Name = "FrmAbmArticulocs";
            this.Text = "FrmAbmArticulocs";
            this.Load += new System.EventHandler(this.FrmAbmArticulocs_Load);
            this.BarraBotones.ResumeLayout(false);
            this.BarraBotones.PerformLayout();
            this.Grupo.ResumeLayout(false);
            this.Grupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BarraBotones;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnAceptar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnAbrir;
        private System.Windows.Forms.ToolStripButton btnIGregarColor;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.GroupBox Grupo;
        private System.Windows.Forms.PictureBox ImagenCodigo;
        private System.Windows.Forms.Button btnGenerarCodigoBarra;
        private System.Windows.Forms.Button btnAgregarOrigen;
        private System.Windows.Forms.Button btnNuevaTipoPrenda;
        private System.Windows.Forms.TextBox txt_Ruta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_CodigoBarra;
        private System.Windows.Forms.Button btnAbrirImagen;
        private System.Windows.Forms.PictureBox Imagen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.ComboBox cmb_CodOrigen;
        private System.Windows.Forms.ComboBox cmb_CodColor;
        private System.Windows.Forms.ComboBox cmb_CodTipoPrenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregarColor;
    }
}