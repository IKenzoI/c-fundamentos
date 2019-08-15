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
    public partial class Idade : Form
    {
        public Idade()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            DateTime nascimento = Convert.ToDateTime(txtDtNascimento.Text);
            DateTime atual = Convert.ToDateTime(txtDtAtual.Text);
            int resultado;

            resultado = atual.Year - nascimento.Year;
            MessageBox.Show($"A idade do caboclo é {resultado} anos");

            if (resultado < 18 && resultado<16)
            {
                MessageBox.Show($"Caro");
            }
            else
            {

            }



        }
    }
}
