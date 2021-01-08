using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV {
    public partial class frmImportarCarga : Form {
        public frmImportarCarga() {
            InitializeComponent();
        }

        MySqlConnection con = Conexao.ConexaoMySQL.obterConexao();
        private string strMySQL;

        private void LimparTabelaProdutos() {
            strMySQL = "TRUNCATE mercado.produtos";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

           con.Open();
            comando.Connection = con;
            {
                comando.ExecuteNonQuery();
            }
            con.Close();

        }
        private async Task cadastraAsync(string produtoid, string nome, string preco, string quantidade, string codbarra, string tipo) {

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

            await Task.Delay(5000);
            this.Close();

        }
        private void ImportarProdutos() {
            
            LimparTabelaProdutos();

            using (StreamReader fluxotexto = new StreamReader(Conexao.ConexaoTabelaItens.caminho))

                while (true) {

                    string linhatexto = fluxotexto.ReadLine();

                    if (linhatexto == null) {

                        break;

                    }


                    string[] quebra = linhatexto.Split(new Char[] { ',' });


                    cadastraAsync(quebra[0], quebra[1], quebra[2], quebra[3], quebra[4], quebra[5]);
                }


        }
        private void ImportandoProdutos_Load(object sender, EventArgs e) {
            ImportarProdutos();

        }
    }
}
