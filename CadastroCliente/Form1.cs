using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        private readonly List<Cliente> clientes = [];
        private readonly BindingSource BindingSource = [];

        public Form1()
        {
            InitializeComponent();

            Endereco enderecoLuis = new Endereco()
            { Logradouro = "Rua 1", Numero = "1", Complemento = "Casa 1", Bairro = "Cocaia", Municipio = "São Paulo", Estado = "SP", CEP = "04849-111", };
            Cliente luis = new Cliente()
            { ID = 0, Nome = "Luis", DataNascimento = "07/08/1996", Telefone = "(11) 11111-1111", Email = "luis@email.com", NomeSocial = "Lu", Estrangeiro = false, Etnia = Etnia.Branco, Genero = Genero.Macho, Tipo = Tipo.PF, Endereco = enderecoLuis };
            clientes.Add(luis);

            Endereco enderecoSarah = new Endereco()
            { Logradouro = "Rua 2", Numero = "2", Complemento = "Casa 2", Bairro = "Cantinho do Céu", Municipio = "São Paulo", Estado = "SP", CEP = "04849-222" };
            Cliente sarah = new Cliente()
            { ID = 1, Nome = "Sarah", NomeSocial = "Sa", Endereco = enderecoSarah, Telefone = "(11) 2222-2222", DataNascimento = "13/01/2003", Email = "sarah@email.com", Estrangeiro = false, Etnia = Etnia.Pardo, Genero = Genero.Fêmea, Tipo = Tipo.PF};
            clientes.Add(sarah);

            Endereco enderecoMari = new Endereco()
            { Logradouro = "Rua 3", Numero = "3", Complemento = "Casa 3", Bairro = "Gaivotas", Municipio = "São Paulo", Estado = "SP", CEP = "04849-333" };
            Cliente mari = new Cliente()
            { ID = 2, Nome = "Mari", NomeSocial = "Ma", Endereco = enderecoMari, Telefone = "(11) 3333-3333", DataNascimento = "01/01/2003", Email = "mari@email.com", Estrangeiro = false, Etnia = Etnia.Preto, Genero = Genero.Fêmea, Tipo = Tipo.PF };
            clientes.Add(mari);

            BindingSource.DataSource = clientes;
            dataGridViewClientes.DataSource = BindingSource;
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

        Tipo ValidarTipo()
        {
            Tipo tipo;
            if (radioPF.Checked == true)
            {
                tipo = Tipo.PF;
            }
            else
            {
                tipo = Tipo.PJ;
            }
            return tipo;
        }

        private bool ValidarDataNascimento(string dataNascimento)
        {
            string dataNas = dataNascimento.Replace("/", "").Replace("_", "");
            if (dataNas.Length != 8 || !DateTime.TryParseExact(dataNascimento, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out _))
            {
                return false;
            }
            return true;
        }


        public bool validarCep(string cep)
        {
            string cepNumeros = cep.Replace("-", "").Replace("_", "");

            if (cepNumeros.Length != 8 || !cepNumeros.All(char.IsDigit))
            {
                return false;
            }
            return true;
        }



        public bool ValidarTudo()
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
         
            if (string.IsNullOrEmpty(nome))
            {
                txtNome.Focus();
                lblErro.Text = "Nome obrigatório";
                return false;
            }

            if (telefone.StartsWith("(") && telefone.Contains(")") && telefone.Contains("-"))
            {
                string numerosTelefone = telefone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
                if (string.IsNullOrEmpty(numerosTelefone) || numerosTelefone.Length != 11)
                {
                    mTxtTelefone.Focus();
                    lblErro.Text = "Telefone obrigatório";
                    return false;
                }
            }

            if (encontrarTelefone(telefone))
            {
                lblErro.Text = "Telefone já cadastrado";
                mTxtTelefone.Focus();
                return false;
            }

            //string dataNas = dataNascimento.Replace("/", "").Replace("_", "");
            //if (dataNas.Length != 8 || !DateTime.TryParseExact(dataNascimento, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out _))
            //{
            //    lblErro.Text = "Data de Nascimento obrigatória ou inválida";
            //    mTxtDataNascimento.Focus();
            //    return false;
            //}

            if (!ValidarDataNascimento(dataNascimento))
            {
                lblErro.Text = "Data de Nascimento obrigatória ou inválida";
                mTxtDataNascimento.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(email) ) 
            {
                txtEmail.Focus();
                lblErro.Text = "Email obrigatório";
                return false;
            }

            if (encontrarEmail())
            {
                lblErro.Text = "Email já cadastrado";
                txtEmail.Focus();
                return false;
            }

            if (!EmailValido(email))
            {
                lblErro.Text = "Email inválido";
                txtEmail.Focus();
                return false;
            }


            if (string.IsNullOrEmpty(genero))
            {
                cBoxGenero.Focus();
                lblErro.Text = "Gênero obrigatório";
                return false;
            }

            if (string.IsNullOrEmpty(etnia))
            {
                cBoxEtnia.Focus();
                lblErro.Text = "Etnia obrigatório";
                return false;
            }

            if (string.IsNullOrEmpty(logradouro))
            {
                lblErro.Text = "Logradouro obrigatório";
                txtLogradouro.Focus(); 
                return false;
            }

            if (string.IsNullOrEmpty(num))
            {
                lblErro.Text = "Número obrigatório";
                txtNumero.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(bairro))
            {
                lblErro.Text = "Bairro obrigatório";
                txtBairro.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(municipio))
            {
                lblErro.Text = "Município obrigatório";
                txtMunicipio.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(estado))
            {
                lblErro.Text = "Campo Estado obrigatório";
                cBoxEstado.Focus();
                return false;
            }

            if(!validarCep(cep))
            {
                lblErro.Text = "CEP obrigatório";
                mTxtCEP.Focus();
                return false;
            }


            return true;
        }

        public void LimparTela()
        {
            txtNome.Clear();
            txtEmail.Clear();
            mTxtTelefone.Clear();
            mTxtDataNascimento.Clear();
            txtNomeSocial.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtMunicipio.Clear();
            mTxtCEP.Clear();
            cBoxEstado.Text = "";
            cBoxGenero.Text = "";
            cBoxEtnia.Text = "";

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
            Tipo tipo = ValidarTipo();
            
            Endereco novoEndereco = new Endereco()
            { Logradouro = logradouro, Numero = num, Complemento = complemento, Bairro = bairro, Municipio = municipio, Estado = estado, CEP = cep};
            Cliente novoCliente = new Cliente()
            { ID = NovoId(), Nome = nome, DataNascimento = dataNascimento, Telefone = telefone, Email = email, NomeSocial = nomeSocial, Estrangeiro = estrangeiro, Etnia = etnia, Genero = genero, Tipo = tipo, Endereco = novoEndereco };
            clientes.Add(novoCliente);

            LimparTela();
        }

        public void cadastroNaTela()
        {
            MessageBox.Show("CADASTRO CONCLUÍDO");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            lblErro.Text = "";
            if (ValidarTudo())
            {
                Cadastrar();
                cadastroNaTela();
                BindingSource.ResetBindings(false);
            }

        }
    }
}
