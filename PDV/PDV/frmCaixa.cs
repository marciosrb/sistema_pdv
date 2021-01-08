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
    public partial class frmCaixa : Form {
        frmMenuPrincipal form;
        public frmCaixa(frmMenuPrincipal f) {
            InitializeComponent();
            form = f;
        }

        string STATUSCAIXA;
        string Operador;
        string DataAbertura;
        public static string IDCAIXA;
        public static string VALORSANGRIA;
        string ENTRADASOMENTEDINHEIRO;
        public static string ENTRADATOTALDINHEIRO;
        public static string SALDOINICIAL;
        string SAIDADINHEIRO;

        //fechamento
        public static string IDCAIXAFECHAMENTO; //idcaixa
        public static string SALDOINICIALFECHAMENTO;
        public static string ENTRADADINHEIROFECHAMENTO;
        public static string ENTRADACREDITOFECHAMENTO;
        public static string ENTRADADEBITOFECHAMENTO;
        public static string VALORFECHAMENTODINHEIRO;
        public static string SANGRIAFECHAMENTO;
        public static string DINHEIROGAVETAFECHAMENTO;
        public static string OPERADORFECHAMENTO;
        public static string SUPERVISORFECHAMENTO;
        public static string DATAFECHAMENTO;
        public static string OBSERVACAO;




        MySqlConnection con = Conexao.ConexaoMySQL.obterConexao();
        private string strMySQL;

        private void CalculoValorDinheiro() {
            string saldoentrada1 = Convert.ToDecimal(lblSaldoInicial.Text).ToString("N");
            string saldoentrada = Convert.ToDecimal(lblSaldoDinheiro.Text).ToString("N");
            string saldosaida = Convert.ToDecimal(lblSaida.Text).ToString("N");


            decimal saldoinicial = Convert.ToDecimal(saldoentrada1);
            decimal saldodinheiro = Convert.ToDecimal(saldoentrada);
            decimal saidasangria = Convert.ToDecimal(saldosaida);

            decimal soma = saldoinicial + saldodinheiro;
            decimal saida = soma - saidasangria;


            lblsomentedinheiro.Text = Convert.ToDecimal(saida).ToString("N");
            VALORSANGRIA = Convert.ToDecimal(saida).ToString("N");

        }
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
                    lblidcaixa.Visible = true;
                    lblcaixa.Visible = true;

                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
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
            comando.Parameters.AddWithValue("@fechamento", txtvalor.Text);
            comando.Parameters.AddWithValue("@operador", cbooperador.SelectedItem);
            comando.Parameters.AddWithValue("@valorabertura", txtvalor.Text);
            comando.Parameters.AddWithValue("@statuscaixa", "ABERTO");
            comando.Parameters.AddWithValue("@data", DateTime.Now);
            comando.Parameters.AddWithValue("@observacao", "Aberto às " + hora + ":" + minuto + " pelo fiscal: " + supervisor);
            lbldataabertura.Text = (DateTime.Now).ToString();


            try {
                String x = "";
                for (int i = 0; i <= txtvalor.Text.Length - 1; i++) {
                    if ((txtvalor.Text[i] >= '0' &&
                        txtvalor.Text[i] <= '9') ||
                        txtvalor.Text[i] == ',') {
                        x += txtvalor.Text[i];
                    }
                }
                txtvalor.Text = x;
                txtvalor.SelectAll();

                con.Open();
                txtstatus.Text = "Caixa Aberto";
                txtstatus.BackColor = Color.GreenYellow;
                pctStatus.BackColor = Color.GreenYellow;
                lbldataabertura.Visible = true;
                lbltextodataehora.Visible = true;
                btnabrircaixa.Enabled = false;
                txtvalor.Enabled = false;
                cbooperador.Enabled = false;
                txtobservacao.Text = "Aberto às " + hora + ":" + minuto + " por " + "teste";
                pctcentral.Visible = true;
                grcentral.Visible = true;
                lblidcaixa.Visible = true;
                lblcaixa.Visible = true;




                comando.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                InserirAbertura();
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
                    lblidcaixa.Text = (dr["idabertura"].ToString());
                    STATUSCAIXA = (dr["statuscaixa"].ToString());
                    txtobservacao.Text = (dr["observacao"].ToString());
                    lbldataabertura.Text = (dr["data"].ToString());
                    DataAbertura = (dr["data"].ToString());
                    txtvalor.Text = (dr["valorabertura"].ToString());
                    cbooperador.Text = (dr["operador"].ToString());
                    Operador = (dr["operador"].ToString());
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                CaixaFechado();
                con.Close();
            }
        }
        private void CaixaFechado() {
            string statuscaixa = STATUSCAIXA;
            string aberto = "ABERTO";

            if (statuscaixa == aberto) {
                txtstatus.Text = "Caixa Aberto";
                txtstatus.BackColor = Color.GreenYellow;
                pctStatus.BackColor = Color.GreenYellow;
                lbldataabertura.Visible = true;
                lbltextodataehora.Visible = true;
                btnabrircaixa.Enabled = false;
                txtvalor.Enabled = false;
                cbooperador.Enabled = false;
                btnSangria.Enabled = true;
                btnFechamento.Enabled = true;

            } else {
                txtobservacao.Clear();
                txtstatus.Text = "Caixa Fechado";
                txtstatus.ForeColor = Color.White;
                txtstatus.BackColor = Color.Red;
                pctStatus.BackColor = Color.Red;
                lbldataabertura.Visible = false;
                lbltextodataehora.Visible = false;
                btnabrircaixa.Enabled = true;
                txtvalor.Enabled = true;
                cbooperador.Enabled = true;
                txtvalor.Clear();
                cbooperador.Select();
                lblSaldoDinheiro.Text = "0,00";
                lblSaldoCredito.Text = "0,00";
                lblSaldoDebito.Text = "0,00";
                lblsomentedinheiro.Text = "0,00";
                btnSangria.Enabled = false;
                btnFechamento.Enabled = false;



            }
        } //
        private void NomearDataGrid() {
            dtvVenda.ColumnCount = 5;
            dtvVenda.Columns[0].Name = "Data / Hora";
            dtvVenda.Columns[0].Width = 130;
            dtvVenda.Columns[1].Name = "Descrição";
            dtvVenda.Columns[1].Width = 130;
            dtvVenda.Columns[2].Name = "Entrada";
            dtvVenda.Columns[2].Width = 70;
            dtvVenda.Columns[3].Name = "Saida";
            dtvVenda.Columns[3].Width = 70;
            dtvVenda.Columns[4].Name = "Forma de Pagto.";
            dtvVenda.Columns[4].Width = 120;


        }
        private void InserirAbertura() {
            strMySQL = "insert into mercado.movimentocaixa(Data, Descricao, Entrada, Saida, FormaPagto, Operador, Observacao, idcaixa) value (@Data, @Descricao, @Entrada, @Saida, @FormaPagto, @Operador, @Observacao, @idcaixa)";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            string valorabertura = Convert.ToDecimal(txtvalor.Text).ToString("N");
            string valor = valorabertura.Replace(',', '.');

            comando.Parameters.AddWithValue("@Data", DateTime.Now);
            comando.Parameters.AddWithValue("@Descricao", "SALDO INICIAL");
            comando.Parameters.AddWithValue("@Entrada", valor);
            comando.Parameters.AddWithValue("@Saida", "0,00");
            comando.Parameters.AddWithValue("@FormaPagto", "Dinheiro/Suprimento");
            comando.Parameters.AddWithValue("@Operador", cbooperador.Text);
            comando.Parameters.AddWithValue("@Observacao", txtobservacao.Text);


            comando.Parameters.AddWithValue("@idcaixa", Convert.ToString(Convert.ToInt32(IDCAIXA) + 1));

            try {

                comando.ExecuteNonQuery();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                CarregaIDCaixa();
            }


        }

        private void SomatorioTotal() {
            decimal total = 0;
            foreach (DataGridViewRow row in dtvVenda.Rows) {
                if (!string.IsNullOrEmpty(Convert.ToString(row.Cells["Entrada"].Value)))
                    total += Convert.ToDecimal(row.Cells["Entrada"].Value);
            }

            lblValorTotal.Text = Convert.ToDouble(total).ToString("N");
        }
        private void SomaEntradaDinheiro() {
            string statuscaixa = STATUSCAIXA;
            string aberto = "ABERTO";

            if (statuscaixa == aberto) {
                DateTime dateAndTime = Convert.ToDateTime(DataAbertura);
                string data1 = (dateAndTime.ToString("dd/MM/yyyy"));


                string TipoPagamento = "Dinheiro";

                strMySQL = "Select sum(Entrada) as Valor from mercado.movimentocaixa Where FormaPagto ='" + TipoPagamento + "' && idcaixa ='" + IDCAIXA + "'";
                MySqlCommand comando = new MySqlCommand(strMySQL, con);

                try {
                    con.Open();
                    MySqlDataReader dr = comando.ExecuteReader();
                    dr.Read();

                    {


                        if (dr.HasRows) {

                            var valordinheiro = "0";
                            dr.Read();

                            valordinheiro = dr.GetString("Valor").ToString();
                            lblSaldoDinheiro.Text = Convert.ToDouble(valordinheiro).ToString("N");
                            ENTRADASOMENTEDINHEIRO = Convert.ToDouble(valordinheiro).ToString("N");
                        }
                    }
                } catch { } finally {
                    con.Close();
                }

            } else {
                lblSaldoDinheiro.Text = "0,00";
                lblSaldoCredito.Text = "0,00";
                lblSaldoDebito.Text = "0,00";
            }



        }
        private void SomaTotalDinheiro() {
            decimal entradadinheiro = Convert.ToDecimal(ENTRADASOMENTEDINHEIRO);
            decimal valorinicial = Convert.ToDecimal(SALDOINICIAL);
            decimal valorsomentedinheiro = entradadinheiro + valorinicial;
            decimal saidadinheiro = Convert.ToDecimal(SAIDADINHEIRO);
            decimal calculototaldinheiro = valorsomentedinheiro - saidadinheiro;
            ENTRADATOTALDINHEIRO = Convert.ToDecimal(calculototaldinheiro).ToString("N");
        }
        private void SomaSaidaDinheiro() {
            string statuscaixa = STATUSCAIXA;
            string aberto = "ABERTO";

            if (statuscaixa == aberto) {
                DateTime dateAndTime = Convert.ToDateTime(DataAbertura);
                string data1 = (dateAndTime.ToString("dd/MM/yyyy"));


                string TipoPagamento = "Dinheiro";

                strMySQL = "Select sum(Saida) as Valor from mercado.movimentocaixa Where FormaPagto ='" + TipoPagamento + "' && idcaixa ='" + IDCAIXA + "'";
                MySqlCommand comando = new MySqlCommand(strMySQL, con);

                try {
                    con.Open();
                    MySqlDataReader dr = comando.ExecuteReader();
                    dr.Read();

                    {


                        if (dr.HasRows) {

                            var valordinheiro = "0";
                            dr.Read();

                            valordinheiro = dr.GetString("Valor").ToString();
                            lblSaida.Text = Convert.ToDouble(valordinheiro).ToString("N");
                            string valorzero = "0,00";


                            decimal valorsaida = Convert.ToDecimal(lblSaida.Text);
                            decimal zero = Convert.ToDecimal(valorzero);
                            if (valorsaida > zero) {
                                lblmensagemsaida.Text = "SAIDAS/SANGRIAS EM DINHEIRO";
                            }


                        }
                    }
                } catch { } finally {
                    con.Close();
                }

            } else {
                lblSaldoDinheiro.Text = "0,00";
                lblSaldoCredito.Text = "0,00";
                lblSaldoDebito.Text = "0,00";
                lblsomentedinheiro.Text = "0,00";
            }



        }
        private void SomaEntradaCredito() {
            string statuscaixa = STATUSCAIXA;
            string aberto = "ABERTO";

            if (statuscaixa == aberto) {
                DateTime dateAndTime = Convert.ToDateTime(DataAbertura);
                string data1 = (dateAndTime.ToString("dd/MM/yyyy"));


                string TipoPagamento = "Crédito";

                strMySQL = "Select sum(Entrada) as Valor from mercado.movimentocaixa Where FormaPagto ='" + TipoPagamento + "' && idcaixa ='" + IDCAIXA + "'";
                MySqlCommand comando = new MySqlCommand(strMySQL, con);

                try {
                    con.Open();
                    MySqlDataReader dr = comando.ExecuteReader();
                    dr.Read();

                    {


                        if (dr.HasRows) {

                            var valorcredito = "0";
                            dr.Read();

                            valorcredito = dr.GetString("Valor").ToString();
                            lblSaldoCredito.Text = Convert.ToDouble(valorcredito).ToString("N");
                        }
                    }
                } catch { } finally {
                    con.Close();
                }

            } else {
                lblSaldoDinheiro.Text = "0,00";
                lblSaldoCredito.Text = "0,00";
                lblSaldoDebito.Text = "0,00";
            }



        }
        private void SomaEntradaDebito() {

            string statuscaixa = STATUSCAIXA;
            string aberto = "ABERTO";

            if (statuscaixa == aberto) {
                DateTime dateAndTime = Convert.ToDateTime(DataAbertura);
                string data1 = (dateAndTime.ToString("dd/MM/yyyy"));


                string TipoPagamento = "Débito";

                strMySQL = "Select sum(Entrada) as Valor from mercado.movimentocaixa Where FormaPagto ='" + TipoPagamento + "' && idcaixa ='" + IDCAIXA + "'";
                MySqlCommand comando = new MySqlCommand(strMySQL, con);

                try {
                    con.Open();
                    MySqlDataReader dr = comando.ExecuteReader();
                    dr.Read();

                    {


                        if (dr.HasRows) {

                            var valorcredito = "0";
                            dr.Read();

                            valorcredito = dr.GetString("Valor").ToString();
                            lblSaldoDebito.Text = Convert.ToDouble(valorcredito).ToString("N");
                        }
                    }
                } catch { } finally {
                    con.Close();
                }

            } else {
                lblSaldoDinheiro.Text = "0,00";
                lblSaldoCredito.Text = "0,00";
                lblSaldoDebito.Text = "0,00";
            }




        }

        private void CarregaSaldoInicial() {
            string statuscaixa = STATUSCAIXA;
            string aberto = "ABERTO";
            string saldoinicial = "SALDO INICIAL";
            SALDOINICIAL = "0,00";


            if (statuscaixa == aberto) {

                DateTime dateAndTime = Convert.ToDateTime(DataAbertura);
                string data1 = (dateAndTime.ToString("dd/MM/yyyy"));

                strMySQL = "select * from mercado.movimentocaixa where idcaixa ='" + IDCAIXA + "' && Descricao = '" + saldoinicial + "'";
                MySqlCommand comando = new MySqlCommand(strMySQL, con);

                try {
                    con.Open();

                    MySqlDataReader result = comando.ExecuteReader();


                    while (result.Read()) {

                        string valor = result["Entrada"].ToString();

                        lblSaldoInicial.Text = valor.Replace('.', ',').ToString();
                        // SALDOINICIAL = valor.Replace('.', ',').ToString(); agora

                    }


                } catch (Exception ex) {
                    // MessageBox.Show(ex.Message);
                } finally {
                    con.Close();
                    SomaTotalDinheiro();
                }

            } else {


            }
        }
        private void CarregaOperador() {


            strMySQL = "select * from mercado.operador";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            try {

                MySqlDataAdapter da = new MySqlDataAdapter(strMySQL, con);
                DataTable dtResultado = new DataTable();
                dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
                cbooperador.DataSource = null;
                da.Fill(dtResultado);
                cbooperador.DataSource = dtResultado;

                cbooperador.DisplayMember = "nome";
                cbooperador.SelectedItem = "";
                cbooperador.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.


            } catch (Exception ex) {
                // MessageBox.Show(ex.Message);
            } finally {
                con.Close();

            }




        }
        private void CarregaDataGrid() {
            dtvVenda.Rows.Clear();

            string statuscaixa = STATUSCAIXA;
            string aberto = "ABERTO";


            if (statuscaixa == aberto) {

                DateTime dateAndTime = Convert.ToDateTime(DataAbertura);
                string data1 = (dateAndTime.ToString("dd/MM/yyyy"));

                strMySQL = "select * from mercado.movimentocaixa where DAY(Data) ='" + data1 + "' && Operador = '" + Operador + "'";
                MySqlCommand comando = new MySqlCommand(strMySQL, con);

                try {
                    con.Open();

                    MySqlDataReader result = comando.ExecuteReader();

                    // Percorro as linhas retornadas e populo o datagridview

                    while (result.Read()) {
                        string entrada = result["Entrada"].ToString();
                        string valorentrada = entrada.Replace('.', ',');


                        string data = result["Data"].ToString();
                        string descricao = result["Descricao"].ToString();
                        string saida = result["Saida"].ToString();
                        string valorsaida = saida.Replace('.', ',');

                        string formapagto = result["FormaPagto"].ToString();




                        dtvVenda.Rows.Add(data, descricao, valorentrada, valorsaida, formapagto);

                        //  comando.ExecuteNonQuery();


                    }


                } catch (Exception ex) {
                    // MessageBox.Show(ex.Message);
                } finally {
                    con.Close();
                }


            } else {


            }

        }
        public bool VerificarOperador(int v) {
            DateTime dateAndTime = Convert.ToDateTime(DataAbertura);
            string operador = cbooperador.Text;

            strMySQL = "select * from mercado.aberturacaixa where operador ='" + operador + "'";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            con.Open();
            return Convert.ToBoolean(comando.ExecuteScalar());

        } //verifica se já foi aberto caixa com operador informado
        private void VerificaOperador() {
            if (VerificarOperador(1) == true) {
                MessageBox.Show("Caixa já foi aberto com o operador informado!", "Caixa já aberto com operador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            } else {
                con.Close();
                AberturaCaixa();

            }
        } //informa o usario sobre o operador aberto

        private void Caixa_Load(object sender, EventArgs e) {
            VerificaCaixa();
            NomearDataGrid();
            TimerCarregaDataGRid.Start();
            CarregaDataGrid();
            CarregaSaldoInicial();
            SomaEntradaDinheiro();
            SomaEntradaCredito();
            SomaEntradaDebito();
            SomatorioTotal();
            CarregaIDCaixa();
            SomaSaidaDinheiro();
            CalculoValorDinheiro();
            txtvalor.Focus();
            CarregaOperador();

        }

        private void Caixa_FormClosing(object sender, FormClosingEventArgs e) {
            form.AlterarVisibilidade();
        }

        private void button1_Click_1(object sender, EventArgs e) {
            VerificaOperador();
        }


        private void btnsaircaixa_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void dtvVenda_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void TimerDatagrid_Tick(object sender, EventArgs e) {

        }

        private void button1_Click_2(object sender, EventArgs e) {
            CarregaDataGrid();
        }

        private void TimerCarregaDataGRid_Tick(object sender, EventArgs e) {
            // CarregaDataGrid();            
            CarregaSaldoInicial();
            SomaEntradaDinheiro();
            SomaEntradaCredito();
            SomaEntradaDebito();
            SomatorioTotal();
            SomaSaidaDinheiro();
            CalculoValorDinheiro();
        }

        private void button1_Click_3(object sender, EventArgs e) {
            CarregaDataGrid();
            CarregaSaldoInicial();


        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void txtvalor_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
                 (e.KeyChar != ',' && e.KeyChar != '.' &&
                  e.KeyChar != (Char)13 && e.KeyChar != (Char)8)) {
                e.KeyChar = (Char)0;
            } else {
                if (e.KeyChar == '.' || e.KeyChar == ',') {
                    if (!txtvalor.Text.Contains(',')) {
                        e.KeyChar = ',';
                    } else {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                this.Close();
            } catch (Exception ex) {
                this.Close();
            }
        }

        private void btnSangria_Click(object sender, EventArgs e) {
            frmSangria form = new frmSangria();
            form.Show();
        }

        private void frmCaixa_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.S) {
                btnSangria.PerformClick();
            }
            if (e.KeyCode == Keys.F) {
                btnFechamento.PerformClick();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e) {

        }

        private void btnFechamento_Click(object sender, EventArgs e) {
            VALORFECHAMENTODINHEIRO = lblsomentedinheiro.Text;
            IDCAIXAFECHAMENTO = lblidcaixa.Text;


            IDCAIXAFECHAMENTO = lblidcaixa.Text;
            SALDOINICIALFECHAMENTO = lblSaldoInicial.Text;
            ENTRADADINHEIROFECHAMENTO = lblSaldoDinheiro.Text;
            ENTRADACREDITOFECHAMENTO = lblSaldoCredito.Text;
            ENTRADADEBITOFECHAMENTO = lblSaldoDebito.Text;

            SANGRIAFECHAMENTO = lblSaida.Text;

            OPERADORFECHAMENTO = cbooperador.Text;
            SUPERVISORFECHAMENTO = frmMenuPrincipal.Supervisor;

            OBSERVACAO = "";





            frmFechamento form = new frmFechamento();
            form.Show();
        }
    }
}
