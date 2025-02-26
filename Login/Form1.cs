namespace Login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String usu = "luis";
            String sen = "1234";

            String usuario = txtUsuario.Text;
            String senha = txtSenha.Text;

            if ( usuario == null || usuario == "")
            {
                lblResultado.Text = "Usuário é obrigatório!!!";
                lblResultado.ForeColor = Color.Red;
                return;
            }
            
            if (usuario == usu & sen == senha)
            {
                lblResultado.Text = "Autenticado com sucesso!";
                lblResultado.ForeColor = Color.Green;
            }
            else
            {
                lblResultado.Text = "Usuário ou Senha incorretos...";
                lblResultado.ForeColor = Color.Red;
            }

        }

    }
}
