using Microsoft.VisualBasic;
using System.Configuration;

namespace LojaCarros
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void rdbCelta_CheckedChanged(object sender, EventArgs e)
		{
			if (rdbCelta.Checked)
			{
				cbbCor.SelectedIndex = default;
				if (cbbCor.SelectedIndex == default)
				{
					cbbCor.Text = "Escolha a cor...";
				}
				cbTurbo.Checked = false;
				rdbNovo.Checked = false;
				rdbSemi.Checked = false;
				rdbUsed.Checked = false;
				cbPer.Checked = false;
				txtPlaca.Text = "";

				rdbVista.Checked = false;
				rdbFin.Checked = false;
				gpbPag.Enabled = false;
				cbTurbo.Enabled = false;
				rdbNovo.Enabled = false;
				gpbModel.Enabled = true;
			}
			else
			{
				cbTurbo.Enabled = true;
				rdbNovo.Enabled = true;
			}
		}

		private void rdbMar_CheckedChanged(object sender, EventArgs e)
		{
			if (rdbMar.Checked)
			{
				cbbCor.SelectedIndex = default;
				if (cbbCor.SelectedIndex == default)
				{
					cbbCor.Text = "Escolha a cor...";
				}
				cbTurbo.Checked = false;
				rdbNovo.Checked = false;
				rdbSemi.Checked = false;
				rdbUsed.Checked = false;
				cbPer.Checked = false;
				txtPlaca.Text = "";

				rdbVista.Checked = false;
				rdbFin.Checked = false;
				gpbPag.Enabled = false;
				cbTurbo.Enabled = true;
				rdbNovo.Enabled = false;
				gpbModel.Enabled = true;
			}
			else
			{
				rdbNovo.Enabled = true;
				cbTurbo.Enabled = false;
			}
		}

		private void rdbG3_CheckedChanged(object sender, EventArgs e)
		{
			if (rdbG3.Checked)
			{

				cbbCor.SelectedIndex = default;
				if (cbbCor.SelectedIndex == default)
				{
					cbbCor.Text = "Escolha a cor...";
				}
				cbTurbo.Checked = false;
				rdbNovo.Checked = false;
				rdbSemi.Checked = false;
				rdbUsed.Checked = false;
				cbPer.Checked = false;
				txtPlaca.Text = "";

				rdbVista.Checked = false;
				rdbFin.Checked = false;
				gpbPag.Enabled = false;
				gpbModel.Enabled = true;
			}
		}

		private void rdbA3_CheckedChanged(object sender, EventArgs e)
		{
			if (rdbA3.Checked)
			{

				cbbCor.SelectedIndex = default;
				if (cbbCor.SelectedIndex == default)
				{
					cbbCor.Text = "Escolha a cor...";
				}
				cbTurbo.Checked = false;
				rdbNovo.Checked = false;
				rdbSemi.Checked = false;
				rdbUsed.Checked = false;
				cbPer.Checked = false;
				txtPlaca.Text = "";
				rdbVista.Checked = false;
				rdbFin.Checked = false;
				gpbPag.Enabled = false;
				gpbModel.Enabled = true;
			}
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Tem certeza que deseja sair?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
			if (res == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void rdbFin_CheckedChanged(object sender, EventArgs e)
		{
			if (rdbFin.Checked)
			{
				cbbParcela.Visible = true;
				lblJur.Visible = true;
				lblParJur.Visible = false;
				lblJuros.Visible = false;
				lblVistaDesc.Visible = false;
				lblValTotal.Visible = false;

				lblVPJ.Text = "";
				lblValJur.Text = "";
				lblVtotal.Text = "";
				cbbParcela.Text = "Escolha as parcelas";
			}
			else
			{
				cbbParcela.Visible = false;
				lblJur.Visible = false;
			}
		}

		private void btnPag_Click(object sender, EventArgs e)
		{
			if (cbbCor.Text != "Escolha a cor..." && cbbCor.SelectedIndex == 0 || cbbCor.SelectedIndex == 1 || cbbCor.SelectedIndex == 2 || cbbCor.SelectedIndex == 3 || cbbCor.SelectedIndex == 4 || cbbCor.SelectedIndex == 5)
			{
				if (rdbNovo.Checked || rdbSemi.Checked || rdbUsed.Checked)
				{
					if (cbPer.Checked && txtPlaca.Text != "")
					{
						gpbPag.Enabled = true;
						gpbModel.Enabled = false;
					}
					if (!cbPer.Checked)
					{
						DialogResult res = MessageBox.Show("Tem certeza que não gostaria de placa personalizada?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
						if (res == DialogResult.Yes)
						{
							gpbPag.Enabled = true;
							gpbModel.Enabled = false;
						}
						else
						{
							cbPer.Checked = true;
						}
					}
					else if (cbPer.Checked && txtPlaca.Text == "")
					{
						MessageBox.Show("Informe o texto da placa personalizada ou desmarque a opção 'Placa personalizada'.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("Informe o estado desejado do carro", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Informe a cor", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void cbPer_CheckedChanged(object sender, EventArgs e)
		{
			if (cbPer.Checked)
			{
				txtPlaca.Enabled = true;
			}
			else
			{
				txtPlaca.Enabled = false;
			}
		}

		private void rdbVista_CheckedChanged(object sender, EventArgs e)
		{
			if (rdbVista.Checked)
			{
				lblFPag.Visible = true;
				cbbForPag.Visible = true;
				lblParJur.Visible = false;
				lblJuros.Visible = false;
				lblVistaDesc.Visible = false;
				lblValTotal.Visible = false;

				lblVPJ.Text = "";
				lblValJur.Text = "";
				lblVtotal.Text = "";
				cbbForPag.Text = "Escolha...";
			}
			else
			{
				lblFPag.Visible = false;
				cbbForPag.Visible = false;
			}
		}

		private void rdbUsed_CheckedChanged(object sender, EventArgs e)
		{
			if (rdbCelta.Checked)
			{
				cbTurbo.Enabled = false;
			}
			if (rdbMar.Checked)
			{
				cbTurbo.Enabled = false;
			}
		}

		private void rdbSemi_CheckedChanged(object sender, EventArgs e)
		{
			if (rdbCelta.Checked)
			{
				cbTurbo.Enabled = false;
			}
			if (rdbMar.Checked)
			{
				cbTurbo.Enabled = true;
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			cbbCor.SelectedIndex = default;
			if (cbbCor.SelectedIndex == default)
			{
				cbbCor.Text = "Escolha a cor...";
			}
			cbbForPag.SelectedIndex = default;
			if (cbbForPag.SelectedIndex == default)
			{
				cbbForPag.Text = "Escolha as parcelas...";
			}
			cbbParcela.SelectedIndex = default;
			if (cbbParcela.SelectedIndex == default)
			{
				cbbParcela.Text = "Escolha as parcelas...";
			}
			cbTurbo.Checked = false;
			rdbNovo.Checked = false;
			rdbSemi.Checked = false;
			rdbUsed.Checked = false;
			cbPer.Checked = false;
			txtPlaca.Text = "";
			if (rdbCelta.Checked)
			{
				rdbCelta.Checked = false;
				gpbModel.Enabled = false;
			}
			if (rdbMar.Checked)
			{
				rdbMar.Checked = false;
				gpbModel.Enabled = false;
			}
			if (rdbG3.Checked)
			{
				rdbG3.Checked = false;
				gpbModel.Enabled = false;
			}
			if (rdbA3.Checked)
			{
				rdbA3.Checked = false;
				gpbModel.Enabled = false;
			}
		}

		private void btnAlt_Click(object sender, EventArgs e)
		{
			gpbModel.Enabled = true;
			gpbPag.Enabled = false;
			rdbVista.Checked = false;
			rdbFin.Checked = false;
			lblVPJ.Text = "";
		}

		private void cbbForPag_SelectedIndexChanged(object sender, EventArgs e)
		{
			double total;
			double placa = 500;
			double valDesc;
			double celtaSemi = 15900;
			double celtaUsed = 12900;
			double marSemTurbo = 42000;
			double marSemi = 24000;
			double marUsed = 17000;
			double g3NovoTur = 58000;
			double g3Novo = 44900;
			double g3SemiTur = 36900;
			double g3Semi = 24900;
			double g3UsedTur = 29900;
			double g3Used = 13900;
			double a3NovoTur = 65000;
			double a3Novo = 45900;
			double a3SemiTur = 43000;
			double a3Semi = 36900;
			double a3UsedTur = 38000;
			double a3Used = 22000;

			int opc = cbbForPag.SelectedIndex;
			switch (opc)
			{
				case 0:
					if (rdbCelta.Checked)
					{
						double estadoCelta = rdbSemi.Checked ? celtaSemi : celtaUsed;
						total = txtPlaca.Text != "" ? placa + estadoCelta : estadoCelta;
						valDesc = total * 0.12;
						total -= valDesc;
						lblVistaDesc.Visible = true;
						lblValJur.Text = valDesc.ToString("C");
						lblValTotal.Visible = true;
						lblVtotal.Text = total.ToString("C");

					}

					if (rdbMar.Checked)
					{
						double estadoMar = rdbSemi.Checked ? (cbTurbo.Checked ? marSemTurbo : marSemi) : marUsed;
						total = txtPlaca.Text != "" ? placa + estadoMar : estadoMar;
						valDesc = total * 0.12;
						total -= valDesc;
						lblVistaDesc.Visible = true;
						lblValJur.Text = valDesc.ToString("C");
						lblValTotal.Visible = true;
						lblVtotal.Text = total.ToString("C");
					}
					if (rdbG3.Checked)
					{
						double estadoG3 = rdbNovo.Checked ? (cbTurbo.Checked ? g3NovoTur : g3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? g3SemiTur : g3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? g3UsedTur : g3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoG3 : estadoG3;
						valDesc = total * 0.12;
						total -= valDesc;
						lblVistaDesc.Visible = true;
						lblValJur.Text = valDesc.ToString("C");
						lblValTotal.Visible = true;
						lblVtotal.Text = total.ToString("C");
					}

					if (rdbA3.Checked)
					{
						double estadoA3 = rdbNovo.Checked ? (cbTurbo.Checked ? a3NovoTur : a3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? a3SemiTur : a3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? a3UsedTur : a3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoA3 : estadoA3;
						valDesc = total * 0.12;
						total -= valDesc;
						lblVistaDesc.Visible = true;
						lblValJur.Text = valDesc.ToString("C");
						lblValTotal.Visible = true;
						lblVtotal.Text = total.ToString("C");
					}
					break;

				case 1:
					if (rdbCelta.Checked)
					{
						double estadoCelta = rdbSemi.Checked ? celtaSemi : celtaUsed;
						total = txtPlaca.Text != "" ? placa + estadoCelta : estadoCelta;
						valDesc = total * 0.12;
						total -= valDesc;
						lblVistaDesc.Visible = true;
						lblValJur.Text = valDesc.ToString("C");
						lblValTotal.Visible = true;
						lblVtotal.Text = total.ToString("C");
					}

					if (rdbMar.Checked)
					{
						double estadoMar = rdbSemi.Checked ? (cbTurbo.Checked ? marSemTurbo : marSemi) : marUsed;
						total = txtPlaca.Text != "" ? placa + estadoMar : estadoMar;
						valDesc = total * 0.12;
						total -= valDesc;
						lblVistaDesc.Visible = true;
						lblValJur.Text = valDesc.ToString("C");
						lblValTotal.Visible = true;
						lblVtotal.Text = total.ToString("C");
					}

					if (rdbG3.Checked)
					{
						double estadoG3 = rdbNovo.Checked ? (cbTurbo.Checked ? g3NovoTur : g3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? g3SemiTur : g3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? g3UsedTur : g3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoG3 : estadoG3;
						valDesc = total * 0.12;
						total -= valDesc;
						lblVistaDesc.Visible = true;
						lblValJur.Text = valDesc.ToString("C");
						lblValTotal.Visible = true;
						lblVtotal.Text = total.ToString("C");
					}

					if (rdbA3.Checked)
					{
						double estadoA3 = rdbNovo.Checked ? (cbTurbo.Checked ? a3NovoTur : a3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? a3SemiTur : a3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? a3UsedTur : a3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoA3 : estadoA3;
						valDesc = total * 0.12;
						total -= valDesc;
						lblVistaDesc.Visible = true;
						lblValJur.Text = valDesc.ToString("C");
						lblValTotal.Visible = true;
						lblVtotal.Text = total.ToString("C");
					}
					break;

				case 2:
					if (rdbCelta.Checked)
					{
						double estadoCelta = rdbSemi.Checked ? celtaSemi : celtaUsed;
						total = txtPlaca.Text != "" ? placa + estadoCelta : estadoCelta;
						valDesc = total * 0.15;
						total -= valDesc;
						lblVistaDesc.Visible = true;
						lblValJur.Text = valDesc.ToString("C");
						lblValTotal.Visible = true;
						lblVtotal.Text = total.ToString("C");
					}

					if (rdbMar.Checked)
					{
						double estadoMar = rdbSemi.Checked ? (cbTurbo.Checked ? marSemTurbo : marSemi) : marUsed;
						total = txtPlaca.Text != "" ? placa + estadoMar : estadoMar;
						valDesc = total * 0.15;
						total -= valDesc;
						lblVistaDesc.Visible = true;
						lblValJur.Text = valDesc.ToString("C");
						lblValTotal.Visible = true;
						lblVtotal.Text = total.ToString("C");
					}

					if (rdbG3.Checked)
					{
						double estadoG3 = rdbNovo.Checked ? (cbTurbo.Checked ? g3NovoTur : g3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? g3SemiTur : g3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? g3UsedTur : g3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoG3 : estadoG3;
						valDesc = total * 0.15;
						total -= valDesc;
						lblVistaDesc.Visible = true;
						lblValJur.Text = valDesc.ToString("C");
						lblValTotal.Visible = true;
						lblVtotal.Text = total.ToString("C");
					}

					if (rdbA3.Checked)
					{
						double estadoA3 = rdbNovo.Checked ? (cbTurbo.Checked ? a3NovoTur : a3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? a3SemiTur : a3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? a3UsedTur : a3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoA3 : estadoA3;
						valDesc = total * 0.15;
						total -= valDesc;
						lblVistaDesc.Visible = true;
						lblValJur.Text = valDesc.ToString("C");
						lblValTotal.Visible = true;
						lblVtotal.Text = total.ToString("C");
					}
					break;

				case 3:
					if (rdbCelta.Checked)
					{
						double estadoCelta = rdbSemi.Checked ? celtaSemi : celtaUsed;
						total = txtPlaca.Text != "" ? placa + estadoCelta : estadoCelta;
						lblValTotal.Visible = true;
						lblVtotal.Text = total.ToString("C");
						lblValJur.Text = "";
						lblVistaDesc.Visible = false;
					}

					if (rdbMar.Checked)
					{
						double estadoMar = rdbSemi.Checked ? (cbTurbo.Checked ? marSemTurbo : marSemi) : marUsed;
						total = txtPlaca.Text != "" ? placa + estadoMar : estadoMar;
						lblValTotal.Visible = true;
						lblVtotal.Text = total.ToString("C");
						lblParJur.Visible = false;
						lblVPJ.Text = "";
					}

					if (rdbG3.Checked)
					{
						double estadoG3 = rdbNovo.Checked ? (cbTurbo.Checked ? g3NovoTur : g3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? g3SemiTur : g3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? g3UsedTur : g3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoG3 : estadoG3;
						lblValTotal.Visible = true;
						lblVtotal.Text = total.ToString("C");
						lblParJur.Visible = false;
						lblVPJ.Text = "";
					}

					if (rdbA3.Checked)
					{
						double estadoA3 = rdbNovo.Checked ? (cbTurbo.Checked ? a3NovoTur : a3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? a3SemiTur : a3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? a3UsedTur : a3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoA3 : estadoA3;
						lblValTotal.Visible = true;
						lblVtotal.Text = total.ToString("C");
						lblParJur.Visible = false;
						lblVPJ.Text = "";
					}
					break;
			}
		}

		private void cbbParcela_SelectedIndexChanged(object sender, EventArgs e)
		{
			double total;
			double placa = 500;
			double celtaSemi = 15900;
			double celtaUsed = 12900;
			double marSemTurbo = 42000;
			double marSemi = 24000;
			double marUsed = 17000;
			double g3NovoTur = 58000;
			double g3Novo = 44900;
			double g3SemiTur = 36900;
			double g3Semi = 24900;
			double g3UsedTur = 29900;
			double g3Used = 13900;
			double a3NovoTur = 65000;
			double a3Novo = 45900;
			double a3SemiTur = 43000;
			double a3Semi = 36900;
			double a3UsedTur = 38000;
			double a3Used = 22000;

			double parcelaMensal;
			double parcelaMensalJuros;
			double parcelaTotal;

			int opc2 = cbbParcela.SelectedIndex;
			switch (opc2)
			{
				case 0:
					if (rdbCelta.Checked)
					{
						double estadoCelta = rdbSemi.Checked ? celtaSemi : celtaUsed;
						total = txtPlaca.Text != "" ? placa + estadoCelta : estadoCelta;
						total /= 2;
						lblVPJ.Text = "2x de " + total.ToString("C");
					}

					if (rdbMar.Checked)
					{
						double estadoMar = rdbSemi.Checked ? (cbTurbo.Checked ? marSemTurbo : marSemi) : marUsed;
						total = txtPlaca.Text != "" ? placa + estadoMar : estadoMar;
						total /= 2;
						lblVPJ.Text = "2x de " + total.ToString("C");
					}

					if (rdbG3.Checked)
					{
						double estadoG3 = rdbNovo.Checked ? (cbTurbo.Checked ? g3NovoTur : g3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? g3SemiTur : g3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? g3UsedTur : g3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoG3 : estadoG3;
						total /= 2;
						lblVPJ.Text = "2x de " + total.ToString("C");
					}

					if (rdbA3.Checked)
					{
						double estadoA3 = rdbNovo.Checked ? (cbTurbo.Checked ? a3NovoTur : a3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? a3SemiTur : a3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? a3UsedTur : a3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoA3 : estadoA3;
						total /= 2;
						lblVPJ.Text = "2x de " + total.ToString("C");
					}
					break;

				case 1:
					if (rdbCelta.Checked)
					{
						double estadoCelta = rdbSemi.Checked ? celtaSemi : celtaUsed;
						total = txtPlaca.Text != "" ? placa + estadoCelta : estadoCelta;
						total /= 3;
						lblVPJ.Text = "3x de " + total.ToString("C");
					}

					if (rdbMar.Checked)
					{
						double estadoMar = rdbSemi.Checked ? (cbTurbo.Checked ? marSemTurbo : marSemi) : marUsed;
						total = txtPlaca.Text != "" ? placa + estadoMar : estadoMar;
						total /= 3;
						lblVPJ.Text = "3x de " + total.ToString("C");
					}

					if (rdbG3.Checked)
					{
						double estadoG3 = rdbNovo.Checked ? (cbTurbo.Checked ? g3NovoTur : g3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? g3SemiTur : g3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? g3UsedTur : g3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoG3 : estadoG3;
						total /= 3;
						lblVPJ.Text = "3x de " + total.ToString("C");
					}

					if (rdbA3.Checked)
					{
						double estadoA3 = rdbNovo.Checked ? (cbTurbo.Checked ? a3NovoTur : a3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? a3SemiTur : a3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? a3UsedTur : a3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoA3 : estadoA3;
						total /= 3;
						lblVPJ.Text = "3x de " + total.ToString("C");
					}
					break;

				case 2:
					if (rdbCelta.Checked)
					{
						double estadoCelta = rdbSemi.Checked ? celtaSemi : celtaUsed;
						total = txtPlaca.Text != "" ? placa + estadoCelta : estadoCelta;
						total /= 4;
						lblVPJ.Text = "4x de " + total.ToString("C");
					}

					if (rdbMar.Checked)
					{
						double estadoMar = rdbSemi.Checked ? (cbTurbo.Checked ? marSemTurbo : marSemi) : marUsed;
						total = txtPlaca.Text != "" ? placa + estadoMar : estadoMar;
						total /= 4;
						lblVPJ.Text = "4x de " + total.ToString("C");
					}

					if (rdbG3.Checked)
					{
						double estadoG3 = rdbNovo.Checked ? (cbTurbo.Checked ? g3NovoTur : g3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? g3SemiTur : g3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? g3UsedTur : g3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoG3 : estadoG3;
						total /= 4;
						lblVPJ.Text = "4x de " + total.ToString("C");
					}

					if (rdbA3.Checked)
					{
						double estadoA3 = rdbNovo.Checked ? (cbTurbo.Checked ? a3NovoTur : a3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? a3SemiTur : a3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? a3UsedTur : a3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoA3 : estadoA3;
						total /= 4;
						lblVPJ.Text = "4x de " + total.ToString("C");
					}
					break;

				case 3:
					if (rdbCelta.Checked)
					{
						double estadoCelta = rdbSemi.Checked ? celtaSemi : celtaUsed;
						total = txtPlaca.Text != "" ? placa + estadoCelta : estadoCelta;
						total /= 5;
						lblVPJ.Text = "5x de " + total.ToString("C");
					}

					if (rdbMar.Checked)
					{
						double estadoMar = rdbSemi.Checked ? (cbTurbo.Checked ? marSemTurbo : marSemi) : marUsed;
						total = txtPlaca.Text != "" ? placa + estadoMar : estadoMar;
						total /= 5;
						lblVPJ.Text = "5x de " + total.ToString("C");
					}

					if (rdbG3.Checked)
					{
						double estadoG3 = rdbNovo.Checked ? (cbTurbo.Checked ? g3NovoTur : g3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? g3SemiTur : g3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? g3UsedTur : g3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoG3 : estadoG3;
						total /= 5;
						lblVPJ.Text = "5x de " + total.ToString("C");
					}

					if (rdbA3.Checked)
					{
						double estadoA3 = rdbNovo.Checked ? (cbTurbo.Checked ? a3NovoTur : a3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? a3SemiTur : a3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? a3UsedTur : a3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoA3 : estadoA3;
						total /= 5;
						lblVPJ.Text = "5x de " + total.ToString("C");
					}
					break;

				case 4:
					if (rdbCelta.Checked)
					{
						double estadoCelta = rdbSemi.Checked ? celtaSemi : celtaUsed;
						total = txtPlaca.Text != "" ? placa + estadoCelta : estadoCelta;
						total /= 6;
						lblVPJ.Text = "6x de " + total.ToString("C");
					}

					if (rdbMar.Checked)
					{
						double estadoMar = rdbSemi.Checked ? (cbTurbo.Checked ? marSemTurbo : marSemi) : marUsed;
						total = txtPlaca.Text != "" ? placa + estadoMar : estadoMar;
						total /= 6;
						lblVPJ.Text = "6x de " + total.ToString("C");
					}

					if (rdbG3.Checked)
					{
						double estadoG3 = rdbNovo.Checked ? (cbTurbo.Checked ? g3NovoTur : g3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? g3SemiTur : g3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? g3UsedTur : g3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoG3 : estadoG3;
						total /= 6;
						lblVPJ.Text = "6x de " + total.ToString("C");
					}

					if (rdbA3.Checked)
					{
						double estadoA3 = rdbNovo.Checked ? (cbTurbo.Checked ? a3NovoTur : a3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? a3SemiTur : a3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? a3UsedTur : a3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoA3 : estadoA3;
						total /= 6;
						lblVPJ.Text = "6x de " + total.ToString("C");
					}
					break;

				case 5:
					if (rdbCelta.Checked)
					{
						double estadoCelta = rdbSemi.Checked ? celtaSemi : celtaUsed;
						total = txtPlaca.Text != "" ? placa + estadoCelta : estadoCelta;
						total /= 7;
						lblVPJ.Text = "7x de " + total.ToString("C");
					}

					if (rdbMar.Checked)
					{
						double estadoMar = rdbSemi.Checked ? (cbTurbo.Checked ? marSemTurbo : marSemi) : marUsed;
						total = txtPlaca.Text != "" ? placa + estadoMar : estadoMar;
						total /= 7;
						lblVPJ.Text = "7x de " + total.ToString("C");
					}

					if (rdbG3.Checked)
					{
						double estadoG3 = rdbNovo.Checked ? (cbTurbo.Checked ? g3NovoTur : g3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? g3SemiTur : g3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? g3UsedTur : g3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoG3 : estadoG3;
						total /= 7;
						lblVPJ.Text = "7x de " + total.ToString("C");
					}

					if (rdbA3.Checked)
					{
						double estadoA3 = rdbNovo.Checked ? (cbTurbo.Checked ? a3NovoTur : a3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? a3SemiTur : a3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? a3UsedTur : a3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoA3 : estadoA3;
						total /= 7;
						lblVPJ.Text = "7x de " + total.ToString("C");
					}
					break;

				case 6:
					if (rdbCelta.Checked)
					{
						double estadoCelta = rdbSemi.Checked ? celtaSemi : celtaUsed;
						total = txtPlaca.Text != "" ? placa + estadoCelta : estadoCelta;
						total /= 8;
						lblVPJ.Text = "8x de " + total.ToString("C");
					}

					if (rdbMar.Checked)
					{
						double estadoMar = rdbSemi.Checked ? (cbTurbo.Checked ? marSemTurbo : marSemi) : marUsed;
						total = txtPlaca.Text != "" ? placa + estadoMar : estadoMar;
						total /= 8;
						lblVPJ.Text = "8x de " + total.ToString("C");
					}

					if (rdbG3.Checked)
					{
						double estadoG3 = rdbNovo.Checked ? (cbTurbo.Checked ? g3NovoTur : g3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? g3SemiTur : g3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? g3UsedTur : g3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoG3 : estadoG3;
						total /= 8;
						lblVPJ.Text = "8x de " + total.ToString("C");
					}

					if (rdbA3.Checked)
					{
						double estadoA3 = rdbNovo.Checked ? (cbTurbo.Checked ? a3NovoTur : a3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? a3SemiTur : a3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? a3UsedTur : a3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoA3 : estadoA3;
						total /= 8;
						lblVPJ.Text = "8x de " + total.ToString("C");
					}
					break;

				case 7:
					if (rdbCelta.Checked)
					{
						double estadoCelta = rdbSemi.Checked ? celtaSemi : celtaUsed;
						total = txtPlaca.Text != "" ? placa + estadoCelta : estadoCelta;
						total /= 9;
						lblVPJ.Text = "9x de " + total.ToString("C");
					}

					if (rdbMar.Checked)
					{
						double estadoMar = rdbSemi.Checked ? (cbTurbo.Checked ? marSemTurbo : marSemi) : marUsed;
						total = txtPlaca.Text != "" ? placa + estadoMar : estadoMar;
						total /= 9;
						lblVPJ.Text = "9x de " + total.ToString("C");
					}

					if (rdbG3.Checked)
					{
						double estadoG3 = rdbNovo.Checked ? (cbTurbo.Checked ? g3NovoTur : g3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? g3SemiTur : g3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? g3UsedTur : g3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoG3 : estadoG3;
						total /= 9;
						lblVPJ.Text = "9x de " + total.ToString("C");
					}

					if (rdbA3.Checked)
					{
						double estadoA3 = rdbNovo.Checked ? (cbTurbo.Checked ? a3NovoTur : a3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? a3SemiTur : a3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? a3UsedTur : a3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoA3 : estadoA3;
						total /= 9;
						lblVPJ.Text = "9x de " + total.ToString("C");
					}
					break;

				case 8:
					if (rdbCelta.Checked)
					{
						double estadoCelta = rdbSemi.Checked ? celtaSemi : celtaUsed;
						total = txtPlaca.Text != "" ? placa + estadoCelta : estadoCelta;
						total /= 10;
						lblVPJ.Text = "10x de " + total.ToString("C");
					}

					if (rdbMar.Checked)
					{
						double estadoMar = rdbSemi.Checked ? (cbTurbo.Checked ? marSemTurbo : marSemi) : marUsed;
						total = txtPlaca.Text != "" ? placa + estadoMar : estadoMar;
						total /= 10;
						lblVPJ.Text = "10x de " + total.ToString("C");
					}

					if (rdbG3.Checked)
					{
						double estadoG3 = rdbNovo.Checked ? (cbTurbo.Checked ? g3NovoTur : g3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? g3SemiTur : g3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? g3UsedTur : g3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoG3 : estadoG3;
						total /= 10;
						lblVPJ.Text = "10x de " + total.ToString("C");
					}

					if (rdbA3.Checked)
					{
						double estadoA3 = rdbNovo.Checked ? (cbTurbo.Checked ? a3NovoTur : a3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? a3SemiTur : a3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? a3UsedTur : a3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoA3 : estadoA3;
						total /= 10;
						lblVPJ.Text = "10x de " + total.ToString("C");
					}
					break;

				case 9:
					if (rdbCelta.Checked)
					{
						double estadoCelta = rdbSemi.Checked ? celtaSemi : celtaUsed;
						total = txtPlaca.Text != "" ? placa + estadoCelta : estadoCelta;
						total /= 11;
						lblVPJ.Text = "11x de " + total.ToString("C");
					}

					if (rdbMar.Checked)
					{
						double estadoMar = rdbSemi.Checked ? (cbTurbo.Checked ? marSemTurbo : marSemi) : marUsed;
						total = txtPlaca.Text != "" ? placa + estadoMar : estadoMar;
						total /= 11;
						lblVPJ.Text = "11x de " + total.ToString("C");
					}

					if (rdbG3.Checked)
					{
						double estadoG3 = rdbNovo.Checked ? (cbTurbo.Checked ? g3NovoTur : g3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? g3SemiTur : g3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? g3UsedTur : g3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoG3 : estadoG3;
						total /= 11;
						lblVPJ.Text = "11x de " + total.ToString("C");
					}

					if (rdbA3.Checked)
					{
						double estadoA3 = rdbNovo.Checked ? (cbTurbo.Checked ? a3NovoTur : a3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? a3SemiTur : a3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? a3UsedTur : a3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoA3 : estadoA3;
						total /= 11;
						lblVPJ.Text = "11x de " + total.ToString("C");
					}
					break;

				case 10:
					if (rdbCelta.Checked)
					{
						double estadoCelta = rdbSemi.Checked ? celtaSemi : celtaUsed;
						total = txtPlaca.Text != "" ? placa + estadoCelta : estadoCelta;
						total /= 12;
						lblVPJ.Text = "12x de " + total.ToString("C");
					}

					if (rdbMar.Checked)
					{
						double estadoMar = rdbSemi.Checked ? (cbTurbo.Checked ? marSemTurbo : marSemi) : marUsed;
						total = txtPlaca.Text != "" ? placa + estadoMar : estadoMar;
						total /= 12;
						lblVPJ.Text = "12x de " + total.ToString("C");
					}

					if (rdbG3.Checked)
					{
						double estadoG3 = rdbNovo.Checked ? (cbTurbo.Checked ? g3NovoTur : g3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? g3SemiTur : g3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? g3UsedTur : g3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoG3 : estadoG3;
						total /= 12;
						lblVPJ.Text = "12x de " + total.ToString("C");
					}

					if (rdbA3.Checked)
					{
						double estadoA3 = rdbNovo.Checked ? (cbTurbo.Checked ? a3NovoTur : a3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? a3SemiTur : a3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? a3UsedTur : a3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoA3 : estadoA3;
						total /= 12;
						lblVPJ.Text = "12x de " + total.ToString("C");
					}
					break;

				case 11:

					if (rdbCelta.Checked)
					{
						double estadoCelta = rdbSemi.Checked ? celtaSemi : celtaUsed;
						total = txtPlaca.Text != "" ? placa + estadoCelta : estadoCelta;
						parcelaMensal = (total / 13);
						parcelaMensalJuros = parcelaMensal * 0.0485;
						parcelaTotal = parcelaMensal + parcelaMensalJuros;
						total = parcelaTotal * 13;
						lblParJur.Visible = true;
						lblVPJ.Text = "13x de " + parcelaTotal.ToString("C");
						lblJuros.Visible = true;
						lblValJur.Text = parcelaMensalJuros.ToString("C") + " ao mês.";
						lblValTotal.Visible = true;
						lblVtotal.Text = total.ToString("C");
						lblVistaDesc.Visible = false;

					}

					if (rdbMar.Checked)
					{
						double estadoMar = rdbSemi.Checked ? (cbTurbo.Checked ? marSemTurbo : marSemi) : marUsed;
						total = txtPlaca.Text != "" ? placa + estadoMar : estadoMar;

					}

					if (rdbG3.Checked)
					{
						double estadoG3 = rdbNovo.Checked ? (cbTurbo.Checked ? g3NovoTur : g3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? g3SemiTur : g3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? g3UsedTur : g3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoG3 : estadoG3;

					}
					if (rdbA3.Checked)
					{
						double estadoA3 = rdbNovo.Checked ? (cbTurbo.Checked ? a3NovoTur : a3Novo) : rdbSemi.Checked ? (cbTurbo.Checked ? a3SemiTur : a3Semi) : rdbUsed.Checked ? (cbTurbo.Checked ? a3UsedTur : a3Used) : 0;
						total = txtPlaca.Text != "" ? placa + estadoA3 : estadoA3;
					}
					break;
				case 12:

					break;

			}
		}
	}
}