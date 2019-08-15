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
    public partial class NumeroDivisivel : Form
    {
        public NumeroDivisivel()
        {
            InitializeComponent();
        }

        private void BtnDivisivel_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);

            if (numero % 7 != 0 && numero % 4 != 0)
            {
                MessageBox.Show($"O número { numero } não é divisivel nem por 4 nem por 7");
            }
            else if (numero % 7 == 0 && numero % 4 == 0)
            {
                MessageBox.Show($"O número { numero } é divisivel por 4 e por 7");
            }
            else if (numero % 7 == 0)
            {
                MessageBox.Show($"O número { numero } é divisivel por 7");
            }
            else if (numero % 4 == 0)
            {
                MessageBox.Show($"O número { numero } é divisivel por 4");
            }
            /*
            switch (numero)
            {
                case 1:
                    if (numero % 7 == 0 && numero % 4 == 0)
                    {
                        MessageBox.Show($"O{ numero } é divisivel por 4 e 7");
                    }
                    break;
                case 2:
                    if (numero % 7 == 0)
                    {
                        MessageBox.Show($"O{ numero } é apenas divisivel por 7");
                    }
                    break;
                case 3:
                    if (numero % 4 == 0)
                    {
                        MessageBox.Show($"O{ numero } é divisivel por 4");
                    }
                    break;
                case 4:
                    if (numero % 7 != 0 && numero % 4 != 0)
                    {
                        MessageBox.Show($"O{ numero } não é divisivel nem por 4 nem por 7");
                    }
                    break;
            }*/

        }
    }
}
