using System;
using System.Windows.Forms;

namespace ProjParametroResposta.Forma2
{
    public partial class FrmForma2Formulario1 : Form
    {
        public FrmForma2Formulario1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            FrmForma2Formulario2 frm = new FrmForma2Formulario2();
            frm.strParametro = txtParametroEnviar.Text;
            frm.ShowDialog();
            txtRespostaRecebida.Text = frm.strResposta;
        }
    }
}
