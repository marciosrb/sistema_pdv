namespace PDV
{
    partial class frmInformarPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformarPagamento));
            this.txtValorRecebido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtValorRecebido
            // 
            this.txtValorRecebido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorRecebido.Font = new System.Drawing.Font("Verdana", 25F, System.Drawing.FontStyle.Bold);
            this.txtValorRecebido.Location = new System.Drawing.Point(149, 110);
            this.txtValorRecebido.Name = "txtValorRecebido";
            this.txtValorRecebido.Size = new System.Drawing.Size(248, 41);
            this.txtValorRecebido.TabIndex = 2;
            this.txtValorRecebido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorRecebido.EnabledChanged += new System.EventHandler(this.txtValorRecebido_EnabledChanged);
            this.txtValorRecebido.TextChanged += new System.EventHandler(this.txtValorRecebido_TextChanged);
            this.txtValorRecebido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // frmInformarPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.txtValorRecebido);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInformarPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagamentoDinheiro";
            this.Load += new System.EventHandler(this.PagamentoDinheiro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtValorRecebido;
    }
}