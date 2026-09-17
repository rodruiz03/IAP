namespace L6RJRJ1037623
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tCAutomovil = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tBModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBPrecio = new System.Windows.Forms.TextBox();
            this.tBTC = new System.Windows.Forms.TextBox();
            this.tBMarca = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tCAutomovil);
            this.tabControl1.Location = new System.Drawing.Point(36, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(289, 271);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.tBTC);
            this.tabPage1.Controls.Add(this.tBMarca);
            this.tabPage1.Controls.Add(this.tBPrecio);
            this.tabPage1.Controls.Add(this.tBModelo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(281, 242);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingreso de datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tCAutomovil
            // 
            this.tCAutomovil.Location = new System.Drawing.Point(4, 25);
            this.tCAutomovil.Name = "tCAutomovil";
            this.tCAutomovil.Padding = new System.Windows.Forms.Padding(3);
            this.tCAutomovil.Size = new System.Drawing.Size(281, 242);
            this.tCAutomovil.TabIndex = 1;
            this.tCAutomovil.Text = "Datos Automovil";
            this.tCAutomovil.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo:";
            // 
            // tBModelo
            // 
            this.tBModelo.Location = new System.Drawing.Point(121, 6);
            this.tBModelo.Name = "tBModelo";
            this.tBModelo.Size = new System.Drawing.Size(100, 22);
            this.tBModelo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Cambio:";
            // 
            // tBPrecio
            // 
            this.tBPrecio.Location = new System.Drawing.Point(121, 41);
            this.tBPrecio.Name = "tBPrecio";
            this.tBPrecio.Size = new System.Drawing.Size(100, 22);
            this.tBPrecio.TabIndex = 4;
            // 
            // tBTC
            // 
            this.tBTC.Location = new System.Drawing.Point(121, 106);
            this.tBTC.Name = "tBTC";
            this.tBTC.Size = new System.Drawing.Size(100, 22);
            this.tBTC.TabIndex = 6;
            // 
            // tBMarca
            // 
            this.tBMarca.Location = new System.Drawing.Point(121, 71);
            this.tBMarca.Name = "tBMarca";
            this.tBMarca.Size = new System.Drawing.Size(100, 22);
            this.tBMarca.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(70, 150);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 55);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar Informacion";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Laboratorio #6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tCAutomovil;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tBTC;
        private System.Windows.Forms.TextBox tBMarca;
        private System.Windows.Forms.TextBox tBPrecio;
        private System.Windows.Forms.TextBox tBModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

