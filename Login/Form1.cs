using System.Windows.Forms;

namespace Login
{
    public partial class FormLogin : Form
    {
        List<string> listaUsuarios = new List<string>() {"ney", "cr7","rony" }; 

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

            int posicaoUsuarioEncontrado = -1;

            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (usuarioBuscado == listaUsuarios[i]) 
                {
                    posicaoUsuarioEncontrado = i;
                }
                
            }

            if (posicaoUsuarioEncontrado > -1 & senha == "1234")
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
    }
}
