namespace CadastroCliente
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mTxtTelefone = new MaskedTextBox();
            btnCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            txtNome = new TextBox();
            txtNomeSocial = new TextBox();
            txtEmail = new TextBox();
            mTxtDataNascimento = new MaskedTextBox();
            cBoxGenero = new ComboBox();
            checkBoxEstrangeiro = new CheckBox();
            cBoxEtnia = new ComboBox();
            radioPF = new RadioButton();
            radioPJ = new RadioButton();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            txtNumero = new TextBox();
            txtLogradouro = new TextBox();
            txtComplemento = new TextBox();
            txtBairro = new TextBox();
            txtMunicipio = new TextBox();
            mTxtCEP = new MaskedTextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            cBoxEstado = new ComboBox();
            lblErro = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // mTxtTelefone
            // 
            mTxtTelefone.Font = new Font("Segoe UI", 12F);
            mTxtTelefone.Location = new Point(408, 47);
            mTxtTelefone.Mask = "(99) 00000-0000";
            mTxtTelefone.Name = "mTxtTelefone";
            mTxtTelefone.Size = new Size(135, 29);
            mTxtTelefone.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(351, 382);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(91, 23);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 21);
            label1.TabIndex = 2;
            label1.Text = "CADASTRO DE CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(8, 55);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(8, 90);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(348, 55);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 6;
            label4.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(563, 53);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 7;
            label5.Text = "Data de Nasc:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(348, 90);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 8;
            label6.Text = "Gênero:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(8, 125);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 9;
            label7.Text = "Nome Social:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(528, 90);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 10;
            label8.Text = "Etnia:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(531, 125);
            label10.Name = "label10";
            label10.Size = new Size(93, 15);
            label10.TabIndex = 12;
            label10.Text = "Tipo de Cliente:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(57, 47);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(276, 29);
            txtNome.TabIndex = 13;
            // 
            // txtNomeSocial
            // 
            txtNomeSocial.Location = new Point(91, 117);
            txtNomeSocial.Name = "txtNomeSocial";
            txtNomeSocial.Size = new Size(242, 29);
            txtNomeSocial.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(57, 82);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(276, 29);
            txtEmail.TabIndex = 17;
            // 
            // mTxtDataNascimento
            // 
            mTxtDataNascimento.Font = new Font("Segoe UI", 12F);
            mTxtDataNascimento.Location = new Point(651, 45);
            mTxtDataNascimento.Mask = "00/00/0000";
            mTxtDataNascimento.Name = "mTxtDataNascimento";
            mTxtDataNascimento.Size = new Size(96, 29);
            mTxtDataNascimento.TabIndex = 18;
            mTxtDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // cBoxGenero
            // 
            cBoxGenero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxGenero.FormattingEnabled = true;
            cBoxGenero.Items.AddRange(new object[] { "Macho", "Fêmea", "Diferente" });
            cBoxGenero.Location = new Point(408, 82);
            cBoxGenero.Name = "cBoxGenero";
            cBoxGenero.Size = new Size(100, 29);
            cBoxGenero.TabIndex = 19;
            // 
            // checkBoxEstrangeiro
            // 
            checkBoxEstrangeiro.AutoSize = true;
            checkBoxEstrangeiro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxEstrangeiro.Location = new Point(354, 125);
            checkBoxEstrangeiro.Name = "checkBoxEstrangeiro";
            checkBoxEstrangeiro.Size = new Size(89, 19);
            checkBoxEstrangeiro.TabIndex = 20;
            checkBoxEstrangeiro.Text = "Estrangeiro";
            checkBoxEstrangeiro.UseVisualStyleBackColor = true;
            // 
            // cBoxEtnia
            // 
            cBoxEtnia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxEtnia.FormattingEnabled = true;
            cBoxEtnia.Items.AddRange(new object[] { "Asiática ", "Branca", "Negra ", "Indígena", "Latina", "Árabe ", "Judaica", "Roma (Cigana)", "Polinésia", "Mestiça", "Nativo Americano", "Aborígene Australiano", "Sul-Asiática", "Europeia", "Subsaariana" });
            cBoxEtnia.Location = new Point(570, 82);
            cBoxEtnia.Name = "cBoxEtnia";
            cBoxEtnia.Size = new Size(177, 29);
            cBoxEtnia.TabIndex = 21;
            // 
            // radioPF
            // 
            radioPF.AutoSize = true;
            radioPF.Checked = true;
            radioPF.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioPF.Location = new Point(637, 121);
            radioPF.Name = "radioPF";
            radioPF.Size = new Size(38, 19);
            radioPF.TabIndex = 22;
            radioPF.TabStop = true;
            radioPF.Text = "PF";
            radioPF.UseVisualStyleBackColor = true;
            // 
            // radioPJ
            // 
            radioPJ.AutoSize = true;
            radioPJ.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioPJ.Location = new Point(681, 121);
            radioPJ.Name = "radioPJ";
            radioPJ.Size = new Size(36, 19);
            radioPJ.TabIndex = 23;
            radioPJ.Text = "PJ";
            radioPJ.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(22, 24);
            label11.Name = "label11";
            label11.Size = new Size(74, 15);
            label11.TabIndex = 25;
            label11.Text = "Logradouro:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(476, 24);
            label12.Name = "label12";
            label12.Size = new Size(56, 15);
            label12.TabIndex = 26;
            label12.Text = "Número:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(22, 52);
            label13.Name = "label13";
            label13.Size = new Size(89, 15);
            label13.TabIndex = 27;
            label13.Text = "Complemento:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.Location = new Point(478, 51);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 28;
            label14.Text = "Bairro:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label15.Location = new Point(22, 83);
            label15.Name = "label15";
            label15.Size = new Size(64, 15);
            label15.TabIndex = 29;
            label15.Text = "Município:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(306, 82);
            label16.Name = "label16";
            label16.Size = new Size(46, 15);
            label16.TabIndex = 30;
            label16.Text = "Estado:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label17.Location = new Point(478, 83);
            label17.Name = "label17";
            label17.Size = new Size(30, 15);
            label17.TabIndex = 31;
            label17.Text = "CEP:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(536, 16);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(190, 23);
            txtNumero.TabIndex = 32;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(100, 16);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(363, 23);
            txtLogradouro.TabIndex = 33;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(117, 45);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(346, 23);
            txtComplemento.TabIndex = 34;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(525, 45);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(201, 23);
            txtBairro.TabIndex = 35;
            // 
            // txtMunicipio
            // 
            txtMunicipio.Location = new Point(100, 74);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(190, 23);
            txtMunicipio.TabIndex = 36;
            // 
            // mTxtCEP
            // 
            mTxtCEP.Location = new Point(514, 74);
            mTxtCEP.Mask = "00000-000";
            mTxtCEP.Name = "mTxtCEP";
            mTxtCEP.Size = new Size(100, 23);
            mTxtCEP.TabIndex = 38;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioPJ);
            groupBox1.Controls.Add(radioPF);
            groupBox1.Controls.Add(cBoxEtnia);
            groupBox1.Controls.Add(checkBoxEstrangeiro);
            groupBox1.Controls.Add(cBoxGenero);
            groupBox1.Controls.Add(mTxtDataNascimento);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtNomeSocial);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(mTxtTelefone);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(16, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(762, 170);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Pessoais";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cBoxEstado);
            groupBox2.Controls.Add(mTxtCEP);
            groupBox2.Controls.Add(txtMunicipio);
            groupBox2.Controls.Add(txtBairro);
            groupBox2.Controls.Add(txtComplemento);
            groupBox2.Controls.Add(txtLogradouro);
            groupBox2.Controls.Add(txtNumero);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(16, 233);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(764, 127);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            groupBox2.Text = "Endereço";
            // 
            // cBoxEstado
            // 
            cBoxEstado.FormattingEnabled = true;
            cBoxEstado.Items.AddRange(new object[] { "AC ", "AL", "AP ", "AM ", "BA ", "CE ", "DF ", "ES ", "GO ", "MA ", "MT ", "MS ", "MG ", "PA ", "PB ", "PR ", "PE ", "PI ", "RJ ", "RN ", "RS ", "RO ", "RR ", "SC ", "SP ", "SE ", "TO" });
            cBoxEstado.Location = new Point(357, 74);
            cBoxEstado.Name = "cBoxEstado";
            cBoxEstado.Size = new Size(106, 23);
            cBoxEstado.TabIndex = 39;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Location = new Point(12, 406);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(0, 15);
            lblErro.TabIndex = 40;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 441);
            Controls.Add(lblErro);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mTxtTelefone;
        private Button btnCadastrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private TextBox txtNome;
        private TextBox txtNomeSocial;
        private TextBox txtEmail;
        private MaskedTextBox mTxtDataNascimento;
        private ComboBox cBoxGenero;
        private CheckBox checkBoxEstrangeiro;
        private ComboBox cBoxEtnia;
        private RadioButton radioPF;
        private RadioButton radioPJ;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txtNumero;
        private TextBox txtLogradouro;
        private TextBox txtComplemento;
        private TextBox txtBairro;
        private TextBox txtMunicipio;
        private MaskedTextBox mTxtCEP;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cBoxEstado;
        private Label lblErro;
    }
}
