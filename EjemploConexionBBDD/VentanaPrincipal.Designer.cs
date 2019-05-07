namespace EjemploConexionBBDD
{
    partial class VentanaPrincipal
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
            this.Desplegable1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Desplegable1
            // 
            this.Desplegable1.FormattingEnabled = true;
            this.Desplegable1.Location = new System.Drawing.Point(24, 56);
            this.Desplegable1.Name = "Desplegable1";
            this.Desplegable1.Size = new System.Drawing.Size(299, 21);
            this.Desplegable1.TabIndex = 0;
            this.Desplegable1.SelectedIndexChanged += new System.EventHandler(this.Desplegable1_SelectedIndexChanged);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Desplegable1);
            this.Name = "VentanaPrincipal";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Desplegable1;
    }
}