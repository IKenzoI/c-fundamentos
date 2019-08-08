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
    public partial class FrmAlunos : Form
    {
        string[] alunos = new string[8];
        public FrmAlunos()
        {
            InitializeComponent();
            
            alunos[0] = "Rossi";
            alunos[1] = "Patrick";
            alunos[2] = "Vivian";
            alunos[3] = "Erik";
            alunos[4] = "Rogério";
            alunos[5] = "Genari";
            alunos[6] = "Kenzo";
            alunos[7] = "Fábio";

            lstAlunos.DataSource = alunos;
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            int i = 0;
            string[] listaFiltrada = new string[alunos.Length];
            foreach (var aluno in alunos)
              {
               if (aluno.ToLower().Contains(txtNome.Text.ToLower()))
               {
                    Array.Resize(ref listaFiltrada, listaFiltrada.Length + 1);
                    listaFiltrada[i] += $"{aluno}";
                    i++;
                }
            }
            lstAlunos.DataSource = listaFiltrada;
        }
    }
}
