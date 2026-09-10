namespace App_Gestión_de_Catálogo
{
    partial class FormMarcas
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
            this.textTituloMarcas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textTituloMarcas
            // 
            this.textTituloMarcas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textTituloMarcas.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTituloMarcas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textTituloMarcas.Location = new System.Drawing.Point(12, 12);
            this.textTituloMarcas.Name = "textTituloMarcas";
            this.textTituloMarcas.Size = new System.Drawing.Size(776, 26);
            this.textTituloMarcas.TabIndex = 3;
            this.textTituloMarcas.Text = "MARCAS";
            // 
            // FormMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textTituloMarcas);
            this.Name = "FormMarcas";
            this.Text = "FormMarcas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTituloMarcas;
    }
}