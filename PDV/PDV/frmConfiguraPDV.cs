using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV {
    public partial class frmConfiguraPDV : Form {
        public frmConfiguraPDV() {
            InitializeComponent();
        }

        MySqlConnection con = Conexao.ConexaoMySQL.obterConexao();
        private string strMySQL;

        private void ConexaoServidorBD() {
            strMySQL = "select * from mercado.servidorbd where idservidor='" + 1 + "'";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            try {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows) {

                } else {
                    txtServidor.Text = (dr["servidor"].ToString());
                    txtUsuario.Text = (dr["usuario"].ToString());
                    txtSenha.Text = (dr["senha"].ToString());
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                con.Close();
            }
        }
        private void CarregaIPServidor() {
            strMySQL = "select * from mercado.configuracao where idconfig='" + 1 + "'";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            try {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows) {

                } else {
                    txtIPServer.Text = (dr["Script"].ToString());
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                con.Close();
            }
        }
        private void CarregaIPTEF() {
            strMySQL = "select * from mercado.configuracao where idconfig='" + 2 + "'";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            try {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows) {

                } else {
                    txtIPTef.Text = (dr["Script"].ToString());

                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                con.Close();
            }
        }
        private void CarregaPDV() {
            strMySQL = "select * from mercado.configuracao where idconfig='" + 3 + "'";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            try {
               con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows) {

                } else {
                    txtPDV.Text = (dr["Script"].ToString());

                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                con.Close();
            }
        }

        private void GravarCaminhoServidor() {

            strMySQL = "update mercado.servidorbd set servidor=@servidor,usuario=@usuario, senha=@senha where idservidor='" + 1 + "';";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            comando.Parameters.AddWithValue("@servidor", txtServidor.Text);
            comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            comando.Parameters.AddWithValue("@senha", txtSenha.Text);

            MessageBox.Show("Dados gravados com sucesso!", "Dados gravados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try {

                con.Open();
                comando.ExecuteNonQuery();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {

                con.Close();


            }
        }
        private void GravarIPServidor() {

            strMySQL = "update mercado.configuracao set Script=@dados where idconfig='" + 1 + "';";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            comando.Parameters.AddWithValue("@dados", txtIPServer.Text);


            try {

                con.Open();
                comando.ExecuteNonQuery();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {

                con.Close();


            }
        }
        private void GravarIPTEF() {


            strMySQL = "update mercado.configuracao set Script=@dados where idconfig='" + 2 + "';";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            comando.Parameters.AddWithValue("@dados", txtIPTef.Text);


            try {

               con.Open();
                comando.ExecuteNonQuery();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {

                con.Close();


            }
        }
        private void GravarPDV() {

            strMySQL = "update mercado.configuracao set Script=@dados where idconfig='" + 3 + "';";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            comando.Parameters.AddWithValue("@dados", txtPDV.Text);


            try {

                con.Open();
                comando.ExecuteNonQuery();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {

                con.Close();


            }
        }
        private void TestarConexao() {
            // Definir os atributos da Conexão com o Connection String Builder
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();

            // Definir os atributos da conexão       


            csb.DataSource = txtServidor.Text; // servidor
            csb.UserID = txtUsuario.Text; //usuario
            csb.Password = txtSenha.Text; //senha
            csb.InitialCatalog = "GERAL"; // nome da BD


            SqlConnection connection = new SqlConnection(csb.ConnectionString);

            try // a conexão foi feita com sucesso?
            {
                Cursor.Current = Cursors.WaitCursor;
                connection.Open(); // abre a conexão
                MessageBox.Show("A conexão foi efetuada com sucesso!", "Configuração de conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (SqlException ex) {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Erro : Não foi possivel realizar a conexão!:", "Erro de Conexão ao Servidor", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            connection.Close();

            //   return connection;

        }

        private void TesteConexao_Load(object sender, EventArgs e) {
            ConexaoServidorBD();
            CarregaIPServidor();
            CarregaIPTEF();
            CarregaPDV();
        }
        private void button1_Click(object sender, EventArgs e) {
            TestarConexao();

        }

        private void button2_Click(object sender, EventArgs e) {
            GravarCaminhoServidor();
            GravarIPServidor();
            GravarIPTEF();
            GravarPDV();
        }

        private void button3_Click(object sender, EventArgs e) {

        }
    }
}

