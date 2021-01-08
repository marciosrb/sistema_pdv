namespace PDV
{
    partial class frmAbrirCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbrirCaixa));
            this.txtCodOperador = new System.Windows.Forms.TextBox();
            this.txtNomeOperador = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblsuprimento = new System.Windows.Forms.Label();
            this.pctsuprimento = new System.Windows.Forms.PictureBox();
            this.txtSuprimento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctsuprimento)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodOperador
            // 
            this.txtCodOperador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodOperador.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodOperador.Location = new System.Drawing.Point(151, 108);
            this.txtCodOperador.Name = "txtCodOperador";
            this.txtCodOperador.Size = new System.Drawing.Size(152, 26);
            this.txtCodOperador.TabIndex = 0;
            this.txtCodOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodOperador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodOperador_KeyPress);
            // 
            // txtNomeOperador
            // 
            this.txtNomeOperador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeOperador.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeOperador.Location = new System.Drawing.Point(45, 168);
            this.txtNomeOperador.Name = "txtNomeOperador";
            this.txtNomeOperador.Size = new System.Drawing.Size(367, 36);
            this.txtNomeOperador.TabIndex = 1;
            this.txtNomeOperador.Text = "...";
            this.txtNomeOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeOperador.TextChanged += new System.EventHandler(this.txtNomeOperador_TextChanged);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(71, 229);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(311, 29);
            this.lblMensagem.TabIndex = 4;
            this.lblMensagem.Text = "Aguardando Operador";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblsuprimento
            // 
            this.lblsuprimento.AutoSize = true;
            this.lblsuprimento.BackColor = System.Drawing.Color.Transparent;
            this.lblsuprimento.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsuprimento.Location = new System.Drawing.Point(12, 294);
            this.lblsuprimento.Name = "lblsuprimento";
            this.lblsuprimento.Size = new System.Drawing.Size(432, 29);
            this.lblsuprimento.TabIndex = 5;
            this.lblsuprimento.Text = "Digite a entrada de suprimento";
            this.lblsuprimento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblsuprimento.Visible = false;
            // 
            // pctsuprimento
            // 
            this.pctsuprimento.BackColor = System.Drawing.Color.Transparent;
            this.pctsuprimento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctsuprimento.BackgroundImage")));
            this.pctsuprimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctsuprimento.Location = new System.Drawing.Point(110, 326);
            this.pctsuprimento.Name = "pctsuprimento";
            this.pctsuprimento.Size = new System.Drawing.Size(240, 62);
            this.pctsuprimento.TabIndex = 6;
            this.pctsuprimento.TabStop = false;
            this.pctsuprimento.Visible = false;
            this.pctsuprimento.Click += new System.EventHandler(this.pctsuprimento_Click);
            // 
            // txtSuprimento
            // 
            this.txtSuprimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuprimento.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuprimento.Location = new System.Drawing.Point(123, 342);
            this.txtSuprimento.Name = "txtSuprimento";
            this.txtSuprimento.Size = new System.Drawing.Size(214, 26);
            this.txtSuprimento.TabIndex = 7;
            this.txtSuprimento.Visible = false;
            this.txtSuprimento.TextChanged += new System.EventHandler(this.txtSuprimento_TextChanged);
            this.txtSuprimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSuprimento_KeyPress);
            // 
            // frmAbrirCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(454, 463);
            this.Controls.Add(this.txtSuprimento);
            this.Controls.Add(this.lblsuprimento);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txtNomeOperador);
            this.Controls.Add(this.txtCodOperador);
            this.Controls.Add(this.pctsuprimento);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmAbrirCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de operador || VTEX";
            this.Load += new System.EventHandler(this.frmAbrirCaixa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAbrirCaixa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctsuprimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodOperador;
        private System.Windows.Forms.TextBox txtNomeOperador;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblsuprimento;
        private System.Windows.Forms.PictureBox pctsuprimento;
        private System.Windows.Forms.TextBox txtSuprimento;
    }
}