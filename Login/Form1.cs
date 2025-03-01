using System.Windows.Forms;

namespace Login
{
    public partial class FormLogin : Form
    {
        List<string> listaUsuarios = new List<string>() { "ney", "cr7", "rony" };
        List<string> listaSenhas = new List<string>() { "bruna", "si", "rustico" };

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

            Boolean usuarioEncontrado = false;

            for (int i = 0; i < listaUsuarios.Count; i++) 
            {
                if (novoUsuario == listaUsuarios[i])
                {
                    usuarioEncontrado = true;
                }
            }

            if (!usuarioEncontrado)
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
