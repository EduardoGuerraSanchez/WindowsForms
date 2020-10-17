namespace Suma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Button();
            this.texto1 = new System.Windows.Forms.TextBox();
            this.texto2 = new System.Windows.Forms.TextBox();
            this.textoResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce el primer numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Introduce el segundo numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(218, 189);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 3;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(53, 189);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(75, 23);
            this.resultado.TabIndex = 4;
            this.resultado.Text = "Resultado";
            this.resultado.UseVisualStyleBackColor = true;
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // texto1
            // 
            this.texto1.Location = new System.Drawing.Point(218, 42);
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(100, 20);
            this.texto1.TabIndex = 5;
            // 
            // texto2
            // 
            this.texto2.Location = new System.Drawing.Point(218, 83);
            this.texto2.Name = "texto2";
            this.texto2.Size = new System.Drawing.Size(100, 20);
            this.texto2.TabIndex = 6;
            // 
            // textoResultado
            // 
            this.textoResultado.Location = new System.Drawing.Point(218, 132);
            this.textoResultado.Name = "textoResultado";
            this.textoResultado.Size = new System.Drawing.Size(100, 20);
            this.textoResultado.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 294);
            this.Controls.Add(this.textoResultado);
            this.Controls.Add(this.texto2);
            this.Controls.Add(this.texto1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Suma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button resultado;
        private System.Windows.Forms.TextBox texto1;
        private System.Windows.Forms.TextBox texto2;
        private System.Windows.Forms.TextBox textoResultado;
    }
}

