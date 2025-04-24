using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloLinq
{
    public class TrabalhandoComLinq
    {
        public void AulaWhere() 
        {
            //string nomeCompleto = "CARLOS SOBRAL";

            //Func<char, bool> filtro = c => c == 'A'; //metodo 1

            ////var resultado = nomeCompleto.Where(i => i == 'A'); //metodo 2 sintaxe de método

            ////var resultado = nomeCompleto.Where(filtro);

            //var resultado = from c in nomeCompleto where c == 'S' select c; //metodo 4 - sintaxe de consulta

            //foreach (var letra in resultado)
            //{
            //    Console.WriteLine(letra);
            //}

            var numeros = new int[] { 1, 2, 3, 4, 5, 6 };
            var resultado = numeros.Where(x => x > 1);

            foreach (var x in resultado)
            {
                Console.WriteLine(x);
            }
        }
        public void AulaOrderBy() 
        {
            var numeros = new int[] { 1, 2, 3, 4, 5, 6 };
            var resultado = numeros.OrderBy(x => x);
            var resultado2 = numeros.OrderByDescending(x => x);

            foreach (var x in resultado)
            {
                Console.WriteLine(x);
            }
            foreach (var x in resultado2)
            {
                Console.WriteLine(x);
            }
        }
        public void AulaTake() 
        {
            var numeros = new int[] { 1, 2, 3, 4, 5, 6 };
            var resultado = numeros.Take(3); //pegando os tres primeiros numeros
            var resultado2 = numeros.Take(3).OrderBy(x => x); //pegando os tres primeiros numeros e ordernando crescente
            var resultado3 = numeros.Where(x => x > 3).Take(3).OrderBy(x => x); //filtrando numeros maior que 3, pegando os tres após esse filtro e ordenando em crescente
        }
        public void AulaCount()
        {
            var numeros = new int[] { 1, 2, 3, 4, 5, 6 };
            var resultado = numeros.Count();
            Console.WriteLine(resultado);

            var resultado2 = numeros.Count(x => x > 2);
        }
        public void AulaFirsteFirstOrDefault()
        {
            var numeros = new int[] { 1, 2, 3, 4, 5, 6 };
            var resultado = numeros.First();
            Console.WriteLine(resultado);

            var resultado2 = numeros.FirstOrDefault(x => x > 2);
            Console.WriteLine(resultado2);
            
            var resultado3 = numeros.FirstOrDefault(x => x > 50, 99); //devolvendo como padrão o valor 99 caso não ache um numero maior que 50
            Console.WriteLine(resultado3);

            var resultado4 = numeros.Min();
            Console.WriteLine(resultado4);
        }
    }

    private static void AulasWhere()
    {
        var wherer = new ModuloLinq.TrabalhandoComLinq();
        wherer.AulaWhere();
    }
    private static void AulasOrderBys()
    {
        var wherer = new ModuloLinq.TrabalhandoComLinq();
        wherer.AulaOrderBy();
    }
    private static void AulaTakes()
    {
        var wherer = new ModuloLinq.TrabalhandoComLinq();
        wherer.AulaTake();
    }
    private static void AulaCounts()
    {
        var wherer = new ModuloLinq.TrabalhandoComLinq();
        wherer.AulaCount();
    }
    private static void AulaFirts()
    {
        var wherer = new ModuloLinq.TrabalhandoComLinq();
        wherer.AulaFirsteFirstOrDefault();
    }
}
