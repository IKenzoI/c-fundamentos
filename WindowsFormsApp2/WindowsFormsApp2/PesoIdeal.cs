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
    public partial class PesoIdeal : Form
    {
        public PesoIdeal()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            decimal altura = Convert.ToDecimal(txtAltura.Text);
            decimal resultado;

            if (checkBoxHomem.Checked && checkBoxMulher.Checked)
            {
                MessageBox.Show("Não selecione dois campos","Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (checkBoxHomem.Checked)
            {

              resultado = (altura * 72.7M) - 58.0M;
                MessageBox.Show($"O resultado é {resultado} Kg");
            }
            else if (checkBoxMulher.Checked)
            {
                resultado = (altura * 62.1M) - 44.7M;
                MessageBox.Show($"O resultado é {resultado} Kg");
            }
           

        }
    }
}
