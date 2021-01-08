namespace PDV
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnMovimento = new System.Windows.Forms.Button();
            this.brnAbrirPDV = new System.Windows.Forms.Button();
            this.lblOperador = new System.Windows.Forms.Label();
            this.Carregaopera = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLicenca = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnSairSistema = new System.Windows.Forms.Button();
            this.btnTrocarUsuario = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMovimento
            // 
            this.btnMovimento.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btnMovimento.BackColor = System.Drawing.Color.Black;
            this.btnMovimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMovimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimento.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimento.ForeColor = System.Drawing.Color.White;
            this.btnMovimento.Location = new System.Drawing.Point(11, 123);
            this.btnMovimento.Name = "btnMovimento";
            this.btnMovimento.Size = new System.Drawing.Size(259, 58);
            this.btnMovimento.TabIndex = 2;
            this.btnMovimento.Text = "&Movimento Caixa";
            this.btnMovimento.UseVisualStyleBackColor = false;
            this.btnMovimento.Click += new System.EventHandler(this.btnabrefecha_Click);
            this.btnMovimento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnMovimento_KeyUp);
            // 
            // brnAbrirPDV
            // 
            this.brnAbrirPDV.BackColor = System.Drawing.Color.Black;
            this.brnAbrirPDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnAbrirPDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnAbrirPDV.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold);
            this.brnAbrirPDV.ForeColor = System.Drawing.Color.White;
            this.brnAbrirPDV.Location = new System.Drawing.Point(11, 51);
            this.brnAbrirPDV.Name = "brnAbrirPDV";
            this.brnAbrirPDV.Size = new System.Drawing.Size(259, 58);
            this.brnAbrirPDV.TabIndex = 1;
            this.brnAbrirPDV.Text = "&ABRIR PDV ";
            this.brnAbrirPDV.UseVisualStyleBackColor = false;
            this.brnAbrirPDV.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOperador
            // 
            this.lblOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOperador.AutoSize = true;
            this.lblOperador.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblOperador.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblOperador.ForeColor = System.Drawing.Color.Black;
            this.lblOperador.Location = new System.Drawing.Point(102, 695);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(122, 18);
            this.lblOperador.TabIndex = 2;
            this.lblOperador.Text = "Caixa fechado";
            // 
            // Carregaopera
            // 
            this.Carregaopera.Enabled = true;
            this.Carregaopera.Interval = 1000;
            this.Carregaopera.Tick += new System.EventHandler(this.Carregaopera_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 674);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 695);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Operador:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(273, 695);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "||  Supervisor:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblLogin.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(400, 695);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(28, 18);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = " ...";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(607, 695);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "||  Licença do sistema:";
            // 
            // lblLicenca
            // 
            this.lblLicenca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLicenca.AutoSize = true;
            this.lblLicenca.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblLicenca.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblLicenca.ForeColor = System.Drawing.Color.Black;
            this.lblLicenca.Location = new System.Drawing.Point(898, 695);
            this.lblLicenca.Name = "lblLicenca";
            this.lblLicenca.Size = new System.Drawing.Size(23, 18);
            this.lblLicenca.TabIndex = 7;
            this.lblLicenca.Text = "...";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1083, 695);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data:";
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblData.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblData.ForeColor = System.Drawing.Color.Black;
            this.lblData.Location = new System.Drawing.Point(1136, 695);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(23, 18);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "...";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(614, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(453, 173);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(81, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "MENU PRINCIPAL";
            // 
            // Data
            // 
            this.Data.Enabled = true;
            this.Data.Interval = 1000;
            this.Data.Tick += new System.EventHandler(this.Data_Tick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(801, 695);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Valido até:";
            // 
            // btnSairSistema
            // 
            this.btnSairSistema.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btnSairSistema.BackColor = System.Drawing.Color.Maroon;
            this.btnSairSistema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSairSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSairSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairSistema.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairSistema.ForeColor = System.Drawing.Color.White;
            this.btnSairSistema.Location = new System.Drawing.Point(11, 452);
            this.btnSairSistema.Name = "btnSairSistema";
            this.btnSairSistema.Size = new System.Drawing.Size(259, 58);
            this.btnSairSistema.TabIndex = 4;
            this.btnSairSistema.Text = "&Sair do Sistema";
            this.btnSairSistema.UseVisualStyleBackColor = false;
            this.btnSairSistema.Click += new System.EventHandler(this.btnSairSistema_Click);
            // 
            // btnTrocarUsuario
            // 
            this.btnTrocarUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btnTrocarUsuario.BackColor = System.Drawing.Color.Black;
            this.btnTrocarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrocarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrocarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrocarUsuario.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrocarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnTrocarUsuario.Location = new System.Drawing.Point(11, 196);
            this.btnTrocarUsuario.Name = "btnTrocarUsuario";
            this.btnTrocarUsuario.Size = new System.Drawing.Size(259, 58);
            this.btnTrocarUsuario.TabIndex = 3;
            this.btnTrocarUsuario.Text = "&Trocar de Usuário";
            this.btnTrocarUsuario.UseVisualStyleBackColor = false;
            this.btnTrocarUsuario.Click += new System.EventHandler(this.btnTrocarUsuario_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btnDesligar.BackColor = System.Drawing.Color.Maroon;
            this.btnDesligar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDesligar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesligar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesligar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesligar.ForeColor = System.Drawing.Color.White;
            this.btnDesligar.Location = new System.Drawing.Point(11, 601);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(259, 58);
            this.btnDesligar.TabIndex = 6;
            this.btnDesligar.Text = "&Desligar Computador";
            this.btnDesligar.UseVisualStyleBackColor = false;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(11, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Reiniciar Computador";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1348, 731);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnTrocarUsuario);
            this.Controls.Add(this.btnSairSistema);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLicenca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.brnAbrirPDV);
            this.Controls.Add(this.btnMovimento);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FundoTelas_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMenuPrincipal_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMovimento;
        private System.Windows.Forms.Button brnAbrirPDV;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Timer Carregaopera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLicenca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer Data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSairSistema;
        private System.Windows.Forms.Button btnTrocarUsuario;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button button1;
    }
}