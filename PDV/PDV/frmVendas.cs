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
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;
using System.IO;
using System.Linq.Expressions;
using System.CodeDom;
using System.Diagnostics;
using System.Threading;
using System.Drawing.Printing;
using Printer;

namespace PDV {
    public partial class frmVendas : Form {


        frmSolicitarSenhaSupervisor frm2;
        frmBloquearPDV frm3;

        public frmVendas(frmFundoPDV frmFundoPDV) {
            InitializeComponent();
        }



        MySqlConnection con = Conexao.ConexaoMySQL.obterConexao();
        private string strMySQL;

        float TotalVenda;
        string precototal;
        string Tipo;
        private string servidor;
        private string tef;
        private int _contador = 0;
        private string pdv;
        private string QuantidadeProduto;
        private string ProdutoNome;
        private string ProdutoNomeBarra;
        string Sinal1;
        string Sinal2;

        public static string VALORVENDA;
        public static string NUMEROCUPOM;
        public static string IDCAIXA;

        public static string PAGDINHEIRO;
        public static string PAGCREDITO;
        public static string PAGDEBITO;
        public static string PRODUTOSCUPOM;
        public static string PRODUTOSCUPOM2;
                 

        private frmAbrirCaixa frmAbrirCaixa;

        private void VerificaCarga() {
            // Verifica o arquivo de sinalização 1 e 2 quando gerado carga
            if (FileCompare(this.Sinal1, this.Sinal2)) {

            } else {
                File.Delete(Sinal1);   //Sinalização
                File.Copy(Sinal2, Sinal1);   //Sinalização2
                frmImportarCarga form1 = new frmImportarCarga();
                form1.Show();
            }
        }
        private void AtivarValoresRecebidos() {
            lblValoresRecebidos.Visible = true;
            lblDinheiroRecebido.Visible = true;
            lblCreditoRecebido.Visible = true;
            lbldebitoRecebido.Visible = true;
            lblOutrosRecebido.Visible = true;
            lblTrocoRecebido.Visible = true;
            txtdinheiro.Visible = true;
            txtcredito.Visible = true;
            txtdebito.Visible = true;
            txtOutros.Visible = true;
            txttroco.Visible = true;
        }
        private void DesativarValoresRecebidos() {
            lblValoresRecebidos.Visible = false;
            lblDinheiroRecebido.Visible = false;
            lblCreditoRecebido.Visible = false;
            lbldebitoRecebido.Visible = false;
            lblOutrosRecebido.Visible = false;
            lblTrocoRecebido.Visible = false;
            txtdinheiro.Visible = false;
            txtcredito.Visible = false;
            txtdebito.Visible = false;
            txtOutros.Visible = false;
            txttroco.Visible = false;
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
        private void InserirMovimento() {
            strMySQL = "insert into mercado.movimentocaixa(Data, Descricao, Entrada, FormaPagto, Operador, Observacao, idcaixa) value (@Data, @Descricao, @Entrada, @FormaPagto, @Operador, @Observacao, @idcaixa)";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            comando.Parameters.AddWithValue("@Data", DateTime.Now);
            comando.Parameters.AddWithValue("@Descricao", "Cupom Nº" + lblnumcupom.Text);
            comando.Parameters.AddWithValue("@Entrada", Convert.ToDecimal(txtValorVenda.Text));
            comando.Parameters.AddWithValue("@FormaPagto", "Dinheiro");
            comando.Parameters.AddWithValue("@Operador", frmMenuPrincipal.Operador.ToString());
            comando.Parameters.AddWithValue("@Observacao", "0");
            comando.Parameters.AddWithValue("@idcaixa", IDCAIXA);

            try {

                comando.ExecuteNonQuery();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
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
        private void ComparaImporta() {

            try {

            } catch { }


            string linhasinal1 = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\..\\Visual Sistemas\\VTEX PDV\\txtsinal1.txt"));


            Refresh();

            string[] linhas = File.ReadAllLines(linhasinal1, Encoding.UTF7);

            foreach (string linha in linhas) {
                Sinal1 += linha;

            }

            string linhasinal2 = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\..\\Visual Sistemas\\VTEX PDV\\txtsinal2.txt"));

            Refresh();

            string[] linhas2 = File.ReadAllLines(linhasinal2, Encoding.UTF7);

            foreach (string linha in linhas2) {
                Sinal2 += linha;

            }
        }
        private bool FileCompare(string file1, string file2) {
            int file1byte;
            int file2byte;
            FileStream fs1;
            FileStream fs2;

            // Determine if the same file was referenced two times.
            if (file1 == file2) {
                // Return true to indicate that the files are the same.
                return true;
            }

            // Open the two files.
            fs1 = new FileStream(file1, FileMode.Open);
            fs2 = new FileStream(file2, FileMode.Open);

            try {

            } catch (Exception ex) {
                MessageBox.Show("Diretório do Arquivo inválido");
            }


            // Check the file sizes. If they are not the same, the files 
            // are not the same.
            if (fs1.Length != fs2.Length) {
                // Close the file
                fs1.Close();
                fs2.Close();

                // Return false to indicate files are different
                return false;
            }

            // Read and compare a byte from each file until either a
            // non-matching set of bytes is found or until the end of
            // file1 is reached.
            do {
                // Read one byte from each file.
                file1byte = fs1.ReadByte();
                file2byte = fs2.ReadByte();
            }
            while ((file1byte == file2byte) && (file1byte != -1));

            // Close the files.
            fs1.Close();
            fs2.Close();

            // Return the success of the comparison. "file1byte" is 
            // equal to "file2byte" at this point only if the files are 
            // the same.
            return ((file1byte - file2byte) == 0);
        }
        private void GerarCodigoVenda() {
            strMySQL = "select max(VendaID) from mercado.caixa";

            try {


                con.Open();
                MySqlCommand comando = new MySqlCommand(strMySQL, con);

                if (comando.ExecuteScalar() == DBNull.Value) {
                    lblnumcupom.Text = "1";
                } else {
                    Int32 ra = Convert.ToInt32(comando.ExecuteScalar()) + 1;
                    lblnumcupom.Text = ra.ToString();
                    NUMEROCUPOM = ra.ToString();
                }
            } catch (Exception ex) {
                txtmensagem.Text = ex.Message;
            } finally {
                con.Close();
            }
        }
        private void LimparParaNovaVenda() {
            txtmskCPF.Text = ""; //limpa os dados do textbox mascara cpf
            txtmskCPF.Mask = ""; //limpa a mascara do textbox cpf
            frmCPFCNPJ.dadoscpfcnpj = ""; //limpa o dados do form CPF
            _contador = Convert.ToInt32(0); //limpa a sequencia de itens
            lblcliente.Text = "";
            txtNome.Text = "";

        }
        private void CancelaCupom() {
            strMySQL = "insert into mercado.caixa(VendaID, ValorTotal, Caixa, Data, Descricao, Operador, Supervisor, Status) value (@VendaID, @ValorTotal, @Caixa, @Data, @Descricao, @Operador, @Supervisor, @Status)";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            comando.Parameters.AddWithValue("@VendaID", Convert.ToInt32(lblnumcupom.Text));
            comando.Parameters.AddWithValue("@ValorTotal", Convert.ToDecimal(txtValorVenda.Text));
            comando.Parameters.AddWithValue("@Caixa", Convert.ToInt32(pdv));
            comando.Parameters.AddWithValue("@Data", DateTime.Now);
            comando.Parameters.AddWithValue("@Descricao", "Venda");
            comando.Parameters.AddWithValue("@Operador", frmMenuPrincipal.Operador);
            comando.Parameters.AddWithValue("@Supervisor", frmMenuPrincipal.Supervisor);
            comando.Parameters.AddWithValue("@Status", "Cancelado");


            try {
                con.Open();
                comando.ExecuteNonQuery();

            } catch (Exception ex) {
                txtmensagem.Text = ex.Message;
            } finally {
                InserirCupomCancelado();
            }
        }
        private void ConsultarProdutoDiversos() {
            strMySQL = "select * from mercado.produtos where CodBarra='" + txtCod.Text + "'";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            try {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows) {
                    txtmensagem.Text = "Produto não encontrado";

                    txtCod.Clear();
                    txtCod.Focus();
                } else {

                    ProdutoNome = dr["Nome"].ToString();
                    int quantidade = int.Parse(dr["Quantidade"].ToString());
                    string precounitario = txtPreco.Text;
                    txtPreco.Text = Convert.ToDecimal(precounitario).ToString("N");
                    Tipo = dr["Tipo"].ToString();
                    // txtQuant.Text = ;
                    CalculoProduto();
                    AdicionarProduto();
                    Limpar();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                con.Close();
            }
        }
        private void ConsultarProduto() {
            strMySQL = "select * from mercado.produtos where CodBarra='" + txtCod.Text + "'";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            try {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows) {
                    txtmensagem.Text = "Produto não encontrado";

                    txtCod.Clear();
                    txtCod.Focus();
                } else {

                    ProdutoNome = dr["Nome"].ToString();


                    int quantidade = int.Parse(dr["Quantidade"].ToString());
                    string precounitario = dr["Preco"].ToString();
                    txtPreco.Text = Convert.ToDecimal(precounitario).ToString("N");
                    Tipo = dr["Tipo"].ToString();
                    // txtQuant.Text = ;
                    CalculoProduto();
                    AdicionarProduto();
                    Limpar();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                con.Close();
            }
        }
        private void ConsultaServidor() {
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
        private void ConsultaPDV() {
            strMySQL = "select * from mercado.configuracao where idconfig='" + 3 + "'";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            try {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows) {

                } else {
                    txtpdv.Text = (dr["Script"].ToString());
                    pdv = (dr["Script"].ToString());
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                con.Close();
            }
        }
        private void ConsultaTef() {
            strMySQL = "select * from mercado.configuracao where idconfig='" + 2 + "'";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            try {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows) {

                } else {
                    tef = (dr["Script"].ToString());
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                con.Close();
            }
        }
        private void PingServidor() {
            Ping pingSender = new Ping();
            byte[] data = Encoding.ASCII.GetBytes("test");
            int timeout = 100;
            PingReply reply = pingSender.Send(servidor, timeout, data);

            if (reply.Status == IPStatus.Success) {
                lblservidor.Text = ("ONLINE");
                lblservidor.ForeColor = System.Drawing.Color.GreenYellow;
            } else {
                lblservidor.Text = ("OFFLINE");
                lblservidor.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void PingTef() {
            Ping pingSender = new Ping();
            byte[] data = Encoding.ASCII.GetBytes("test");
            int timeout = 100;
            PingReply reply = pingSender.Send(tef, timeout, data);

            if (reply.Status == IPStatus.Success) {
                lbltef.Text = ("ONLINE");
                lbltef.ForeColor = System.Drawing.Color.GreenYellow;
            } else {
                lbltef.Text = ("OFFLINE");
                lbltef.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void ConsultarProdutoBarra() {
            var codigodebarra = txtCod.Text;


            string codigo = Convert.ToString(codigodebarra.Substring(1, 4)); //pega o codigo da linha codigo de barra
            string preco = Convert.ToString(codigodebarra.Substring(7, 5));  //pega o valor da linha codigo de barra

            string strInput = codigo;
            strInput = strInput.TrimStart('0'); //remove os numeros zero do codigo

            //colocar a virgula com 2 casas decimais
            decimal valorNormal = Convert.ToDecimal(preco) / 100;

            //converte decimal para string
            var valorreal = Convert.ToString(valorNormal);

            strMySQL = "select * from mercado.produtos where CodBarra='" + strInput + "'";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            try {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows) {
                    txtmensagem.Text = "Produto não encontrado";
                    txtCod.Clear();
                    txtCod.Focus();
                } else {

                    ProdutoNomeBarra = dr["Nome"].ToString();
                    int quantidade = int.Parse(dr["Quantidade"].ToString());
                    string precounitario = dr["Preco"].ToString();
                    txtPreco.Text = Convert.ToDecimal(precounitario).ToString("N");
                    Tipo = dr["Tipo"].ToString();
                    CalculoProdutoBarra();
                    AdicionarProdutoBarra();
                    Limpar();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                con.Close();
            }
        }
        void Limpar() {
            txtCod.Clear();
            txtQuant.Text = "1,000";
            txtmensagem.Text = txtCod.Text;
            txtPreco.Clear();
            txtCod.Focus();

        }
        private void CarregaOperador() {
            lblOperador.Text = frmMenuPrincipal.Operador.ToString();
        }
        private void NomearDataGrid() {
            dtvVenda.ColumnCount = 6;
            dtvVenda.Columns[0].Name = "SEQ.";
            dtvVenda.Columns[0].Width = 40;
            dtvVenda.Columns[1].Name = "CÓD.";
            dtvVenda.Columns[1].Width = 80;
            dtvVenda.Columns[2].Name = "DESCRIÇÃO";
            dtvVenda.Columns[2].Width = 130;
            dtvVenda.Columns[3].Name = "PREÇO";
            dtvVenda.Columns[3].Width = 50;
            dtvVenda.Columns[4].Name = "QTD";
            dtvVenda.Columns[4].Width = 70;
            dtvVenda.Columns[5].Name = "TOTAL";
            dtvVenda.Columns[5].Width = 60;

        }
        private void VerificaCPF() {
            if (txtmskCPF.Text == string.Empty) // verifica se o campo esta vazio
            {
                // passa os dados para o messagebox
                string message = "Deseja colocar o CPF ou CNPJ?";
                string caption = "CPF ou CNPJ?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // exibe messagebox
                result = MessageBox.Show(message, caption, buttons);

                //se o resultado for yes, abre ao form pra digitar os dados
                if (result == System.Windows.Forms.DialogResult.Yes) {

                    frmCPFCNPJ form1 = new frmCPFCNPJ();
                    form1.ShowDialog();
                } else {
                    txtmskCPF.Text = "00000000000"; // se o resultador for no , insere esses dados no campo
                }
            }
        }
        private void MascaraCPFCNPJ() {

            if (frmCPFCNPJ.dadoscpfcnpj == string.Empty) // se dados retornar vazio, preenche com zeros
            {
                txtmskCPF.Text = "00000000000";

                lblcliente.Text = "Cliente não informado";

                txtmskCPF.Mask = "000,000,000-00";

            } else // retorna dados do CPF ou CNPJ cliente
              {
                txtmskCPF.Text = Convert.ToString(frmCPFCNPJ.dadoscpfcnpj); //insere CPF ou CNPJ do cliente

                if (txtmskCPF.Text.Length < 13) {
                    txtmskCPF.Mask = "000,000,000-00";
                } else {
                    txtmskCPF.Mask = "00,000,000/0000-00";
                }
            }
        }
        private void AdicionarProduto() {
            VerificaCPF();

            string tipo = Tipo;
            string quantidade = (txtQuant.Text + (" ") + tipo);
            string quantidadeponto = quantidade.Replace(',', '.');

            QuantidadeProduto = quantidadeponto;

            // Gerando Código Incremento na coluna SEQ
            this._contador++;
            string cont = this._contador.ToString().PadLeft(1, '0');

            dtvVenda.Rows.Add(cont, txtCod.Text, ProdutoNome, txtPreco.Text, quantidadeponto, precototal);
            TotalVenda += float.Parse(precototal);
            //txtValorVenda.Text = TotalVenda.ToString("N");

            //rola pro ultimo dados inserido na tabela
            this.dtvVenda.CurrentCell = this.dtvVenda.Rows[this.dtvVenda.Rows.Count - 1].Cells[0];
            dtvVenda.FirstDisplayedScrollingRowIndex = dtvVenda.RowCount - 1;

            txtNome.Text = QuantidadeProduto + " " + "X" + " " + ProdutoNome;

            txtmensagem.Text = QuantidadeProduto + " " + "X" + " " + ProdutoNome;

            MascaraCPFCNPJ();

            calculaValorTotalGrid();
        }

        private decimal ValorTotal() {
            decimal total = 0;
            int i = 0;
            for (i = 0; i < dtvVenda.Rows.Count; i++) {
                total = total + Convert.ToDecimal(dtvVenda.Rows[i].Cells["TOTAL"].Value);
            }
            return total;
        }
        private void calculaValorTotalGrid() {
            if (dtvVenda.Rows.Count > 0)
                txtValorVenda.Text = ValorTotal().ToString("N");
        }
        private void AdicionarProdutoBarra() {
            VerificaCPF();
            var codigodebarra = txtCod.Text;


            string codigo = Convert.ToString(codigodebarra.Substring(1, 4)); //pega o codigo da linha codigo de barra
            string preco = Convert.ToString(codigodebarra.Substring(7, 5));  //pega o valor da linha codigo de barra

            string strInput = codigo;
            strInput = strInput.TrimStart('0'); //remove os numeros zero do codigo

            //colocar a virgula com 2 casas decimais
            decimal valorNormal = Convert.ToDecimal(preco) / 100;

            //converte decimal para string
            var valorreal = Convert.ToString(valorNormal);
            string valordecimal = Convert.ToDecimal(valorreal).ToString("N");

            string tipo = Tipo;
            string quantidade = (txtQuant.Text + (" ") + tipo);

            // Gerando Código Incremento na coluna SEQ
            this._contador++;
            string cont = this._contador.ToString().PadLeft(1, '0');

            dtvVenda.Rows.Add(cont, strInput, ProdutoNomeBarra, txtPreco.Text, quantidade, valordecimal);
            TotalVenda += float.Parse(valorreal);
            txtValorVenda.Text = TotalVenda.ToString("N");

            txtNome.Text = quantidade + " " + "X" + " " + ProdutoNomeBarra;

            txtmensagem.Text = quantidade + " " + "X" + " " + ProdutoNomeBarra;


            MascaraCPFCNPJ();
        }
        private void CalculoProduto() {


            if (txtQuant.Text != string.Empty) {
                string precocorreto = (float.Parse(txtPreco.Text) * float.Parse(txtQuant.Text)).ToString("N");

                precototal = precocorreto;

            } else {
                MessageBox.Show("Digite a quantidade", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQuant.Focus();
            }

        }
        private void CalculoProdutoBarra() {
            var codigodebarra = txtCod.Text;


            string codigo = Convert.ToString(codigodebarra.Substring(1, 4)); //pega o codigo da linha codigo de barra
            string preco = Convert.ToString(codigodebarra.Substring(7, 5));  //pega o valor da linha codigo de barra

            //colocar a virgula com 2 casas decimais
            decimal valorNormal = Convert.ToDecimal(preco) / 100;

            //converte decimal para string
            var valorreal = Convert.ToString(valorNormal);


            string quant = (float.Parse(valorreal) / float.Parse(txtPreco.Text)).ToString("N3");
            string quantidade = quant;
            quantidade = quantidade.Replace(',', '.');
            txtQuant.Text = quantidade;


        }
        private void Pd_PrintPage(object sender, PrintPageEventArgs e) {

            CupomVenda impressao = new CupomVenda();
            impressao.ImpressaoCupom(e);
        }
        public void FazImpressaoCupom() {

            //  textoCupom = txtTexto.Text.ToString(); // passa txtbox por parametro no contrutor
            ;

            PrinterSettings settings = new PrinterSettings();
            string defaultPrinterName = settings.PrinterName;


            using (var pd = new PrintDocument()) {

                pd.PrinterSettings.PrinterName = defaultPrinterName;
                pd.PrintPage += new PrintPageEventHandler(this.Pd_PrintPage);
                pd.PrintController = new System.Drawing.Printing.StandardPrintController();
                pd.Print();
            }
        }

            public void exportarVendaParaTxt(DataGridView dgv) {

            txtmensagem.Text = "Gravando registros ... Aguarde!";

            System.IO.StreamWriter sw = null;

            //Caractere delimitador
            string delimitador = "|"; //tab

            string nomearquivo = "VD" + pdv + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".txt";
            string path = @"C:\Users\Márcio\Desktop\vendas\" + nomearquivo;
            string PDV = pdv;
            string CUPOM = NUMEROCUPOM;
            string DATA = DateTime.Now.ToString("ddMMyyyyHHmm");
            string FISCAL = frmMenuPrincipal.Supervisor.ToString();
            string OPERADOR = frmMenuPrincipal.Operador.ToString();
            string valor = txtValorVenda.Text;
            string VALORVENDA = valor.Replace(',', '.');

            try {
                txtmensagem.Text = "Gravando registros ... Aguarde!";

                //Pega o caminho do arquivo
                string caminho = path;
                //Cria um StreamWriter no local
                sw = new System.IO.StreamWriter(caminho);


                /*    sw.WriteLine("A |");
                    sw.WriteLine("B | RAZAO SOCIAL DA EMPRESA");
                    sw.WriteLine("C | CNPJ");
                    sw.WriteLine("D | " + NUMEROCUPOM);
                    sw.WriteLine("Z | " + frmMenuPrincipal.Operador.ToString());*/

                
                
                int qtdColunas = dgv.Columns.Count;

                string[] produto = new string[200];  
                
                

                //Loop em todas as linhas para escrever na stream já com o delimitador.
                foreach (DataGridViewRow dgvLinha in dgv.Rows) {
                    
                    string linha = PDV + "|" + CUPOM + "|" + DATA + "|" + FISCAL + "|" + OPERADOR + "|" + VALORVENDA + "|";
                    for (int i = 0; i < qtdColunas; i++) {
                        string linhanormal = dgvLinha.Cells[i].Value.ToString() + delimitador;

                        string linhacorrigida = linhanormal.Replace(',', '.');
                        linha += linhacorrigida;                        

                    }

                    sw.WriteLine(linha);                    

                    for (int i = 0; i < 200; i++)
                         {
                             produto[i] = i + linha;
                         }
                    CupomVenda.dadoss = produto[0].ToString();
                }

            } catch (Exception ex) {
                // MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                //Fechar stream SEMPRE
                sw.Close();                

                FazImpressaoCupom();
            }
        }

        private void EfetuarPagamento() {
            // GravarVenda();
            //GerarCodigoVenda();
            if (txtValorVenda.Text == "") {
                MessageBox.Show("Registre um produto antes!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCod.Focus();
            } else {

                VALORVENDA = txtValorVenda.Text;


                {
                    frmPagamento form = new frmPagamento();
                    if (form.ShowDialog() == DialogResult.OK) {

                        txtdinheiro.Text = form.txtpagamentodinheiro;
                        txtcredito.Text = form.txtpagamentocredito;
                        txtdebito.Text = form.txtpagamentodebito;
                        txttroco.Text = form.txttroco;

                        decimal valorpagodinheiro = Convert.ToDecimal(form.txtpagamentodinheiro);
                        decimal valorpagocredito = Convert.ToDecimal(form.txtpagamentocredito);
                        decimal valorpagodebito = Convert.ToDecimal(form.txtpagamentodebito);
                        decimal soma = Convert.ToDecimal(valorpagodinheiro + valorpagodebito + valorpagocredito);
                        decimal valorvenda = Convert.ToDecimal(txtValorVenda.Text);

                        if (soma < valorvenda) {
                            txtmensagem.Text = "Aguardando pagamento!";
                            //txtmensagem.Clear();
                            btnPagamento.Enabled = true;
                            txtCod.Enabled = true;
                            //Chamando o método...                       

                        } else {

                            exportarVendaParaTxt(dtvVenda);
                            AtivarValoresRecebidos();
                            txtmensagem.Text = "Pagamento realizado, aguarde a impressão!";
                            txtNome.Text = "Pagamento realizado!";
                            btnPagamento.Enabled = false;
                            txtCod.Enabled = false;
                            GravarVenda();
                        }

                    }
                }
            }
        }
        private void GravarVenda() {
            strMySQL = "insert into mercado.caixa(VendaID, ValorTotal, Caixa) value (@VendaID, @ValorTotal, @Caixa)";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            comando.Parameters.AddWithValue("@VendaID", Convert.ToInt32(lblnumcupom.Text));
            comando.Parameters.AddWithValue("@ValorTotal", Convert.ToDecimal(txtValorVenda.Text));
            comando.Parameters.AddWithValue("@Caixa", Convert.ToInt32(pdv));

            try {
                con.Open();
                comando.ExecuteNonQuery();

            } catch (Exception ex) {
                txtmensagem.Text = ex.Message;
            } finally {
                con.Close();
                Inserir();
                GerarCodigoVenda();
                LimparParaNovaVenda();
            }
        }
        private void InserirTeste() {
            strMySQL = "insert into mercado.teste(VendaID, ProdutoID, Quantidade, ValorTotal, Caixa) value (@VendaID, @ProdutoID, @Quantidade, @ValorTotal, @Caixa)";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);
            con.Open();

            //percorro o DataGridView
            for (int i = 0; i < dtvVenda.Rows.Count - 1; i++) {
                //limpo os parâmetros
                comando.Parameters.Clear();
                //crio os parâmetro do comando
                //e passo as linhas do dgvClientes para eles
                //onde a célula indica a coluna do dgv                
                comando.Parameters.AddWithValue("@VendaID", lblnumcupom.Text);
                comando.Parameters.AddWithValue("@ProdutoID", dtvVenda.Rows[i].Cells[1].Value);
                comando.Parameters.AddWithValue("@Quantidade", dtvVenda.Rows[i].Cells[4].Value);
                comando.Parameters.AddWithValue("@ValorTotal", float.Parse(dtvVenda.Rows[i].Cells[5].Value.ToString()));
                comando.Parameters.AddWithValue("@Caixa", Convert.ToInt32(pdv));

                comando.ExecuteNonQuery();
            }
            //Fecho conexão
            con.Close();
        }

        private void InserirCupomCancelado() {
            strMySQL = "insert into mercado.cupomcancelado(VendaID, ProdutoID, Quantidade, ValorTotal, Caixa) value (@VendaID, @ProdutoID, @Quantidade, @ValorTotal, @Caixa)";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            try {
                if (con.State == ConnectionState.Closed) {
                    con.Open();
                }


                for (int i = 0; i < dtvVenda.Rows.Count - 1; i++) {

                    //remove as letras da string
                    string quantnumeros = Convert.ToString(dtvVenda.Rows[i].Cells[4].Value);

                    Regex re = new Regex("[0-9]");
                    StringBuilder s = new StringBuilder();

                    foreach (Match m in re.Matches(quantnumeros)) {
                        s.Append(m.Value);
                    }

                    //passa a quantidade sem letras para string
                    string numerosquantidade = (s.ToString());

                    string strInput = numerosquantidade;
                    strInput = strInput.TrimEnd('0'); //remove os numeros zero da direita do codigo

                    string removezero = (float.Parse(strInput).ToString("N3")); // passa para decimal e acrescenta o ponto

                    string quantidade = removezero.TrimEnd('0', ','); //remove os numeros zero e a virgula da direita do codigo


                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@VendaID", lblnumcupom.Text);
                    comando.Parameters.AddWithValue("@ProdutoID", dtvVenda.Rows[i].Cells[1].Value);
                    comando.Parameters.AddWithValue("@Quantidade", quantidade.ToString());
                    comando.Parameters.AddWithValue("@ValorTotal", float.Parse(dtvVenda.Rows[i].Cells[5].Value.ToString()));
                    comando.Parameters.AddWithValue("@Caixa", Convert.ToInt32(pdv));

                    comando.ExecuteNonQuery();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                con.Close();
                txtmskCPF.Text = ""; //limpa os dados do textbox mascara cpf
                txtmskCPF.Mask = ""; //limpa a mascara do textbox cpf
                frmCPFCNPJ.dadoscpfcnpj = ""; //limpa o dados do form CPF
                _contador = Convert.ToInt32(0); //limpa a sequencia de itens
                lblcliente.Text = "";
                txtNome.Text = "";
                dtvVenda.Rows.Clear();
                TotalVenda = 0;
                txtmensagem.Text = "";
                btnPagamento.Enabled = true;
                DesativarValoresRecebidos();
                txtCod.Enabled = true;
                txtCod.Focus();
                txtValorVenda.Text = "0,00";
                GerarCodigoVenda();
            }
        }
        private void Inserir() {
            strMySQL = "insert into mercado.itemvenda(VendaID, ProdutoID, Quantidade, ValorTotal, Caixa) value (@VendaID, @ProdutoID, @Quantidade, @ValorTotal, @Caixa)";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            try {
                if (con.State == ConnectionState.Closed) {
                    con.Open();
                }


                for (int i = 0; i < dtvVenda.Rows.Count - 1; i++) {

                    //remove as letras da string
                    string quantnumeros = Convert.ToString(dtvVenda.Rows[i].Cells[4].Value);

                    Regex re = new Regex("[0-9]");
                    StringBuilder s = new StringBuilder();

                    foreach (Match m in re.Matches(quantnumeros)) {
                        s.Append(m.Value);
                    }

                    //passa a quantidade sem letras para string
                    string numerosquantidade = (s.ToString());

                    string strInput = numerosquantidade;
                    strInput = strInput.TrimEnd('0'); //remove os numeros zero da direita do codigo

                    string removezero = (float.Parse(strInput).ToString("N3")); // passa para decimal e acrescenta o ponto

                    string quantidade = removezero.TrimEnd('0', ','); //remove os numeros zero e a virgula da direita do codigo


                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@VendaID", lblnumcupom.Text);
                    comando.Parameters.AddWithValue("@ProdutoID", dtvVenda.Rows[i].Cells[1].Value);
                    comando.Parameters.AddWithValue("@Quantidade", quantidade.ToString());
                    comando.Parameters.AddWithValue("@ValorTotal", float.Parse(dtvVenda.Rows[i].Cells[5].Value.ToString()));
                    comando.Parameters.AddWithValue("@Caixa", Convert.ToInt32(pdv));

                    comando.ExecuteNonQuery();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                dtvVenda.Rows.Clear();
                TotalVenda = 0;
                txtmensagem.Text = "";
                btnPagamento.Enabled = true;
                DesativarValoresRecebidos();
                txtCod.Enabled = true;
                txtCod.Focus();
                txtValorVenda.Text = "0,00";

                con.Close();
            }
        }

        private void frmVendas_Load(object sender, EventArgs e) {
            GerarCodigoVenda();
            NomearDataGrid();
            ConsultaServidor();
            ConsultaTef();
            timerpingservidor.Start();
            timedata.Start();
            LimparParaNovaVenda();
            ConsultaPDV();
            ComparaImporta();
            CarregaOperador();
            CarregaIDCaixa();
            NUMEROCUPOM = lblnumcupom.Text;
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e) {

            //Executa ao teclar Enter
            if (Convert.ToInt32(e.KeyChar) == 13) {
                if (txtCod.Text != string.Empty) {

                    if (txtCod.Text == "9999") {
                        txtmensagem.Text = "Digite o valor do produto e tecle ENTER!";
                        txtPreco.Focus();
                    } else {
                        var codigodebarra = txtCod.Text;

                        string digito = Convert.ToString(codigodebarra.Substring(0, 1)); //pega o codigo da linha codigo de barra

                        if (txtCod.Text.Length > 12 && digito == "2") {
                            ConsultarProdutoBarra();
                        } else {
                            ConsultarProduto();

                        }
                    }


                } else {
                    txtCod.Focus();
                }
            }

            //Permite numero e virgula no txtcod
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) {
                e.Handled = true;
            }
        }

        private void txtCod_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.X) {
                string quant = txtCod.Text;
                string quantidade = float.Parse(quant).ToString("N3");

                txtQuant.Text = quantidade;
                txtCod.Clear();
                txtCod.Focus();
            }

            if (e.KeyCode == Keys.P) {
                frmConsultaPreco form = new frmConsultaPreco();
                form.Show();
            }

            if (e.KeyCode == Keys.D) {
                txtCod.Text = "9999";
                txtPreco.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            GravarVenda();
            GerarCodigoVenda();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            PingServidor();
            PingTef();
        }

        private void timedata_Tick(object sender, EventArgs e) {
            lbldata.Text = DateTime.Now.ToString();
        }

        private void Fechar_Click(object sender, EventArgs e) {

        }

        private void timer1_Tick_1(object sender, EventArgs e) {
            VerificaCarga();
        }


        private void frmVendas_FormClosing(object sender, FormClosingEventArgs e) {
            Dispose();
            { if (frmVendas.ModifierKeys == Keys.Alt || frmVendas.ModifierKeys == Keys.F4) { e.Cancel = true; } }

        }


        private void button1_Click(object sender, EventArgs e) {

            this.Close();

        }

        private void button2_Click_1(object sender, EventArgs e) {
            EfetuarPagamento();
        }

        private void button3_Click(object sender, EventArgs e) {
            GravarVenda();
            GerarCodigoVenda();
        }

        private void txtpdv_TextChanged(object sender, EventArgs e) {

        }

        private void frmVendas_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F12) {
                btnPagamento.PerformClick();

            }

            if (e.KeyCode == Keys.M) {
                PainelMenu.Visible = true;
                btnExcluirItem.Focus();
            }
        }

        private void frmVendas_KeyPress(object sender, KeyPressEventArgs e) {

        }

        private void txtdinheiro_TextChanged(object sender, EventArgs e) {
            txtmensagem.Text = "Pagamento realizado, aguarde a impressão";
        }

        private void txtcredito_TextChanged(object sender, EventArgs e) {
            txtmensagem.Text = "Pagamento realizado, aguarde a impressão";
        }

        private void txtdebito_TextChanged(object sender, EventArgs e) {
            txtmensagem.Text = "Pagamento realizado, aguarde a impressão";
        }

        private void lbl001_Click(object sender, EventArgs e) {

        }

        private void txtCod_TextChanged(object sender, EventArgs e) {

        }

        private void txtCod_Click(object sender, EventArgs e) {

        }

        private void frmVendas_KeyDown(object sender, KeyEventArgs e) {

        }

        private void btnexcluir_Click(object sender, EventArgs e) {

        }

        private void dtvVenda_SelectionChanged(object sender, EventArgs e) {

        }

        private void dtvVenda_KeyPress(object sender, KeyPressEventArgs e) {
            //Executa ao teclar Enter
            if (Convert.ToInt32(e.KeyChar) == 13) {

                try {
                    // verificar se existe alguma linha selecionada
                    if (dtvVenda.SelectedRows.Count == 0) {
                        MessageBox.Show("Nenhum registro selecionado", "Atenção");
                        return;
                    } else {

                        frm2 = new frmSolicitarSenhaSupervisor();
                        DialogResult dr = frm2.ShowDialog(this);
                        if (dr == DialogResult.Cancel) {
                            frm2.Close();
                            txtmensagem.Text = frm2.getText();
                            txtNome.Text = "Cancelamento de item negado!";
                        } else if (dr == DialogResult.OK) {
                            string id = dtvVenda.CurrentRow.Cells[0].Value.ToString();
                            string codigo = dtvVenda.CurrentRow.Cells[1].Value.ToString();
                            string descricao = dtvVenda.CurrentRow.Cells[2].Value.ToString();
                            string precounitario = dtvVenda.CurrentRow.Cells[3].Value.ToString();
                            string quantidade = dtvVenda.CurrentRow.Cells[4].Value.ToString();
                            string precototal = dtvVenda.CurrentRow.Cells[5].Value.ToString();

                            strMySQL = "insert into mercado.itemcancelado(tipo, cupom, codigoproduto, descricao, valorunitario, valortotal, operador, supervisor, data) value (@tipo, @cupom, @codigoproduto, @descricao, @valorunitario, @valortotal, @operador, @supervisor, @data)";
                            MySqlCommand comando = new MySqlCommand(strMySQL, con);



                            comando.Parameters.AddWithValue("@tipo", "Item Cancelado");
                            comando.Parameters.AddWithValue("@cupom", lblnumcupom.Text);
                            comando.Parameters.AddWithValue("@codigoproduto", codigo);
                            comando.Parameters.AddWithValue("@descricao", descricao);
                            comando.Parameters.AddWithValue("@valorunitario", precounitario);
                            comando.Parameters.AddWithValue("@valortotal", precototal);
                            comando.Parameters.AddWithValue("@Operador", frmMenuPrincipal.Operador.ToString());
                            comando.Parameters.AddWithValue("@supervisor", frmMenuPrincipal.Supervisor.ToString());
                            comando.Parameters.AddWithValue("@data", DateTime.Now);

                            try {
                                con.Open();
                                comando.ExecuteNonQuery();

                            } catch (Exception ex) {
                                MessageBox.Show(ex.Message);
                            } finally {
                                con.Close();
                            }

                            txtmensagem.Text = frm2.getText();
                            frm2.Close();

                            dtvVenda.Rows.RemoveAt(dtvVenda.CurrentRow.Index);
                            calculaValorTotalGrid();
                            txtNome.Clear();
                        }
                        
                    }

                } catch {

                } finally {
                    txtCod.Focus();
                }
            }

        }

        private void dtvVenda_KeyDown(object sender, KeyEventArgs e) {
            {
                if (e.KeyCode == Keys.Enter) {
                    e.Handled = true;
                }

            }
        }

        private void btnExcluirItem_Click(object sender, EventArgs e) {
            txtNome.Text = "Excluindo item...";
            txtmensagem.Text = "Selecione e tecle ENTER para excluir o item!";
            dtvVenda.Focus();
            PainelMenu.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e) {

            frm2 = new frmSolicitarSenhaSupervisor();
            DialogResult dr = frm2.ShowDialog(this);
            if (dr == DialogResult.Cancel) {
                PainelMenu.Visible = false;
                MessageBox.Show("Senha incorreta!, PDV não será fechado!", "Senha incorreta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else if (dr == DialogResult.OK) {

                PainelMenu.Visible = false;

                btnSair.PerformClick();
            }
        }
        private void button3_Click_1(object sender, EventArgs e) {
            Process.Start("Shutdown", "-s -f -t 10");
        }

        private void button2_Click_2(object sender, EventArgs e) {
            frm2 = new frmSolicitarSenhaSupervisor();
            DialogResult dr = frm2.ShowDialog(this);
            if (dr == DialogResult.Cancel) {
                PainelMenu.Visible = false;
                MessageBox.Show("Senha incorreta! Cancelamento negado!", "Senha incorreta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else if (dr == DialogResult.OK) {

                CancelaCupom();

                PainelMenu.Visible = false;
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e) {
            InserirTeste();
        }

        private void PainelMenu_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                PainelMenu.Visible = false;
            }
        }

        private void button3_Click_2(object sender, EventArgs e) {
            PainelMenu.Visible = false;
            txtCod.Focus();
        }



        private void PainelMenu_Paint(object sender, PaintEventArgs e) {

        }

        private void button6_Click(object sender, EventArgs e) {

            txtCod.Focus();

            frmBloquearPDV form = new frmBloquearPDV();
            form.ShowDialog();

            PainelMenu.Visible = false;
        }

        private void btnExcluirItem_Click_1(object sender, EventArgs e) {
            txtNome.Text = "Excluindo item...";
            txtmensagem.Text = "Selecione e tecle ENTER para excluir o item!";
            dtvVenda.Focus();
            PainelMenu.Visible = false;
        }

        private void button1_Click_2(object sender, EventArgs e) {
            frm2 = new frmSolicitarSenhaSupervisor();
            DialogResult dr = frm2.ShowDialog(this);
            if (dr == DialogResult.Cancel) {
                PainelMenu.Visible = false;
                MessageBox.Show("Senha incorreta! Cancelamento negado!", "Senha incorreta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else if (dr == DialogResult.OK) {

                CancelaCupom();

                PainelMenu.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e) {

            txtCod.Focus();

            frmBloquearPDV form = new frmBloquearPDV();
            form.ShowDialog();

            PainelMenu.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e) {
            frm2 = new frmSolicitarSenhaSupervisor();
            DialogResult dr = frm2.ShowDialog(this);
            if (dr == DialogResult.Cancel) {
                PainelMenu.Visible = false;
                MessageBox.Show("Senha incorreta!, PDV não será fechado!", "Senha incorreta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else if (dr == DialogResult.OK) {

                PainelMenu.Visible = false;

                btnSair.PerformClick();
            }
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e) {
            if (Convert.ToInt32(e.KeyChar) == 13) {
                ConsultarProdutoDiversos();
            }
        }
        private void dtvVenda_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}



