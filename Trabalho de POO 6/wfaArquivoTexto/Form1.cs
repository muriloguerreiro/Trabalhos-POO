using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// Murilo Guerreiro Badoco 11711ECP010

namespace wfaArquivoTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Obtem informação sobre arquivo ou diretório
        private string obtemInformacaoArquivo(string nomeArquivo)
        {
            string informacao;

            // saída dizendo que o arquivo ou diretório existe
            informacao = nomeArquivo + " existe\r\n\r\n";

            // saída dizendo quando o arquivo ou diretório foi criado
            informacao += "Criado em : " +
               File.GetCreationTime(nomeArquivo) + "\r\n";

            // saída dizendo quando o arquivo ou diretório foi modificado pela última vez
            informacao += "Última modificação: " +
               File.GetLastWriteTime(nomeArquivo) + "\r\n";

            // saída dizendo quando o arquivo ou diretório foi acessado pela última vez
            informacao += "Último acesso: " +
               File.GetLastAccessTime(nomeArquivo) + "\r\n" + "\r\n";

            return informacao;

        } // fim do método obtemInformacaoArquivo

        // chamado quando o usuário pressiona uma tecla
        private void tbEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            // determina se o usuário pressionou a tecla Enter
            if (e.KeyCode == Keys.Enter)
            {
                string nomeArquivo; // nome do arquivo ou diretório

                // pega arquivo ou diretório especificado pelo usuário
                nomeArquivo = tbEntrada.Text;

                // determina se nomeArquivo é um arquivo
                if (File.Exists( nomeArquivo ))
                {
                    // obtenha a data de criação do arquivo, 
                    // data de modificação, etc.
                    tbSaida.Text = obtemInformacaoArquivo(nomeArquivo);

                     // exibe o conteúdo do arquivo por meio de StreamReader
                    try
                    {
                        // obtém o Reader e o conteúdo do arquivo
                        StreamReader stream = new StreamReader(nomeArquivo);
                        tbSaida.Text += stream.ReadToEnd();
                    }
                    // trata exceção se StreamReader está indisponível
                    catch (IOException)
                    {
                        MessageBox.Show("Erro de Arquivo", "Erro de Arquivo",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } // fim do (File.Exists( nomeArquivo ))

                // determine se nomeArquivo é um diretório
                else if (Directory.Exists(nomeArquivo))
                {
                    // array para diretórios
                    string[] directoryList;

                    // obtém data de criação do diretório, 
                    // data de modificação, etc.
                    tbSaida.Text = obtemInformacaoArquivo(nomeArquivo);

                    // obtém a lista de arquivos e diretórios
                    directoryList = Directory.GetDirectories(nomeArquivo);

                    tbSaida.Text +=
                       "\r\n\r\nConteúdo do diretório:\r\n";

                    // exibe conteúdo de directoryList 
                    for (int i = 0; i < directoryList.Length; i++)
                        tbSaida.Text += directoryList[i] + "\r\n";
                }
                else
                {
                    // notifica usuário quando não existe arquivo ou diretório
                    MessageBox.Show(tbEntrada.Text +
                       " não existe", "Erro de Arquivo",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } // end if

        } // fim do método tbEntrada_KeyDown

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            {
                string caminho = tbEntrada.Text;
                // Se o arquivo não existir, é salvado apenas o texto 
                // escolhido.
            if (File.Exists(caminho))
               {
                    try
                    {
                        tbSaida.SelectionStart = tbEntrada.Text.Length + 123 + File.ReadAllText(caminho).Length;
                        tbSaida.SelectionLength = tbSaida.Text.Length;
                        File.AppendAllText(caminho, tbSaida.SelectedText);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Houve um erro. Tente novamente.", "Erro");
                    }
               }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                string caminho = tbEntrada.Text;
                if (File.Exists(caminho))
                {
                    tbSaida.SelectionStart = tbEntrada.Text.Length + 123;
                    tbSaida.SelectionLength = tbSaida.Text.Length;
                    if (tbSaida.SelectedText.Equals(File.ReadAllText(caminho)))
                    {
                    }
                    else
                    {
                        DialogResult resposta = MessageBox.Show("Deseja salvar as alterações?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resposta == System.Windows.Forms.DialogResult.Yes)
                        {
                            try
                            {
                                tbSaida.SelectionStart = tbEntrada.Text.Length + 123 + File.ReadAllText(caminho).Length;
                                tbSaida.SelectionLength = tbSaida.Text.Length;
                                File.AppendAllText(caminho, tbSaida.SelectedText);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Houve um erro. Tente novamente.", "Erro");
                            }
                        }
                    }
                }
            
        }
    } // fim da classe class Form1 : Form

} // fim do namespace wfaArquivoTexto


