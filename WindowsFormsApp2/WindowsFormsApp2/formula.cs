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
    public partial class formula : Form
    {
        public formula()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            decimal numero1 = Convert.ToDecimal(txtNum1.Text);
            decimal numero2 = Convert.ToDecimal(txtNum2.Text);
            decimal resultado;

            resultado = ((numero1 * 9) / (87 - numero2)) * ((numero1 * 9) / (87 - numero2));

            MessageBox.Show($"O resultado é {resultado}");
        }
    }
}
