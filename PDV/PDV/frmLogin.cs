

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using PDV;
using MySql.Data.MySqlClient;

namespace PDV {
    public partial class login : Form {


        public login() {

            InitializeComponent();
            this.IsNewLogged = false;
        }

        public bool IsNewLogged { get; protected set; }



        MySqlConnection con = Conexao.ConexaoMySQL.obterConexao();
        private string strMySQL;

        public static string usuarioConectado;
        public static string Codigo = "";
        public static string dataexp;
        public static string nomelogin;

        private void Login_Load(object sender, EventArgs e) {

        }
        private void Button1_Click_2(object sender, EventArgs e) {

            MySqlCommand cmd = new MySqlCommand(strMySQL, con);
            cmd.CommandText = "select * from mercado.usuario where login = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", txtlogin.Text);
            cmd.Parameters.AddWithValue("@senha", txtsenha.Text);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader;
            con.Open();

            reader = cmd.ExecuteReader();
            try {
                if (!reader.Read()) {
                    txtmensagem.Text = "Usuario ou senha incorretos!";
                    txtlogin.Clear();
                    txtsenha.Clear();
                    txtlogin.Focus();

                } else {
                    nomelogin = txtlogin.Text;
                    this.Hide();


                    frmMenuPrincipal novoFormulario = new frmMenuPrincipal();
                    novoFormulario.ShowDialog();

                    if (novoFormulario.IsDisposed)
                        Close();

                    this.IsNewLogged = true;
                    this.Dispose();

                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                con.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e) {
            frmConfiguraPDV form = new frmConfiguraPDV();
            form.Show();
        }
    }
}

