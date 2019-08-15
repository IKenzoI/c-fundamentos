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
    public partial class multiplicacao : Form
    {
        public multiplicacao()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);

            numero = numero * numero;
            MessageBox.Show($"O numero informado vezes ele mesmo é {numero}");
        }
    }
}
