using MySql.Data.MySqlClient;
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
    public partial class frmSolicitarSenhaSupervisor : Form {
        public frmSolicitarSenhaSupervisor() {
            InitializeComponent();
        }
        public string getText() {
            return STATUSLOGIN;
        }

        MySqlConnection con = Conexao.ConexaoMySQL.obterConexao();
        private string strMySQL;

        public static string STATUSLOGIN;

        private void txtSenha_TextChanged(object sender, EventArgs e) {
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e) {
            if (Convert.ToInt32(e.KeyChar) == 13) {
                MySqlCommand cmd = new MySqlCommand(strMySQL, con);
                cmd.CommandText = "select * from mercado.usuario where login = @login and senha = @senha";
                cmd.Parameters.AddWithValue("@login", login.nomelogin);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader reader;
                con.Open();

                reader = cmd.ExecuteReader();
                try {
                    if (!reader.Read()) {
                        STATUSLOGIN = "Senha incorreta! Cancelamento do item foi negado!";
                        this.Close();

                    } else {
                        STATUSLOGIN = "Item cancelado com sucesso!";
                        DialogResult = DialogResult.OK;
                        this.Close();

                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {
                    con.Close();
                }
            }
        }

        private void frmSolicitarSenhaSupervisor_Load(object sender, EventArgs e) {

        }
    }
}
