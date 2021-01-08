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
    public partial class frmSangria : Form {
        public frmSangria() {
            InitializeComponent();
        }

        MySqlConnection con = Conexao.ConexaoMySQL.obterConexao();
        private string strMySQL;
        private void CalculaSangria() {
            decimal entradadinheiro = Convert.ToDecimal(frmCaixa.VALORSANGRIA);
            decimal sangria = Convert.ToDecimal(txtValor.Text);

            if (sangria > entradadinheiro) {
                MessageBox.Show("Valor solicitado não esta disponivel na gaveta", "ERRO: Verifique o valor.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                InserirSangria();
            }
        }
        private void InserirSangria() {
            strMySQL = "insert into mercado.movimentocaixa(Data, Descricao, Entrada, Saida, FormaPagto, Operador, Observacao, idcaixa) value (@Data, @Descricao, @Entrada, @Saida, @FormaPagto, @Operador, @Observacao, @idcaixa)";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            string valorsangria = Convert.ToDecimal(txtValor.Text).ToString("N");
            string var1 = valorsangria.Replace(".", "");
            string valor = var1.Replace(',', '.');
            comando.Parameters.AddWithValue("@Data", DateTime.Now);
            comando.Parameters.AddWithValue("@Descricao", "SANGRIA");
            comando.Parameters.AddWithValue("@Entrada", "0,00");
            comando.Parameters.AddWithValue("@Saida", valor);
            comando.Parameters.AddWithValue("@FormaPagto", "Dinheiro");
            comando.Parameters.AddWithValue("@Operador", frmMenuPrincipal.Operador);
            comando.Parameters.AddWithValue("@Observacao", "");
            comando.Parameters.AddWithValue("@idcaixa", frmCaixa.IDCAIXA);

            try {
                con.Open();
                comando.ExecuteNonQuery();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);

            } finally {
                con.Close();
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if (Convert.ToInt32(e.KeyChar) == 13) {

                CalculaSangria();
                this.Close();


                //Permite numero e virgula no txtcod
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) {
                    e.Handled = true;
                }
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e) {

        }

        private void frmSangria_Load(object sender, EventArgs e) {

        }
    }
}
