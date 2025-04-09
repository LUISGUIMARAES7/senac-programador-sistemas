namespace Login
{
    partial class FormLogin
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
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            lblEmail = new Label();
            lblSenha = new Label();
            lblResultado = new Label();
            label1 = new Label();
            lblNovoUsuario = new Label();
            txtNovoUsuario = new TextBox();
            label2 = new Label();
            txtNovaSenha = new TextBox();
            btnCadastrar = new Button();
            lblRes = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(378, 81);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(240, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(378, 125);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(240, 23);
            txtSenha.TabIndex = 1;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.ActiveCaption;
            btnEntrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(378, 168);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(240, 26);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(378, 63);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Usuário";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(378, 107);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(41, 15);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(378, 215);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 21);
            lblResultado.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 31);
            label1.Name = "label1";
            label1.Size = new Size(221, 21);
            label1.TabIndex = 6;
            label1.Text = "CADASTRO NOVO USUARIO";
            // 
            // lblNovoUsuario
            // 
            lblNovoUsuario.AutoSize = true;
            lblNovoUsuario.Location = new Point(40, 65);
            lblNovoUsuario.Name = "lblNovoUsuario";
            lblNovoUsuario.Size = new Size(47, 15);
            lblNovoUsuario.TabIndex = 7;
            lblNovoUsuario.Text = "Usuario";
            // 
            // txtNovoUsuario
            // 
            txtNovoUsuario.Location = new Point(39, 83);
            txtNovoUsuario.Name = "txtNovoUsuario";
            txtNovoUsuario.Size = new Size(186, 23);
            txtNovoUsuario.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 109);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 9;
            label2.Text = "Digite uma senha";
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(39, 127);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(186, 23);
            txtNovaSenha.TabIndex = 10;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(40, 168);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(184, 23);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Location = new Point(37, 216);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(0, 15);
            lblRes.TabIndex = 12;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(676, 274);
            Controls.Add(lblRes);
            Controls.Add(btnCadastrar);
            Controls.Add(txtNovaSenha);
            Controls.Add(label2);
            Controls.Add(txtNovoUsuario);
            Controls.Add(lblNovoUsuario);
            Controls.Add(label1);
            Controls.Add(lblResultado);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Label lblEmail;
        private Label lblSenha;
        private Label lblResultado;
        private Label label1;
        private Label lblNovoUsuario;
        private TextBox txtNovoUsuario;
        private Label label2;
        private TextBox txtNovaSenha;
        private Button btnCadastrar;
        private Label lblRes;
    }
}
