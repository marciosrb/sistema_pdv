namespace PDV
{
    partial class frmVendas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codPropLabel;
            System.Windows.Forms.Label valorProdutoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            this.dtvVenda = new System.Windows.Forms.DataGridView();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.lblnumcupom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsepara = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblservidor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timerpingservidor = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lbltef = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.timedata = new System.Windows.Forms.Timer(this.components);
            this.txtmskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpdv = new System.Windows.Forms.TextBox();
            this.lblcliente = new System.Windows.Forms.Label();
            this.txtmensagem = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.txtdinheiro = new System.Windows.Forms.TextBox();
            this.txtdebito = new System.Windows.Forms.TextBox();
            this.txtcredito = new System.Windows.Forms.TextBox();
            this.txttroco = new System.Windows.Forms.TextBox();
            this.txtOutros = new System.Windows.Forms.TextBox();
            this.lblValoresRecebidos = new System.Windows.Forms.Label();
            this.lblDinheiroRecebido = new System.Windows.Forms.Label();
            this.lblCreditoRecebido = new System.Windows.Forms.Label();
            this.lbldebitoRecebido = new System.Windows.Forms.Label();
            this.lblOutrosRecebido = new System.Windows.Forms.Label();
            this.lblTrocoRecebido = new System.Windows.Forms.Label();
            this.PainelMenu = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            codPropLabel = new System.Windows.Forms.Label();
            valorProdutoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvVenda)).BeginInit();
            this.PainelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // codPropLabel
            // 
            codPropLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            codPropLabel.AutoSize = true;
            codPropLabel.BackColor = System.Drawing.Color.Transparent;
            codPropLabel.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            codPropLabel.ForeColor = System.Drawing.Color.White;
            codPropLabel.Location = new System.Drawing.Point(5, 85);
            codPropLabel.Name = "codPropLabel";
            codPropLabel.Size = new System.Drawing.Size(96, 15);
            codPropLabel.TabIndex = 51;
            codPropLabel.Text = "Código do Produto";
            // 
            // valorProdutoLabel
            // 
            valorProdutoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            valorProdutoLabel.AutoSize = true;
            valorProdutoLabel.BackColor = System.Drawing.Color.Transparent;
            valorProdutoLabel.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            valorProdutoLabel.ForeColor = System.Drawing.Color.White;
            valorProdutoLabel.Location = new System.Drawing.Point(5, 200);
            valorProdutoLabel.Name = "valorProdutoLabel";
            valorProdutoLabel.Size = new System.Drawing.Size(96, 15);
            valorProdutoLabel.TabIndex = 49;
            valorProdutoLabel.Text = "Preço Unitário / KG";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.BackColor = System.Drawing.Color.Transparent;
            quantidadeLabel.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            quantidadeLabel.ForeColor = System.Drawing.Color.White;
            quantidadeLabel.Location = new System.Drawing.Point(5, 142);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(59, 15);
            quantidadeLabel.TabIndex = 50;
            quantidadeLabel.Text = "Quantidade";
            // 
            // dtvVenda
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dtvVenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtvVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvVenda.BackgroundColor = System.Drawing.Color.White;
            this.dtvVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvVenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtvVenda.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtvVenda.Location = new System.Drawing.Point(915, 178);
            this.dtvVenda.Name = "dtvVenda";
            this.dtvVenda.ReadOnly = true;
            this.dtvVenda.RowHeadersVisible = false;
            this.dtvVenda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtvVenda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtvVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvVenda.Size = new System.Drawing.Size(432, 337);
            this.dtvVenda.TabIndex = 100;
            this.dtvVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvVenda_CellContentClick);
            this.dtvVenda.SelectionChanged += new System.EventHandler(this.dtvVenda_SelectionChanged);
            this.dtvVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtvVenda_KeyDown);
            this.dtvVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtvVenda_KeyPress);
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPreco.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(7, 220);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(196, 32);
            this.txtPreco.TabIndex = 47;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            // 
            // txtQuant
            // 
            this.txtQuant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtQuant.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuant.Location = new System.Drawing.Point(7, 162);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(196, 32);
            this.txtQuant.TabIndex = 52;
            this.txtQuant.Text = "1,000";
            // 
            // txtCod
            // 
            this.txtCod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCod.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(7, 104);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(196, 32);
            this.txtCod.TabIndex = 0;
            this.txtCod.Click += new System.EventHandler(this.txtCod_Click);
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_KeyPress);
            this.txtCod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCod_KeyUp);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Maroon;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtNome.Location = new System.Drawing.Point(318, 83);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(996, 59);
            this.txtNome.TabIndex = 56;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorVenda.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorVenda.ForeColor = System.Drawing.Color.Maroon;
            this.txtValorVenda.Location = new System.Drawing.Point(590, 210);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(296, 59);
            this.txtValorVenda.TabIndex = 59;
            this.txtValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblnumcupom
            // 
            this.lblnumcupom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblnumcupom.AutoSize = true;
            this.lblnumcupom.BackColor = System.Drawing.Color.Transparent;
            this.lblnumcupom.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblnumcupom.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblnumcupom.Location = new System.Drawing.Point(104, 725);
            this.lblnumcupom.Name = "lblnumcupom";
            this.lblnumcupom.Size = new System.Drawing.Size(118, 18);
            this.lblnumcupom.TabIndex = 63;
            this.lblnumcupom.Text = "Carregando...";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 725);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 103;
            this.label1.Text = "Nº Cupom:";
            // 
            // lblsepara
            // 
            this.lblsepara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblsepara.AutoSize = true;
            this.lblsepara.BackColor = System.Drawing.Color.Transparent;
            this.lblsepara.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsepara.ForeColor = System.Drawing.Color.White;
            this.lblsepara.Location = new System.Drawing.Point(226, 724);
            this.lblsepara.Name = "lblsepara";
            this.lblsepara.Size = new System.Drawing.Size(24, 18);
            this.lblsepara.TabIndex = 104;
            this.lblsepara.Text = "||";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(256, 724);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 106;
            this.label2.Text = "Operador:";
            // 
            // lblOperador
            // 
            this.lblOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOperador.AutoSize = true;
            this.lblOperador.BackColor = System.Drawing.Color.Transparent;
            this.lblOperador.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblOperador.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblOperador.Location = new System.Drawing.Point(347, 724);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(118, 18);
            this.lblOperador.TabIndex = 105;
            this.lblOperador.Text = "Carregando...";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(548, 724);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 109;
            this.label3.Text = "Servidor:";
            // 
            // lblservidor
            // 
            this.lblservidor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblservidor.AutoSize = true;
            this.lblservidor.BackColor = System.Drawing.Color.Transparent;
            this.lblservidor.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblservidor.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblservidor.Location = new System.Drawing.Point(630, 724);
            this.lblservidor.Name = "lblservidor";
            this.lblservidor.Size = new System.Drawing.Size(118, 18);
            this.lblservidor.TabIndex = 108;
            this.lblservidor.Text = "Carregando...";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(518, 724);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 18);
            this.label5.TabIndex = 107;
            this.label5.Text = "||";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(9, 699);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 111;
            this.label6.Text = "CPF/CNPJ:";
            // 
            // timerpingservidor
            // 
            this.timerpingservidor.Enabled = true;
            this.timerpingservidor.Interval = 1000;
            this.timerpingservidor.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(773, 724);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 114;
            this.label4.Text = "TEF:";
            // 
            // lbltef
            // 
            this.lbltef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltef.AutoSize = true;
            this.lbltef.BackColor = System.Drawing.Color.Transparent;
            this.lbltef.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbltef.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbltef.Location = new System.Drawing.Point(816, 724);
            this.lbltef.Name = "lbltef";
            this.lbltef.Size = new System.Drawing.Size(118, 18);
            this.lbltef.TabIndex = 113;
            this.lbltef.Text = "Carregando...";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(743, 724);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 18);
            this.label9.TabIndex = 112;
            this.label9.Text = "||";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1095, 722);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 116;
            this.label8.Text = "Data:";
            // 
            // lbldata
            // 
            this.lbldata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldata.AutoSize = true;
            this.lbldata.BackColor = System.Drawing.Color.Transparent;
            this.lbldata.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbldata.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbldata.Location = new System.Drawing.Point(1148, 722);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(118, 18);
            this.lbldata.TabIndex = 115;
            this.lbldata.Text = "Carregando...";
            // 
            // timedata
            // 
            this.timedata.Interval = 1000;
            this.timedata.Tick += new System.EventHandler(this.timedata_Tick);
            // 
            // txtmskCPF
            // 
            this.txtmskCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtmskCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmskCPF.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtmskCPF.Location = new System.Drawing.Point(111, 698);
            this.txtmskCPF.Name = "txtmskCPF";
            this.txtmskCPF.ReadOnly = true;
            this.txtmskCPF.Size = new System.Drawing.Size(185, 19);
            this.txtmskCPF.TabIndex = 118;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 120;
            this.label7.Text = "CAIXA";
            // 
            // txtpdv
            // 
            this.txtpdv.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtpdv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpdv.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpdv.ForeColor = System.Drawing.Color.Red;
            this.txtpdv.Location = new System.Drawing.Point(14, 31);
            this.txtpdv.Name = "txtpdv";
            this.txtpdv.Size = new System.Drawing.Size(62, 24);
            this.txtpdv.TabIndex = 121;
            this.txtpdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpdv.TextChanged += new System.EventHandler(this.txtpdv_TextChanged);
            // 
            // lblcliente
            // 
            this.lblcliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblcliente.AutoSize = true;
            this.lblcliente.BackColor = System.Drawing.Color.Transparent;
            this.lblcliente.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblcliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcliente.Location = new System.Drawing.Point(302, 698);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(0, 18);
            this.lblcliente.TabIndex = 122;
            // 
            // txtmensagem
            // 
            this.txtmensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmensagem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.txtmensagem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtmensagem.Location = new System.Drawing.Point(739, 558);
            this.txtmensagem.Name = "txtmensagem";
            this.txtmensagem.Size = new System.Drawing.Size(608, 24);
            this.txtmensagem.TabIndex = 123;
            this.txtmensagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Location = new System.Drawing.Point(1135, 259);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(58, 55);
            this.btnSair.TabIndex = 125;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPagamento
            // 
            this.btnPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagamento.BackColor = System.Drawing.Color.Maroon;
            this.btnPagamento.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamento.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnPagamento.Location = new System.Drawing.Point(1191, 673);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(165, 45);
            this.btnPagamento.TabIndex = 126;
            this.btnPagamento.Text = "PAGAMENTO - F12";
            this.btnPagamento.UseVisualStyleBackColor = false;
            this.btnPagamento.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtdinheiro
            // 
            this.txtdinheiro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdinheiro.Location = new System.Drawing.Point(955, 618);
            this.txtdinheiro.Name = "txtdinheiro";
            this.txtdinheiro.Size = new System.Drawing.Size(100, 20);
            this.txtdinheiro.TabIndex = 129;
            this.txtdinheiro.Text = "0,00";
            this.txtdinheiro.Visible = false;
            this.txtdinheiro.TextChanged += new System.EventHandler(this.txtdinheiro_TextChanged);
            // 
            // txtdebito
            // 
            this.txtdebito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdebito.Location = new System.Drawing.Point(1255, 618);
            this.txtdebito.Name = "txtdebito";
            this.txtdebito.Size = new System.Drawing.Size(100, 20);
            this.txtdebito.TabIndex = 130;
            this.txtdebito.Text = "0,00";
            this.txtdebito.Visible = false;
            this.txtdebito.TextChanged += new System.EventHandler(this.txtdebito_TextChanged);
            // 
            // txtcredito
            // 
            this.txtcredito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcredito.Location = new System.Drawing.Point(1106, 618);
            this.txtcredito.Name = "txtcredito";
            this.txtcredito.Size = new System.Drawing.Size(100, 20);
            this.txtcredito.TabIndex = 131;
            this.txtcredito.Text = "0,00";
            this.txtcredito.Visible = false;
            this.txtcredito.TextChanged += new System.EventHandler(this.txtcredito_TextChanged);
            // 
            // txttroco
            // 
            this.txttroco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txttroco.Location = new System.Drawing.Point(1255, 643);
            this.txttroco.Name = "txttroco";
            this.txttroco.Size = new System.Drawing.Size(100, 20);
            this.txttroco.TabIndex = 132;
            this.txttroco.Text = "0,00";
            this.txttroco.Visible = false;
            // 
            // txtOutros
            // 
            this.txtOutros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutros.Location = new System.Drawing.Point(1106, 643);
            this.txtOutros.Name = "txtOutros";
            this.txtOutros.Size = new System.Drawing.Size(100, 20);
            this.txtOutros.TabIndex = 138;
            this.txtOutros.Text = "0,00";
            this.txtOutros.Visible = false;
            // 
            // lblValoresRecebidos
            // 
            this.lblValoresRecebidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValoresRecebidos.AutoSize = true;
            this.lblValoresRecebidos.BackColor = System.Drawing.Color.Transparent;
            this.lblValoresRecebidos.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.lblValoresRecebidos.Location = new System.Drawing.Point(1110, 595);
            this.lblValoresRecebidos.Name = "lblValoresRecebidos";
            this.lblValoresRecebidos.Size = new System.Drawing.Size(92, 15);
            this.lblValoresRecebidos.TabIndex = 140;
            this.lblValoresRecebidos.Text = "Valores Recebidos";
            this.lblValoresRecebidos.Visible = false;
            // 
            // lblDinheiroRecebido
            // 
            this.lblDinheiroRecebido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDinheiroRecebido.AutoSize = true;
            this.lblDinheiroRecebido.BackColor = System.Drawing.Color.Transparent;
            this.lblDinheiroRecebido.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.lblDinheiroRecebido.Location = new System.Drawing.Point(903, 621);
            this.lblDinheiroRecebido.Name = "lblDinheiroRecebido";
            this.lblDinheiroRecebido.Size = new System.Drawing.Size(50, 15);
            this.lblDinheiroRecebido.TabIndex = 141;
            this.lblDinheiroRecebido.Text = "Dinheiro:";
            this.lblDinheiroRecebido.Visible = false;
            // 
            // lblCreditoRecebido
            // 
            this.lblCreditoRecebido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreditoRecebido.AutoSize = true;
            this.lblCreditoRecebido.BackColor = System.Drawing.Color.Transparent;
            this.lblCreditoRecebido.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.lblCreditoRecebido.Location = new System.Drawing.Point(1059, 621);
            this.lblCreditoRecebido.Name = "lblCreditoRecebido";
            this.lblCreditoRecebido.Size = new System.Drawing.Size(44, 15);
            this.lblCreditoRecebido.TabIndex = 142;
            this.lblCreditoRecebido.Text = "Crédito:";
            this.lblCreditoRecebido.Visible = false;
            // 
            // lbldebitoRecebido
            // 
            this.lbldebitoRecebido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldebitoRecebido.AutoSize = true;
            this.lbldebitoRecebido.BackColor = System.Drawing.Color.Transparent;
            this.lbldebitoRecebido.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.lbldebitoRecebido.Location = new System.Drawing.Point(1213, 621);
            this.lbldebitoRecebido.Name = "lbldebitoRecebido";
            this.lbldebitoRecebido.Size = new System.Drawing.Size(40, 15);
            this.lbldebitoRecebido.TabIndex = 143;
            this.lbldebitoRecebido.Text = "Débito:";
            this.lbldebitoRecebido.Visible = false;
            // 
            // lblOutrosRecebido
            // 
            this.lblOutrosRecebido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutrosRecebido.AutoSize = true;
            this.lblOutrosRecebido.BackColor = System.Drawing.Color.Transparent;
            this.lblOutrosRecebido.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.lblOutrosRecebido.Location = new System.Drawing.Point(1060, 646);
            this.lblOutrosRecebido.Name = "lblOutrosRecebido";
            this.lblOutrosRecebido.Size = new System.Drawing.Size(41, 15);
            this.lblOutrosRecebido.TabIndex = 144;
            this.lblOutrosRecebido.Text = "Outros:";
            this.lblOutrosRecebido.Visible = false;
            // 
            // lblTrocoRecebido
            // 
            this.lblTrocoRecebido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrocoRecebido.AutoSize = true;
            this.lblTrocoRecebido.BackColor = System.Drawing.Color.Transparent;
            this.lblTrocoRecebido.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.lblTrocoRecebido.Location = new System.Drawing.Point(1213, 646);
            this.lblTrocoRecebido.Name = "lblTrocoRecebido";
            this.lblTrocoRecebido.Size = new System.Drawing.Size(36, 15);
            this.lblTrocoRecebido.TabIndex = 145;
            this.lblTrocoRecebido.Text = "Troco:";
            this.lblTrocoRecebido.Visible = false;
            // 
            // PainelMenu
            // 
            this.PainelMenu.BackColor = System.Drawing.Color.Black;
            this.PainelMenu.Controls.Add(this.button7);
            this.PainelMenu.Controls.Add(this.button3);
            this.PainelMenu.Controls.Add(this.button5);
            this.PainelMenu.Controls.Add(this.label10);
            this.PainelMenu.Controls.Add(this.button1);
            this.PainelMenu.Controls.Add(this.btnExcluirItem);
            this.PainelMenu.Location = new System.Drawing.Point(497, 148);
            this.PainelMenu.Name = "PainelMenu";
            this.PainelMenu.Size = new System.Drawing.Size(371, 417);
            this.PainelMenu.TabIndex = 147;
            this.PainelMenu.Visible = false;
            this.PainelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelMenu_Paint);
            this.PainelMenu.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PainelMenu_PreviewKeyDown);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(26, 288);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(317, 50);
            this.button7.TabIndex = 4;
            this.button7.Text = "Sair da tela PDV";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(156, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 55);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(26, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(317, 50);
            this.button5.TabIndex = 3;
            this.button5.Text = "Bloquear PDV";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(83, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 23);
            this.label10.TabIndex = 148;
            this.label10.Text = "Menu Operacional";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(27, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancelar Cupom Atual";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnExcluirItem.Location = new System.Drawing.Point(27, 60);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(317, 50);
            this.btnExcluirItem.TabIndex = 1;
            this.btnExcluirItem.Text = "Excluir Item";
            this.btnExcluirItem.UseVisualStyleBackColor = true;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click_1);
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 767);
            this.ControlBox = false;
            this.Controls.Add(this.PainelMenu);
            this.Controls.Add(this.lblTrocoRecebido);
            this.Controls.Add(this.lblOutrosRecebido);
            this.Controls.Add(this.lbldebitoRecebido);
            this.Controls.Add(this.lblCreditoRecebido);
            this.Controls.Add(this.lblDinheiroRecebido);
            this.Controls.Add(this.lblValoresRecebidos);
            this.Controls.Add(this.txtOutros);
            this.Controls.Add(this.txttroco);
            this.Controls.Add(this.txtcredito);
            this.Controls.Add(this.txtdebito);
            this.Controls.Add(this.txtdinheiro);
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.txtmensagem);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.txtpdv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmskCPF);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbltef);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblservidor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lblsepara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblnumcupom);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(codPropLabel);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(valorProdutoLabel);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(this.dtvVenda);
            this.Controls.Add(this.btnSair);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "frmVendas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda em andamento || VTEX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVendas_FormClosing);
            this.Load += new System.EventHandler(this.frmVendas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVendas_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmVendas_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmVendas_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dtvVenda)).EndInit();
            this.PainelMenu.ResumeLayout(false);
            this.PainelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvVenda;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Label lblnumcupom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsepara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblservidor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerpingservidor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltef;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Timer timedata;
        private System.Windows.Forms.MaskedTextBox txtmskCPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpdv;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.TextBox txtmensagem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.TextBox txtdinheiro;
        private System.Windows.Forms.TextBox txtdebito;
        private System.Windows.Forms.TextBox txtcredito;
        private System.Windows.Forms.TextBox txttroco;
        private System.Windows.Forms.TextBox txtOutros;
        private System.Windows.Forms.Label lblValoresRecebidos;
        private System.Windows.Forms.Label lblDinheiroRecebido;
        private System.Windows.Forms.Label lblCreditoRecebido;
        private System.Windows.Forms.Label lbldebitoRecebido;
        private System.Windows.Forms.Label lblOutrosRecebido;
        private System.Windows.Forms.Label lblTrocoRecebido;
        private System.Windows.Forms.Panel PainelMenu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
    }
}

