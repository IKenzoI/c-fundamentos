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
    public partial class ImpressaoNumeros : Form
    {
        public ImpressaoNumeros()
        {
            InitializeComponent();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
          int  numero = 6;

            /*for (int i = 17; i >= 5; i--)
            {
                MessageBox.Show(" "+i);
            }*/
            /*for (int i = 10; i <= 20; i++)
            {
                numero += i;
                MessageBox.Show(""+numero);
            }*/
            for (int i = 1; i < 10; i++)
            {
                numero = numero * i;
                MessageBox.Show("Tabuada do 6 " + numero);
            }
        }
    }
}
