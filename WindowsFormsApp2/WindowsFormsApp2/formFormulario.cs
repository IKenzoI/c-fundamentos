using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class formFormulario : Form
    {
        public formFormulario()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int idade = Convert.ToInt32(txtIdade.Text);

            if (checkBoxMasculino.Checked)
            {
                MessageBox.Show($"Seu nome é {nome} sua idade é {idade} seu sexo é Masculino");
            }
            else if (checkBoxFeminino.Checked)
            {
                MessageBox.Show($"Seu nome é {nome} sua idade é {idade} seu sexo é Feminino");
            }
        }

        private void FormFormulario_Load(object sender, EventArgs e)
        {

        }
    }
}
