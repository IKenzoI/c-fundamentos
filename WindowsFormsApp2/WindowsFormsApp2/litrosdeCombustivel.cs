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
    public partial class litrosdeCombustivel : Form
    {
        public litrosdeCombustivel()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int distanciaPercorrida;
            int tempo = Convert.ToInt32(txtTempo.Text);
            int velocidade = Convert.ToInt32(txtVelocidade.Text);
            int litros;

            distanciaPercorrida = tempo * velocidade;
            litros = distanciaPercorrida / 12;

            System.Console.WriteLine($"A velocidade média é de {velocidade} Km/h");
            MessageBox.Show($"O tempo gasto na viagem é de {tempo} minutos");
            MessageBox.Show($"A disância percorrida é de {distanciaPercorrida} Km");
            MessageBox.Show($"A quantidade de litros usada é de {litros} litros de combustível");





        }
    }
}
