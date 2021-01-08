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
    public partial class frmConsultaPreco : Form {
        public frmConsultaPreco() {
            InitializeComponent();
        }

        MySqlConnection con = Conexao.ConexaoMySQL.obterConexao();
        private string strMySQL;

        private void ConsultarProduto() {
            strMySQL = "select * from mercado.produtos where CodBarra='" + txtCod.Text + "'";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            try {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows) {
                    txtNome.Text = "Produto não encontrado";

                    txtCod.Clear();
                    txtCod.Focus();
                    txtPreco.Clear();
                } else {
                    string precounitario = dr["Preco"].ToString();
                    txtPreco.Text = Convert.ToDecimal(precounitario).ToString("N");
                    txtNome.Text = dr["Nome"].ToString();


                    txtCod.Clear();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                con.Close();
            }
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            //Executa ao teclar Enter
            if (Convert.ToInt32(e.KeyChar) == 13) {


                ConsultarProduto();


            } else {
                txtCod.Focus();
            }


            //Permite numero e virgula no txtcod
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) {
                e.Handled = true;
            }
        }

        private void frmConsultaPreco_Load(object sender, EventArgs e) {
            txtNome.Text = "Digite o código do produto";
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                this.Close();
            } catch (Exception ex) {
                this.Close();
            }
        }
    }
}

