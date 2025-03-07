using System.Windows.Forms;

namespace Login
{
    public partial class FormLogin : Form
    {
        List<string> listaUsuarios = new List<string>() { "ney", "cr7", "rony" };
        List<string> listaSenhas = new List<string>() { "Bruna123.", "Receba123.", "Rustico123." };

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

            int UsuarioEncontrado = -1;

            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (usuarioBuscado == listaUsuarios[i])
                {
                    UsuarioEncontrado = i;
                }

            }

            if (UsuarioEncontrado > -1 & senha == listaSenhas[UsuarioEncontrado])
            {
                lblResultado.Text = "Autenticado com sucesso!";
                lblResultado.ForeColor = Color.Green;
            }
            else
            {
                lblResultado.Text = "Usuario ou Senha incorretos...";
                lblResultado.ForeColor = Color.Red;
            }

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

            if (listaUsuarios.Contains(novoUsuario))
            {
                listaUsuarios.Add(novoUsuario);
                listaSenhas.Add(novaSenha);
                lblRes.Text = "Cadastrado com sucesso!!!";
            }
            else
            {
                lblRes.Text = "Usuario já existe";
            }

        }
    }

}
