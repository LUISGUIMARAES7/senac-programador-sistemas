namespace Calculadora
{
    partial class Form2
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
            radioPer = new RadioButton();
            radioArea = new RadioButton();
            radioVol = new RadioButton();
            btnCalcular = new Button();
            txtLado1 = new TextBox();
            lblRes = new Label();
            txtLado2 = new TextBox();
            label2 = new Label();
            lblErro = new Label();
            radioQuad = new RadioButton();
            radioRet = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // radioPer
            // 
            radioPer.AutoSize = true;
            radioPer.Location = new Point(24, 172);
            radioPer.Name = "radioPer";
            radioPer.Size = new Size(77, 19);
            radioPer.TabIndex = 0;
            radioPer.TabStop = true;
            radioPer.Text = "Perímetro";
            radioPer.UseVisualStyleBackColor = true;
            // 
            // radioArea
            // 
            radioArea.AutoSize = true;
            radioArea.Location = new Point(147, 172);
            radioArea.Name = "radioArea";
            radioArea.Size = new Size(49, 19);
            radioArea.TabIndex = 1;
            radioArea.TabStop = true;
            radioArea.Text = "Área";
            radioArea.UseVisualStyleBackColor = true;
            // 
            // radioVol
            // 
            radioVol.AutoSize = true;
            radioVol.Location = new Point(259, 172);
            radioVol.Name = "radioVol";
            radioVol.Size = new Size(65, 19);
            radioVol.TabIndex = 2;
            radioVol.TabStop = true;
            radioVol.Text = "Volume";
            radioVol.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(135, 216);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtLado1
            // 
            txtLado1.Location = new Point(81, 83);
            txtLado1.Name = "txtLado1";
            txtLado1.Size = new Size(63, 23);
            txtLado1.TabIndex = 4;
            txtLado1.Text = "0";
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Font = new Font("Segoe UI", 12F);
            lblRes.Location = new Point(24, 129);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(0, 21);
            lblRes.TabIndex = 5;
            // 
            // txtLado2
            // 
            txtLado2.Location = new Point(178, 83);
            txtLado2.Name = "txtLado2";
            txtLado2.Size = new Size(63, 23);
            txtLado2.TabIndex = 7;
            txtLado2.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 66);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 9;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Location = new Point(12, 250);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(0, 15);
            lblErro.TabIndex = 13;
            // 
            // radioQuad
            // 
            radioQuad.AutoSize = true;
            radioQuad.Location = new Point(11, 22);
            radioQuad.Name = "radioQuad";
            radioQuad.Size = new Size(78, 19);
            radioQuad.TabIndex = 14;
            radioQuad.TabStop = true;
            radioQuad.Text = "Quadrado";
            radioQuad.UseVisualStyleBackColor = true;
            radioQuad.CheckedChanged += radioQuad_CheckedChanged;
            // 
            // radioRet
            // 
            radioRet.AutoSize = true;
            radioRet.Location = new Point(211, 22);
            radioRet.Name = "radioRet";
            radioRet.Size = new Size(79, 19);
            radioRet.TabIndex = 15;
            radioRet.TabStop = true;
            radioRet.Text = "Retângulo";
            radioRet.UseVisualStyleBackColor = true;
            radioRet.CheckedChanged += radioRet_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioQuad);
            groupBox1.Controls.Add(radioRet);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 50);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 274);
            Controls.Add(groupBox1);
            Controls.Add(lblErro);
            Controls.Add(label2);
            Controls.Add(txtLado2);
            Controls.Add(lblRes);
            Controls.Add(txtLado1);
            Controls.Add(btnCalcular);
            Controls.Add(radioVol);
            Controls.Add(radioArea);
            Controls.Add(radioPer);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioPer;
        private RadioButton radioArea;
        private RadioButton radioVol;
        private Button btnCalcular;
        private TextBox txtLado1;
        private Label lblRes;
        private TextBox txtLado2;
        private Label label2;
        private Label lblErro;
        private RadioButton radioQuad;
        private RadioButton radioRet;
        private GroupBox groupBox1;
    }
}