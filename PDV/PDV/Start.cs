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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace PDV {
    public partial class Start : Form {
        public Start() {
            InitializeComponent();
        }
        public static string SERVIDORSQL;
        public static string USUARIOSQL;
        public static string SENHASQL;

        string cnpj;
        string nomeempresa;
        string razaosocial;
        string fantasia;
        string contato;
        string endereco;
        string telefone;
        string email;
        string licenca;
        string cidade;
        string estado;
        string cep;

        MySqlConnection con = Conexao.ConexaoMySQL.obterConexao();
        private string strMySQL;
        private string strSQL;

        SqlConnection conn = null;
        SqlDataReader reader = null;

        private string strLinha;
        private object cmd;
        private StreamReader fluxotexto;
        private Stream arquivo;
        public static string Finalizador;
        private string servidor;

        private void criarPastaSistema() {
            string folder = @"C:\VtexSistema\Carga"; //nome do diretorio a ser criado

            //Se o diretório não existir...

            if (!Directory.Exists(folder)) {

                //Criamos um com o nome folder
                Directory.CreateDirectory(folder);

            }
        }
        private async Task inicioAsync() {
            conexaoServidorBD(); //carrega a string d conexao do BD central em variaveis
            var w = new Start();
            var t = new Thread(w.Hide);
            //Iniciando a Thread
            t.Start();

            lblStatus.Text = "Carregando o sistema. Aguarde!!";
            await Task.Delay(5000);

            try {
                //Fechando form auxiliar
                t.Abort();
            } catch (Exception) {

            }

            threatprodutosAsync();
        }
        private async Task threatprodutosAsync() {
            var w = new Start();
            var t = new Thread(w.Hide);
            //Iniciando a Thread
            t.Start();

            //Carregamento dos dados
            ImportarDadosEmpresa(); // pega as informações da empresa do BD Central
            ImportarLicenca(); //importa licenca do BD Central
            verificaServidor(); //verifica se o servidor esta respondendo, caso sim, ele faz a inserção dos novos dados da empresa no bd local
            importarProdutos(); //faz a importação da tabela de preços

            try {
                //Fechando form auxiliar
                t.Abort();

                lblStatus.Text = "Sistema atualizado!";
                Finalizador = Convert.ToString(0);
                lblMensagem.Visible = false;
                await Task.Delay(3000);

                this.Hide();

                login form = new login();
                form.ShowDialog();




            } catch (Exception) {


            }


        }
        private void limparTabelaProdutos() {
            strMySQL = "TRUNCATE mercado.produtos";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);


            con.Open();
            comando.Connection = con;
            {
                comando.ExecuteNonQuery();
            }
            con.Close();

        }
        private void cadastra(string produtoid, string nome, string preco, string quantidade, string codbarra, string tipo) {

            string strConn = "server = localhost; User Id = root; password = 123456";

            MySqlConnection conn = new MySqlConnection(strConn);

            conn.Open();

            string strSql = "Insert into mercado.produtos (ProdutoID, Nome, Preco, Quantidade, CodBarra, Tipo) Values (@ProdutoID, @Nome, @Preco, @Quantidade, @CodBarra, @Tipo)";

            MySqlCommand cmd = new MySqlCommand();

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ProdutoID", produtoid);
            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@Preco", preco);
            cmd.Parameters.AddWithValue("@Quantidade", quantidade);
            cmd.Parameters.AddWithValue("@CodBarra", codbarra);
            cmd.Parameters.AddWithValue("@Tipo", tipo);


            cmd.Connection = conn;

            cmd.CommandText = strSql;

            cmd.CommandType = CommandType.Text;


            cmd.ExecuteNonQuery();


        }
        private void importarProdutos() {
            lblMensagem.Visible = true;
            lblStatus.Text = "Sincronizando dados...";
            lblMensagem.Text = "Carregando produtos";
            limparTabelaProdutos();

            using (StreamReader fluxotexto = new StreamReader(Conexao.ConexaoTabelaItens.caminho))

                while (true) {

                    string linhatexto = fluxotexto.ReadLine();

                    if (linhatexto == null) {

                        break;

                    }


                    string[] quebra = linhatexto.Split(new Char[] { ',' });


                    cadastra(quebra[0], quebra[1], quebra[2], quebra[3], quebra[4], quebra[5]);
                }


        }
        private void conexaoServidorBD() {
            strMySQL = "select * from mercado.servidorbd where idservidor='" + 1 + "'";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            try {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows) {

                } else {
                    //armazena os dados da conexao ao bd central nessas variaveis
                    SERVIDORSQL = (dr["servidor"].ToString()); 
                    USUARIOSQL = (dr["usuario"].ToString());
                    SENHASQL = (dr["senha"].ToString());
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                con.Close();
            }
        }
        private void ImportarDadosEmpresa() {

            // Definir os atributos da Conexão com o Connection String Builder
            SqlConnectionStringBuilder con = new SqlConnectionStringBuilder();


            // Definir os atributos da conexão       
            con.DataSource = SERVIDORSQL; // servidor
            con.UserID = USUARIOSQL; //usuario
            con.Password = SENHASQL; //senha
            con.InitialCatalog = "GERAL"; // nome da BD


            SqlConnection connection = new SqlConnection(con.ConnectionString);



            try // a conexão foi feita com sucesso?
            {
                // Criando o SqlCommand com um parâmetro
                SqlCommand cmd = new SqlCommand("select * from Empresa where idempresa=@idempresa ", connection);

                // Define as informações do parâmetro criado
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@idempresa";
                param.Value = 1;

                connection.Open(); // abre a conexão

                // Inserindo o parâmetro no comando
                cmd.Parameters.Add(param);

                // Executando o commando e obtendo o resultado
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();


                cnpj = dr["cnpj"].ToString();
                razaosocial = dr["razaosocial"].ToString();
                fantasia = dr["fantasia"].ToString();
                contato = dr["contato"].ToString();
                endereco = dr["endereco"].ToString();
                telefone = dr["telefone"].ToString();
                email = dr["email"].ToString();
                licenca = dr["licenca"].ToString();
                cidade = dr["estado"].ToString();
                estado = dr["cidade"].ToString();
                cep = dr["cep"].ToString();


            } catch (Exception) {

            } finally {
                // Fecha o datareader
                if (reader != null) {
                    reader.Close();
                }

                // Fecha a conexão
                if (conn != null) {

                    conn.Close();
                }
            }
        }
        private void ImportarLicenca() {

            // Definir os atributos da Conexão com o Connection String Builder
            SqlConnectionStringBuilder con = new SqlConnectionStringBuilder();


            // Definir os atributos da conexão       
            con.DataSource = SERVIDORSQL; // servidor
            con.UserID = USUARIOSQL; //usuario
            con.Password = SENHASQL; //senha
            con.InitialCatalog = "GERAL"; // nome da BD


            SqlConnection connection = new SqlConnection(con.ConnectionString);



            try // a conexão foi feita com sucesso?
            {
                // Criando o SqlCommand com um parâmetro
                SqlCommand cmd = new SqlCommand("select * from Licenca where idlicenca=@idlicenca ", connection);

                // Define as informações do parâmetro criado
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@idlicenca";
                param.Value = 1;

                connection.Open(); // abre a conexão

                // Inserindo o parâmetro no comando
                cmd.Parameters.Add(param);

                // Executando o commando e obtendo o resultado
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();


                licenca = dr["licenca"].ToString();

            } catch (Exception) {

            } finally {
                // Fecha o datareader
                if (reader != null) {
                    reader.Close();
                }

                // Fecha a conexão
                if (conn != null) {

                    conn.Close();
                }
            }
        }
        private void carregarBDEmpresaLocal() {
            strMySQL = "update mercado.empresa set cnpj=@cnpj, razaosocial=@razaosocial, fantasia=@fantasia, contato=@contato, endereco=@endereco, cidade=@cidade, estado=@estado, cep=@cep, telefone=@telefone, email=@email, licenca=@licenca where idempresa='" + 1 + "'";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            comando.Parameters.AddWithValue("@cnpj", cnpj);
            comando.Parameters.AddWithValue("@razaosocial", razaosocial);
            comando.Parameters.AddWithValue("@fantasia", fantasia);
            comando.Parameters.AddWithValue("@contato", contato);
            comando.Parameters.AddWithValue("@endereco", endereco);
            comando.Parameters.AddWithValue("@telefone", telefone);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@licenca", licenca);
            comando.Parameters.AddWithValue("@estado", cidade);
            comando.Parameters.AddWithValue("@cidade", estado);
            comando.Parameters.AddWithValue("@cep", cep);

            try {

                con.Open();
                comando.ExecuteNonQuery();

            } catch (Exception ex) {

            } finally {

                con.Close();

            }
        }
        private void consultaServidor() {
            strMySQL = "select * from mercado.configuracao where idconfig='" + 1 + "'";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            try {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows) {

                } else {
                    servidor = (dr["Script"].ToString());
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                con.Close();
            }
        }
        private void verificaServidor() {
            Ping pingSender = new Ping();
            byte[] data = Encoding.ASCII.GetBytes("test");
            int timeout = 100;
            PingReply reply = pingSender.Send(servidor, timeout, data);

            if (reply.Status == IPStatus.Success) {
                carregarBDEmpresaLocal();

            } else {              

            }
        }





        private void Start_Load(object sender, EventArgs e) {
            inicioAsync();
            criarPastaSistema();
            consultaServidor();


        }

        private void button2_Click(object sender, EventArgs e) {
            // frmVendas form1 = new frmVendas();
            // form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) {
            frmConfiguraPDV form = new frmConfiguraPDV();
            form.Show();
        }
    }
}
