namespace Paqueteria
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.correoNormal = new System.Windows.Forms.CheckBox();
            this.paqueteriaNormal = new System.Windows.Forms.CheckBox();
            this.paqueteriaUrgente = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Email",
            "Teléfono",
            "Fax"});
            this.checkedListBox1.Location = new System.Drawing.Point(19, 185);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(325, 143);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Calcular coste";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // correoNormal
            // 
            this.correoNormal.AutoSize = true;
            this.correoNormal.Location = new System.Drawing.Point(19, 59);
            this.correoNormal.Name = "correoNormal";
            this.correoNormal.Size = new System.Drawing.Size(135, 17);
            this.correoNormal.TabIndex = 9;
            this.correoNormal.Text = "Correo Normal--> 2.50€";
            this.correoNormal.UseVisualStyleBackColor = true;
            // 
            // paqueteriaNormal
            // 
            this.paqueteriaNormal.AutoSize = true;
            this.paqueteriaNormal.Location = new System.Drawing.Point(19, 82);
            this.paqueteriaNormal.Name = "paqueteriaNormal";
            this.paqueteriaNormal.Size = new System.Drawing.Size(152, 17);
            this.paqueteriaNormal.TabIndex = 10;
            this.paqueteriaNormal.Text = "Paqueteria Normal-->3.50€";
            this.paqueteriaNormal.UseVisualStyleBackColor = true;
            // 
            // paqueteriaUrgente
            // 
            this.paqueteriaUrgente.AutoSize = true;
            this.paqueteriaUrgente.Location = new System.Drawing.Point(19, 105);
            this.paqueteriaUrgente.Name = "paqueteriaUrgente";
            this.paqueteriaUrgente.Size = new System.Drawing.Size(157, 17);
            this.paqueteriaUrgente.TabIndex = 11;
            this.paqueteriaUrgente.Text = "Paquetería urgente-->5.00€";
            this.paqueteriaUrgente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Te avisamos totalmente GRATIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "El pedido cuesta 17.80€";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Selecciona una sola opción, porfavor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 322);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paqueteriaUrgente);
            this.Controls.Add(this.paqueteriaNormal);
            this.Controls.Add(this.correoNormal);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox correoNormal;
        private System.Windows.Forms.CheckBox paqueteriaNormal;
        private System.Windows.Forms.CheckBox paqueteriaUrgente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}

