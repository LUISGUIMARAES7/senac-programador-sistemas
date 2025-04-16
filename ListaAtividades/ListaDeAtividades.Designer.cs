
namespace ListaAtividades
{
    partial class ListaDeAtividades
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
            AtividadeEmAndamento = new TextBox();
            buttonFinalizar = new Button();
            dataGridViewAtividades = new DataGridView();
            buttonAtualizar = new Button();
            buttonCriar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtividades).BeginInit();
            SuspendLayout();
            // 
            // AtividadeEmAndamento
            // 
            AtividadeEmAndamento.Location = new Point(27, 12);
            AtividadeEmAndamento.Name = "AtividadeEmAndamento";
            AtividadeEmAndamento.ReadOnly = true;
            AtividadeEmAndamento.Size = new Size(625, 23);
            AtividadeEmAndamento.TabIndex = 0;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.Location = new Point(695, 12);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(75, 23);
            buttonFinalizar.TabIndex = 1;
            buttonFinalizar.Text = "FINALIZAR";
            buttonFinalizar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAtividades
            // 
            dataGridViewAtividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAtividades.Location = new Point(27, 67);
            dataGridViewAtividades.Name = "dataGridViewAtividades";
            dataGridViewAtividades.Size = new Size(625, 371);
            dataGridViewAtividades.TabIndex = 2;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.Location = new Point(695, 67);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(75, 23);
            buttonAtualizar.TabIndex = 3;
            buttonAtualizar.Text = "ATUALIZAR";
            buttonAtualizar.UseVisualStyleBackColor = true;
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(695, 415);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(75, 23);
            buttonCriar.TabIndex = 4;
            buttonCriar.Text = "CRIAR";
            buttonCriar.UseVisualStyleBackColor = true;
            // 
            // ListaDeAtividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCriar);
            Controls.Add(buttonAtualizar);
            Controls.Add(dataGridViewAtividades);
            Controls.Add(buttonFinalizar);
            Controls.Add(AtividadeEmAndamento);
            Name = "ListaDeAtividades";
            Text = "Form1";
            Load += this.ListaDeAtividades_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        

        #endregion

        private TextBox AtividadeEmAndamento;
        private Button buttonFinalizar;
        private DataGridView dataGridViewAtividades;
        private Button buttonAtualizar;
        private Button buttonCriar;
    }
}
