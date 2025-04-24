using Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientes
{
    public class ClienteRepository
    {
        public List<Cliente> Clientes = new List<Cliente>();

        public void GravarDadosClientes()
        {
            var json = System.Text.Json.JsonSerializer.Serialize(Clientes);

            File.WriteAllText("C:\\Logs\\AulaCriandoArquivos\\DadosClientes\\Clientes.txt", json);
        }
        public void LerDadosClientes()
        {
            if (File.Exists("C:\\Logs\\AulaCriandoArquivos\\DadosClientes\\Clientes.txt"))
            {
                var dados = File.ReadAllText("C:\\Logs\\AulaCriandoArquivos\\DadosClientes\\Clientes.txt");

                var clientesArquivo = System.Text.Json.JsonSerializer.Deserialize<List<Cliente>>(dados);

                Clientes.AddRange(clientesArquivo);
            }

        }

        public void ExcluirCliente()
        {
            Console.Clear();

            Console.WriteLine("Informe o código do cliente: ");
            var codigo = Console.ReadLine();

            var cliente = Clientes.FirstOrDefault(x => x.Id == int.Parse(codigo));

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado! [Enter]");
                Console.ReadKey();
                return;
            }

            ImprimirCliente(cliente);

            Clientes.Remove(cliente);

            Console.WriteLine("Cliente removido com sucesso! [Enter]");
            Console.ReadKey();

        }

        public void EditarCliente()
        {
            Console.Clear();

            Console.WriteLine("Informe o código do cliente: ");
            var codigo = Console.ReadLine();

            var cliente = Clientes.FirstOrDefault(x => x.Id == int.Parse(codigo));

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado! [Enter]");
                Console.ReadKey();
                return;
            }

            ImprimirCliente(cliente);

            Console.WriteLine("Nome do cliente: ");
            var nome = Console.ReadLine();
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Data de nascimento: ");
            var dataNascimento = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);
            
            Console.WriteLine("Desconto cliente: ");
            var desconto = decimal.Parse(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);

            cliente.Nome = nome;
            cliente.Desconto = desconto;
            cliente.DataNascimento = dataNascimento;
            cliente.DataCadastro = DateTime.Now;

            Console.WriteLine("Cliente alterado com sucesso! [Enter]");
            ImprimirCliente(cliente);
            Console.ReadKey();

        }

        public void CadastrarCliente()
        {
            Console.Clear();

            Console.WriteLine("Nome do Cliente: ");
            var nome = Console.ReadLine();
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Data de nascimento do Cliente: ");
            var dataNascimento = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Desconto do Cliente: ");
            var desconto = decimal.Parse(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);

           var cliente = new Cliente();
            cliente.Id = Clientes == null ? Clientes.Count + 1 : 1;
            cliente.Nome = nome;
            cliente.DataNascimento = dataNascimento;
            cliente.Desconto = desconto;
            cliente.DataCadastro = DateTime.Now;

            Clientes.Add(cliente);

            Console.WriteLine("Cliente cadastrado com sucesso! [Enter]");
            ImprimirCliente(cliente);
            Console.ReadKey();

        }

        public void ImprimirCliente(Cliente cliente)
        {
            Console.WriteLine("ID.............: " + cliente.Id);
            Console.WriteLine("Nome...........: " + cliente.Nome);
            Console.WriteLine("Desconto.......: " + cliente.Desconto.ToString("0.00"));
            Console.WriteLine("Data Nascimento: " + cliente.DataNascimento);
            Console.WriteLine("Data Cadastro..: " + cliente.DataCadastro);
            Console.WriteLine("-----------------------------------------------------");
        }

        public void ExibirCliente()
        {
            Console.Clear();

            foreach (var cliente in Clientes)
            {
                ImprimirCliente(cliente);
            }

            Console.ReadKey();
        }
    }
}
