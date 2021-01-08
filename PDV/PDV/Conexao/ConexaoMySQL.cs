using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PDV.Conexao {
    class ConexaoMySQL {

        // vamos nos conectar a base da dados ,msql
        private static string connString = "server=localhost;User Id=root; password=123456";

        // representa a conexão com o banco
        private static MySqlConnection conn = null;

        // método que permite obter a conexão
        public static MySqlConnection obterConexao() {
            // vamos criar a conexão
            conn = new MySqlConnection(connString);

            // a conexão foi feita com sucesso?
          /*  try {
                // abre a conexão e a devolve ao chamador do método
                conn.Open();
            } catch (MySqlException sqle) {
                conn = null;
                // colocar futuramente um log
            }
           */
            return conn;
        }

        public static void fecharConexao() {
            if (conn != null) {
                conn.Close();
            }
        }
    }
}

