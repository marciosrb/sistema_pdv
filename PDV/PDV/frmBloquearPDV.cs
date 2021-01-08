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
    public partial class frmBloquearPDV : Form {
        public frmBloquearPDV() {
            InitializeComponent();
        }

        frmSolicitarSenhaSupervisor frm2;

        private void frmBloquearPDV_KeyPress(object sender, KeyPressEventArgs e) {
            frm2 = new frmSolicitarSenhaSupervisor();
            DialogResult dr = frm2.ShowDialog(this);
            if (dr == DialogResult.Cancel) {

                MessageBox.Show("Senha incorreta!", "Senha incorreta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else if (dr == DialogResult.OK) {

                this.Close();

            }
        }

        private bool _altF4Pressed;

        private void frmBloquearPDV_FormClosing(object sender, FormClosingEventArgs e) {

            if (_altF4Pressed) {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void frmBloquearPDV_Load(object sender, EventArgs e) {
            timer1.Start();
        }
    }
}
