namespace PDV
{
    partial class frmCaixa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            this.pctStatus = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnabrircaixa = new System.Windows.Forms.Button();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbooperador = new System.Windows.Forms.ComboBox();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltextodataehora = new System.Windows.Forms.Label();
            this.lbldataabertura = new System.Windows.Forms.Label();
            this.txtobservacao = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtvVenda = new System.Windows.Forms.DataGridView();
            this.pctcentral = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.grcentral = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnsaircaixa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.TimerCarregaDataGRid = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lblSaldoInicial = new System.Windows.Forms.Label();
            this.lblSaldoDinheiro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSaldoCredito = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSaldoDebito = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblmensagemsaida = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSaida = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblcaixa = new System.Windows.Forms.Label();
            this.lblidcaixa = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSangria = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lblsomentedinheiro = new System.Windows.Forms.Label();
            this.btnFechamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctcentral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.grcentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctStatus
            // 
            this.pctStatus.BackColor = System.Drawing.Color.White;
            this.pctStatus.Location = new System.Drawing.Point(12, 21);
            this.pctStatus.Name = "pctStatus";
            this.pctStatus.Size = new System.Drawing.Size(195, 50);
            this.pctStatus.TabIndex = 0;
            this.pctStatus.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox2.Location = new System.Drawing.Point(12, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 353);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnabrircaixa
            // 
            this.btnabrircaixa.Location = new System.Drawing.Point(24, 368);
            this.btnabrircaixa.Name = "btnabrircaixa";
            this.btnabrircaixa.Size = new System.Drawing.Size(167, 36);
            this.btnabrircaixa.TabIndex = 3;
            this.btnabrircaixa.Text = "&A - Abrir Caixa";
            this.btnabrircaixa.UseVisualStyleBackColor = true;
            this.btnabrircaixa.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(24, 117);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(167, 27);
            this.txtvalor.TabIndex = 0;
            this.txtvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Saldo Inicial (Dinheiro):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Operador:";
            // 
            // cbooperador
            // 
            this.cbooperador.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbooperador.FormattingEnabled = true;
            this.cbooperador.Location = new System.Drawing.Point(24, 179);
            this.cbooperador.Name = "cbooperador";
            this.cbooperador.Size = new System.Drawing.Size(167, 26);
            this.cbooperador.TabIndex = 500;
            // 
            // txtstatus
            // 
            this.txtstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtstatus.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstatus.Location = new System.Drawing.Point(24, 33);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(167, 19);
            this.txtstatus.TabIndex = 100;
            this.txtstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Observações";
            // 
            // lbltextodataehora
            // 
            this.lbltextodataehora.AutoSize = true;
            this.lbltextodataehora.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbltextodataehora.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextodataehora.ForeColor = System.Drawing.Color.White;
            this.lbltextodataehora.Location = new System.Drawing.Point(23, 320);
            this.lbltextodataehora.Name = "lbltextodataehora";
            this.lbltextodataehora.Size = new System.Drawing.Size(168, 13);
            this.lbltextodataehora.TabIndex = 15;
            this.lbltextodataehora.Text = "Data e hora de abertura:";
            // 
            // lbldataabertura
            // 
            this.lbldataabertura.AutoSize = true;
            this.lbldataabertura.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbldataabertura.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldataabertura.ForeColor = System.Drawing.Color.White;
            this.lbldataabertura.Location = new System.Drawing.Point(24, 337);
            this.lbldataabertura.Name = "lbldataabertura";
            this.lbldataabertura.Size = new System.Drawing.Size(19, 13);
            this.lbldataabertura.TabIndex = 16;
            this.lbldataabertura.Text = "...";
            // 
            // txtobservacao
            // 
            this.txtobservacao.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobservacao.Location = new System.Drawing.Point(24, 245);
            this.txtobservacao.Multiline = true;
            this.txtobservacao.Name = "txtobservacao";
            this.txtobservacao.ReadOnly = true;
            this.txtobservacao.Size = new System.Drawing.Size(167, 58);
            this.txtobservacao.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(197, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(875, 398);
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dtvVenda
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtvVenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtvVenda.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtvVenda.Location = new System.Drawing.Point(209, 66);
            this.dtvVenda.Name = "dtvVenda";
            this.dtvVenda.ReadOnly = true;
            this.dtvVenda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtvVenda.Size = new System.Drawing.Size(576, 338);
            this.dtvVenda.TabIndex = 103;
            this.dtvVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvVenda_CellContentClick);
            // 
            // pctcentral
            // 
            this.pctcentral.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pctcentral.Location = new System.Drawing.Point(293, 155);
            this.pctcentral.Name = "pctcentral";
            this.pctcentral.Size = new System.Drawing.Size(411, 133);
            this.pctcentral.TabIndex = 104;
            this.pctcentral.TabStop = false;
            this.pctcentral.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.LightPink;
            this.pictureBox4.Location = new System.Drawing.Point(788, 66);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(284, 338);
            this.pictureBox4.TabIndex = 105;
            this.pictureBox4.TabStop = false;
            // 
            // grcentral
            // 
            this.grcentral.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grcentral.Controls.Add(this.textBox1);
            this.grcentral.Controls.Add(this.btnsaircaixa);
            this.grcentral.Controls.Add(this.label4);
            this.grcentral.Controls.Add(this.lbl1);
            this.grcentral.Location = new System.Drawing.Point(304, 164);
            this.grcentral.Name = "grcentral";
            this.grcentral.Size = new System.Drawing.Size(388, 112);
            this.grcentral.TabIndex = 106;
            this.grcentral.TabStop = false;
            this.grcentral.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-34, -4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(470, 20);
            this.textBox1.TabIndex = 133;
            // 
            // btnsaircaixa
            // 
            this.btnsaircaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaircaixa.Location = new System.Drawing.Point(128, 78);
            this.btnsaircaixa.Name = "btnsaircaixa";
            this.btnsaircaixa.Size = new System.Drawing.Size(133, 23);
            this.btnsaircaixa.TabIndex = 109;
            this.btnsaircaixa.Text = "OK, Sair!";
            this.btnsaircaixa.UseVisualStyleBackColor = true;
            this.btnsaircaixa.Click += new System.EventHandler(this.btnsaircaixa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(1, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 13);
            this.label4.TabIndex = 108;
            this.label4.Text = "Consulte aqui, todas as entradas e saidas de valores do seu caixa";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl1.Location = new System.Drawing.Point(45, 16);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(285, 18);
            this.lbl1.TabIndex = 107;
            this.lbl1.Text = "Seu caixa foi aberto com sucesso!";
            // 
            // TimerCarregaDataGRid
            // 
            this.TimerCarregaDataGRid.Enabled = true;
            this.TimerCarregaDataGRid.Interval = 1000;
            this.TimerCarregaDataGRid.Tick += new System.EventHandler(this.TimerCarregaDataGRid_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightPink;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(793, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 108;
            this.label5.Text = "(+) SALDO INICIAL:";
            // 
            // lblSaldoInicial
            // 
            this.lblSaldoInicial.AutoSize = true;
            this.lblSaldoInicial.BackColor = System.Drawing.Color.LightPink;
            this.lblSaldoInicial.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoInicial.Location = new System.Drawing.Point(930, 76);
            this.lblSaldoInicial.Name = "lblSaldoInicial";
            this.lblSaldoInicial.Size = new System.Drawing.Size(35, 13);
            this.lblSaldoInicial.TabIndex = 109;
            this.lblSaldoInicial.Text = "0,00";
            // 
            // lblSaldoDinheiro
            // 
            this.lblSaldoDinheiro.AutoSize = true;
            this.lblSaldoDinheiro.BackColor = System.Drawing.Color.LightPink;
            this.lblSaldoDinheiro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoDinheiro.Location = new System.Drawing.Point(874, 146);
            this.lblSaldoDinheiro.Name = "lblSaldoDinheiro";
            this.lblSaldoDinheiro.Size = new System.Drawing.Size(35, 13);
            this.lblSaldoDinheiro.TabIndex = 111;
            this.lblSaldoDinheiro.Text = "0,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightPink;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(793, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 13);
            this.label7.TabIndex = 110;
            this.label7.Text = "(+) ENTRADAS DO CAIXA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightPink;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(807, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 112;
            this.label8.Text = "VENDAS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightPink;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(808, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 113;
            this.label9.Text = "Dinheiro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightPink;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(808, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 115;
            this.label6.Text = "Cartão de crédito:";
            // 
            // lblSaldoCredito
            // 
            this.lblSaldoCredito.AutoSize = true;
            this.lblSaldoCredito.BackColor = System.Drawing.Color.LightPink;
            this.lblSaldoCredito.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoCredito.Location = new System.Drawing.Point(933, 163);
            this.lblSaldoCredito.Name = "lblSaldoCredito";
            this.lblSaldoCredito.Size = new System.Drawing.Size(35, 13);
            this.lblSaldoCredito.TabIndex = 114;
            this.lblSaldoCredito.Text = "0,00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightPink;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(808, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 13);
            this.label11.TabIndex = 117;
            this.label11.Text = "Cartão de débito:";
            // 
            // lblSaldoDebito
            // 
            this.lblSaldoDebito.AutoSize = true;
            this.lblSaldoDebito.BackColor = System.Drawing.Color.LightPink;
            this.lblSaldoDebito.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoDebito.Location = new System.Drawing.Point(933, 181);
            this.lblSaldoDebito.Name = "lblSaldoDebito";
            this.lblSaldoDebito.Size = new System.Drawing.Size(35, 13);
            this.lblSaldoDebito.TabIndex = 116;
            this.lblSaldoDebito.Text = "0,00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightPink;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(793, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 13);
            this.label10.TabIndex = 118;
            this.label10.Text = "(-) SAIDAS DO CAIXA";
            // 
            // lblmensagemsaida
            // 
            this.lblmensagemsaida.AutoSize = true;
            this.lblmensagemsaida.BackColor = System.Drawing.Color.LightPink;
            this.lblmensagemsaida.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensagemsaida.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblmensagemsaida.Location = new System.Drawing.Point(807, 242);
            this.lblmensagemsaida.Name = "lblmensagemsaida";
            this.lblmensagemsaida.Size = new System.Drawing.Size(198, 13);
            this.lblmensagemsaida.TabIndex = 119;
            this.lblmensagemsaida.Text = "NÃO HÁ REGISTROS DE SAÍDA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LightPink;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(807, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 121;
            this.label13.Text = "Dinheiro:";
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.BackColor = System.Drawing.Color.LightPink;
            this.lblSaida.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaida.Location = new System.Drawing.Point(873, 263);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(35, 13);
            this.lblSaida.TabIndex = 120;
            this.lblSaida.Text = "0,00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LightPink;
            this.label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(793, 303);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 13);
            this.label15.TabIndex = 122;
            this.label15.Text = "(=) SALDO FINAL";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.LightPink;
            this.label16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(808, 327);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 124;
            this.label16.Text = "Valor Total:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.BackColor = System.Drawing.Color.LightPink;
            this.lblValorTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(890, 327);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(35, 13);
            this.lblValorTotal.TabIndex = 123;
            this.lblValorTotal.Text = "0,00";
            // 
            // lblcaixa
            // 
            this.lblcaixa.AutoSize = true;
            this.lblcaixa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblcaixa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaixa.Location = new System.Drawing.Point(213, 37);
            this.lblcaixa.Name = "lblcaixa";
            this.lblcaixa.Size = new System.Drawing.Size(66, 13);
            this.lblcaixa.TabIndex = 125;
            this.lblcaixa.Text = "ID Caixa:";
            this.lblcaixa.Visible = false;
            // 
            // lblidcaixa
            // 
            this.lblidcaixa.AutoSize = true;
            this.lblidcaixa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblidcaixa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidcaixa.Location = new System.Drawing.Point(278, 37);
            this.lblidcaixa.Name = "lblidcaixa";
            this.lblidcaixa.Size = new System.Drawing.Size(19, 13);
            this.lblidcaixa.TabIndex = 126;
            this.lblidcaixa.Text = "...";
            this.lblidcaixa.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(1031, 26);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 36);
            this.btnSair.TabIndex = 127;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSangria
            // 
            this.btnSangria.Enabled = false;
            this.btnSangria.Location = new System.Drawing.Point(547, 26);
            this.btnSangria.Name = "btnSangria";
            this.btnSangria.Size = new System.Drawing.Size(238, 36);
            this.btnSangria.TabIndex = 128;
            this.btnSangria.Text = "&S - Sangria";
            this.btnSangria.UseVisualStyleBackColor = true;
            this.btnSangria.Click += new System.EventHandler(this.btnSangria_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightPink;
            this.label14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(808, 349);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 13);
            this.label14.TabIndex = 130;
            this.label14.Text = "Somente Dinheiro:";
            // 
            // lblsomentedinheiro
            // 
            this.lblsomentedinheiro.AutoSize = true;
            this.lblsomentedinheiro.BackColor = System.Drawing.Color.LightPink;
            this.lblsomentedinheiro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsomentedinheiro.Location = new System.Drawing.Point(937, 349);
            this.lblsomentedinheiro.Name = "lblsomentedinheiro";
            this.lblsomentedinheiro.Size = new System.Drawing.Size(35, 13);
            this.lblsomentedinheiro.TabIndex = 129;
            this.lblsomentedinheiro.Text = "0,00";
            // 
            // btnFechamento
            // 
            this.btnFechamento.Enabled = false;
            this.btnFechamento.Location = new System.Drawing.Point(789, 26);
            this.btnFechamento.Name = "btnFechamento";
            this.btnFechamento.Size = new System.Drawing.Size(238, 36);
            this.btnFechamento.TabIndex = 131;
            this.btnFechamento.Text = "&F - Fechar Caixa";
            this.btnFechamento.UseVisualStyleBackColor = true;
            this.btnFechamento.Click += new System.EventHandler(this.btnFechamento_Click);
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.btnFechamento);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblsomentedinheiro);
            this.Controls.Add(this.btnSangria);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblidcaixa);
            this.Controls.Add(this.lblcaixa);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.lblmensagemsaida);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblSaldoDebito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSaldoCredito);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSaldoDinheiro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSaldoInicial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grcentral);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pctcentral);
            this.Controls.Add(this.txtobservacao);
            this.Controls.Add(this.lbldataabertura);
            this.Controls.Add(this.lbltextodataehora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.cbooperador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.btnabrircaixa);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pctStatus);
            this.Controls.Add(this.dtvVenda);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentação do caixa || VTEX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Caixa_FormClosing);
            this.Load += new System.EventHandler(this.Caixa_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmCaixa_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pctStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctcentral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.grcentral.ResumeLayout(false);
            this.grcentral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctStatus;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnabrircaixa;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbooperador;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltextodataehora;
        private System.Windows.Forms.Label lbldataabertura;
        private System.Windows.Forms.TextBox txtobservacao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtvVenda;
        private System.Windows.Forms.PictureBox pctcentral;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox grcentral;
        private System.Windows.Forms.Button btnsaircaixa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Timer TimerCarregaDataGRid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSaldoInicial;
        private System.Windows.Forms.Label lblSaldoDinheiro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSaldoCredito;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSaldoDebito;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblmensagemsaida;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblcaixa;
        private System.Windows.Forms.Label lblidcaixa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSangria;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblsomentedinheiro;
        private System.Windows.Forms.Button btnFechamento;
        private System.Windows.Forms.TextBox textBox1;
    }
}