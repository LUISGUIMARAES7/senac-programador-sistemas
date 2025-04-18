using Produto.dominio;

namespace Produto
{
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {
            labelErro.Text = "...";
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {

            Produto_ produto = new()
            {
                Nome = textBoxProduto.Text
            };

            if (!produto.CriarProduto((int) numericQuantidade.Value))
            {
                labelErro.Text = "Não foi possível adicionar";
                return;
            }

            labelErro.Text = "Adicionado com sucesso";
            this.DialogResult = DialogResult.OK;
            CarregarProdutos();
        }

        private void CarregarProdutos() 
        { 
            Produto_ produto = new();

            var listaProdutos = produto.ListarProdutos();
            dataGridView1.DataSource = listaProdutos;
        }
    }
}
