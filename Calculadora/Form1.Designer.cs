namespace Calculadora
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
            components = new System.ComponentModel.Container();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            label1 = new Label();
            btnSoma = new Button();
            label2 = new Label();
            label3 = new Label();
            lblRes = new Label();
            btnSub = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            label4 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem1 = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(113, 92);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(73, 23);
            txtValor1.TabIndex = 0;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(113, 118);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(73, 23);
            txtValor2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 41);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 2;
            label1.Text = "CALCULADORA";
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(49, 172);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(47, 23);
            btnSoma.TabIndex = 3;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnCalcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 95);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Valor 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 109);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 5;
            label3.Text = "=";
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Font = new Font("Segoe UI", 12F);
            lblRes.Location = new Point(220, 108);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(0, 21);
            lblRes.TabIndex = 6;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(113, 172);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(39, 23);
            btnSub.TabIndex = 7;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(166, 172);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(48, 23);
            btnMult.TabIndex = 8;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(231, 172);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(43, 23);
            btnDiv.TabIndex = 9;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 121);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 10;
            label4.Text = "Valor 2";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(314, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem1, openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem1
            // 
            newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            newToolStripMenuItem1.Size = new Size(180, 22);
            newToolStripMenuItem1.Text = "New";
            newToolStripMenuItem1.Click += newToolStripMenuItem1_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 247);
            Controls.Add(label4);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnSub);
            Controls.Add(lblRes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSoma);
            Controls.Add(label1);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "f";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValor1;
        private TextBox txtValor2;
        private Label label1;
        private Button btnSoma;
        private Label label2;
        private Label label3;
        private Label lblRes;
        private Button btnSub;
        private Button btnMult;
        private Button btnDiv;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
    }
}
