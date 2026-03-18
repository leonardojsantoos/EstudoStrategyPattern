using Strategy.Models;
using Strategy.Services;
using Strategy.Strategies;
using Strategy.Factory;
using System;
using static Strategy.Factory.Factory;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Sistema Exames ( 0 - sair )\n\n" +
                                  "Escolha o tipo do exame:\n" +
                                  "1 - Sangue\n2 - RaioX\n3 - Ultrassom\n");
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                    Console.ReadKey();
                    continue;
                }

                if (opcao == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Programa Encerrado...");
                    break;
                }

                if (!Enum.IsDefined(typeof(TipoExame), opcao))
                {
                    Console.WriteLine("\nOpção inválida! Escolha um exame da lista.");
                    Console.ReadKey();
                    continue;
                }

                TipoExame tipo = (TipoExame)opcao;
                Console.Clear();
                Console.Write("Insira o nome do exame: ");
                string nome = Console.ReadLine();
                Console.Clear();
                try
                {
                    var strategy = ExameStrategyFactory.Criar(tipo);
                    var exame = new Exame { Tipo = tipo, Descricao = nome };
                    var processador = new ProcessadorExame(strategy);
                    processador.Processar(exame);
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (true);
        }
    }
}