namespace WindowsFormsApp5
{
    partial class Factorial
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
            this.numero = new System.Windows.Forms.TextBox();
            this.hola = new System.Windows.Forms.Button();
            this.hola2 = new System.Windows.Forms.Button();
            this.hola3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(172, 46);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(100, 20);
            this.numero.TabIndex = 0;
            // 
            // hola
            // 
            this.hola.Location = new System.Drawing.Point(61, 239);
            this.hola.Name = "hola";
            this.hola.Size = new System.Drawing.Size(75, 23);
            this.hola.TabIndex = 1;
            this.hola.Text = "&Calcular";
            this.hola.UseVisualStyleBackColor = true;
            // 
            // hola2
            // 
            this.hola2.Location = new System.Drawing.Point(172, 239);
            this.hola2.Name = "hola2";
            this.hola2.Size = new System.Drawing.Size(75, 23);
            this.hola2.TabIndex = 2;
            this.hola2.Text = "Nuevo";
            this.hola2.UseVisualStyleBackColor = true;
            this.hola2.Click += new System.EventHandler(this.hola2_Click);
            // 
            // hola3
            // 
            this.hola3.Location = new System.Drawing.Point(288, 239);
            this.hola3.Name = "hola3";
            this.hola3.Size = new System.Drawing.Size(75, 23);
            this.hola3.TabIndex = 3;
            this.hola3.Text = "Salir";
            this.hola3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresar un numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(172, 99);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(100, 20);
            this.resultado.TabIndex = 6;
            // 
            // Factorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 308);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hola3);
            this.Controls.Add(this.hola2);
            this.Controls.Add(this.hola);
            this.Controls.Add(this.numero);
            this.Name = "Factorial";
            this.Text = "Factorial";
            this.Load += new System.EventHandler(this.Factorial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Button hola;
        private System.Windows.Forms.Button hola2;
        private System.Windows.Forms.Button hola3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultado;
    }
}