using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloArquivos
{
    public class Arquivos
    {
        public void AulaCriandoArquivo()
        {
            var escrever = new StreamWriter("C:\\Logs\\AulaCriandoArquivos\\Cadastro.txt", true);
            Console.WriteLine("Informe o nome da pessoa: ");
            var nome = Console.ReadLine(); 
            escrever.WriteLine("-------------------Realizando um cadastro de pessoa-------------------");
            escrever.WriteLine("ID...: " + Random.Shared.Next(1, 100)); //Estou gerando um numero aleatório entre 1 e 100
            escrever.WriteLine("Nome...: " + nome);
            escrever.WriteLine("-------------------"); 
            escrever.Close();
        }
        public void AulaLendoUmArquivo()
        {
            //var conteudo = File.ReadAllText("C:\\Logs\\AulaCriandoArquivos\\Cadastro.txt");

            var ler = new StreamReader("C:\\Logs\\AulaCriandoArquivos\\Cadastro.txt");
            
            while (!ler.EndOfStream) //ler até terminar todas as linhas do meu arquivo
            {
                var linha = ler.ReadLine(); //Ler linha a linha
                Console.WriteLine($"O conteúdo deste linha é =>  {linha}");
            }

            ler.Close();

            //if (conteudo.StartsWith("Leitura de cadastro de pessoas"))
            //{
            //    Console.WriteLine($"O conteúdo deste arquivo é: \n {conteudo}");
            //}
            //else
            //{
            //    Console.WriteLine("Arquivo Errado");
            //}
        }
        public void AulaExcluindoArquivo()
        {
            if (File.Exists("C:\\Logs\\AulaCriandoArquivos\\Cadastro.txt"))
            {
                File.Delete("C:\\Logs\\AulaCriandoArquivos\\Cadastro.txt");
            }
        }
        private static void AulaCriandoArquivos()
        {
            var arquivo = new ModuloArquivos.Arquivos();
            arquivo.AulaCriandoArquivo();
        }
        private static void AulaLendoArquivos()
        {
            var arquivo = new ModuloArquivos.Arquivos();
            arquivo.AulaLendoUmArquivo();
        }
        private static void AulaExcluirArquivos()
        {
            var arquivo = new ModuloArquivos.Arquivos();
            arquivo.AulaExcluindoArquivo();
        }
    }
}
