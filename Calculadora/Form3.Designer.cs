namespace Calculadora
{
    partial class Form3
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
            txtRaio = new TextBox();
            radioPer = new RadioButton();
            radioDia = new RadioButton();
            radioArea = new RadioButton();
            radioVol = new RadioButton();
            label1 = new Label();
            btncalcular = new Button();
            label2 = new Label();
            lblRes = new Label();
            lblErro = new Label();
            SuspendLayout();
            // 
            // txtRaio
            // 
            txtRaio.Location = new Point(60, 68);
            txtRaio.Name = "txtRaio";
            txtRaio.Size = new Size(78, 23);
            txtRaio.TabIndex = 0;
            // 
            // radioPer
            // 
            radioPer.AutoSize = true;
            radioPer.Checked = true;
            radioPer.Location = new Point(24, 12);
            radioPer.Name = "radioPer";
            radioPer.Size = new Size(77, 19);
            radioPer.TabIndex = 1;
            radioPer.TabStop = true;
            radioPer.Text = "Perimetro";
            radioPer.UseVisualStyleBackColor = true;
            radioPer.CheckedChanged += radioPer_CheckedChanged;
            // 
            // radioDia
            // 
            radioDia.AutoSize = true;
            radioDia.Location = new Point(107, 12);
            radioDia.Name = "radioDia";
            radioDia.Size = new Size(74, 19);
            radioDia.TabIndex = 2;
            radioDia.Text = "Diametro";
            radioDia.UseVisualStyleBackColor = true;
            radioDia.CheckedChanged += radioDia_CheckedChanged;
            // 
            // radioArea
            // 
            radioArea.AutoSize = true;
            radioArea.Location = new Point(187, 12);
            radioArea.Name = "radioArea";
            radioArea.Size = new Size(49, 19);
            radioArea.TabIndex = 3;
            radioArea.Text = "Area";
            radioArea.UseVisualStyleBackColor = true;
            radioArea.CheckedChanged += radioArea_CheckedChanged;
            // 
            // radioVol
            // 
            radioVol.AutoSize = true;
            radioVol.Location = new Point(242, 12);
            radioVol.Name = "radioVol";
            radioVol.Size = new Size(65, 19);
            radioVol.TabIndex = 4;
            radioVol.Text = "Volume";
            radioVol.UseVisualStyleBackColor = true;
            radioVol.CheckedChanged += radioVol_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 71);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 5;
            label1.Text = "Raio";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(202, 68);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 6;
            btncalcular.Text = "CALCULAR";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(24, 132);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 7;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRes.Location = new Point(24, 119);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(0, 21);
            lblRes.TabIndex = 8;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Location = new Point(20, 160);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(0, 15);
            lblErro.TabIndex = 9;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 184);
            Controls.Add(lblErro);
            Controls.Add(lblRes);
            Controls.Add(label2);
            Controls.Add(btncalcular);
            Controls.Add(label1);
            Controls.Add(radioVol);
            Controls.Add(radioArea);
            Controls.Add(radioDia);
            Controls.Add(radioPer);
            Controls.Add(txtRaio);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRaio;
        private RadioButton radioPer;
        private RadioButton radioDia;
        private RadioButton radioArea;
        private RadioButton radioVol;
        private Label label1;
        private Button btncalcular;
        private Label label2;
        private Label lblRes;
        private Label lblErro;
    }
}