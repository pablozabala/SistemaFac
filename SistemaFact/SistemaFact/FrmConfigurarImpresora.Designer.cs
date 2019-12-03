namespace SistemaFact
{
    partial class FrmConfigurarImpresora
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
            this.Grupo = new System.Windows.Forms.GroupBox();
            this.txtFila = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColumna = new System.Windows.Forms.TextBox();
            this.Grupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grupo
            // 
            this.Grupo.Controls.Add(this.txtColumna);
            this.Grupo.Controls.Add(this.txtFila);
            this.Grupo.Controls.Add(this.label1);
            this.Grupo.Location = new System.Drawing.Point(24, 21);
            this.Grupo.Name = "Grupo";
            this.Grupo.Size = new System.Drawing.Size(353, 131);
            this.Grupo.TabIndex = 21;
            this.Grupo.TabStop = false;
            this.Grupo.Text = "Tipos de Color";
            this.Grupo.Enter += new System.EventHandler(this.Grupo_Enter);
            // 
            // txtFila
            // 
            this.txtFila.Location = new System.Drawing.Point(89, 38);
            this.txtFila.Multiline = true;
            this.txtFila.Name = "txtFila";
            this.txtFila.Size = new System.Drawing.Size(114, 20);
            this.txtFila.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripción ";
            // 
            // txtColumna
            // 
            this.txtColumna.Location = new System.Drawing.Point(89, 73);
            this.txtColumna.Multiline = true;
            this.txtColumna.Name = "txtColumna";
            this.txtColumna.Size = new System.Drawing.Size(114, 20);
            this.txtColumna.TabIndex = 3;
            // 
            // FrmConfigurarImpresora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 165);
            this.Controls.Add(this.Grupo);
            this.Name = "FrmConfigurarImpresora";
            this.Text = "FrmConfigurarImpresora";
            this.Load += new System.EventHandler(this.FrmConfigurarImpresora_Load);
            this.Grupo.ResumeLayout(false);
            this.Grupo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grupo;
        private System.Windows.Forms.TextBox txtFila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColumna;
    }
}