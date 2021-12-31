using System.Collections.Generic;
using System.IO;

namespace exemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho,"*", SearchOption.AllDirectories);
            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void ListarArquivosDiretorios(string caminho)
        {
            var retornoArquivos = Directory.GetFiles(caminho, "*2*", SearchOption.AllDirectories);

            foreach (var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }
        }


        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }


        public void ApagarDiretorio(string caminho, bool apagarArquivos)
        {
            Directory.Delete(caminho,apagarArquivos);
        }


        public void CriarArquivoTexto(string caminho, string conteudo)
        {

            if (!File.Exists(caminho)) // se o caminho nao existir vc cria ,pra nao sobrescrever o conteudo
            {
                File.WriteAllText(caminho, conteudo);
            }
        }


        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }


         public void AdicionarTextoStream(string caminho, List<string> conteudo)
        {
                         
            using ( var stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
                                                       
            }             
        }

        public void CriandoArquivoTextoStream(string caminho, List<string> conteudo)
        {
       
                using ( var stream = File.CreateText(caminho))
                {
                    foreach (var linha in conteudo)
                    {
                        stream.WriteLine(linha);
                    }
                                                       
                }                              
        }


        public void LerArquivo(string caminho)
        {
           var conteudo =  File.ReadAllLines(caminho);
           foreach (var linha in conteudo)
           {
            System.Console.WriteLine(linha);
           }
        }

        
        public void LerArquivoStream(string caminho)
        {
           string linha = string.Empty;
            using (var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                    System.Console.WriteLine(linha);
                }
            }

        }


        public void MoverArquivo(string caminho, string novoCaminho)
        {
            File.Move(caminho, novoCaminho);
        }
        
            
        

        public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Copy(caminho, novoCaminho, sobrescrever);
        }


        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }

        // OBS: stream não le o arquivo de uma vez, ele lê em partes


        // using ---> quando cria stream, essa strem é colocada em memória e preparada pra ser 
             //escrita, e quando termina o arquivo não pdoe deixar a stream aberta.
             // o using libera o arquivo pra ser usado por outro processo
    } // OBS: NÃO PRECISOU INSTANCIAR DIRECTORY PQ  NÃO PRECISA INSTANCIAR CLASSE ESTATICA!
}