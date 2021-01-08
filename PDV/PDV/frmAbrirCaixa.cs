using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV {
    public partial class frmAbrirCaixa : Form {
        public frmAbrirCaixa() {
            InitializeComponent();
            this.KeyDown += frmAbrirCaixa_KeyDown;
        }

        string DataAbertura;
        private string IDCAIXA;

        MySqlConnection con = Conexao.ConexaoMySQL.obterConexao();
        private string strMySQL;

        private void CarregaIDCaixa() {

            strMySQL = "select * from mercado.aberturacaixa where idabertura = (select max(idabertura) from mercado.aberturacaixa)";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            try {
               
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows) {

                } else {
                    IDCAIXA = (dr["idabertura"].ToString());

                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {

                con.Close();
            }
        }
        private void VerificaCaixa() {



            strMySQL = "select * from mercado.aberturacaixa where idabertura = (select max(idabertura) from mercado.aberturacaixa)";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            try {
                
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows) {

                } else {

                    DataAbertura = (dr["data"].ToString());

                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {

                con.Close();
            }
        }
        private void ConsultarOperador() {
            strMySQL = "select * from mercado.operador where idoperador='" + txtCodOperador.Text + "'";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            try {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows) {
                    lblMensagem.Text = "Operador não encontrado";

                    txtCodOperador.Clear();
                    txtCodOperador.Focus();
                    txtCodOperador.Clear();
                    con.Close();
                } else {
                    txtNomeOperador.Text = dr["nome"].ToString();

                    lblMensagem.Visible = false;
                    lblsuprimento.Visible = true;

                    txtSuprimento.Visible = true;
                    txtSuprimento.Focus();
                    txtSuprimento.Visible = true;
                    pctsuprimento.Visible = true;





                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                con.Close();

                if (VerificarOperador(1) == true) {
                    MessageBox.Show("Caixa já foi aberto hoje com este operador. Informe outro operador para prosseguir!", "Escolha outro operador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodOperador.Focus();
                    txtCodOperador.Clear();
                    txtNomeOperador.Text = "Digite outro operador";
                    lblMensagem.Visible = true;
                    lblsuprimento.Visible = false;
                    pctsuprimento.Visible = false;
                    txtSuprimento.Visible = false;
                } else {

                }
            }
        }
        private void InserirAbertura() {
            strMySQL = "insert into mercado.movimentocaixa(Data, Descricao, Entrada, Saida, FormaPagto, Operador, Observacao, idcaixa) value (@Data, @Descricao, @Entrada, @Saida, @FormaPagto, @Operador, @Observacao, @idcaixa)";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            string valorabertura = Convert.ToDecimal(txtSuprimento.Text).ToString("N");
            string valor = valorabertura.Replace(',', '.');

            comando.Parameters.AddWithValue("@Data", DateTime.Now);
            comando.Parameters.AddWithValue("@Descricao", "SALDO INICIAL");
            comando.Parameters.AddWithValue("@Entrada", valor);
            comando.Parameters.AddWithValue("@Saida", "0,00");
            comando.Parameters.AddWithValue("@FormaPagto", "Dinheiro/Suprimento");
            comando.Parameters.AddWithValue("@Operador", txtNomeOperador.Text);
            comando.Parameters.AddWithValue("@Observacao", "");
            comando.Parameters.AddWithValue("@idcaixa", Convert.ToString(Convert.ToInt32(IDCAIXA) + 1));

            try {
                con.Open();
                comando.ExecuteNonQuery();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                CarregaIDCaixa();
            } finally {
                con.Close();
            }


        }
        private void AberturaCaixa() {
            strMySQL = "insert into mercado.aberturacaixa (fechamento, operador, valorabertura, statuscaixa, data, observacao) Values (@fechamento, @operador, @valorabertura, @statuscaixa, @data, @observacao)";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            int hora = DateTime.Now.Hour;
            int minuto = DateTime.Now.Minute;
            string supervisor = frmMenuPrincipal.Supervisor;

            // comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@fechamento", txtSuprimento.Text);
            comando.Parameters.AddWithValue("@operador", txtNomeOperador.Text);
            comando.Parameters.AddWithValue("@valorabertura", txtSuprimento.Text);
            comando.Parameters.AddWithValue("@statuscaixa", "ABERTO");
            comando.Parameters.AddWithValue("@data", DateTime.Now);
            comando.Parameters.AddWithValue("@observacao", "Aberto às " + hora + ":" + minuto + " pelo fiscal: " + supervisor);



            try {


                con.Open();


                comando.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                con.Close();

                InserirAbertura();

                this.Close();



            }
        }

        public bool VerificarOperador(int v) {

            strMySQL = "select * from mercado.aberturacaixa where operador=@operador AND data > @Data";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            try {
                con.Open();
                comando.Parameters.AddWithValue("@Data", DateTime.Now.ToString("yyyy/MM/dd" + " 00:00:00"));
                comando.Parameters.AddWithValue("@operador", txtNomeOperador.Text);
                return Convert.ToBoolean(comando.ExecuteScalar());

            } catch {
                return Convert.ToBoolean(comando.ExecuteScalar());
            } finally {

                con.Close();
            }

        }


        private void txtCodOperador_KeyPress(object sender, KeyPressEventArgs e) {
            if (Convert.ToInt32(e.KeyChar) == 13) {
                ConsultarOperador();


            } else {
                txtCodOperador.Focus();
                con.Close();
            }


            //Permite numero e virgula no txtcod
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) {
                e.Handled = true;
            }
        }


        private void txtValorSuprimento_KeyPress(object sender, KeyPressEventArgs e) {


            AberturaCaixa();

            MessageBox.Show("Entrada de operador realizada com sucesso!", "Caixa aberto!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();




        }

        private void frmAbrirCaixa_Load(object sender, EventArgs e) {
            CarregaIDCaixa();
            VerificaCaixa();
        }

        private void txtNomeOperador_TextChanged(object sender, EventArgs e) {

        }

        private void txtValorSuprimento_TextChanged(object sender, EventArgs e) {

        }

        private void txtSuprimento_KeyPress(object sender, KeyPressEventArgs e) {
            //Executa ao teclar Enter
            if (Convert.ToInt32(e.KeyChar) == 13) {
                if (txtSuprimento.Text != string.Empty) {
                    AberturaCaixa();

                    MessageBox.Show("Entrada de operador realizada com sucesso!", "Caixa aberto!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                } else {
                    txtSuprimento.Focus();
                }
            }



        }

        private void pctsuprimento_Click(object sender, EventArgs e) {

        }

        private void txtSuprimento_TextChanged(object sender, EventArgs e) {

        }

        private void frmAbrirCaixa_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
                //System.Windows.Forms.Application.Exit();
            }
        }
    }
}
