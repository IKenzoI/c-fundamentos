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
    public partial class ImparPar : Form
    {
        public ImparPar()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);

            if (numero % 2 == 1 && numero % 2 == 0)
            {
                MessageBox.Show($"O número é par");
            }
            else if (numero%2==0)
            {
                MessageBox.Show($"O número é par");
            }
            else if (numero%2==1)
            {
                MessageBox.Show($"O número é impar");
            }
            
        }
    }
}
