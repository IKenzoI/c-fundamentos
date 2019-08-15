using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class juros : Form
    {
        public juros()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            decimal valor = Convert.ToDecimal(txtValor.Text);
            int parcelado = Convert.ToInt32(txtPagamento.Text);
            decimal resultado;

            if (parcelado == 1)
            {
                resultado = valor + (valor * 0.08M);
                MessageBox.Show($"O valor final é de {resultado}");
            }
            else if (parcelado == 2)
            {
                resultado = valor + (valor * 0.15M);
                MessageBox.Show($"O valor final é de {resultado}");
            }
            else if (parcelado == 3)
            {
                resultado = valor + (valor * 0.21M);
                MessageBox.Show($"O valor final é de {resultado}");
            }
            else
            {
                MessageBox.Show($"Não é possivel parcelar nessas vezes");
            }



        }
    }
}
