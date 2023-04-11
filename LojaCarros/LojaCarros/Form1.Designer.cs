namespace LojaCarros
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			pictureBox4 = new PictureBox();
			gpbModel = new GroupBox();
			btnReset = new Button();
			btnPag = new Button();
			txtPlaca = new TextBox();
			cbPer = new CheckBox();
			rdbUsed = new RadioButton();
			rdbSemi = new RadioButton();
			rdbNovo = new RadioButton();
			cbTurbo = new CheckBox();
			cbbCor = new ComboBox();
			rdbCelta = new RadioButton();
			rdbMar = new RadioButton();
			rdbG3 = new RadioButton();
			rdbA3 = new RadioButton();
			gpbPag = new GroupBox();
			lblVistaDesc = new Label();
			lblVtotal = new Label();
			lblValTotal = new Label();
			lblValJur = new Label();
			lblJuros = new Label();
			btnAlt = new Button();
			btnComprar = new Button();
			lblFPag = new Label();
			cbbForPag = new ComboBox();
			lblJur = new Label();
			rdbFin = new RadioButton();
			rdbVista = new RadioButton();
			cbbParcela = new ComboBox();
			lblVPJ = new Label();
			lblParJur = new Label();
			btnSair = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			gpbModel.SuspendLayout();
			gpbPag.SuspendLayout();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.celta;
			pictureBox1.Location = new Point(86, 28);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(173, 149);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.marea;
			pictureBox2.Location = new Point(265, 28);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(175, 149);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = Properties.Resources.g3;
			pictureBox3.Location = new Point(446, 28);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(219, 149);
			pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 2;
			pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = Properties.Resources.a3;
			pictureBox4.Location = new Point(671, 28);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(190, 149);
			pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox4.TabIndex = 3;
			pictureBox4.TabStop = false;
			// 
			// gpbModel
			// 
			gpbModel.Controls.Add(btnReset);
			gpbModel.Controls.Add(btnPag);
			gpbModel.Controls.Add(txtPlaca);
			gpbModel.Controls.Add(cbPer);
			gpbModel.Controls.Add(rdbUsed);
			gpbModel.Controls.Add(rdbSemi);
			gpbModel.Controls.Add(rdbNovo);
			gpbModel.Controls.Add(cbTurbo);
			gpbModel.Controls.Add(cbbCor);
			gpbModel.Enabled = false;
			gpbModel.Location = new Point(48, 256);
			gpbModel.Name = "gpbModel";
			gpbModel.Size = new Size(431, 182);
			gpbModel.TabIndex = 4;
			gpbModel.TabStop = false;
			gpbModel.Text = "Modelo";
			// 
			// btnReset
			// 
			btnReset.Location = new Point(303, 153);
			btnReset.Name = "btnReset";
			btnReset.Size = new Size(58, 23);
			btnReset.TabIndex = 8;
			btnReset.Text = "Limpar";
			btnReset.UseVisualStyleBackColor = true;
			btnReset.Click += btnReset_Click;
			// 
			// btnPag
			// 
			btnPag.Location = new Point(367, 153);
			btnPag.Name = "btnPag";
			btnPag.Size = new Size(58, 23);
			btnPag.TabIndex = 7;
			btnPag.Text = "Pagar";
			btnPag.UseVisualStyleBackColor = true;
			btnPag.Click += btnPag_Click;
			// 
			// txtPlaca
			// 
			txtPlaca.Enabled = false;
			txtPlaca.Location = new Point(18, 151);
			txtPlaca.Name = "txtPlaca";
			txtPlaca.Size = new Size(129, 23);
			txtPlaca.TabIndex = 6;
			// 
			// cbPer
			// 
			cbPer.AutoSize = true;
			cbPer.Location = new Point(18, 126);
			cbPer.Name = "cbPer";
			cbPer.Size = new Size(129, 19);
			cbPer.TabIndex = 5;
			cbPer.Text = "Placa personalizada";
			cbPer.UseVisualStyleBackColor = true;
			cbPer.CheckedChanged += cbPer_CheckedChanged;
			// 
			// rdbUsed
			// 
			rdbUsed.AutoSize = true;
			rdbUsed.Location = new Point(172, 76);
			rdbUsed.Name = "rdbUsed";
			rdbUsed.Size = new Size(58, 19);
			rdbUsed.TabIndex = 4;
			rdbUsed.TabStop = true;
			rdbUsed.Text = "Usado";
			rdbUsed.UseVisualStyleBackColor = true;
			rdbUsed.CheckedChanged += rdbUsed_CheckedChanged;
			// 
			// rdbSemi
			// 
			rdbSemi.AutoSize = true;
			rdbSemi.Location = new Point(77, 76);
			rdbSemi.Name = "rdbSemi";
			rdbSemi.Size = new Size(85, 19);
			rdbSemi.TabIndex = 3;
			rdbSemi.TabStop = true;
			rdbSemi.Text = "Semi-Novo";
			rdbSemi.UseVisualStyleBackColor = true;
			rdbSemi.CheckedChanged += rdbSemi_CheckedChanged;
			// 
			// rdbNovo
			// 
			rdbNovo.AutoSize = true;
			rdbNovo.Location = new Point(12, 76);
			rdbNovo.Name = "rdbNovo";
			rdbNovo.Size = new Size(54, 19);
			rdbNovo.TabIndex = 2;
			rdbNovo.TabStop = true;
			rdbNovo.Text = "Novo";
			rdbNovo.UseVisualStyleBackColor = true;
			// 
			// cbTurbo
			// 
			cbTurbo.AutoSize = true;
			cbTurbo.Location = new Point(12, 51);
			cbTurbo.Name = "cbTurbo";
			cbTurbo.Size = new Size(57, 19);
			cbTurbo.TabIndex = 1;
			cbTurbo.Text = "Turbo";
			cbTurbo.UseVisualStyleBackColor = true;
			// 
			// cbbCor
			// 
			cbbCor.FormattingEnabled = true;
			cbbCor.Items.AddRange(new object[] { "Prata", "Preto", "Branco", "Azul", "Vermelho" });
			cbbCor.Location = new Point(12, 22);
			cbbCor.Name = "cbbCor";
			cbbCor.Size = new Size(103, 23);
			cbbCor.TabIndex = 0;
			cbbCor.Text = "Escolha a cor...";
			// 
			// rdbCelta
			// 
			rdbCelta.AutoSize = true;
			rdbCelta.Location = new Point(142, 183);
			rdbCelta.Name = "rdbCelta";
			rdbCelta.Size = new Size(52, 19);
			rdbCelta.TabIndex = 5;
			rdbCelta.Text = "Celta";
			rdbCelta.UseVisualStyleBackColor = true;
			rdbCelta.CheckedChanged += rdbCelta_CheckedChanged;
			// 
			// rdbMar
			// 
			rdbMar.AutoSize = true;
			rdbMar.Location = new Point(325, 183);
			rdbMar.Name = "rdbMar";
			rdbMar.Size = new Size(58, 19);
			rdbMar.TabIndex = 6;
			rdbMar.Text = "Marea";
			rdbMar.UseVisualStyleBackColor = true;
			rdbMar.CheckedChanged += rdbMar_CheckedChanged;
			// 
			// rdbG3
			// 
			rdbG3.AutoSize = true;
			rdbG3.Location = new Point(538, 183);
			rdbG3.Name = "rdbG3";
			rdbG3.Size = new Size(39, 19);
			rdbG3.TabIndex = 7;
			rdbG3.Text = "G3";
			rdbG3.UseVisualStyleBackColor = true;
			rdbG3.CheckedChanged += rdbG3_CheckedChanged;
			// 
			// rdbA3
			// 
			rdbA3.AutoSize = true;
			rdbA3.Location = new Point(744, 183);
			rdbA3.Name = "rdbA3";
			rdbA3.Size = new Size(39, 19);
			rdbA3.TabIndex = 8;
			rdbA3.Text = "A3";
			rdbA3.UseVisualStyleBackColor = true;
			rdbA3.CheckedChanged += rdbA3_CheckedChanged;
			// 
			// gpbPag
			// 
			gpbPag.Controls.Add(lblVistaDesc);
			gpbPag.Controls.Add(lblVtotal);
			gpbPag.Controls.Add(lblValTotal);
			gpbPag.Controls.Add(lblValJur);
			gpbPag.Controls.Add(lblJuros);
			gpbPag.Controls.Add(btnAlt);
			gpbPag.Controls.Add(btnComprar);
			gpbPag.Controls.Add(lblFPag);
			gpbPag.Controls.Add(cbbForPag);
			gpbPag.Controls.Add(lblJur);
			gpbPag.Controls.Add(rdbFin);
			gpbPag.Controls.Add(rdbVista);
			gpbPag.Controls.Add(cbbParcela);
			gpbPag.Controls.Add(lblVPJ);
			gpbPag.Controls.Add(lblParJur);
			gpbPag.Enabled = false;
			gpbPag.Location = new Point(485, 256);
			gpbPag.Name = "gpbPag";
			gpbPag.Size = new Size(417, 182);
			gpbPag.TabIndex = 9;
			gpbPag.TabStop = false;
			gpbPag.Text = "Pagamento";
			// 
			// lblVistaDesc
			// 
			lblVistaDesc.AutoSize = true;
			lblVistaDesc.Location = new Point(15, 140);
			lblVistaDesc.Name = "lblVistaDesc";
			lblVistaDesc.Size = new Size(102, 15);
			lblVistaDesc.TabIndex = 14;
			lblVistaDesc.Text = "Valor do desconto";
			lblVistaDesc.Visible = false;
			// 
			// lblVtotal
			// 
			lblVtotal.AutoSize = true;
			lblVtotal.Location = new Point(124, 159);
			lblVtotal.Name = "lblVtotal";
			lblVtotal.Size = new Size(0, 15);
			lblVtotal.TabIndex = 13;
			// 
			// lblValTotal
			// 
			lblValTotal.AutoSize = true;
			lblValTotal.Location = new Point(15, 159);
			lblValTotal.Name = "lblValTotal";
			lblValTotal.Size = new Size(63, 15);
			lblValTotal.TabIndex = 12;
			lblValTotal.Text = "Valor total:";
			lblValTotal.Visible = false;
			// 
			// lblValJur
			// 
			lblValJur.AutoSize = true;
			lblValJur.Location = new Point(124, 140);
			lblValJur.Name = "lblValJur";
			lblValJur.Size = new Size(0, 15);
			lblValJur.TabIndex = 11;
			// 
			// lblJuros
			// 
			lblJuros.AutoSize = true;
			lblJuros.Location = new Point(15, 140);
			lblJuros.Name = "lblJuros";
			lblJuros.Size = new Size(37, 15);
			lblJuros.TabIndex = 10;
			lblJuros.Text = "Juros:";
			lblJuros.Visible = false;
			// 
			// btnAlt
			// 
			btnAlt.Location = new Point(259, 153);
			btnAlt.Name = "btnAlt";
			btnAlt.Size = new Size(75, 23);
			btnAlt.TabIndex = 9;
			btnAlt.Text = "Alterar";
			btnAlt.UseVisualStyleBackColor = true;
			btnAlt.Click += btnAlt_Click;
			// 
			// btnComprar
			// 
			btnComprar.Location = new Point(336, 153);
			btnComprar.Name = "btnComprar";
			btnComprar.Size = new Size(75, 23);
			btnComprar.TabIndex = 8;
			btnComprar.Text = "Comprar";
			btnComprar.UseVisualStyleBackColor = true;
			// 
			// lblFPag
			// 
			lblFPag.AutoSize = true;
			lblFPag.Location = new Point(15, 72);
			lblFPag.Name = "lblFPag";
			lblFPag.Size = new Size(124, 15);
			lblFPag.TabIndex = 7;
			lblFPag.Text = "Forma de pagamento:";
			lblFPag.Visible = false;
			// 
			// cbbForPag
			// 
			cbbForPag.FormattingEnabled = true;
			cbbForPag.Items.AddRange(new object[] { "Débito", "Boleto", "Dinheiro", "Crédito 1x" });
			cbbForPag.Location = new Point(15, 90);
			cbbForPag.Name = "cbbForPag";
			cbbForPag.Size = new Size(77, 23);
			cbbForPag.TabIndex = 6;
			cbbForPag.Text = "Escolha...";
			cbbForPag.Visible = false;
			cbbForPag.SelectedIndexChanged += cbbForPag_SelectedIndexChanged;
			// 
			// lblJur
			// 
			lblJur.AutoSize = true;
			lblJur.Location = new Point(15, 72);
			lblJur.Name = "lblJur";
			lblJur.Size = new Size(100, 15);
			lblJur.TabIndex = 5;
			lblJur.Text = "Até 12x sem juros";
			lblJur.Visible = false;
			// 
			// rdbFin
			// 
			rdbFin.AutoSize = true;
			rdbFin.Location = new Point(15, 47);
			rdbFin.Name = "rdbFin";
			rdbFin.Size = new Size(77, 19);
			rdbFin.TabIndex = 4;
			rdbFin.TabStop = true;
			rdbFin.Text = "Parcelado";
			rdbFin.UseVisualStyleBackColor = true;
			rdbFin.CheckedChanged += rdbFin_CheckedChanged;
			// 
			// rdbVista
			// 
			rdbVista.AutoSize = true;
			rdbVista.Location = new Point(15, 22);
			rdbVista.Name = "rdbVista";
			rdbVista.Size = new Size(60, 19);
			rdbVista.TabIndex = 3;
			rdbVista.TabStop = true;
			rdbVista.Text = "À vista";
			rdbVista.UseVisualStyleBackColor = true;
			rdbVista.CheckedChanged += rdbVista_CheckedChanged;
			// 
			// cbbParcela
			// 
			cbbParcela.FormattingEnabled = true;
			cbbParcela.Items.AddRange(new object[] { "2x", "3x", "4x", "5x", "6x", "7x", "8x", "9x", "10x", "11x", "12x", "13x Taxa mensal 4,85%", "14x Taxa mensal 4,24%", "15x Taxa mensal 4,00%", "16x Taxa mensal 3,82%", "17x Taxa mensal 3,72%", "18x Taxa mensal 3,33%", "19x Taxa mensal 3,25%", "20x Taxa mensal 3,20%", "21x Taxa mensal 3,02%", "22x Taxa mensal 2,98%", "23x Taxa mensal 2,92%", "24x Taxa mensal 2,90%" });
			cbbParcela.Location = new Point(15, 90);
			cbbParcela.Name = "cbbParcela";
			cbbParcela.Size = new Size(131, 23);
			cbbParcela.TabIndex = 2;
			cbbParcela.Text = "Escolha as parcelas...";
			cbbParcela.Visible = false;
			cbbParcela.SelectedIndexChanged += cbbParcela_SelectedIndexChanged;
			// 
			// lblVPJ
			// 
			lblVPJ.AutoSize = true;
			lblVPJ.Location = new Point(124, 124);
			lblVPJ.Name = "lblVPJ";
			lblVPJ.Size = new Size(0, 15);
			lblVPJ.TabIndex = 1;
			// 
			// lblParJur
			// 
			lblParJur.AutoSize = true;
			lblParJur.Location = new Point(15, 121);
			lblParJur.Name = "lblParJur";
			lblParJur.Size = new Size(91, 15);
			lblParJur.TabIndex = 0;
			lblParJur.Text = "Parcela c/ juros:";
			lblParJur.Visible = false;
			// 
			// btnSair
			// 
			btnSair.Location = new Point(909, 409);
			btnSair.Name = "btnSair";
			btnSair.Size = new Size(75, 23);
			btnSair.TabIndex = 10;
			btnSair.Text = "Sair";
			btnSair.UseVisualStyleBackColor = true;
			btnSair.Click += btnSair_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(996, 442);
			Controls.Add(btnSair);
			Controls.Add(gpbPag);
			Controls.Add(rdbA3);
			Controls.Add(rdbG3);
			Controls.Add(rdbMar);
			Controls.Add(rdbCelta);
			Controls.Add(gpbModel);
			Controls.Add(pictureBox4);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			gpbModel.ResumeLayout(false);
			gpbModel.PerformLayout();
			gpbPag.ResumeLayout(false);
			gpbPag.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private PictureBox pictureBox4;
		private GroupBox gpbModel;
		private TextBox txtPlaca;
		private CheckBox cbPer;
		private RadioButton rdbUsed;
		private RadioButton rdbSemi;
		private RadioButton rdbNovo;
		private CheckBox cbTurbo;
		private ComboBox cbbCor;
		private RadioButton rdbCelta;
		private RadioButton rdbMar;
		private RadioButton rdbG3;
		private RadioButton rdbA3;
		private GroupBox gpbPag;
		private Label lblVPJ;
		private Label lblParJur;
		private Button btnReset;
		private Button btnPag;
		private ComboBox cbbParcela;
		private RadioButton rdbFin;
		private RadioButton rdbVista;
		private Button btnSair;
		private Label lblJur;
		private Label lblFPag;
		private ComboBox cbbForPag;
		private Button btnComprar;
		private Button btnAlt;
		private Label lblValJur;
		private Label lblJuros;
		private Label lblVtotal;
		private Label lblValTotal;
		private Label lblVistaDesc;
	}
}