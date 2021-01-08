using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV {
    public partial class frmCPFCNPJ : Form {
        public frmCPFCNPJ() {
            InitializeComponent();
        }

        public static string dadoscpfcnpj;

        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e) {
            //Executa ao teclar Enter
            if (Convert.ToInt32(e.KeyChar) == 13) {
                string valor = txtcpf.Text;

                if (CpfCnpjUtils.IsValid(valor)) {
                    string dados = "Confirma os dados informados:  " + txtcpf.Text;

                    // passa os dados para o messagebox
                    string message = dados;
                    string caption = "Confirme os dados digitados!";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // exibe messagebox
                    result = MessageBox.Show(message, caption, buttons);

                    if (result == System.Windows.Forms.DialogResult.Yes) {
                        dadoscpfcnpj = txtcpf.Text;
                        this.Close();
                    } else {
                        txtcpf.Clear();
                        txtcpf.Focus();
                    }

                } else {
                    MessageBox.Show("Dados informados estão incorretos! Digite novamente!", "Dados incorretos", MessageBoxButtons.OK);

                    txtcpf.Clear();
                    txtcpf.Focus();
                }



            }
        }

        private void PegaConsumidor_Load(object sender, EventArgs e) {
            dadoscpfcnpj = Convert.ToString(0);
        }
    }
}

