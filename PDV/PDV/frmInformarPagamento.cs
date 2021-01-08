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
    public partial class frmInformarPagamento : Form {

        public frmInformarPagamento() {
            InitializeComponent();
        }
        public string txtTipo { get; set; }
        public string txtValor { get; set; }
        public string txtIDCaixa { get; set; }

        public static string VALORRECEBIDO;
        public static string TIPO;

        private void label2_Click(object sender, EventArgs e) {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {

            //Executa ao teclar Enter
            if (Convert.ToInt32(e.KeyChar) == 13) {
                if (txtValorRecebido.Text != string.Empty) {
                    this.txtIDCaixa = frmPagamento.IDCAIXA;
                    this.txtTipo = frmPagamento.TIPO;
                    this.txtValor = txtValorRecebido.Text;
                    this.DialogResult = DialogResult.OK;

                } else {
                    txtValorRecebido.Focus();
                }
            }
        }

        private void PagamentoDinheiro_Load(object sender, EventArgs e) {

        }

        private void txtValorRecebido_EnabledChanged(object sender, EventArgs e) {

        }

        private void txtValorRecebido_TextChanged(object sender, EventArgs e) {

        }
    }
}
