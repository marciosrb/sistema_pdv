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
    public partial class frmFechamento : Form {
        public frmFechamento() {
            InitializeComponent();
        }

        MySqlConnection con = Conexao.ConexaoMySQL.obterConexao();
        private string strMySQL;

        private void frmFechamento_Load(object sender, EventArgs e) {
            txttotaldinheiro.Text = frmCaixa.VALORFECHAMENTODINHEIRO;
            txtdinheiroconferencia.Focus();
        }

        private void AlterarparaCaixaFechado() {
            string idcaixa = frmCaixa.IDCAIXAFECHAMENTO;

            strMySQL = "update mercado.aberturacaixa set statuscaixa=@statuscaixa where idabertura='" + idcaixa + "';";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            comando.Parameters.AddWithValue("@statuscaixa", "FECHADO");


            MessageBox.Show("Caixa fechado com sucesso!", "Dados gravados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try {

                con.Open();
                comando.ExecuteNonQuery();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {

                con.Close();


            }
        }
        private void InserirFechamentoCaixa() {
            string idcaixa = frmCaixa.IDCAIXAFECHAMENTO;

            string saldoinicial = frmCaixa.SALDOINICIALFECHAMENTO;
            string dinheiro = frmCaixa.ENTRADADINHEIROFECHAMENTO;  //
            string credito = frmCaixa.ENTRADACREDITOFECHAMENTO;   //
            string debito = frmCaixa.ENTRADADEBITOFECHAMENTO;
            string fechamentodinheiro = frmCaixa.VALORFECHAMENTODINHEIRO;
            string sangria = frmCaixa.SANGRIAFECHAMENTO;
            string gavetadinheiro = txtdinheiroconferencia.Text;
            string operador = frmCaixa.OPERADORFECHAMENTO;
            string supervidor = frmCaixa.SUPERVISORFECHAMENTO;
            string obeservacao = frmCaixa.OBSERVACAO;

            string inicial = saldoinicial; string inicial1 = inicial.Replace(".", ""); string inicial2 = inicial1.Replace(',', '.');
            string pagdinheiro = dinheiro; string pagdinheiro1 = pagdinheiro.Replace(".", ""); string pagdinheiro2 = pagdinheiro1.Replace(',', '.');
            string pagcredito = credito; string pagcredito1 = pagcredito.Replace(".", ""); string pagcredito2 = pagcredito1.Replace(',', '.');
            string pagdebito = debito; string pagdebito1 = pagdebito.Replace(".", ""); string pagdebito2 = pagdebito1.Replace(',', '.');
            string fechamento = fechamentodinheiro; string fechamento1 = fechamento.Replace(".", ""); string fechamento2 = fechamento1.Replace(',', '.');
            string saidasangria = sangria; string saidasangria1 = saidasangria.Replace(".", ""); string saidasangria2 = saidasangria1.Replace(',', '.');
            string gaveta = gavetadinheiro; string gaveta1 = gaveta.Replace(".", ""); string gaveta2 = gaveta1.Replace(',', '.');

            strMySQL = "insert into mercado.fechamentocaixa(idabertura, valorabertura, entradadinheiro, entradacredito, entradadebito, " +
                "sangria, dinheiroahaver, dinheirogaveta, operador, supervisor, datafechamento, observacao) value (@idabertura, @valorabertura, @entradadinheiro, @entradacredito, @entradadebito, " +
                "@sangria, @dinheiroahaver, @dinheirogaveta, @operador, @supervisor, @datafechamento, @observacao)";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            comando.Parameters.AddWithValue("@idabertura", idcaixa);
            comando.Parameters.AddWithValue("@valorabertura", inicial2);
            comando.Parameters.AddWithValue("@entradadinheiro", pagdinheiro2);
            comando.Parameters.AddWithValue("@entradacredito", pagcredito2);
            comando.Parameters.AddWithValue("@entradadebito", pagdebito2);
            comando.Parameters.AddWithValue("@sangria", saidasangria2);
            comando.Parameters.AddWithValue("@dinheiroahaver", fechamento2);
            comando.Parameters.AddWithValue("@dinheirogaveta", gaveta2);
            comando.Parameters.AddWithValue("@operador", frmCaixa.OPERADORFECHAMENTO);
            comando.Parameters.AddWithValue("@supervisor", frmCaixa.SUPERVISORFECHAMENTO);
            comando.Parameters.AddWithValue("@datafechamento", DateTime.Now);
            comando.Parameters.AddWithValue("@Observacao", "");

            


            try {

                comando.ExecuteNonQuery();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);


            } finally {

                con.Close();


            }
        }

        private void txtdinheiroconferencia_KeyPress(object sender, KeyPressEventArgs e) {
            if (Convert.ToInt32(e.KeyChar) == 13) {

                AlterarparaCaixaFechado();
                InserirFechamentoCaixa();
                this.Close();


                //Permite numero e virgula no txtcod
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) {
                    e.Handled = true;
                }
            }
        }
    }
}

