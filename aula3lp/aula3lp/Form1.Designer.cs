namespace aula3lp
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonResposta = new System.Windows.Forms.Button();
            this.textBoxBase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.textBoxRaio = new System.Windows.Forms.TextBox();
            this.textBoxBaseMaior = new System.Windows.Forms.TextBox();
            this.textBoxBaseMenor = new System.Windows.Forms.TextBox();
            this.buttonEscolha = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRespostaG = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBoxGraus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Retângulo",
            "Círculo",
            "Trapézio",
            "Pentágono"});
            this.comboBox1.Location = new System.Drawing.Point(178, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Opção";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonResposta
            // 
            this.buttonResposta.Location = new System.Drawing.Point(193, 261);
            this.buttonResposta.Name = "buttonResposta";
            this.buttonResposta.Size = new System.Drawing.Size(76, 34);
            this.buttonResposta.TabIndex = 1;
            this.buttonResposta.Text = "Resposta";
            this.buttonResposta.UseVisualStyleBackColor = true;
            this.buttonResposta.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxBase
            // 
            this.textBoxBase.Location = new System.Drawing.Point(178, 125);
            this.textBoxBase.Name = "textBoxBase";
            this.textBoxBase.Size = new System.Drawing.Size(108, 20);
            this.textBoxBase.TabIndex = 2;
            this.textBoxBase.TextChanged += new System.EventHandler(this.textBoxBase_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escolha o Objeto que \r\nquer Calcular a Área:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Base:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Base Menor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Base Maior:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Raio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Altura:";
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(178, 152);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(108, 20);
            this.textBoxAltura.TabIndex = 11;
            this.textBoxAltura.TextChanged += new System.EventHandler(this.textBoxAltura_TextChanged);
            // 
            // textBoxRaio
            // 
            this.textBoxRaio.Location = new System.Drawing.Point(178, 182);
            this.textBoxRaio.Name = "textBoxRaio";
            this.textBoxRaio.Size = new System.Drawing.Size(108, 20);
            this.textBoxRaio.TabIndex = 12;
            this.textBoxRaio.TextChanged += new System.EventHandler(this.textBoxRaio_TextChanged);
            // 
            // textBoxBaseMaior
            // 
            this.textBoxBaseMaior.Location = new System.Drawing.Point(178, 209);
            this.textBoxBaseMaior.Name = "textBoxBaseMaior";
            this.textBoxBaseMaior.Size = new System.Drawing.Size(108, 20);
            this.textBoxBaseMaior.TabIndex = 13;
            this.textBoxBaseMaior.TextChanged += new System.EventHandler(this.textBoxBaseMaior_TextChanged);
            // 
            // textBoxBaseMenor
            // 
            this.textBoxBaseMenor.Location = new System.Drawing.Point(178, 235);
            this.textBoxBaseMenor.Name = "textBoxBaseMenor";
            this.textBoxBaseMenor.Size = new System.Drawing.Size(108, 20);
            this.textBoxBaseMenor.TabIndex = 14;
            this.textBoxBaseMenor.TextChanged += new System.EventHandler(this.textBoxBaseMenor_TextChanged);
            // 
            // buttonEscolha
            // 
            this.buttonEscolha.Location = new System.Drawing.Point(305, 77);
            this.buttonEscolha.Name = "buttonEscolha";
            this.buttonEscolha.Size = new System.Drawing.Size(76, 34);
            this.buttonEscolha.TabIndex = 17;
            this.buttonEscolha.Text = "Escolha";
            this.buttonEscolha.UseVisualStyleBackColor = true;
            this.buttonEscolha.Click += new System.EventHandler(this.buttonResposta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Conversor de Celsius e Fahrenhiet:";
            // 
            // buttonRespostaG
            // 
            this.buttonRespostaG.Location = new System.Drawing.Point(579, 174);
            this.buttonRespostaG.Name = "buttonRespostaG";
            this.buttonRespostaG.Size = new System.Drawing.Size(76, 34);
            this.buttonRespostaG.TabIndex = 19;
            this.buttonRespostaG.Text = "Resposta";
            this.buttonRespostaG.UseVisualStyleBackColor = true;
            this.buttonRespostaG.Click += new System.EventHandler(this.buttonRespostaG_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Celsius -> Fahrenheit",
            "Fahrenheit -> Celsius"});
            this.comboBox2.Location = new System.Drawing.Point(481, 142);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(148, 21);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.Text = "Opção";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBoxGraus
            // 
            this.textBoxGraus.Location = new System.Drawing.Point(635, 143);
            this.textBoxGraus.Name = "textBoxGraus";
            this.textBoxGraus.Size = new System.Drawing.Size(108, 20);
            this.textBoxGraus.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxGraus);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.buttonRespostaG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonEscolha);
            this.Controls.Add(this.textBoxBaseMenor);
            this.Controls.Add(this.textBoxBaseMaior);
            this.Controls.Add(this.textBoxRaio);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBase);
            this.Controls.Add(this.buttonResposta);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonResposta;
        private System.Windows.Forms.TextBox textBoxBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.TextBox textBoxRaio;
        private System.Windows.Forms.TextBox textBoxBaseMaior;
        private System.Windows.Forms.TextBox textBoxBaseMenor;
        private System.Windows.Forms.Button buttonEscolha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRespostaG;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBoxGraus;
    }
}

