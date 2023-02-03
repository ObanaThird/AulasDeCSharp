using System.Data;

namespace CalculoMedia
{
    public partial class frmCalculo : Form
    {
        public frmCalculo()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double n1, n2, res;

            n1 = Convert.ToDouble(txtNota1.Text);
            n2 = Convert.ToDouble(txtNota2.Text);

            res = (n1 + n2) / 2;

            if(res >= 7) { MessageBox.Show("Aluno aprovado!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else if(res >=4 && res<7) { MessageBox.Show("Aluno em recuperação!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else { MessageBox.Show("Aluno reprovado!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}