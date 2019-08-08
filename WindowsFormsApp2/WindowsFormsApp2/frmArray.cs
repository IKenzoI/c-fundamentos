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
    public partial class frmArray : Form
    {
        string[] alunos = new string[8];
        public frmArray()
        {
            /*inicializa com o form*/
            InitializeComponent();
            lblTamanhoArray.Text = "";

            alunos[0] = "Rossi";
            alunos[1] = "VPatrick";
            alunos[2] = "Vivian";
            alunos[3] = "VErik";
            alunos[4] = "VRogério";
            alunos[5] = "VGenari";
            alunos[6] = "VKenzo";
            alunos[7] = "Fábio"; 
        }

                private void BtnOk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < alunos.Length; i++)
            {
                if (alunos[i] == null)
                {
                    alunos[i] = txtNome.Text;
                    lblTamanhoArray.Text += $"{txtNome.Text}\r \n";
                    txtNome.Text = string.Empty;
                    break;
                }
            }
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
           #region Primeiro Item
         /*   if (alunos.Length >= 1)
            {

                lblPrimeiroItem.Text = alunos[0];

                
            }
            #endregion
           #region LetraR
            lblNomeR.Text = string.Empty;
            foreach (var aluno in alunos)
            {
                if (aluno.StartsWith("R"))
                {
                    lblNomeR.Text += $"{aluno}, ";
                }
            }*/
            #endregion
            
            #region Array alunos letra R
            for (int i = 0; i < alunos.Length; i++)
            {
                if (alunos[i] == null)
                {
                    alunos[i] = txtNome.Text;
                    lblTamanhoArray.Text += $"{txtNome.Text}\r \n";
                    txtNome.Text = string.Empty;
                    break;
                }

                lblNomeLetraR.Text = string.Empty;
                foreach (var aluno in alunos)
                {
                    if (aluno.StartsWith("V"))
                    {
                        lblNomeLetraR.Text += $"{aluno}, ";
                    }
                }
            }
            #endregion
        }
    }
}
