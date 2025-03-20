using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

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
            { ID = 1, Nome = "Sarah", NomeSocial = "Sa", Endereco = enderecoSarah, DataNascimento = "13/01/2003", Email = "sarah@email.com", Estrangeiro = false, Etnia = Etnia.Pardo, Genero = Genero.Fêmea, Tipo = Tipo.PF, Telefone = "2222-2222" };
            clientes.Add(sarah);

            Endereco enderecoMari = new Endereco()
            { Logradouro = "Rua 3", Numero = "3", Complemento = "Casa 3", Bairro = "Gaivotas", Municipio = "São Paulo", Estado = "SP", CEP = "04849-333" };
            Cliente mari = new Cliente()
            { ID = 2, Nome = "Mari", NomeSocial = "Ma", Endereco = enderecoMari, DataNascimento = "01/01/2003", Email = "mari@email.com", Estrangeiro = false, Etnia = Etnia.Preto, Genero = Genero.Fêmea, Tipo = Tipo.PF, Telefone = "3333-3333" };
            clientes.Add(mari);
        }

        public int NovoId()
        {
            int id = clientes[clientes.Count - 1].ID;
            int novoId = id + 1;
            return novoId;
        }

        public bool encontrarEmail()
        {
            foreach (var e in clientes)
            {
                string email = txtEmail.Text;
                if (e.Email == email)
                {
                    return true;
                }
                
            }
            return false;
        }
        public bool EmailValido(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        public bool encontrarTelefone(string tel)
        {
            foreach (var e in clientes)
            {
                string telefone = tel;
                if (e.Telefone == telefone)
                {
                    return true;
                }

            }
            return false;
        }

        

        public bool Validar()
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string telefone = mTxtTelefone.Text;
            string dataNascimento = mTxtDataNascimento.Text;
            string nomeSocial = txtNomeSocial.Text;
            string estrangeiro = checkBoxEstrangeiro.Text;
            string logradouro = txtLogradouro.Text;
            string num = txtNumero.Text;
            string complemento = txtComplemento.Text;
            string bairro = txtBairro.Text;
            string municipio = txtMunicipio.Text;
            string estado = cBoxEstado.Text;
            string cep = mTxtCEP.Text;
            string etnia = cBoxEtnia.Text;
            string genero = cBoxGenero.Text;
            string tipoPF = radioPF.Text;
            string tipoPJ = radioPJ.Text;


            if (string.IsNullOrEmpty(nome))
            {
                txtNome.Focus();
                lblErro.Text = "Campo Nome obrigatório";
                return false;
            }

            if (telefone.StartsWith("(") && telefone.Contains(")") && telefone.Contains("-"))
            {
                string numerosTelefone = telefone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
                if (string.IsNullOrEmpty(numerosTelefone) || numerosTelefone.Length != 11)
                {
                    mTxtTelefone.Focus();
                    lblErro.Text = "Campo Telefone obrigatório";
                    return false;
                }
            }

            if (encontrarTelefone(telefone))
            {
                lblErro.Text = "Telefone já cadastrado";
                mTxtTelefone.Focus();
                return false;
            }

            //if (dataNascimento.StartsWith("_") && dataNascimento.Contains("_"))
            //{
            //    string dataNas = dataNascimento.Replace("_", "").Replace(" ", "");

            //    if (string.IsNullOrEmpty(dataNas) || dataNas.Length != 8)
            //    {
            //        mTxtDataNascimento.Focus();
            //        lblErro.Text = "Campo Data Nascimento obrigatório";
            //        return false;
            //    }
            //}

            if (string.IsNullOrEmpty(email) ) 
            {
                txtEmail.Focus();
                lblErro.Text = "Campo Email obrigatório";
                return false;
            }

            if (encontrarEmail())
            {
                lblErro.Text = "Email já cadastrado";
                return false;
            }

            if (!EmailValido(email))
            {
                lblErro.Text = "Email inválido";
                return false;
            }

            //if (string.IsNullOrEmpty(genero))
            //{
            //    lblErro.Text = "Campo Gênero obrigatório";
            //    return false;
            //}
            //if (string.IsNullOrEmpty(etnia))
            //{
            //    lblErro.Text = "Campo Etnia obrigatório";
            //    return false;
            //}
            //if (string.IsNullOrEmpty(logradouro))
            //{
            //    lblErro.Text = "Campo Logradouro obrigatório";
            //    return false;
            //}
            //if (string.IsNullOrEmpty(num))
            //{
            //    lblErro.Text = "Campo Número obrigatório";
            //    return false;
            //}
            //if (string.IsNullOrEmpty(bairro)) {
            //    lblErro.Text = "Campo Bairro obrigatório";
            //    return false;
            //}
            //if (string.IsNullOrEmpty(municipio))
            //{
            //    lblErro.Text = "Campo Bairro obrigatório";
            //    return false;
            //}
            //if (string.IsNullOrEmpty(estado))
            //{
            //    lblErro.Text = "Campo Estado obrigatório";
            //    return false;
            //}
            //if (string.IsNullOrEmpty(cep))
            //{
            //    lblErro.Text = "Campo CEP obrigatório";
            //    return false;
            //}
            return true;
        }

        public void Cadastrar()
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string telefone = mTxtTelefone.Text;
            string dataNascimento = mTxtDataNascimento.Text;
            string nomeSocial = txtNomeSocial.Text;
            bool estrangeiro = checkBoxEstrangeiro.Checked;
            string logradouro = txtLogradouro.Text;
            string num = txtNumero.Text;
            string complemento = txtComplemento.Text;
            string bairro = txtBairro.Text;
            string municipio = txtMunicipio.Text;
            string estado = cBoxEstado.Text;
            string cep = mTxtCEP.Text;
            Etnia etnia = (Etnia)cBoxEtnia.SelectedIndex;
            Genero genero = (Genero)cBoxGenero.SelectedIndex;
            Tipo tipo = (Tipo)groupBox1.TabIndex;

            Endereco novoEndereco = new Endereco()
            { Logradouro = logradouro, Numero = num, Complemento = complemento, Bairro = bairro, Municipio = municipio, Estado = estado, CEP = cep};
            Cliente novoCliente = new Cliente()
            { ID = NovoId(), Nome = nome, DataNascimento = dataNascimento, Telefone = telefone, Email = email, NomeSocial = nomeSocial, Estrangeiro = estrangeiro, Etnia = etnia, Genero = genero, Tipo = tipo, Endereco = novoEndereco };
            clientes.Add(novoCliente);
        }

        public void cadastroNaTela()
        {
            int id = clientes[clientes.Count - 1].ID;
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string telefone = mTxtTelefone.Text;

            MessageBox.Show($"CADASTRO CONCLUÍDO\n\nID:{id}\nNome:{nome}\nEmail:{email}");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            lblErro.Text = "";
            if (Validar())
            {
                Cadastrar();
                cadastroNaTela();
            }

        }
    }
}
