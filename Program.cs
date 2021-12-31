using System;
using System.Collections.Generic;
using System.IO;
using exemploPOO.Helper;
using exemploPOO.interfaces;
using exemploPOO.Models;

namespace exemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {

        
        var caminho = @"C:\TrabalhandoComArquivos" ; 
        var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 1");
        var caminhoArquivo = Path.Combine(caminho, "teste-stream.txt");
        var caminhoArquivoTesteCopia = Path.Combine(caminho, "teste-stream-bkp.txt");
        var listaString = new List<string> {" Linha 1", " Linha 2 " , " Linha 3"};
        var listaStringContinuacao = new List<string> {" Linha 4", " Linha 5 " , " Linha 6"};
        var novoCaminhoArquivo = Path.Combine(caminho,"Pasta Teste 2", "arquivo copiado.txt");

        FileHelper helper = new FileHelper();
        helper.DeletarArquivo(caminhoArquivoTesteCopia);        


        
        //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo);      

        //helper.CriandoArquivoTextoStream(caminhoArquivo, listaString);
        //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
        //helper.CopiarArquivo(caminhoArquivo,caminhoArquivoTesteCopia, true);
        //helper.LerArquivoStream(caminhoArquivos);  
        

        //helper.CriarArquivoTexto(caminhoArquivos, " Olá, teste e escrita de arquivo.");       
        // helper.ApagarDiretorio(caminhoPathCombine,true);
        //  System.Console.WriteLine(" Criando diretório: " + caminhoPathCombine);
        //  helper.CriarDiretorio(caminhoPathCombine);
         //helper.ListarDiretorios(caminho);
        //helper.ListarArquivosDiretorios(caminho);

        
        // ICalculadora calc = new Calculadora(); // atenção aqui,.... criou  um new Calculadora e nao new ICalculadora
        // System.Console.WriteLine(calc.Somar(10,20));


           
        // Corrente c= new Corrente();
        // c.Creditar(100);

        // c.ExibirSaldo();



            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());




            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine(" Resultado da primeira soma: " +calc.Somar(10,10));
            // System.Console.WriteLine(" Resultado da segunda soma: " + calc.Somar(10,10,10));




            
            // Professor p1 = new Professor();            
            // p1.Nome = " Luis";
            // p1.Idade= 57;
            // p1.Salario=2000;

            // p1.Apresentar();
                    
                                                    
           
           
            // Aluno p2 = new Aluno();            
            // p2.Nome = " Maikel";
            // p2.Idade= 38;
            // p2.Nota=10;

            // p2.Apresentar();
            





            // Aluno p1 = new Aluno();
            // p1.Nome = " Maikel";
            // p1.Idade= 38;

            // p1.Apresentar();







            // valores válidos
            // Retangulo r =new Retangulo();
            // r.DefinirMedidas(30,30);
            // System.Console.WriteLine($"Área: {r.ObterArea()}");      
                    
            
                      
                      
                       
            // Pessoa p1 = new Pessoa();
            // p1.Nome="Bob";
            // p1.Idade=20;
            
            // p1.Apresentar();


        }
    }
}
