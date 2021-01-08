using PDV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Printer {
    class CupomVenda : DadosEmpresa {

        public static string dadoss;   
       





        public void ImpressaoCupom(PrintPageEventArgs e) {

            // Principal vardados = new Principal();

            string[] vet = new string[200];
            vet[0] = dadoss;
            vet[1] = dadoss;

            DadosEmpresa dados = new DadosEmpresa();
            string nomeEmpresa = dados.nomeEmpresa;
            string enderecoEmpresa = dados.enderecoEmpresa;
            string logradouroEmpresa = dados.logradouroEmpresa;
            string CNPJ = dados.cnpj;
            string barra = "________________________________________________________";
            string naoFiscal = "CUPOM NAO FISCAL";
            string descritivo = "#|COD|DESC|QTD|UN|VL UN R$|VL TR R$|VL ITEM R$";
            string produto = vet[0];
            string produto2 = vet[1];
            
            string numeroCupom = frmVendas.NUMEROCUPOM;

            //  string texto = Principal.textoCupom;

            string data = DateTime.Now.ToString();

            var fonteCabecalho = new Font("Segoe UI", 8f, FontStyle.Regular);
            var fonteDestaque = new Font("Segoe UI", 8f, FontStyle.Bold);
            var fontePequena = new Font("Segoe UI", 7f, FontStyle.Bold);


            //print header
            e.Graphics.DrawString(nomeEmpresa, fonteCabecalho, Brushes.Black, 20, 0);
            e.Graphics.DrawString(enderecoEmpresa, fonteCabecalho, Brushes.Black, 20, 12);
            e.Graphics.DrawString(logradouroEmpresa, fonteCabecalho, Brushes.Black, 20, 24);
            e.Graphics.DrawString(CNPJ, fonteCabecalho, Brushes.Black, 20, 36);
            e.Graphics.DrawString(barra, fonteCabecalho, Brushes.Black, 20, 48);
            e.Graphics.DrawString(naoFiscal, fonteDestaque, Brushes.Black, 80, 60);
            e.Graphics.DrawString("CUPOM Nº " + numeroCupom + " | " + "Data: " + data, fontePequena, Brushes.Black, 20, 73);
            e.Graphics.DrawString(barra, fonteCabecalho, Brushes.Black, 20, 77);


            //itens header
            e.Graphics.DrawString(descritivo, fonteCabecalho, Brushes.Black, 20, 90);


            //itens de venda
            e.Graphics.DrawString(produto, fonteCabecalho, Brushes.Black, 20, 100);
            e.Graphics.DrawString(produto2, fonteCabecalho, Brushes.Black, 20, 110);

            //  e.Graphics.DrawString(texto, fonteCabecalho, Brushes.Black, 20, 100);


        }
    }
}
