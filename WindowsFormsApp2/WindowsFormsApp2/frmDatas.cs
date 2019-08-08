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
    public partial class frmDatas : Form
    {
        public frmDatas()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            DateTime data = Convert.ToDateTime(txtData.Text);

            DateTime dataMes = Convert.ToDateTime(txtMeses.Text);


            int dias = Convert.ToInt32(txtDias.Text);
            int qtdMes = Convert.ToInt32(txtMeses.Text);
            dataMes = dataMes.AddMonths(qtdMes);
            data = data.AddDays(dias);
            


            //dd-MM-yyyy;
            //dd-MMM-yyyy;
            //dd-MMMM-yyyy;
            //dd-MM-yy;
            //para subtrair dias coloque um - na frente
            lblQtdDias.Text = data.ToString("dddd " + "dd - MM - yyyy");
            lblQtdMeses.Text = dataMes.ToString("dddd " + "dd - MM - yyyy");




        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            
            txtData.Text = string.Empty;
            txtDias.Text = string.Empty;
            txtMeses.Text = string.Empty;
        }

        private void FrmDatas_Load(object sender, EventArgs e)
        {

        }
    }
}
