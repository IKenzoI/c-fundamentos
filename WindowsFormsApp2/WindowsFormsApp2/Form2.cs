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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            bool valido = true;
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valido = false;
            }
            if (txtSobrenome.Text == string.Empty)
            {
                MessageBox.Show("Preecha o campo de Sobrneome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valido = false;
            }
            if (txtDtNascimento.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo da Data de Nascimento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valido = false;
            }
            //se o cod tiver errado sai fora do metodo
            if (valido == false)
            {
                return;
            }
            string nome, sobrenome;
            DateTime datanascimento;
            //Pegar apenas o texto do textbox
            nome = txtNome.Text;
            sobrenome = txtSobrenome.Text;
            datanascimento = Convert.ToDateTime(txtDtNascimento.Text);



            MessageBox.Show($"Nome: {nome} Sobrneome: {sobrenome} Data Nascimento: {datanascimento}");
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
