using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            int valorInteiro;
            decimal valorDecimal;
            DateTime data;

            valorInteiro = Convert.ToInt32(txtValorInteiro.Text);
            valorDecimal = Convert.ToDecimal(txtValorDecimal.Text);
            data = Convert.ToDateTime(txtData.Text);

        }

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            int inteiro = Convert.ToInt32(txtValorInteiro.Text);
            decimal valorDecimal = Convert.ToDecimal(txtValorDecimal.Text);

            decimal result;

            result = inteiro + valorDecimal;

            MessageBox.Show($"O resultado é: {result}");
        }
        

        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            int inteiroSub = Convert.ToInt32(txtValorInteiro.Text);
            decimal valorDecimalSub = Convert.ToDecimal(txtValorDecimal.Text);

            decimal resultado;

            resultado = inteiroSub - valorDecimalSub;

            MessageBox.Show($"O resultado é: {resultado}");
        }
       

        private void BtnFormula_Click(object sender, EventArgs e)
        {
            //somar valor inteiro com valor decimal
            //multipilcar o resultaod por 1,5 e exibir
            //em uma mensagem de alerta  
            //Se colocar M no numero que é um double ele vira decimal
            //nunca chumbar numeros no codigo, smepre declarar varialveis p/ caso mude no futuro for mais simples para mudar
            int inteiro = Convert.ToInt32(txtValorInteiro.Text);
            decimal valorDecimal = Convert.ToDecimal(txtValorDecimal.Text);

            decimal result;
            decimal resultado;
            decimal multiplicador = 1.5m;

            result = inteiro / valorDecimal;
            resultado = result * multiplicador;
            MessageBox.Show($"O resultado é {resultado}","",MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
