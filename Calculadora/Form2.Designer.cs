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
            label1 = new Label();
            txtLado3 = new TextBox();
            txtLado2 = new TextBox();
            txtLado4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            // 
            // txtLado1
            // 
            txtLado1.Location = new Point(32, 84);
            txtLado1.Name = "txtLado1";
            txtLado1.Size = new Size(63, 23);
            txtLado1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(24, 129);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 5;
            // 
            // txtLado3
            // 
            txtLado3.Location = new Point(170, 84);
            txtLado3.Name = "txtLado3";
            txtLado3.Size = new Size(63, 23);
            txtLado3.TabIndex = 6;
            // 
            // txtLado2
            // 
            txtLado2.Location = new Point(101, 84);
            txtLado2.Name = "txtLado2";
            txtLado2.Size = new Size(63, 23);
            txtLado2.TabIndex = 7;
            // 
            // txtLado4
            // 
            txtLado4.Location = new Point(239, 84);
            txtLado4.Name = "txtLado4";
            txtLado4.Size = new Size(63, 23);
            txtLado4.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 66);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 9;
            label2.Text = "lado 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 66);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 10;
            label3.Text = "lado 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(181, 66);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 11;
            label4.Text = "lado 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(249, 66);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 12;
            label5.Text = "lado 4";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 274);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtLado4);
            Controls.Add(txtLado2);
            Controls.Add(txtLado3);
            Controls.Add(label1);
            Controls.Add(txtLado1);
            Controls.Add(btnCalcular);
            Controls.Add(radioVol);
            Controls.Add(radioArea);
            Controls.Add(radioPer);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioPer;
        private RadioButton radioArea;
        private RadioButton radioVol;
        private Button btnCalcular;
        private TextBox txtLado1;
        private Label label1;
        private TextBox txtLado3;
        private TextBox txtLado2;
        private TextBox txtLado4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}