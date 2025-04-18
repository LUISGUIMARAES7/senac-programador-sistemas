
namespace Produto
{
    partial class CadastroProduto
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            numericQuantidade = new NumericUpDown();
            label2 = new Label();
            buttonAdicionar = new Button();
            textBoxProduto = new TextBox();
            labelNome = new Label();
            labelErro = new Label();
            buttonRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 276);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 21);
            label1.TabIndex = 1;
            label1.Text = "CADASTRO PRODUTOS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericQuantidade);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(buttonAdicionar);
            groupBox1.Controls.Add(textBoxProduto);
            groupBox1.Controls.Add(labelNome);
            groupBox1.Location = new Point(12, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 128);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // numericQuantidade
            // 
            numericQuantidade.Location = new Point(81, 78);
            numericQuantidade.Name = "numericQuantidade";
            numericQuantidade.Size = new Size(68, 23);
            numericQuantidade.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 86);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Quantidade";
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdicionar.Location = new Point(658, 86);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(92, 23);
            buttonAdicionar.TabIndex = 1;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // textBoxProduto
            // 
            textBoxProduto.Location = new Point(62, 41);
            textBoxProduto.Name = "textBoxProduto";
            textBoxProduto.Size = new Size(688, 23);
            textBoxProduto.TabIndex = 0;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(6, 49);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 15);
            labelNome.TabIndex = 3;
            labelNome.Text = "Produto";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(12, 485);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 15);
            labelErro.TabIndex = 4;
            // 
            // buttonRemover
            // 
            buttonRemover.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRemover.Location = new Point(687, 473);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(75, 23);
            buttonRemover.TabIndex = 5;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 508);
            Controls.Add(buttonRemover);
            Controls.Add(labelErro);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "CadastroProduto";
            Load += CadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBoxProduto;
        private Button buttonAdicionar;
        private Label labelNome;
        private Label labelErro;
        private Button buttonRemover;
        private Label label2;
        private NumericUpDown numericQuantidade;
    }
}
