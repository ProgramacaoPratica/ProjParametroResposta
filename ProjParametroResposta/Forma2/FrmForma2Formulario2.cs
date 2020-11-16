using System;
using System.Windows.Forms;

namespace ProjParametroResposta.Forma2
{
    public partial class FrmForma2Formulario2 : Form
    {
        public string strParametro;
        public string strResposta;
        public FrmForma2Formulario2()
        {
            InitializeComponent();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            strResposta = txtRespostaDevolver.Text;
            Close();
        }

        private void FrmForma2Formulario2_Load(object sender, EventArgs e)
        {
            txtParametroRecebido.Text = strParametro;
        }
    }
}
