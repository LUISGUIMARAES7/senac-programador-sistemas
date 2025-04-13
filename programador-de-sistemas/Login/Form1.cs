using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Login
{
    public partial class FormLogin : Form
    {
        private static readonly string ConnectionString = "dataSource=localhost;username=root;password=;database=senac;";
        private MySqlConnection Connection = new MySqlConnection(ConnectionString);

        List <Usuario> usuarios = new List<Usuario> ();
        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String usuarioBuscado = txtUsuario.Text;
            String senha = txtSenha.Text;


            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                lblResultado.Text = "Usuario e obrigatorio!!!";
                lblResultado.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(senha))
            {
                lblResultado.Text = "Senha e obrigatoria!!!";
                lblResultado.ForeColor = Color.Red;
                return;
            }

            bool autenticado = false;

            //for (int i = 0;usuarios.Count < i;i++)
            //{
            //    if (usuarios[i].Email == usuarioBuscado && usuarios[i].Senha == senha)
            //    {
            //        autenticado = true;
            //    }
            //}

            try
            {
                Connection.Open();

                string query = $"SELECT * FROM usuario WHERE email = '{usuarioBuscado}'";

                MySqlCommand mySqlCommand = new MySqlCommand(query,Connection);

                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                autenticado = reader.Read() && reader.GetString(2) == senha;
           
            }
            catch 
            {
                MessageBox.Show("Erro de banco de dados");
            }
            finally 
            {
                Connection.Close();
            }

            if (!autenticado)
            {
                lblResultado.Text = "Usuário e/ou senha incorretos.";
                lblResultado.ForeColor = Color.Red;
                return;
            }

            lblResultado.Text = "Autenticado com sucesso!";
            lblResultado.ForeColor = Color.Green;
            txtUsuario.Clear();
            txtSenha.Clear();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String novoUsuario = txtNovoUsuario.Text;
            String novaSenha = txtNovaSenha.Text;

            if (string.IsNullOrWhiteSpace(novoUsuario))
            {
                lblRes.Text = "Usuario é obrigatório!!!";
                return;
            }

            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                lblRes.Text = "Senha é obrigatória!!!";
                return;
            }

            if (novaSenha.Length < 8)
            {
                lblRes.Text = "Senha precisa ter 8 digitos";
                return;
            }

            if (!novaSenha.Any(char.IsUpper))
            {
                lblRes.Text = "Senha precisa ter uma letra maiúscula";
                return;
            }

            if (!novaSenha.Any(char.IsLower))
            {
                lblRes.Text = "Senha precisa ter uma letra minúscula";
                return;
            }

            if (!novaSenha.Any(char.IsNumber))
            {
                lblRes.Text = "Senha precisa ter um número";
                return;
            }

            if (!novaSenha.Any(char.IsPunctuation))
            {
                lblRes.Text = "Senha precisa ter um caracter especial ";
                return;
            }

            if (novaSenha.Contains(" "))
            {
                lblRes.Text = "Senha não deve conter espaços em branco";
                return;
            }

            bool encontrado = false;

            try
            {
                Connection.Open();

                string query = $"insert into usuario (email, senha) values ('{novoUsuario}','{novaSenha}');";
                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                mySqlCommand.ExecuteNonQuery();

                lblRes.Text = "Cadastrado com sucesso!!!";
                lblRes.ForeColor = Color.Green;
                txtNovoUsuario.Clear();
                txtNovaSenha.Clear();

            }
            catch
            {
                MessageBox.Show("Erro de banco de dados");
            }
            finally
            {
                Connection.Close();
            }

            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].Email == novoUsuario)
                {
                    encontrado = true;
                }
            }

            if (encontrado)
            {
                lblRes.Text = "Usuario já existe";
                return;
            }          
            
        }
    }

}
