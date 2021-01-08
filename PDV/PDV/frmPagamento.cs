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
    public partial class frmPagamento : Form {
        public frmPagamento() {
            InitializeComponent();
        }
        public string txtpagamentodinheiro { get; set; }
        public string txtpagamentocredito { get; set; }
        public string txtpagamentodebito { get; set; }

        public string txttroco { get; set; }

        MySqlConnection con = Conexao.ConexaoMySQL.obterConexao();
        private string strMySQL;

        public static string TIPO;
        public static string IDCAIXA;
        string VALORTOTALRECEBIDO;
        string PAGDINHEIRO;
        string PAGCREDITO;
        string PAGDEBITO;
        string TXTTROCO;
        string PAGAMDINHEIRO;

        private void InserirMovimento() {
            InserirPagamentoDinheiro();
            InserirPagamentoCredito();
            InserirPagamentoDebito();
        }
        private void InserirPagamentoDinheiro() {
            decimal valordinheiro = Convert.ToDecimal(PAGDINHEIRO);
            decimal valor1 = Convert.ToDecimal("0,00");
            if (valordinheiro > valor1) {

                strMySQL = "insert into mercado.movimentocaixa(Data, Descricao, Entrada, Saida, FormaPagto, Operador, Observacao, idcaixa) value (@Data, @Descricao, @Entrada, @Saida, @FormaPagto, @Operador, @Observacao, @idcaixa)";
                MySqlCommand comando = new MySqlCommand(strMySQL, con);

                try {
                    if (con.State == ConnectionState.Closed) {
                        con.Open();
                    }

                    {
                        string dinheiro = PAGDINHEIRO;
                        string dinheiro1 = dinheiro.Replace(".", "");
                        string dinheiro2 = dinheiro1.Replace(',', '.');
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@Data", DateTime.Now);
                        comando.Parameters.AddWithValue("@Descricao", "Cupom Nº" + frmVendas.NUMEROCUPOM);
                        comando.Parameters.AddWithValue("@Entrada", dinheiro2);
                        comando.Parameters.AddWithValue("@Saida", "0,00");
                        comando.Parameters.AddWithValue("@FormaPagto", "Dinheiro");
                        comando.Parameters.AddWithValue("@Operador", frmMenuPrincipal.Operador);
                        comando.Parameters.AddWithValue("@Observacao", "");
                        comando.Parameters.AddWithValue("@idcaixa", frmVendas.IDCAIXA);


                        comando.ExecuteNonQuery();
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {

                }
            }

        }
        private void InserirPagamentoCredito() {
            decimal credito = Convert.ToDecimal(PAGCREDITO);
            decimal valor1 = Convert.ToDecimal("0,00");
            if (credito > valor1) {

                strMySQL = "insert into mercado.movimentocaixa(Data, Descricao, Entrada, Saida, FormaPagto, Operador, Observacao, idcaixa) value (@Data, @Descricao, @Entrada, @Saida, @FormaPagto, @Operador, @Observacao, @idcaixa)";
                MySqlCommand comando = new MySqlCommand(strMySQL, con);

                try {
                    if (con.State == ConnectionState.Closed) {
                        con.Open();
                    }
                    {
                        string valor = PAGCREDITO;
                        string var1 = valor.Replace(".", "");
                        string valorok = var1.Replace(',', '.');
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@Data", DateTime.Now);
                        comando.Parameters.AddWithValue("@Descricao", "Cupom Nº" + frmVendas.NUMEROCUPOM);
                        comando.Parameters.AddWithValue("@Entrada", valorok);
                        comando.Parameters.AddWithValue("@Saida", "0,00");
                        comando.Parameters.AddWithValue("@FormaPagto", "Crédito");
                        comando.Parameters.AddWithValue("@Operador", frmMenuPrincipal.Operador);
                        comando.Parameters.AddWithValue("@Observacao", "");
                        comando.Parameters.AddWithValue("@idcaixa", frmVendas.IDCAIXA);
                        comando.ExecuteNonQuery();
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {

                }
            }

        }
        private void InserirPagamentoDebito() {
            decimal debito = Convert.ToDecimal(PAGDEBITO);
            decimal valor1 = Convert.ToDecimal("0,00");
            if (debito > valor1) {

                strMySQL = "insert into mercado.movimentocaixa(Data, Descricao, Entrada, Saida, FormaPagto, Operador, Observacao, idcaixa) value (@Data, @Descricao, @Entrada, @Saida, @FormaPagto, @Operador, @Observacao, @idcaixa)";
                MySqlCommand comando = new MySqlCommand(strMySQL, con);

                try {
                    if (con.State == ConnectionState.Closed) {
                        con.Open();
                    }

                    {
                        string valor = PAGDEBITO;
                        string var1 = valor.Replace(".", "");
                        string valorok = var1.Replace(',', '.');
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@Data", DateTime.Now);
                        comando.Parameters.AddWithValue("@Descricao", "Cupom Nº" + frmVendas.NUMEROCUPOM);
                        comando.Parameters.AddWithValue("@Entrada", valorok);
                        comando.Parameters.AddWithValue("@Saida", "0,00");
                        comando.Parameters.AddWithValue("@FormaPagto", "Debito");
                        comando.Parameters.AddWithValue("@Operador", frmMenuPrincipal.Operador);
                        comando.Parameters.AddWithValue("@Observacao", "");
                        comando.Parameters.AddWithValue("@idcaixa", frmVendas.IDCAIXA);
                        comando.ExecuteNonQuery();
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {

                }
            }

        }
        private void VoltarTelaVenda() {

            decimal valordinheiro = Convert.ToDecimal("0,00");

            this.txtpagamentodinheiro = valordinheiro.ToString("N");
            this.txtpagamentocredito = valordinheiro.ToString("N");
            this.txtpagamentodebito = valordinheiro.ToString("N");
            this.DialogResult = DialogResult.OK;
        }

        private void PagamentoDinheiroo() {
            TIPO = "Dinheiro";
            frmInformarPagamento form = new frmInformarPagamento(); //Se não retornar OK (um botão cancelar por exemplo) não faz nada
            if (form.ShowDialog() == DialogResult.OK) {
                txtdinheiro.Text = Convert.ToDecimal(form.txtValor).ToString("N");
                txtdinheiro.Visible = true;
                lblrecebdinheiro.Visible = true;
                VALORTOTALRECEBIDO = form.txtValor;

                CalculaTroco();
            }
            //Se não retornar OK (um botão cancelar por exemplo) não faz nada
        }
        private void PagamentoCredito() {
            TIPO = "Crédito";
            frmInformarPagamento form = new frmInformarPagamento();
            if (form.ShowDialog() == DialogResult.OK) {
                decimal valorvenda = Convert.ToDecimal(lblValorVenda.Text);
                decimal valorpagocredito = Convert.ToDecimal(form.txtValor);

                if (valorvenda < valorpagocredito) {
                    MessageBox.Show("Valor pago não pode ser maior que o valor da venda!", "Pagamento incorreto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    txtcredito.Text = Convert.ToDecimal(form.txtValor).ToString("N");
                    txtcredito.Visible = true;
                    lblRecebCredito.Visible = true;
                    VALORTOTALRECEBIDO = form.txtValor;
                    CalculaTroco();

                }

            }
            //Se não retornar OK (um botão cancelar por exemplo) não faz nada
        }
        private void PagamentoDebito() {
            TIPO = "Débito";
            frmInformarPagamento form = new frmInformarPagamento();
            if (form.ShowDialog() == DialogResult.OK) {
                decimal valorvenda = Convert.ToDecimal(lblValorVenda.Text);
                decimal valorpagodebito = Convert.ToDecimal(form.txtValor);

                if (valorvenda < valorpagodebito) {
                    MessageBox.Show("Valor pago não pode ser maior que o valor da venda!", "Pagamento incorreto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {

                    txtdebito.Text = Convert.ToDecimal(form.txtValor).ToString("N");
                    txtdebito.Visible = true;
                    lblRecebDebito.Visible = true;
                    VALORTOTALRECEBIDO = form.txtValor;
                    CalculaTroco();

                }
            }

        }
        private void SomaPagamento() {
            decimal dinheiro = 0;
            decimal credito = 0;
            decimal debito = 0;


            dinheiro = Convert.ToDecimal(txtdinheiro.Text);
            credito = Convert.ToDecimal(txtcredito.Text);
            debito = Convert.ToDecimal(txtdebito.Text);
            double resultado = Convert.ToDouble(dinheiro) + Convert.ToDouble(credito) + Convert.ToDouble(debito); ;
            VALORTOTALRECEBIDO = resultado.ToString();
            lblValorPago.Text = resultado.ToString("N");
        }
        private void CalculaTroco() {
            SomaPagamento();
            CalculoInserirMovimento();
            decimal res = 0;
            decimal removersinal = 0;
            decimal positivo = 0;
            decimal negativo = 0;
            decimal sinal = -1;
            positivo = Convert.ToDecimal(lblValorVenda.Text);
            negativo = Convert.ToDecimal(VALORTOTALRECEBIDO);
            removersinal = positivo - negativo;
            res = removersinal * sinal;

            lblTroco.Text = Convert.ToString(res);
            TXTTROCO = Convert.ToString(res);

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
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {

                con.Close();
            }
        }
        private void CalculoInserirMovimento() {
            decimal dinheiro = 0;
            decimal credito = 0;
            decimal debito = 0;
            decimal valortotal = 0;

            dinheiro = Convert.ToDecimal(txtdinheiro.Text);
            credito = Convert.ToDecimal(txtcredito.Text);
            //string credito1 = credito.Replace(',', '.');
            debito = Convert.ToDecimal(txtdebito.Text);
            //string qdebito1 = debito.Replace(',', '.');
            valortotal = Convert.ToDecimal(lblValorVenda.Text);
            double resultado = Convert.ToDouble(dinheiro) + Convert.ToDouble(credito) + Convert.ToDouble(debito);
            VALORTOTALRECEBIDO = resultado.ToString();
            lblValorPago.Text = resultado.ToString("N");
            double soma = Convert.ToDouble(credito) + Convert.ToDouble(debito);
            double res = Convert.ToDouble(valortotal) - Convert.ToDouble(soma);
            // string res1 = res.Replace(',', '.');

            PAGDINHEIRO = res.ToString("N");
            PAGCREDITO = credito.ToString("N");
            PAGDEBITO = debito.ToString("N");
        }

        private void Pagamento_Load(object sender, EventArgs e) {
            lblValorVenda.Text = frmVendas.VALORVENDA;
            CarregaIDCaixa();
        }

        private void button1_Click(object sender, EventArgs e) {

            PagamentoDinheiroo();


        }

        private void label4_TextChanged(object sender, EventArgs e) {

        }


        private void button2_Click(object sender, EventArgs e) {
            PagamentoCredito();
        }

        private void button3_Click(object sender, EventArgs e) {
            PagamentoDebito();
        }


        private void Pagamento_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.A) {
                PagamentoDinheiroo();
            }
            if (e.KeyCode == Keys.B) {
                PagamentoCredito();
            }
            if (e.KeyCode == Keys.C) {
                PagamentoDebito();
            }
            if (e.KeyCode == Keys.F12) {
                btnPagamento.PerformClick();

            }

        }
        private void button7_Click(object sender, EventArgs e) {
            decimal valorpago = Convert.ToDecimal(lblValorPago.Text);
            decimal valorvenda = Convert.ToDecimal(lblValorVenda.Text);
            //Executa ao teclar Enter

            if (valorpago >= valorvenda) {
                decimal valordinheiro = Convert.ToDecimal(PAGAMDINHEIRO);

                this.txtpagamentodinheiro = valordinheiro.ToString("N");
                this.txtpagamentocredito = PAGCREDITO;
                this.txtpagamentodebito = PAGDEBITO;
                this.txttroco = TXTTROCO;
                InserirMovimento();
                DialogResult = DialogResult.OK;
            } else {
                btnDinheiro.Focus();
                MessageBox.Show("Pagamento informado é menor do que o valor da compra! Verifique!", "Verifique o pagamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtdinheiro_TextChanged(object sender, EventArgs e) {
            PAGAMDINHEIRO = txtdinheiro.Text;
        }
        private void txtcredito_TextChanged(object sender, EventArgs e) {
            PAGCREDITO = txtcredito.Text;
        }
        private void txtdebito_TextChanged(object sender, EventArgs e) {
            PAGDEBITO = txtdebito.Text;
        }
        private void button6_Click(object sender, EventArgs e) {
            MessageBox.Show("Em Desenvolvimento", "Em Desenvolvimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool _altF4Pressed;
        private void Pagamento_FormClosing(object sender, FormClosingEventArgs e) {
            if (_altF4Pressed) {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }
        }
        private void Pagamento_KeyDown(object sender, KeyEventArgs e) {
            if (e.Alt && e.KeyCode == Keys.F4)
                _altF4Pressed = true;
        }
        private void button7_Click_1(object sender, EventArgs e) {
            VoltarTelaVenda();
        }
    }
}





