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
    public partial class frmEnum : Form
    {
        public frmEnum()
        {
            InitializeComponent();
        }

        enum TimeEnum
        {
            SaoPaulo,
            Corinthians,
            Palmeiras,
            Santos,
            Portuguesa
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text.ToLower();
            nome = nome.Trim();
            TimeEnum time;
            if (nome == "vivian" || nome == "fabio" || nome == "kleber" || nome == "rossi")
            {
                time = TimeEnum.Corinthians;
            }
            else if (nome == "patrick" || nome == "erik")
            {
                time = TimeEnum.Palmeiras;
            }
            else if (nome == "kenzo" || nome == "genari")
            {
                time = TimeEnum.SaoPaulo;
            }
            else if (nome == "rogerio")
            {
                time = TimeEnum.Santos;
            }
            else
            {
                time = TimeEnum.Portuguesa;
            }
            switch (time)
            {
                case TimeEnum.SaoPaulo:
                    txtNome.Text = $"{nome} seu time é tricampeão";
                    break;
                case TimeEnum.Corinthians:
                    txtNome.Text = $"{nome} só gamba";
                    break;
                case TimeEnum.Palmeiras:
                    txtNome.Text = $"{nome} seu time não tem mundial";
                    break;
                case TimeEnum.Santos:
                    txtNome.Text = $"{nome} era uma vez o Pelé";
                    break;
                case TimeEnum.Portuguesa:
                    txtNome.Text = $"{nome} seu time exite?";
                    break;
                default:
                    txtNome.Text = $"{nome} vai ver show do Sandy e Junior";
                    break;
            }

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
        }
    }
}
