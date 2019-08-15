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
    public partial class pagamentoFuncionario : Form
    {
        public pagamentoFuncionario()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            decimal salario = Convert.ToDecimal(txtSalario.Text);
            decimal vendas = Convert.ToDecimal(txtVendas.Text);
            decimal salarioFinal;

            salarioFinal = (salario + (vendas * 0.1M));
            MessageBox.Show($"O salário final do {nome} será de {salarioFinal}");
        }
    }
}
