namespace PDV
{
    partial class frmPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagamento));
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.btnDinheiro = new System.Windows.Forms.Button();
            this.btnCredito = new System.Windows.Forms.Button();
            this.btnDebito = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.txtcredito = new System.Windows.Forms.TextBox();
            this.txtdinheiro = new System.Windows.Forms.TextBox();
            this.txtdebito = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblrecebdinheiro = new System.Windows.Forms.Label();
            this.lblRecebCredito = new System.Windows.Forms.Label();
            this.lblRecebDebito = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.BackColor = System.Drawing.Color.Transparent;
            this.lblValorVenda.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorVenda.ForeColor = System.Drawing.Color.Red;
            this.lblValorVenda.Location = new System.Drawing.Point(88, 98);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(144, 59);
            this.lblValorVenda.TabIndex = 2;
            this.lblValorVenda.Text = "0,00";
            // 
            // btnDinheiro
            // 
            this.btnDinheiro.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDinheiro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDinheiro.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDinheiro.ForeColor = System.Drawing.Color.Black;
            this.btnDinheiro.Location = new System.Drawing.Point(404, 474);
            this.btnDinheiro.Name = "btnDinheiro";
            this.btnDinheiro.Size = new System.Drawing.Size(184, 49);
            this.btnDinheiro.TabIndex = 4;
            this.btnDinheiro.Text = "A - Dinheiro";
            this.btnDinheiro.UseVisualStyleBackColor = false;
            this.btnDinheiro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCredito
            // 
            this.btnCredito.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCredito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCredito.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCredito.ForeColor = System.Drawing.Color.Black;
            this.btnCredito.Location = new System.Drawing.Point(593, 474);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(184, 49);
            this.btnCredito.TabIndex = 5;
            this.btnCredito.Text = "B - Crédito";
            this.btnCredito.UseVisualStyleBackColor = false;
            this.btnCredito.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDebito
            // 
            this.btnDebito.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDebito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDebito.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDebito.ForeColor = System.Drawing.Color.Black;
            this.btnDebito.Location = new System.Drawing.Point(783, 474);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(184, 49);
            this.btnDebito.TabIndex = 6;
            this.btnDebito.Text = "C - Débito";
            this.btnDebito.UseVisualStyleBackColor = false;
            this.btnDebito.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.IndianRed;
            this.button4.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(386, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 49);
            this.button4.TabIndex = 9;
            this.button4.Text = "Definir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(196, 183);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 49);
            this.button5.TabIndex = 8;
            this.button5.Text = "Definir";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.IndianRed;
            this.button6.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(7, 183);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(184, 49);
            this.button6.TabIndex = 7;
            this.button6.Text = "D - Fiado";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblValorPago
            // 
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.BackColor = System.Drawing.Color.Transparent;
            this.lblValorPago.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPago.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblValorPago.Location = new System.Drawing.Point(681, 116);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(88, 35);
            this.lblValorPago.TabIndex = 11;
            this.lblValorPago.Text = "0,00";
            this.lblValorPago.TextChanged += new System.EventHandler(this.label4_TextChanged);
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.BackColor = System.Drawing.Color.Transparent;
            this.lblTroco.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblTroco.ForeColor = System.Drawing.Color.Red;
            this.lblTroco.Location = new System.Drawing.Point(681, 224);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(88, 35);
            this.lblTroco.TabIndex = 13;
            this.lblTroco.Text = "0,00";
            // 
            // btnPagamento
            // 
            this.btnPagamento.BackColor = System.Drawing.Color.Black;
            this.btnPagamento.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamento.ForeColor = System.Drawing.Color.White;
            this.btnPagamento.Location = new System.Drawing.Point(783, 392);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(184, 35);
            this.btnPagamento.TabIndex = 15;
            this.btnPagamento.Text = "Realizar pagamento - F12";
            this.btnPagamento.UseVisualStyleBackColor = false;
            this.btnPagamento.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtcredito
            // 
            this.txtcredito.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtcredito.Location = new System.Drawing.Point(127, 496);
            this.txtcredito.Name = "txtcredito";
            this.txtcredito.ReadOnly = true;
            this.txtcredito.Size = new System.Drawing.Size(106, 24);
            this.txtcredito.TabIndex = 17;
            this.txtcredito.Text = "0,00";
            this.txtcredito.Visible = false;
            this.txtcredito.TextChanged += new System.EventHandler(this.txtcredito_TextChanged);
            // 
            // txtdinheiro
            // 
            this.txtdinheiro.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtdinheiro.Location = new System.Drawing.Point(15, 496);
            this.txtdinheiro.Name = "txtdinheiro";
            this.txtdinheiro.ReadOnly = true;
            this.txtdinheiro.Size = new System.Drawing.Size(106, 24);
            this.txtdinheiro.TabIndex = 18;
            this.txtdinheiro.Text = "0,00";
            this.txtdinheiro.Visible = false;
            this.txtdinheiro.TextChanged += new System.EventHandler(this.txtdinheiro_TextChanged);
            // 
            // txtdebito
            // 
            this.txtdebito.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtdebito.Location = new System.Drawing.Point(238, 496);
            this.txtdebito.Name = "txtdebito";
            this.txtdebito.ReadOnly = true;
            this.txtdebito.Size = new System.Drawing.Size(106, 24);
            this.txtdebito.TabIndex = 19;
            this.txtdebito.Text = "0,00";
            this.txtdebito.Visible = false;
            this.txtdebito.TextChanged += new System.EventHandler(this.txtdebito_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(783, 433);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(184, 35);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Voltar para tela de venda  (ESC)";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // lblrecebdinheiro
            // 
            this.lblrecebdinheiro.AutoSize = true;
            this.lblrecebdinheiro.BackColor = System.Drawing.Color.Transparent;
            this.lblrecebdinheiro.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecebdinheiro.Location = new System.Drawing.Point(14, 475);
            this.lblrecebdinheiro.Name = "lblrecebdinheiro";
            this.lblrecebdinheiro.Size = new System.Drawing.Size(50, 18);
            this.lblrecebdinheiro.TabIndex = 21;
            this.lblrecebdinheiro.Text = "Dinheiro";
            this.lblrecebdinheiro.Visible = false;
            // 
            // lblRecebCredito
            // 
            this.lblRecebCredito.AutoSize = true;
            this.lblRecebCredito.BackColor = System.Drawing.Color.Transparent;
            this.lblRecebCredito.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblRecebCredito.Location = new System.Drawing.Point(125, 475);
            this.lblRecebCredito.Name = "lblRecebCredito";
            this.lblRecebCredito.Size = new System.Drawing.Size(44, 18);
            this.lblRecebCredito.TabIndex = 22;
            this.lblRecebCredito.Text = "Crédito";
            this.lblRecebCredito.Visible = false;
            // 
            // lblRecebDebito
            // 
            this.lblRecebDebito.AutoSize = true;
            this.lblRecebDebito.BackColor = System.Drawing.Color.Transparent;
            this.lblRecebDebito.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblRecebDebito.Location = new System.Drawing.Point(235, 475);
            this.lblRecebDebito.Name = "lblRecebDebito";
            this.lblRecebDebito.Size = new System.Drawing.Size(39, 18);
            this.lblRecebDebito.TabIndex = 23;
            this.lblRecebDebito.Text = "Débito";
            this.lblRecebDebito.Visible = false;
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.lblRecebDebito);
            this.Controls.Add(this.lblRecebCredito);
            this.Controls.Add(this.lblrecebdinheiro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtdebito);
            this.Controls.Add(this.txtdinheiro);
            this.Controls.Add(this.txtcredito);
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.lblValorPago);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnDebito);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.btnDinheiro);
            this.Controls.Add(this.lblValorVenda);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe o pagamento || VTEX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pagamento_FormClosing);
            this.Load += new System.EventHandler(this.Pagamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pagamento_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pagamento_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.Button btnDinheiro;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Button btnDebito;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblValorPago;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.TextBox txtcredito;
        private System.Windows.Forms.TextBox txtdinheiro;
        private System.Windows.Forms.TextBox txtdebito;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblrecebdinheiro;
        private System.Windows.Forms.Label lblRecebCredito;
        private System.Windows.Forms.Label lblRecebDebito;
    }
}