using System;
using System.Collections;

namespace ProjetoVendas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Cliente c = new Cliente();
            do
            {
                Console.Clear();
                Console.WriteLine("     ------ MENU ------\n");
                //ArrayList opcao = new ArrayList { "Cadastrar Cliente", "Listar Clientes"};
                //Console.WriteLine($"{opcao}");
                Console.WriteLine("1 - Cadastrar Cliente.");
                Console.WriteLine("2 - Listar Clientes.");
                Console.WriteLine("0 - Sair.");

                Console.WriteLine("\nDigite a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine(" -- CADASTRAR CLIENTE --\n");

                        Console.WriteLine("Digite o nome do cliente:");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do cliente:");
                        c.Cpf = Console.ReadLine();

                        break;
                    case 2:
                        Console.WriteLine(" -- LISTAR CLIENTE --\n");
                        break;
                    case 3:
                        Console.WriteLine(" -- CADASTRAR VENDEDOR --\n");
                        break;
                    case 4:
                        Console.WriteLine(" -- LISTAR VENDEDOR --\n");
                        break;
                    case 5:
                        Console.WriteLine(" -- CADASTRAR PRODUTO --\n");
                        break;
                    case 6:
                        Console.WriteLine(" -- LISTAR PRODUTO --\n");
                        break;
                    case 7:
                        Console.WriteLine(" -- REGISTRAR VENDA --\n");
                        break;
                    case 8:
                        Console.WriteLine(" -- LISTAR VENDAS --\n");
                        break;
                    case 9:
                        Console.WriteLine(" -- LISTAR VENDAS POR CLIENTES --\n");
                        break;
                    case 0:
                        Console.WriteLine("SAINDO.................\n");
                        break;
                    default:
                        Console.WriteLine(" -- OPÇÃO INVÁLIDA --\n");
                        break;
                }
                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }
    }
}
