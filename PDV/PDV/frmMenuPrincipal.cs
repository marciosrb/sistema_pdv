using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using PDV;

namespace PDV {
    public partial class frmMenuPrincipal : Form {
        public frmMenuPrincipal() {
            InitializeComponent();
        }
        MySqlConnection con = Conexao.ConexaoMySQL.obterConexao();
        private string strMySQL;
        public static string Operador;
        public static string Supervisor;

        public void AlterarVisibilidade() {
        }
        private void CarregaSupervisor() {
            string nome = login.nomelogin;

            MySqlCommand cmd = new MySqlCommand(strMySQL, con);
            cmd.CommandText = "select * from mercado.usuario where login = @login ";
            cmd.Parameters.AddWithValue("@login", nome);

            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader;
            con.Open();

            reader = cmd.ExecuteReader();
            try {
                if (!reader.Read()) {


                } else {
                    lblLogin.ForeColor = Color.White;
                    lblLogin.Text = reader["nome"].ToString();
                    Supervisor = reader["nome"].ToString();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                con.Close();
            }
        }
        private void CarregaLicenca() {


            MySqlCommand cmd = new MySqlCommand(strMySQL, con);
            cmd.CommandText = "select * from mercado.empresa where idempresa = @idempresa ";
            cmd.Parameters.AddWithValue("@idempresa", 1);

            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader;
            con.Open();

            reader = cmd.ExecuteReader();
            try {
                if (!reader.Read()) {


                } else {
                    lblLicenca.ForeColor = Color.White;
                    lblLicenca.Text = reader["licenca"].ToString();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                con.Close();
            }
        }
        private void CarregaOperador() {
            string aberto = "ABERTO";

            strMySQL = "select * from mercado.aberturacaixa where statuscaixa ='" + aberto + "'";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);
            try {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows) {
                    lblOperador.Text = "Caixa Fechado";
                } else {
                    lblOperador.ForeColor = Color.White;
                    lblOperador.Text = dr["operador"].ToString();
                    Operador = dr["operador"].ToString();

                }
            } catch (Exception ex) {

            } finally {
                con.Close();
            }
        }

        private void VerificaCaixa() //verifica se o caixa esta aberto ou fechado
        {
            string aberto = "ABERTO";

            strMySQL = "select * from mercado.aberturacaixa where statuscaixa ='" + aberto + "'";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);
            try {
              
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows) {

                    frmAbrirCaixa form2 = new frmAbrirCaixa();
                    form2.Show();
                } else {

                    DateTime dataabertura = Convert.ToDateTime(dr["data"].ToString());
                    DateTime dataatual = DateTime.Now;



                    if (dataabertura.Date < dataatual.Date) {
                        MessageBox.Show("Movimento de caixa da data de: (" + dataabertura + ") ainda está em aberto. Para prosseguir, feche o movimento anterior e abra um novo! ", "Fechar movimento anterior", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    } else {
                        // Verifica se o formulário está aberto. Caso estiver aberto, o COUNT será maior que 0 (zero)
                        if (Application.OpenForms.OfType<frmFundoPDV>().Count() > 0) {

                        } else {

                            //Chamando o Caixa(Confirmação)
                            frmFundoPDV f3 = new frmFundoPDV(this);
                            f3.ShowDialog();
                        }
                    }




                }
            } catch (Exception ex) {

            } finally {
                con.Close();
            }
        }


        private void FundoTelas_Load(object sender, EventArgs e) {
            CarregaOperador();
            Data.Start();
            CarregaSupervisor();
            CarregaLicenca();



        }
        private void janela_Paint(object sender, PaintEventArgs e) {

        }

        private void painel1_Paint(object sender, PaintEventArgs e) {

        }

        private void btnabrefecha_Click(object sender, EventArgs e) {
            // Verifica se o formulário está aberto. Caso estiver aberto, o COUNT será maior que 0 (zero)
            if (Application.OpenForms.OfType<frmCaixa>().Count() > 0) {

            } else {
                //Chamando o Caixa(Confirmação)
                frmCaixa f2 = new frmCaixa(this);
                f2.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            VerificaCaixa();
        }

        private void Carregaopera_Tick(object sender, EventArgs e) {
            CarregaOperador();
        }

        private void frmMenuPrincipal_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.A) {
                VerificaCaixa();
            }

            if (e.KeyCode == Keys.T) {
                btnTrocarUsuario.PerformClick();
            }


            if (e.KeyCode == Keys.M) {
                btnMovimento.PerformClick();
            }

            if (e.KeyCode == Keys.P) {
                frmConsultaPreco form = new frmConsultaPreco();
                form.Show();
            }

            if (e.KeyCode == Keys.S) {
                btnSairSistema.PerformClick();
            }

        }
        private void btnMovimento_KeyUp(object sender, KeyEventArgs e) {
        }

        private void Data_Tick(object sender, EventArgs e) {
            lblData.Text = DateTime.Now.ToString();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void lblLogin_Click(object sender, EventArgs e) {

        }

        private void btnSairSistema_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnTrocarUsuario_Click(object sender, EventArgs e) {
            this.Hide();
            login abrir = new login();
            abrir.ShowDialog();

        }




        private void btnDesligar_Click(object sender, EventArgs e) {
            var dls = new ProcessStartInfo("shutdown", "/s /t 0");
            dls.CreateNoWindow = true;
            dls.UseShellExecute = false;
            Process.Start(dls);
        }

        private void button1_Click_1(object sender, EventArgs e) {
            var dlsa = new ProcessStartInfo("shutdown", "/r /t 0"); // the argument /r is to restart the computer
            dlsa.CreateNoWindow = true;
            dlsa.UseShellExecute = false;
            Process.Start(dlsa);
        }
    }
}

