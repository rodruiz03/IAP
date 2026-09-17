namespace L4RJRJ1037623
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
            this.lb1_accion = new System.Windows.Forms.Label();
            this.txt_numero_ingresado = new System.Windows.Forms.TextBox();
            this.butt_mostrar_fibonacci = new System.Windows.Forms.Button();
            this.lb2_serie_de_Fibonacci = new System.Windows.Forms.Label();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb1_accion
            // 
            this.lb1_accion.AutoSize = true;
            this.lb1_accion.Location = new System.Drawing.Point(77, 94);
            this.lb1_accion.Name = "lb1_accion";
            this.lb1_accion.Size = new System.Drawing.Size(182, 16);
            this.lb1_accion.TabIndex = 0;
            this.lb1_accion.Text = "Ingrese un número mayor a N";
            this.lb1_accion.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_numero_ingresado
            // 
            this.txt_numero_ingresado.Location = new System.Drawing.Point(276, 94);
            this.txt_numero_ingresado.Name = "txt_numero_ingresado";
            this.txt_numero_ingresado.Size = new System.Drawing.Size(100, 22);
            this.txt_numero_ingresado.TabIndex = 1;
            // 
            // butt_mostrar_fibonacci
            // 
            this.butt_mostrar_fibonacci.Location = new System.Drawing.Point(400, 91);
            this.butt_mostrar_fibonacci.Name = "butt_mostrar_fibonacci";
            this.butt_mostrar_fibonacci.Size = new System.Drawing.Size(137, 23);
            this.butt_mostrar_fibonacci.TabIndex = 2;
            this.butt_mostrar_fibonacci.Text = "Mostrar Fibonacci";
            this.butt_mostrar_fibonacci.UseVisualStyleBackColor = true;
            this.butt_mostrar_fibonacci.Click += new System.EventHandler(this.butt_mostrar_fibonacci_Click);
            // 
            // lb2_serie_de_Fibonacci
            // 
            this.lb2_serie_de_Fibonacci.AutoSize = true;
            this.lb2_serie_de_Fibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2_serie_de_Fibonacci.Location = new System.Drawing.Point(95, 155);
            this.lb2_serie_de_Fibonacci.Name = "lb2_serie_de_Fibonacci";
            this.lb2_serie_de_Fibonacci.Size = new System.Drawing.Size(138, 16);
            this.lb2_serie_de_Fibonacci.TabIndex = 4;
            this.lb2_serie_de_Fibonacci.Text = "Serie de Fibonacci";
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(273, 155);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(0, 16);
            this.lb_resultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.lb2_serie_de_Fibonacci);
            this.Controls.Add(this.butt_mostrar_fibonacci);
            this.Controls.Add(this.txt_numero_ingresado);
            this.Controls.Add(this.lb1_accion);
            this.Name = "Form1";
            this.Text = "Ejercisio No.04 1037623";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1_accion;
        private System.Windows.Forms.TextBox txt_numero_ingresado;
        private System.Windows.Forms.Button butt_mostrar_fibonacci;
        private System.Windows.Forms.Label lb2_serie_de_Fibonacci;
        private System.Windows.Forms.Label lb_resultado;
    }
}

