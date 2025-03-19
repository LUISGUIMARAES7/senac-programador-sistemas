namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();


        

        public Form1()
        {
            InitializeComponent();

            Endereco enderecoLuis = new Endereco()
            { Logradouro = "Rua 1", Numero = "1", Complemento = "Casa 1", Bairro = "Cocaia", Municipio = "São Paulo", Estado = "SP", CEP = "04849-111", };
            Cliente luis = new Cliente()
            { ID = 0, Nome = "Luis", DataNascimento = "07/08/1996", Telefone = "1111-1111", Email = "luis@email.com", NomeSocial = "Lu", Estrangeiro = false, Etnia = Etnia.Branco, Genero = Genero.Macho, Tipo = Tipo.PF, Endereco = enderecoLuis };
            clientes.Add(luis);

            Endereco enderecoSarah = new Endereco()
            { Logradouro = "Rua 2", Numero = "2", Complemento = "Casa 2", Bairro = "Cantinho do Céu", Municipio = "São Paulo", Estado = "SP", CEP = "04849-222" };
            Cliente sarah = new Cliente()
            { ID = 1, Nome = "Sarah", NomeSocial = "Sa", Endereco = enderecoSarah, DataNascimento = "13/01/2003", Email = "sarah@email.com", Estrangeiro = false, Etnia = Etnia.Pardo, Genero = Genero.Femi, Tipo = Tipo.PF, Telefone = "2222-2222" };
            clientes.Add(sarah);

            Endereco enderecoMari = new Endereco()
            { Logradouro = "Rua 3", Numero = "3", Complemento = "Casa 3", Bairro = "Gaivotas", Municipio = "São Paulo", Estado = "SP", CEP = "04849-333" };
            Cliente mari = new Cliente()
            { ID = 2, Nome = "Mari", NomeSocial = "Ma", Endereco = enderecoMari, DataNascimento = "01/01/2003", Email = "mari@email.com", Estrangeiro = false, Etnia = Etnia.Preto, Genero = Genero.Femi, Tipo = Tipo.PF, Telefone = "3333-3333" };
            clientes.Add(mari);

        }

        public bool Validar()
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string telefone = mTxtTelefone.Text;
            string dataNascimento = mTxtDataNascimento.Text;
            string genero = cBoxGenero.Text;
            string etnia = cBoxEtnia.Text;
            string nomeSocial = txtNomeSocial.Text;
            bool estrangeiro = checkBoxEstrangeiro.Checked;
            string logradouro = txtLogradouro.Text;
            string num = txtNumero.Text;
            string complemento = txtComplemento.Text;
            string bairro = txtBairro.Text;
            string municipio = txtMunicipio.Text;
            string estado = cBoxEstado.Text;
            string cep = mTxtCEP.Text;
            string PF = radioPF.Text;
            string PJ = radioPJ.Text;
            
            if (string.IsNullOrEmpty(nome))
            {
                lblErro.Text = "Campo Nome vazio";
                return false;
            }

            if (string.IsNullOrEmpty(email)) 
            {
                lblErro.Text = "Campo Email vazio";
                return false;
            }
            if (string.IsNullOrEmpty(telefone)) 
            {
                lblErro.Text = "Campo Telefone vazio";
                return false;
            }
            if (string.IsNullOrEmpty(dataNascimento)) 
            {
                lblErro.Text = "Campo Data de Nascimento vazio";
                return false;
            }
            if (string.IsNullOrEmpty(genero))
            {
                lblErro.Text = "Campo Gênero vazio";
                return false;
            }
            if (string.IsNullOrEmpty(etnia)) 
            {
                lblErro.Text = "Campo Etnia vazio";
                return false;
            }
            if (string.IsNullOrEmpty(logradouro))
            {
                lblErro.Text = "Campo Logradouro vazio";
                return false;
            }
            if (string.IsNullOrEmpty(num))
            {
                lblErro.Text = "Campo Número vazio";
                return false;
            }
            if (string.IsNullOrEmpty(bairro)) {
                lblErro.Text = "Campo Bairro vazio";
                return false;
            }
            if (string.IsNullOrEmpty(municipio))
            {
                lblErro.Text = "Campo Bairro vazio";
                return false;
            }
            if (string.IsNullOrEmpty(estado))
            {
                lblErro.Text = "Campo Estado vazio";
                return false;
            }
            if (string.IsNullOrEmpty(cep))
            {
                lblErro.Text = "Campo CEP vazio";
                return false;
            }

            return true;
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (Validar()){
                lblErro.Text = "Cadastro concluído com sucesso!";
            }

        }
    }
}
