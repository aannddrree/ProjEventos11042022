using Models;
using System;
using System.Collections.Generic;

namespace ProjEventos
{
    internal class Program
    {
        public static List<Event> events = new List<Event>();
        public static List<Ticket> tickets = new List<Ticket>();

        static void Main(string[] args)
        {
            int opcao = 0;
            do
            {
                Console.WriteLine("Menu");

                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Cadastrar Tipo");
                Console.WriteLine("3 - Cadastrar Endereço");
                Console.WriteLine("4 - Cadastrar Evento");
                Console.WriteLine("5 - Gerar Lote");


                //MAIS ITENS DE MENU

                Console.WriteLine("9 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AddClient();
                        break;
                    case 2:
                        AddType();
                        break;
                    case 4:
                        AddEvent();
                        break;
                    case 5:
                        GenerateTickets();
                        break;
                    default: Console.WriteLine();
                        break;
                }

            } while (opcao != 9);
           
        }

        private static void GenerateTickets()
        {
            Console.Write("Id Evento para gerar o lote: ");
            int idEvent = int.Parse(Console.ReadLine());
            Console.Write("Qtd de Ingressos");
            int qtdTickets = int.Parse(Console.ReadLine());

            List<Ticket> tickets = new List<Ticket>();

            for (int i = 1; i <= qtdTickets; i++)
            {
                tickets.Add(new Ticket() { Id = i, Event = new Event() { Id = idEvent } });
            }
        }

        private static void AddClient()
        {
            //Implementacao
            Console.WriteLine("Entrei no Cadastro de Clientes");
        }

        private static void AddType()
        {
            Console.WriteLine("Entrei no Cadastro de Tipo");
        }

        private static void AddEvent()
        {

            Event ev = new Event();

            Console.Write("Id: ");
            ev.Id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            ev.Name = Console.ReadLine();

            Console.Write("Data: ");
            ev.Date = DateTime.Parse(Console.ReadLine());

            ev.Address = new Address();
            Console.Write("Id Endereço: ");
            ev.Address.Id = int.Parse(Console.ReadLine());
            Console.Write("Rua/Av Endereço: ");
            ev.Address.Street = Console.ReadLine();

            ev.Type = new Models.Type();
            Console.Write("Id Tipo: ");
            ev.Type.Id = int.Parse(Console.ReadLine());
            Console.Write("Descrição Tipo: ");
            ev.Type.Description = Console.ReadLine();

            Console.Write("Capacidade: ");
            ev.Capacity = int.Parse(Console.ReadLine());

            Console.Write("Duração: ");
            ev.Duration = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de Apresentações: ");
            int numberOfApresentation = int.Parse(Console.ReadLine());

            List<Apresentation> apresentations = new List<Apresentation>();

            for (int i = 0; i < numberOfApresentation; i++)
            {
                Apresentation a = new Apresentation();
                Console.Write("Id Apresentação: ");
                a.Id = int.Parse(Console.ReadLine());
                Console.Write("Descrição: ");
                a.Description = Console.ReadLine();
                apresentations.Add(a);
            }
            
            ev.Apresentations = apresentations;

            events.Add(ev);
        }
    }
}
