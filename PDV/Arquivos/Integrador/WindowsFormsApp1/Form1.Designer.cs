namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtserver = new System.Windows.Forms.TextBox();
            this.txtpdv = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Lbl_status = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.txtArquivo2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtserver
            // 
            this.txtserver.Location = new System.Drawing.Point(103, 249);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(439, 20);
            this.txtserver.TabIndex = 0;
            this.txtserver.TextChanged += new System.EventHandler(this.Textbox1_TextChanged);
            // 
            // txtpdv
            // 
            this.txtpdv.Location = new System.Drawing.Point(103, 289);
            this.txtpdv.Name = "txtpdv";
            this.txtpdv.Size = new System.Drawing.Size(439, 20);
            this.txtpdv.TabIndex = 1;
            this.txtpdv.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lbl_status
            // 
            this.Lbl_status.AutoSize = true;
            this.Lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_status.Location = new System.Drawing.Point(99, 393);
            this.Lbl_status.Name = "Lbl_status";
            this.Lbl_status.Size = new System.Drawing.Size(62, 20);
            this.Lbl_status.TabIndex = 3;
            this.Lbl_status.Text = "Status";
            // 
            // timer2
            // 
            
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(12, 12);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(644, 20);
            this.txtArquivo.TabIndex = 8;
            
           
            // 
            // txtArquivo2
            // 
            this.txtArquivo2.Location = new System.Drawing.Point(12, 38);
            this.txtArquivo2.Name = "txtArquivo2";
            this.txtArquivo2.Size = new System.Drawing.Size(644, 20);
            this.txtArquivo2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.txtArquivo2);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.Lbl_status);
            this.Controls.Add(this.txtpdv);
            this.Controls.Add(this.txtserver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtserver;
        private System.Windows.Forms.TextBox txtpdv;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Lbl_status;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.TextBox txtArquivo2;
    }
}

