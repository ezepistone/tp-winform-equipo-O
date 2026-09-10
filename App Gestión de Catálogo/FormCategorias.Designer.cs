namespace App_Gestión_de_Catálogo
{
    partial class FormCategorias
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
            this.textTituloCategorias = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textTituloCategorias
            // 
            this.textTituloCategorias.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textTituloCategorias.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTituloCategorias.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textTituloCategorias.Location = new System.Drawing.Point(12, 12);
            this.textTituloCategorias.Name = "textTituloCategorias";
            this.textTituloCategorias.Size = new System.Drawing.Size(776, 26);
            this.textTituloCategorias.TabIndex = 2;
            this.textTituloCategorias.Text = "CATEGORÍAS";
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textTituloCategorias);
            this.Name = "FormCategorias";
            this.Text = "FormCategorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTituloCategorias;
    }
}