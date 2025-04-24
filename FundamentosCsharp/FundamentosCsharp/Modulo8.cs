using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos
{
    public static class Calculos
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }
    }
    public class Produto
    {
        private int Id;

        public int Estoque { get; } // ou public readonly int Estoque;
        public string Descricao { get; set; }

        public Produto() //Construtor da classe
        {
            Estoque = 5;
        }

        public void ImprimirDescricao()
        {
            Console.WriteLine($"O ID do produto é:{GetId()} e o produto é: {Descricao}");
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public int GetId()
        {
            return Id;
        }
    }

    public class Pessoa
    {
        public int Id { get; set; }

        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public string Cep { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine("Codigo: " + Id);
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine("Cidade: " + Cidade);
            Console.WriteLine("Cep: " + Cep);
        }
    }

    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public void ImprimirCPF()
        {
            Console.WriteLine("CPF: " + CPF);
        }
    }

    public class Funcionario : PessoaFisica
    {
        public string Matricula { get; set; }
    }

    public sealed class Configuracao
    {
        public string Host { get; set; }
    }

    public abstract class Animal
    {
        public string Nome { get; set; }

        public abstract string GetInformacoes();

        public void ImprimirDados()
        {
            Console.WriteLine($"O nome do animal é: {Nome}");
            Console.WriteLine($"Informações: {GetInformacoes().ToString()}");
        }
    }
    public class Cachorro : Animal
    {
        public override string GetInformacoes()
        {
            return "Cachorro é um bom amigo";
        }
    }

    public record Curso(int Id, string Descricao);

    public class CursoTeste
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

    }

    /*public record Curso
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (obj is Curso curso)
            {
                return Id == curso.Id && Descricao == curso.Descricao;
            }

            return base.Equals(obj);
        }

        public static bool operator == (Curso a, Curso b)
        {
            return a.Equals(b);
        }

        public static bool operator != (Curso a, Curso b)
        {
            return !(a == b);
        }
    }*/

    public interface INotificacao
    {
        string Descricao { get; set; }

        void Notificar();
    }

    public class NotificacaoCliente : INotificacao
    {
        public string Descricao { get ; set ; }

        public void Notificar()
        {
            Console.WriteLine("Notificando cliente");
        }
        public void NotificandoOutros()
        {
            Console.WriteLine("Notificando funcionario");
        }
    }
    public class NotificacaoFuncionario : INotificacao
    {
        public string Descricao { get ; set ; }

        public void Notificar()
        {
            Console.WriteLine("Notificando funcionario");
        }
        public void NotificandoOutros()
        {
            Console.WriteLine("Notificando funcionario");
        }
    }

    public static class Aulas
    {
        private static void AulaInterface()
        {
            var notificandoCliente = new Produtos.NotificacaoCliente();
            notificandoCliente.Notificar();

            Produtos.INotificacao notificacao = new Produtos.NotificacaoFuncionario();
            notificacao.Notificar();
        }

        private static void AulaRecord()
        {
            //var curso1 = new Produtos.Curso { Id = 1, Descricao = "Curso" };
            //var curso2 = new Produtos.Curso { Id = 1, Descricao = "Curso" }; usando a classe record

            var curso1 = new Produtos.Curso(1, "Curso");
            var curso2 = curso1 with { Descricao = "Teste Novo" };

            //var curso1 = new Produtos.CursoTeste { Id = 1, Descricao = "Curso"};
            //var curso2 = curso1;
            //curso2.Descricao = "TESTE TESTE";

            //var curso2 = new Produtos.CursoTeste();//não ocorre o problema pois estou criando uma instancia nova e não atribuindo a primeira instancia a variavel

            //curso2.Id = curso1.Id;
            //curso2.Descricao = "Nova Descrição";

            Console.WriteLine(curso1.Descricao);
            Console.WriteLine(curso2.Descricao);

            //Console.WriteLine($"Os cursos são iguais ? {curso1.Equals(curso2)}"); //Utilizando o equals para comparacao
        }

        private static void AulaClasseAbstrada()
        {
            var animal = new Produtos.Cachorro();
            animal.Nome = "Cão";
            animal.ImprimirDados();

        }

        private static void AulaClasseSelada()
        {
            //var configuracao = new Produtos.Configuracao();
            //configuracao.Host = "localhost";
            var config = new Produtos.Configuracao
            {
                Host = "localhost"
            };

            Console.WriteLine(config.Host);

        }

        private static void AulaHeranca()
        {
            /*var pessoaFisica = new Produtos.PessoaFisica();
            pessoaFisica.Id = 1;
            pessoaFisica.Endereco = "Rua Calados";
            pessoaFisica.Cep = "05736100";
            pessoaFisica.Cidade = "São Paulo";

            pessoaFisica.ImprimirDados();
            pessoaFisica.ImprimirCPF();*/

            var funcionario = new Produtos.Funcionario();
            funcionario.Id = 10;
            funcionario.Endereco = "Rua Calados";
            funcionario.Cep = "05736100";
            funcionario.Cidade = "São Paulo";
            funcionario.CPF = "12345678920";

            funcionario.ImprimirDados();
            funcionario.ImprimirCPF();
        }

        private static void AulaClasses()
        {
            var resultado = Produtos.Calculos.Somar(1, 2);
            Console.WriteLine(resultado);

            //var produto = new Produtos.Produto();

            //produto.SetId(1);
            //produto.Descricao = "Teclado";
            //produto.ImprimirDescricao();
        }

        private static void AulaPropSomenteLeitura()
        {
            var produto = new Produtos.Produto();
            produto.Descricao = "Mouse";
            //produto.Estoque = 1; não posso atribuir valor pois essa é uma prop de somente de leitura, e só posso passar valor pelo construtor dentro da classe
            Console.WriteLine($"O produto é: {produto.Descricao} e a quantidade em estoque é: {produto.Estoque}");
        }
    }

}
