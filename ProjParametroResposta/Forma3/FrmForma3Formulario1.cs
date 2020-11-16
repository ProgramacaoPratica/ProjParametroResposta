using System;
using System.Windows.Forms;

namespace ProjParametroResposta.Forma3
{
    public partial class FrmForma3Formulario1 : Form
    {
        public FrmForma3Formulario1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            FrmForma3Formulario2 frm = new FrmForma3Formulario2();
            frm.Valor = txtParametroEnviar.Text;

            frm.ShowDialog();

            txtRespostaRecebida.Text = frm.Valor;
        }
    }
}
