namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            string valor1 = txtValor1.Text;
            string valor2 = txtValor2.Text;
            string Res = lblRes.Text;


            if (string.IsNullOrWhiteSpace(valor1) || string.IsNullOrWhiteSpace(valor2))
            {
                MessageBox.Show("Valores obrigatórios");
                return;
            }

            if (!valor1.All(char.IsNumber) || !valor2.All(char.IsNumber))
            {
                MessageBox.Show("Digite somente números");
                return;
            }

            double calcular = Convert.ToDouble(valor1) + Convert.ToDouble(valor2);

            lblRes.Text = $"{calcular}";

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            string valor1 = txtValor1.Text;
            string valor2 = txtValor2.Text;
            string Res = lblRes.Text;

            if (string.IsNullOrWhiteSpace(valor1) || string.IsNullOrWhiteSpace(valor2))
            {
                MessageBox.Show("Valores obrigatórios");
                return;
            }

            if (!valor1.All(char.IsNumber) || !valor2.All(char.IsNumber))
            {
                MessageBox.Show("Digite somente números");
                return;
            }

            double calcular = Convert.ToDouble(valor1) - Convert.ToDouble(valor2);

            lblRes.Text = $"{calcular}";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            string valor1 = txtValor1.Text;
            string valor2 = txtValor2.Text;
            string Res = lblRes.Text;

            if (string.IsNullOrWhiteSpace(valor1) || string.IsNullOrWhiteSpace(valor2))
            {
                MessageBox.Show("Valores obrigatórios");
                return;
            }

            if (!valor1.All(char.IsNumber) || !valor2.All(char.IsNumber))
            {
                MessageBox.Show("Digite somente números");
                return;
            }

            double calcular = Convert.ToDouble(valor1) * Convert.ToDouble(valor2);

            lblRes.Text = $"{calcular}";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            string valor1 = txtValor1.Text;
            string valor2 = txtValor2.Text;
            string Res = lblRes.Text;

            if (string.IsNullOrWhiteSpace(valor1) || string.IsNullOrWhiteSpace(valor2))
            {
                MessageBox.Show("Valores obrigatórios");
                return;
            }

            if (!valor1.All(char.IsNumber) || !valor2.All(char.IsNumber))
            {
                MessageBox.Show("Digite somente números");
                return;
            }

            double calcular = Convert.ToDouble(valor1) / Convert.ToDouble(valor2);

            if (calcular % 1 != 0)
            {
                lblRes.Text = $"{calcular:F2}";
                return;
            }

            lblRes.Text = $"{calcular}";
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 novaAba = new Form1();
            this.Hide();
            novaAba.Show();
        }
    }
}
