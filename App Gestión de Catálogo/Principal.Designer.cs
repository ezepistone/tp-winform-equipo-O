namespace App_Gestión_de_Catálogo
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.BtnArticulos = new System.Windows.Forms.Button();
            this.BtnMarcas = new System.Windows.Forms.Button();
            this.BtnCategorias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnArticulos
            // 
            this.BtnArticulos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnArticulos.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.BtnArticulos.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArticulos.Location = new System.Drawing.Point(12, 12);
            this.BtnArticulos.Name = "BtnArticulos";
            this.BtnArticulos.Size = new System.Drawing.Size(142, 54);
            this.BtnArticulos.TabIndex = 1;
            this.BtnArticulos.Text = "ARTÍCULOS";
            this.BtnArticulos.UseVisualStyleBackColor = false;
            this.BtnArticulos.Click += new System.EventHandler(this.BtnArticulos_Click);
            // 
            // BtnMarcas
            // 
            this.BtnMarcas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMarcas.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.BtnMarcas.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMarcas.Location = new System.Drawing.Point(12, 72);
            this.BtnMarcas.Name = "BtnMarcas";
            this.BtnMarcas.Size = new System.Drawing.Size(142, 54);
            this.BtnMarcas.TabIndex = 2;
            this.BtnMarcas.Text = "MARCAS";
            this.BtnMarcas.UseVisualStyleBackColor = false;
            this.BtnMarcas.Click += new System.EventHandler(this.BtnMarcas_Click);
            // 
            // BtnCategorias
            // 
            this.BtnCategorias.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCategorias.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.BtnCategorias.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategorias.Location = new System.Drawing.Point(12, 132);
            this.BtnCategorias.Name = "BtnCategorias";
            this.BtnCategorias.Size = new System.Drawing.Size(142, 54);
            this.BtnCategorias.TabIndex = 3;
            this.BtnCategorias.Text = "CATEGORÍAS";
            this.BtnCategorias.UseVisualStyleBackColor = false;
            this.BtnCategorias.Click += new System.EventHandler(this.BtnCategorias_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(654, 491);
            this.Controls.Add(this.BtnCategorias);
            this.Controls.Add(this.BtnMarcas);
            this.Controls.Add(this.BtnArticulos);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnArticulos;
        private System.Windows.Forms.Button BtnMarcas;
        private System.Windows.Forms.Button BtnCategorias;
    }
}

