namespace L8_RJRJ_1037623
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
            this.mtbM = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnM = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbN = new System.Windows.Forms.MaskedTextBox();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.dGVMostrar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbM
            // 
            this.mtbM.Location = new System.Drawing.Point(110, 62);
            this.mtbM.Mask = "000";
            this.mtbM.Name = "mtbM";
            this.mtbM.Size = new System.Drawing.Size(30, 22);
            this.mtbM.TabIndex = 0;
            this.mtbM.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la cantidad de filas:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(70, 90);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(106, 31);
            this.btnM.TabIndex = 2;
            this.btnM.Text = "Ingreso";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnDimenciones_Click);
            // 
            // btnN
            // 
            this.btnN.Location = new System.Drawing.Point(355, 90);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(106, 31);
            this.btnN.TabIndex = 5;
            this.btnN.Text = "Ingreso";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese la cantidad de filas";
            // 
            // mtbN
            // 
            this.mtbN.Location = new System.Drawing.Point(395, 62);
            this.mtbN.Mask = "000";
            this.mtbN.Name = "mtbN";
            this.mtbN.Size = new System.Drawing.Size(30, 22);
            this.mtbN.TabIndex = 3;
            this.mtbN.ValidatingType = typeof(int);
            // 
            // BtnCrear
            // 
            this.BtnCrear.Location = new System.Drawing.Point(228, 62);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(106, 31);
            this.BtnCrear.TabIndex = 6;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // dGVMostrar
            // 
            this.dGVMostrar.AllowUserToAddRows = false;
            this.dGVMostrar.AllowUserToDeleteRows = false;
            this.dGVMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMostrar.ColumnHeadersVisible = false;
            this.dGVMostrar.Location = new System.Drawing.Point(56, 127);
            this.dGVMostrar.Name = "dGVMostrar";
            this.dGVMostrar.ReadOnly = true;
            this.dGVMostrar.RowHeadersVisible = false;
            this.dGVMostrar.RowHeadersWidth = 51;
            this.dGVMostrar.RowTemplate.Height = 24;
            this.dGVMostrar.Size = new System.Drawing.Size(438, 297);
            this.dGVMostrar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.dGVMostrar);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtbN);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbM);
            this.Name = "Form1";
            this.Text = "L8+RJRJ+1037623";
            ((System.ComponentModel.ISupportInitialize)(this.dGVMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbN;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.DataGridView dGVMostrar;
    }
}

