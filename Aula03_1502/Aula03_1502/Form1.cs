namespace Aula03_1502
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
            mtxtDataVen.Clear();
            mtxtDataPag.Clear();
            txtMulta.Clear();
            txtJuros.Clear();
            txtValDesc.Clear();

            txtDiasAtraso.Clear();
            txtValMulta.Clear();
            txtValJuros.Clear();
            txtValDesc.Clear();
            txtAcrescimos.Clear();
            txtTotal.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor, multa, desconto, juros, diasAtraso, valMulta, valJuros, valDesc, acrescimos, total;
            DateTime dataVenc, dataPag;

            try
            {
                valor = Convert.ToDouble(txtValor.Text);
                multa = Convert.ToDouble(txtMulta.Text);
                desconto = Convert.ToDouble(txtDesconto.Text);
                juros = Convert.ToDouble(txtJuros.Text);

                dataVenc = Convert.ToDateTime(mtxtDataVen.Text);
                dataPag = Convert.ToDateTime(mtxtDataPag.Text);

                //atraso
                if(dataPag > dataVenc)
                {
                    diasAtraso = (dataPag - dataVenc).Days;
                    valMulta = (multa / 100) * valor * diasAtraso;
                    valJuros = (juros / 100) * valor;
                    acrescimos = valMulta + valJuros;
                    total = valor + acrescimos;

                    txtDiasAtraso.Text = diasAtraso.ToString();
                    txtValMulta.Text = valMulta.ToString();
                    txtValJuros.Text = valJuros.ToString();
                    txtValDesc.Text = " ";
                    txtAcrescimos.Text = acrescimos.ToString();
                    txtTotal.Text = total.ToString();
                }
                //em dia
                else 
                {
                    valDesc = (desconto / 100) * valor;
                    total = valor - valDesc;

                    txtDiasAtraso.Text = "";
                    txtMulta.Text = "";
                    txtValJuros.Text = "";
                    txtValDesc.Text = Convert.ToString(valDesc);
                    txtAcrescimos.Text = "";
                    txtTotal.Text = Convert.ToString(total);
                }
            }
            catch
            {
                MessageBox.Show("Formato incorreto! Tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}