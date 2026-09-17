namespace L7_RJRJ_1037623
{
    partial class Form1
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
            this.lBDatos = new System.Windows.Forms.ListBox();
            this.Lpromedio = new System.Windows.Forms.Label();
            this.LDesviacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lBDatos
            // 
            this.lBDatos.FormattingEnabled = true;
            this.lBDatos.ItemHeight = 16;
            this.lBDatos.Location = new System.Drawing.Point(244, 82);
            this.lBDatos.Name = "lBDatos";
            this.lBDatos.Size = new System.Drawing.Size(120, 164);
            this.lBDatos.TabIndex = 0;
            this.lBDatos.SelectedIndexChanged += new System.EventHandler(this.lBDatos_SelectedIndexChanged);
            // 
            // Lpromedio
            // 
            this.Lpromedio.AutoSize = true;
            this.Lpromedio.Location = new System.Drawing.Point(424, 82);
            this.Lpromedio.Name = "Lpromedio";
            this.Lpromedio.Size = new System.Drawing.Size(0, 16);
            this.Lpromedio.TabIndex = 1;
            // 
            // LDesviacion
            // 
            this.LDesviacion.AutoSize = true;
            this.LDesviacion.Location = new System.Drawing.Point(424, 124);
            this.LDesviacion.Name = "LDesviacion";
            this.LDesviacion.Size = new System.Drawing.Size(0, 16);
            this.LDesviacion.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LDesviacion);
            this.Controls.Add(this.Lpromedio);
            this.Controls.Add(this.lBDatos);
            this.Name = "Form1";
            this.Text = "L7+RJRJ+1037623";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBDatos;
        private System.Windows.Forms.Label Lpromedio;
        private System.Windows.Forms.Label LDesviacion;
    }
}

