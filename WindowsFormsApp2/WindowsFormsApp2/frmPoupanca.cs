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
    public partial class frmPoupanca : Form
    {
        public frmPoupanca()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            DateTime previsaoSaque = Convert.ToDateTime(txtPrevisaoSaque.Text);

            int totalMeses = Convert.ToInt32((previsaoSaque - DateTime.Today).TotalDays / 30);

            String nome = txtNome.Text;
            decimal saldo = Convert.ToDecimal(txtSaldo.Text);
            decimal variacao = 0.0037M;
            decimal resultado;
            for (int i = 0; i < totalMeses; i++)
            {
                saldo += saldo * variacao;
 
            }
            MessageBox.Show($"Senhor(a) {nome} o saldo será de  {saldo.ToString("C")}");

        }
    }
}
