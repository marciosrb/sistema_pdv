namespace PDV
{
    partial class frmFechamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFechamento));
            this.txttotaldinheiro = new System.Windows.Forms.TextBox();
            this.txtdinheiroconferencia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txttotaldinheiro
            // 
            this.txttotaldinheiro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotaldinheiro.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotaldinheiro.Location = new System.Drawing.Point(44, 110);
            this.txttotaldinheiro.Name = "txttotaldinheiro";
            this.txttotaldinheiro.Size = new System.Drawing.Size(364, 39);
            this.txttotaldinheiro.TabIndex = 30;
            this.txttotaldinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdinheiroconferencia
            // 
            this.txtdinheiroconferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdinheiroconferencia.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold);
            this.txtdinheiroconferencia.Location = new System.Drawing.Point(42, 238);
            this.txtdinheiroconferencia.Name = "txtdinheiroconferencia";
            this.txtdinheiroconferencia.Size = new System.Drawing.Size(364, 39);
            this.txtdinheiroconferencia.TabIndex = 1;
            this.txtdinheiroconferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdinheiroconferencia_KeyPress);
            // 
            // frmFechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(454, 361);
            this.Controls.Add(this.txtdinheiroconferencia);
            this.Controls.Add(this.txttotaldinheiro);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmFechamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFechamento";
            this.Load += new System.EventHandler(this.frmFechamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttotaldinheiro;
        private System.Windows.Forms.TextBox txtdinheiroconferencia;
    }
}