namespace CadastroDeClientes
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
        /// 
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
            buttonCadastrar = new Button();
            maskedTextBoxTelefone = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            textBoxNome = new TextBox();
            textBoxNomeSocial = new TextBox();
            textBoxEmail = new TextBox();
            maskedTextBoxDataNascimento = new MaskedTextBox();
            comboBoxGenero = new ComboBox();
            checkBoxEstrangeiro = new CheckBox();
            comboBoxEtnia = new ComboBox();
            radioButtonPf = new RadioButton();
            radioButtonPj = new RadioButton();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            textBoxNumero = new TextBox();
            textBoxLogradouro = new TextBox();
            textBoxComplemento = new TextBox();
            textBoxBairro = new TextBox();
            textBoxMunicipio = new TextBox();
            maskedTextBoxCEP = new MaskedTextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBoxEstado = new TextBox();
            labelErro = new Label();
            dataGridViewClientes = new DataGridView();
            buttonRemover = new Button();
            buttonEditar = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCadastrar.Location = new Point(54, 382);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(91, 23);
            buttonCadastrar.TabIndex = 17;
            buttonCadastrar.Text = "ADICIONAR";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonAdicionar_Click;
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Font = new Font("Segoe UI", 12F);
            maskedTextBoxTelefone.Location = new Point(408, 47);
            maskedTextBoxTelefone.Mask = "(99) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(135, 29);
            maskedTextBoxTelefone.TabIndex = 1;
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
            // textBoxNome
            // 
            textBoxNome.Font = new Font("Segoe UI", 12F);
            textBoxNome.Location = new Point(57, 47);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(276, 29);
            textBoxNome.TabIndex = 0;
            // 
            // textBoxNomeSocial
            // 
            textBoxNomeSocial.Font = new Font("Segoe UI", 12F);
            textBoxNomeSocial.Location = new Point(91, 117);
            textBoxNomeSocial.Name = "textBoxNomeSocial";
            textBoxNomeSocial.Size = new Size(242, 29);
            textBoxNomeSocial.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(57, 82);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(276, 29);
            textBoxEmail.TabIndex = 3;
            // 
            // maskedTextBoxDataNascimento
            // 
            maskedTextBoxDataNascimento.Font = new Font("Segoe UI", 12F);
            maskedTextBoxDataNascimento.Location = new Point(651, 45);
            maskedTextBoxDataNascimento.Mask = "00/00/0000";
            maskedTextBoxDataNascimento.Name = "maskedTextBoxDataNascimento";
            maskedTextBoxDataNascimento.Size = new Size(96, 29);
            maskedTextBoxDataNascimento.TabIndex = 2;
            maskedTextBoxDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Macho", "Fêmea", "Diferente" });
            comboBoxGenero.Location = new Point(408, 82);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(100, 29);
            comboBoxGenero.TabIndex = 4;
            // 
            // checkBoxEstrangeiro
            // 
            checkBoxEstrangeiro.AutoSize = true;
            checkBoxEstrangeiro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxEstrangeiro.Location = new Point(354, 125);
            checkBoxEstrangeiro.Name = "checkBoxEstrangeiro";
            checkBoxEstrangeiro.Size = new Size(89, 19);
            checkBoxEstrangeiro.TabIndex = 7;
            checkBoxEstrangeiro.Text = "Estrangeiro";
            checkBoxEstrangeiro.UseVisualStyleBackColor = true;
            // 
            // comboBoxEtnia
            // 
            comboBoxEtnia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxEtnia.FormattingEnabled = true;
            comboBoxEtnia.Items.AddRange(new object[] { "Branco", "Preto", "Pardo", "Amarelo" });
            comboBoxEtnia.Location = new Point(570, 82);
            comboBoxEtnia.Name = "comboBoxEtnia";
            comboBoxEtnia.Size = new Size(177, 29);
            comboBoxEtnia.TabIndex = 5;
            // 
            // radioButtonPf
            // 
            radioButtonPf.AutoSize = true;
            radioButtonPf.Checked = true;
            radioButtonPf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonPf.Location = new Point(637, 121);
            radioButtonPf.Name = "radioButtonPf";
            radioButtonPf.Size = new Size(38, 19);
            radioButtonPf.TabIndex = 8;
            radioButtonPf.TabStop = true;
            radioButtonPf.Text = "PF";
            radioButtonPf.UseVisualStyleBackColor = true;
            // 
            // radioButtonPj
            // 
            radioButtonPj.AutoSize = true;
            radioButtonPj.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButtonPj.Location = new Point(681, 121);
            radioButtonPj.Name = "radioButtonPj";
            radioButtonPj.Size = new Size(36, 19);
            radioButtonPj.TabIndex = 9;
            radioButtonPj.Text = "PJ";
            radioButtonPj.UseVisualStyleBackColor = true;
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
            // textBoxNumero
            // 
            textBoxNumero.Font = new Font("Segoe UI", 9F);
            textBoxNumero.Location = new Point(536, 16);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(190, 23);
            textBoxNumero.TabIndex = 11;
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Font = new Font("Segoe UI", 9F);
            textBoxLogradouro.Location = new Point(100, 16);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(363, 23);
            textBoxLogradouro.TabIndex = 10;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Font = new Font("Segoe UI", 9F);
            textBoxComplemento.Location = new Point(117, 45);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(346, 23);
            textBoxComplemento.TabIndex = 12;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Font = new Font("Segoe UI", 9F);
            textBoxBairro.Location = new Point(525, 45);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(201, 23);
            textBoxBairro.TabIndex = 13;
            // 
            // textBoxMunicipio
            // 
            textBoxMunicipio.Font = new Font("Segoe UI", 9F);
            textBoxMunicipio.Location = new Point(100, 74);
            textBoxMunicipio.Name = "textBoxMunicipio";
            textBoxMunicipio.Size = new Size(190, 23);
            textBoxMunicipio.TabIndex = 14;
            // 
            // maskedTextBoxCEP
            // 
            maskedTextBoxCEP.Font = new Font("Segoe UI", 9F);
            maskedTextBoxCEP.Location = new Point(514, 74);
            maskedTextBoxCEP.Mask = "00000-000";
            maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            maskedTextBoxCEP.Size = new Size(100, 23);
            maskedTextBoxCEP.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonPj);
            groupBox1.Controls.Add(radioButtonPf);
            groupBox1.Controls.Add(comboBoxEtnia);
            groupBox1.Controls.Add(checkBoxEstrangeiro);
            groupBox1.Controls.Add(comboBoxGenero);
            groupBox1.Controls.Add(maskedTextBoxDataNascimento);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxNomeSocial);
            groupBox1.Controls.Add(textBoxNome);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(maskedTextBoxTelefone);
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
            groupBox2.Controls.Add(textBoxEstado);
            groupBox2.Controls.Add(maskedTextBoxCEP);
            groupBox2.Controls.Add(textBoxMunicipio);
            groupBox2.Controls.Add(textBoxBairro);
            groupBox2.Controls.Add(textBoxComplemento);
            groupBox2.Controls.Add(textBoxLogradouro);
            groupBox2.Controls.Add(textBoxNumero);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(16, 233);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(764, 127);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            groupBox2.Text = "Endereço";
            // 
            // textBoxEstado
            // 
            textBoxEstado.Font = new Font("Segoe UI", 9F);
            textBoxEstado.Location = new Point(358, 75);
            textBoxEstado.Name = "textBoxEstado";
            textBoxEstado.Size = new Size(105, 23);
            textBoxEstado.TabIndex = 15;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(12, 406);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 15);
            labelErro.TabIndex = 40;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewClientes.AllowUserToOrderColumns = true;
            dataGridViewClientes.AllowUserToResizeRows = false;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(16, 427);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.Size = new Size(764, 217);
            dataGridViewClientes.TabIndex = 42;
            // 
            // buttonRemover
            // 
            buttonRemover.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRemover.Location = new Point(642, 382);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(91, 23);
            buttonRemover.TabIndex = 20;
            buttonRemover.Text = "REMOVER";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditar.Location = new Point(258, 382);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(91, 23);
            buttonEditar.TabIndex = 18;
            buttonEditar.Text = "EDITAR";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(455, 382);
            button1.Name = "button1";
            button1.Size = new Size(83, 23);
            button1.TabIndex = 19;
            button1.Text = "ATUALIZAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 656);
            Controls.Add(button1);
            Controls.Add(buttonEditar);
            Controls.Add(buttonRemover);
            Controls.Add(dataGridViewClientes);
            Controls.Add(labelErro);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(buttonCadastrar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox textBoxNome;
        private MaskedTextBox maskedTextBoxTelefone;
        private MaskedTextBox maskedTextBoxDataNascimento;
        private TextBox textBoxEmail;
        private ComboBox comboBoxGenero;
        private ComboBox comboBoxEtnia;
        private TextBox textBoxNomeSocial;
        private CheckBox checkBoxEstrangeiro;
        private RadioButton radioButtonPf;
        private RadioButton radioButtonPj;
        private TextBox textBoxLogradouro;
        private TextBox textBoxNumero;
        private TextBox textBoxComplemento;
        private TextBox textBoxBairro;
        private TextBox textBoxMunicipio;
        private TextBox textBoxEstado;
        private MaskedTextBox maskedTextBoxCEP;
        private Button buttonEditar;
        private Button buttonCadastrar;
        private Button buttonRemover;
        private Label labelErro;
        private DataGridView dataGridViewClientes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
    }
}
