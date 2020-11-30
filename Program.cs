using System;
using System.Collections.Generic;


namespace Trabalho_poo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            List<Reserva> listaReserva = new List<Reserva>();
            List<Cliente> listaCliente = new List<Cliente>();

            Console.WriteLine("Escolha as opções: ");
            Console.WriteLine("1 - Cadastro de reserva; ");
            Console.WriteLine("2 - Controle de gastos; ");
            Console.WriteLine("3 - Fechamento de conta; ");
            Console.WriteLine("4 - Relatorio diario; ");
            while ((op = int.Parse(Console.ReadLine())) != 0)
            {
                switch(op)
                {
                    case 1:
                        cadastrarReserva(listaCliente, listaReserva);

                        break;
                    case 2:
                        Console.WriteLine("teste 2");

                        break;
                    case 3:
                        Console.WriteLine("teste 3");

                        break;         
                    case 4:
                        Console.WriteLine("teste 4");
                        break;         

                }
                Console.WriteLine("Escolha as opções: ");
                Console.WriteLine("1 - Cadastro de reserva; ");
                Console.WriteLine("2 - Controle de gastos; ");
                Console.WriteLine("3 - Fechamento de conta; ");
                Console.WriteLine("4 - Relatorio diario; ");
            }
            Console.WriteLine("Programa encerrado!");
        }
        public static void cadastrarReserva(List<Cliente> listaCliente, List<Reserva> listaReserva)
        {
            Console.WriteLine("Digite o nome do cliente: ");    
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o data de nascimento do cliente: ");
            DateTime ? dataNascimento = null;    
            dataNascimento =  DateTime.Parse(Console.ReadLine());
            if (listaCliente.Exists(cliente => cliente.getNome() == nome && cliente.getDataNascimento() == dataNascimento))
            {
                int rgCliente = 0;
                foreach (Cliente c in listaCliente)
                {
                    if (c.getNome() == nome && c.getDataNascimento() == dataNascimento)
                    {
                        rgCliente = c.getRg();
                    }
                }
                Reserva novaReserva = new Reserva();
                Console.WriteLine("Digite o tipo de acomodação do cliente: ");    
                novaReserva.setTipoAcomodacao(int.Parse(Console.ReadLine()));
                Console.WriteLine("Digite a data de entrada do cliente: ");    
                novaReserva.setEntrada(DateTime.Parse(Console.ReadLine()));
                Console.WriteLine("Digite a data de saida do cliente: ");    
                novaReserva.setSaida(DateTime.Parse(Console.ReadLine()));
                Console.WriteLine("Digite o numero da acomodação do cliente: ");    
                novaReserva.setNumeroAcomodacao(int.Parse(Console.ReadLine()));
                novaReserva.setRgCliente(rgCliente);
            }
            else
            {
                cadastrarCliente(nome, dataNascimento);
                int rgCliente = 0;
                foreach (Cliente c in listaCliente)
                {
                    if (c.getNome() == nome && c.getDataNascimento() == dataNascimento)
                    {
                        rgCliente = c.getRg();
                    }
                }
                Reserva novaReserva = new Reserva();
                Console.WriteLine("Digite o tipo de acomodação do cliente: ");    
                novaReserva.setTipoAcomodacao(int.Parse(Console.ReadLine()));
                Console.WriteLine("Digite a data de entrada do cliente: ");    
                novaReserva.setEntrada(DateTime.Parse(Console.ReadLine()));
                Console.WriteLine("Digite a data de saida do cliente: ");    
                novaReserva.setSaida(DateTime.Parse(Console.ReadLine()));
                Console.WriteLine("Digite o numero da acomodação do cliente: ");    
                novaReserva.setNumeroAcomodacao(int.Parse(Console.ReadLine()));
                novaReserva.setRgCliente(rgCliente);
            }
        }
        public static void cadastrarCliente(string nome, Nullable <DateTime> dataNascimento)
        {
            Cliente novoCliente = new Cliente();
            // DateTime nascimento = dataNascimento;
            if(nome != null)
            {
                novoCliente.setNome(nome);
            } else {
                Console.WriteLine("Digite o nome do cliente: ");    
                novoCliente.setNome(Console.ReadLine());
            }
            if(!dataNascimento.HasValue)
            {
                novoCliente.setDataNascimento(dataNascimento);
            } else {
                Console.WriteLine("Digite a data de nascimento do cliente: ");    
                novoCliente.setDataNascimento(DateTime.Parse(Console.ReadLine()));
            }

            
            
            Console.WriteLine("Digite o endereço do cliente: ");    
            novoCliente.setEndereco(Console.ReadLine());
            Console.WriteLine("Digite o telefone do cliente: ");    
            novoCliente.setTelefone(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o bairro do cliente: ");    
            novoCliente.setBairro(Console.ReadLine());
            Console.WriteLine("Digite o cidade do cliente: ");    
            novoCliente.setCidade(Console.ReadLine());
            Console.WriteLine("Digite o estado do cliente: ");    
            novoCliente.setEstado(Console.ReadLine());
            Console.WriteLine("Digite o rg do cliente: ");    
            novoCliente.setRg(int.Parse(Console.ReadLine()));
        }
    }
}

