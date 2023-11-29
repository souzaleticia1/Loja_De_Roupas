namespace Loja_De_Roupas
{
    partial class Aparencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonTemaClaro = new System.Windows.Forms.RadioButton();
            this.radioButtonTemaEscuro = new System.Windows.Forms.RadioButton();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aparência";
            // 
            // radioButtonTemaClaro
            // 
            this.radioButtonTemaClaro.AutoSize = true;
            this.radioButtonTemaClaro.Location = new System.Drawing.Point(287, 191);
            this.radioButtonTemaClaro.Name = "radioButtonTemaClaro";
            this.radioButtonTemaClaro.Size = new System.Drawing.Size(79, 17);
            this.radioButtonTemaClaro.TabIndex = 1;
            this.radioButtonTemaClaro.TabStop = true;
            this.radioButtonTemaClaro.Text = "Tema Claro";
            this.radioButtonTemaClaro.UseVisualStyleBackColor = true;
            this.radioButtonTemaClaro.CheckedChanged += new System.EventHandler(this.radioButtonTemaClaro_CheckedChanged);
            // 
            // radioButtonTemaEscuro
            // 
            this.radioButtonTemaEscuro.AutoSize = true;
            this.radioButtonTemaEscuro.Location = new System.Drawing.Point(287, 214);
            this.radioButtonTemaEscuro.Name = "radioButtonTemaEscuro";
            this.radioButtonTemaEscuro.Size = new System.Drawing.Size(88, 17);
            this.radioButtonTemaEscuro.TabIndex = 2;
            this.radioButtonTemaEscuro.TabStop = true;
            this.radioButtonTemaEscuro.Text = "Tema Escuro";
            this.radioButtonTemaEscuro.UseVisualStyleBackColor = true;
            this.radioButtonTemaEscuro.CheckedChanged += new System.EventHandler(this.radioButtonTemaEscuro_CheckedChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Aparencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.radioButtonTemaEscuro);
            this.Controls.Add(this.radioButtonTemaClaro);
            this.Controls.Add(this.label1);
            this.Name = "Aparencia";
            this.Text = "ConfigGeral";
            this.Load += new System.EventHandler(this.Aparencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonTemaClaro;
        private System.Windows.Forms.RadioButton radioButtonTemaEscuro;
        private System.Windows.Forms.Button btnVoltar;
    }
}