using AppClientes;
using System;
using System.Diagnostics;

namespace Application
{
    public class Program
    {
        static ClienteRepository _clienteRepository = new ClienteRepository();

        static void Main(string[] args)
        {
            _clienteRepository.LerDadosClientes();

            while (true)
            {
                Menu();

                Console.ReadKey(); //ele limpa e executa novamente o console
            }
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Clientes");
            Console.WriteLine("--------------------");
            Console.WriteLine("1 - Cadastrar cliente");
            Console.WriteLine("2 - Exibir Cliente");
            Console.WriteLine("3 - Editar Cliente");
            Console.WriteLine("4 - Excluir Cliente");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("--------------------");

            EscolherOpcao();
            
        }

        static void EscolherOpcao()
        {
            Console.WriteLine("Escolha uma opção: ");

            var opcao = Console.ReadLine();

            switch (int.Parse(opcao))
            {
                case 1:
                    {
                        _clienteRepository.CadastrarCliente();
                        Menu();
                        break;
                    }
                    
                case 2:
                    {
                        _clienteRepository.ExibirCliente();
                        Menu();
                        break;
                    }
                case 3:
                    {
                        _clienteRepository.EditarCliente();
                        Menu();
                        break;
                    }
                case 4:
                    {
                        _clienteRepository.ExcluirCliente();
                        Menu();
                        break;
                    }
                case 5:
                    {
                        _clienteRepository.GravarDadosClientes();
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Opção inválida!");
                        break;
                    }
            }
        }
    }
}