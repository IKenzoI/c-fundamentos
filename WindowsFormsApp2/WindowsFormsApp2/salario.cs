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
    public partial class salario : Form
    {
        public salario()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            decimal salario = Convert.ToDecimal(txtSalario.Text);
            decimal reajuste = Convert.ToDecimal(txtReajuste.Text);
            decimal resultado;

            resultado = (salario * (reajuste/100)) + salario;

            MessageBox.Show($"O novo salario é {resultado:C}");
        }
    }
}
