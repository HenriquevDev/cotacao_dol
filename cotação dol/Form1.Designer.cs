namespace cotação_dol
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConverter = new System.Windows.Forms.Button();
            this.textBoxReal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDolar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escreva em Reais para ver o resultado em Dólares";
            // 
            // buttonConverter
            // 
            this.buttonConverter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConverter.Font = new System.Drawing.Font("Schadow BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConverter.Location = new System.Drawing.Point(154, 122);
            this.buttonConverter.Name = "buttonConverter";
            this.buttonConverter.Size = new System.Drawing.Size(118, 31);
            this.buttonConverter.TabIndex = 1;
            this.buttonConverter.Text = "Converter";
            this.buttonConverter.UseVisualStyleBackColor = false;
            this.buttonConverter.Click += new System.EventHandler(this.buttonConverter_Click);
            // 
            // textBoxReal
            // 
            this.textBoxReal.BackColor = System.Drawing.Color.Black;
            this.textBoxReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxReal.ForeColor = System.Drawing.Color.White;
            this.textBoxReal.Location = new System.Drawing.Point(65, 83);
            this.textBoxReal.Name = "textBoxReal";
            this.textBoxReal.Size = new System.Drawing.Size(96, 20);
            this.textBoxReal.TabIndex = 2;
            this.textBoxReal.TextChanged += new System.EventHandler(this.textBoxReal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(32, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "R$";
            // 
            // textBoxDolar
            // 
            this.textBoxDolar.BackColor = System.Drawing.Color.Black;
            this.textBoxDolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDolar.ForeColor = System.Drawing.Color.White;
            this.textBoxDolar.Location = new System.Drawing.Point(346, 83);
            this.textBoxDolar.Name = "textBoxDolar";
            this.textBoxDolar.Size = new System.Drawing.Size(96, 20);
            this.textBoxDolar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(284, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dolar $";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Font = new System.Drawing.Font("Schadow BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(324, 122);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(118, 31);
            this.buttonLimpar.TabIndex = 6;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(543, 250);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDolar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxReal);
            this.Controls.Add(this.buttonConverter);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conversão";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConverter;
        private System.Windows.Forms.TextBox textBoxReal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDolar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLimpar;
    }
}

