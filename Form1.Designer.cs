namespace Mult
{
    partial class FrmMenuPrincipal
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
            this.btnIr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIr
            // 
            this.btnIr.Location = new System.Drawing.Point(331, 422);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(75, 23);
            this.btnIr.TabIndex = 0;
            this.btnIr.Text = "Ir A la Tabla";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 457);
            this.Controls.Add(this.btnIr);
            this.Name = "FrmMenuPrincipal";
            this.Text = "Menú de Número";
            this.Load += new System.EventHandler(this.wMulti);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIr;
    }
}

