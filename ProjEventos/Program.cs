using System;

namespace ProjEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            do
            {
                Console.WriteLine("Menu");

                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Cadastrar Tipo");
                Console.WriteLine("3 - Cadastrar Endereço");
                Console.WriteLine("9 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastroCliente();
                        break;
                    case 2:
                        CadastroTipo();
                        break;
                    default: Console.WriteLine();
                        break;
                }

            } while (opcao != 9);
           
        }

        private static void CadastroCliente()
        {
            //Implementacao
            Console.WriteLine("Entrei no Cadastro de Clientes");
        }

        private static void CadastroTipo()
        {
            Console.WriteLine("Entrei no Cadastro de Tipo");
        }
    }
}
