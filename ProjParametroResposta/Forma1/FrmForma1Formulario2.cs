using System;
using System.Windows.Forms;

namespace ProjParametroResposta.Forma1
{
    public partial class FrmForma1Formulario2 : Form
    {
        private TextBox txtResposta;
        public FrmForma1Formulario2()
        {
            InitializeComponent();
        }

        public FrmForma1Formulario2(TextBox txt): this()
        {
            txtResposta = txt;
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            txtResposta.Text = txtRespostaDevolver.Text;

            txtResposta.Visible = false;

            Close();
        }
    }
}
