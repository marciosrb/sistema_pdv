using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV {
    public partial class frmFundoPDV : Form {
        public frmFundoPDV() {

        }


        public frmFundoPDV(frmMenuPrincipal menuPrincipal) {
            InitializeComponent();
        }



        private void frmInicio_Load(object sender, EventArgs e) {

            frmVendas f3 = new frmVendas(this);
            f3.ShowDialog();

            timer1.Start();

        }

        private bool ALT_F4 = false;
        private void frmFundoPDV_FormClosing(object sender, FormClosingEventArgs e) {
            if (ALT_F4) {
                e.Cancel = true;
                return;
            }
        }

        private void frmFundoPDV_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
                //System.Windows.Forms.Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            // Verifica se o formulário está aberto. Caso estiver aberto, o COUNT será maior que 0 (zero)
            if (Application.OpenForms.OfType<frmVendas>().Count() > 0) {

            } else {
                this.Close();
            }
        }
    }
}
