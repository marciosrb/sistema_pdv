using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Timers;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        MySqlConnection con = new MySqlConnection("server=localhost;User Id=root; password=123456");
        private string strMySQL;
        string Sinal1;
        String Sinal2;

        private void VerificaCarga()
        {
            // Compare the two files that referenced in the textbox controls.
            if (FileCompare(this.Sinal1, this.Sinal2))
            {
                Lbl_status.Text = "Carga Atualizada ";
            }
            else
            {
                Lbl_status.Text = "Enviando Carga para os PDVs....";
                File.Delete(Sinal1);   //Sinalização
                File.Copy(Sinal2, Sinal1);   //Sinalização2
                ImportarProdutos();
            }
        }
        private void LimparTabelaProdutos()
        {
            strMySQL = "TRUNCATE mercado.produtos";
            MySqlCommand comando = new MySqlCommand(strMySQL, con);

            con.Open();
            comando.Connection = con;
            {
                comando.ExecuteNonQuery();
            }
            con.Close();

        }
        private void cadastra(string produtoid, string nome, string preco, string quantidade, string codbarra, string tipo)

        {

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
        private void ImportarProdutos()
        {
            //lblmensagem.Visible = true;
            // lblStatus.Text = "Sincronizando dados...";
            // lblmensagem.Text = "Carregando produtos";
            LimparTabelaProdutos();

            using (StreamReader fluxotexto = new StreamReader("C:\\VtexSistema\\Carga\\txtprodutos.txt"))

                while (true)

                {

                    string linhatexto = fluxotexto.ReadLine();

                    if (linhatexto == null)

                    {

                        break;

                    }


                    string[] quebra = linhatexto.Split(new Char[] { ',' });


                    cadastra(quebra[0], quebra[1], quebra[2], quebra[3], quebra[4], quebra[5]);
                }


        }

        private void ComparaImporta()
        {


            try
            {

            }
            catch { }


            string linhasinal1 = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\..\\txtsinal1.txt"));


            Refresh();



            string[] linhas = File.ReadAllLines(linhasinal1, Encoding.UTF7);

            foreach (string linha in linhas)
            {
                Sinal1 += linha;

            }



            string linhasinal2 = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\..\\txtsinal2.txt"));

            Refresh();

            string[] linhas2 = File.ReadAllLines(linhasinal2, Encoding.UTF7);

            foreach (string linha in linhas2)
            {
                Sinal2 += linha;

            }


        }

        private bool FileCompare(string file1, string file2)
        {
            int file1byte;
            int file2byte;
            FileStream fs1;
            FileStream fs2;

            // Determine if the same file was referenced two times.
            if (file1 == file2)
            {
                // Return true to indicate that the files are the same.
                return true;
            }

            // Open the two files.
            fs1 = new FileStream(file1, FileMode.Open);
            fs2 = new FileStream(file2, FileMode.Open);

            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Diretório do Arquivo inválido");
            }


            // Check the file sizes. If they are not the same, the files 
            // are not the same.
            if (fs1.Length != fs2.Length)
            {
                // Close the file
                fs1.Close();
                fs2.Close();

                // Return false to indicate files are different
                return false;
            }

            // Read and compare a byte from each file until either a
            // non-matching set of bytes is found or until the end of
            // file1 is reached.
            do
            {
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

        private void Form1_Load(object sender, EventArgs e)

        {
            ComparaImporta();
        }






        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            VerificaCarga();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }





        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }




        private void Textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArquivo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


      


       


