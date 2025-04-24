using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloStrings
{
    public class TrabalhandoComStrings
    {
        public void ConverterToLower()
        {
            Console.Write("Digite algum valor: ");
            var frase = Console.ReadLine();
            Console.WriteLine($"{frase.ToLower()}");
        }
        public void ConverterToUpper()
        {
            Console.Write("Digite algum valor: ");
            var frase = Console.ReadLine();
            Console.WriteLine($"{frase.ToUpper()}");
        }
        public void Substrings()
        {
            Console.Write("Digite algum valor: ");
            var frase = Console.ReadLine();
            Console.WriteLine($"{frase.Substring(0,4)}");
        }
        public void AulaRange()
        {
            var nomeArquivo = "2022_12_01_backup.bak";
            string ano = nomeArquivo[..4]; //pegando os 4 primeiros caracteres
            Console.WriteLine(ano);
            
            string extensao = nomeArquivo[^3..]; //pegando os 3 ultimos caracteres
            Console.WriteLine(extensao);
            
            string nome = nomeArquivo[11..^4]; //pegando o nome do tipo do arquivo
            Console.WriteLine(nome);

            string apenasNome = nomeArquivo[..^4]; //pegando os até 4 ultimos caracteres
            Console.WriteLine(apenasNome);
        }

        public void AulaContains()
        {
            string nomeArquivo = "2022_12_01_backup.bak";
            if (nomeArquivo.Contains("backup"))
            {
                Console.WriteLine("Palavra encontrada");
            }
            else
            {
                Console.WriteLine("Palavra não encontrada");
            }

            //Console.WriteLine($"Contem nome: {nomeArquivo.Contains("backup")}");
        }

        public void AulaTrim()
        {
            string teste = "**CARLOS HENRIQUE**";
            Console.WriteLine($"TRIM total: {teste.Trim('*')}");
            Console.WriteLine($"TRIM inicio: {teste.TrimStart('*')}");
            Console.WriteLine($"TRIM fim: {teste.TrimEnd('*')}");
        }        
        public void AulaStartWith()
        {
            string teste = "Curso Csharp";

            Console.WriteLine($"INICIO: {teste.StartsWith("Curso")}");
            Console.WriteLine($"FIM: {teste.EndsWith("Csharp02")}");
        }
        public void AulaReplace()
        {
            string teste = "Curso Csharp";

            Console.WriteLine($"{teste}");
            Console.WriteLine($"Depois do replace: {teste.Replace("Csharp", "C#")}");
        }
        public void AulaLength()
        {
            string teste = Console.ReadLine();

            Console.WriteLine($"{teste}");
            Console.WriteLine($"Qtd de caracteres: {teste.Length}");
        }

        private static void AulasStrings()
        {
            var strings = new ModuloStrings.TrabalhandoComStrings();
            //strings.ConverterToLower();
            //strings.ConverterToUpper();
            //strings.Substrings();
            //strings.AulaRange();
            //strings.AulaContains();
            //strings.AulaTrim();
            //strings.AulaStartWith();
            //strings.AulaReplace();
            //strings.AulaLength();
        }

    }
}
