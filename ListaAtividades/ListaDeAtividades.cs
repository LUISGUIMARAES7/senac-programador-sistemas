
using ListaAtividades.dominio;

namespace ListaAtividades
{
    public partial class ListaDeAtividades : Form
    {
        public ListaDeAtividades()
        {
            InitializeComponent();
        }

        private void ListaDeAtividades_Load(object sender, EventArgs e)
        {
            Atividade atividade = new();

            var atividadeEmAndamento = atividade.BuscarAtividadeEmAndamento();
            if (atividadeEmAndamento.Id = 0)
            {
                TextBoxAtividadeEmAndamento.Text = $"{atividadeEmAndamento.Id} - {atividadeEmAndamento.Titulo}";
            }
            
            var atividadesPendentes = atividade.ListarAtividadesPendentes();
        }
    }
}
