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
            this.textTituloArticulos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textTituloArticulos
            // 
            this.textTituloArticulos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textTituloArticulos.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTituloArticulos.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textTituloArticulos.Location = new System.Drawing.Point(12, 12);
            this.textTituloArticulos.Name = "textTituloArticulos";
            this.textTituloArticulos.Size = new System.Drawing.Size(776, 26);
            this.textTituloArticulos.TabIndex = 3;
            this.textTituloArticulos.Text = "MARCAS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(12, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "TRAER DATOS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textTituloArticulos);
            this.Name = "FormMarcas";
            this.Text = "FormMarcas";
            this.Load += new System.EventHandler(this.FormMarcas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTituloArticulos;
        private System.Windows.Forms.Button button1;
    }
}