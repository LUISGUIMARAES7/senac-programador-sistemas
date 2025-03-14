using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            string valorRaio = txtRaio.Text;


            if (string.IsNullOrWhiteSpace(valorRaio))
            {
                lblErro.Text = "Valor obrigatório";
                return false;
            }

            try
            {
                Convert.ToDouble(valorRaio);
                return true;
            }
            catch
            {
                lblErro.Text = "Digite somente números";
                return false;
            }


        }

        private int TipoOperacao()
        {

            if (radioPer.Checked)
            {
                return 0;
            }
            else if (radioDia.Checked)
            {
                return 1;
            }
            else if (radioArea.Checked)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        private void Calcular()
        {
            double valorRaio = Convert.ToDouble(txtRaio.Text);

            switch (TipoOperacao())
            {
                case 0:
                    lblRes.Text = $"Perímetro: {2 * Math.PI * valorRaio:F2} ";
                    break;
                case 1:
                    lblRes.Text = $"Diametro: {2 * valorRaio} ";
                    break;
                case 2:
                    lblRes.Text = $"Área: {Math.PI * Math.Pow(valorRaio, 2):F2}";
                    break;
                case 3:
                    lblRes.Text = $"Volume: {(4.0 / 3.0) * Math.PI * Math.Pow(valorRaio, 3):F2} ";
                    break;
                default:
                    break;
            }
        }



        private void radioPer_CheckedChanged(object sender, EventArgs e)
        {
            lblErro.Text = "";
        }

        private void radioDia_CheckedChanged(object sender, EventArgs e)
        {
            lblErro.Text = "";
        }

        private void radioArea_CheckedChanged(object sender, EventArgs e)
        {
            lblErro.Text = "";
        }

        private void radioVol_CheckedChanged(object sender, EventArgs e)
        {
            lblErro.Text = "";
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            lblErro.Text = "";
            if (Validar())
            {
                Calcular();
            }
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void quadradoRetânguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void esferaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
