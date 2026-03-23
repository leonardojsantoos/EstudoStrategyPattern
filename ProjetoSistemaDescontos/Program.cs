using System;
using ProjetoSistemaDescontos;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal salarioBase = 3000m;

            // Cria o contexto
            var processor = new SalarioProcessador();

            // Adiciona estratégias
            processor.AddStrategy(new InssStrategy());
            // Aqui você pode adicionar outras Strategies, como IRRF, Bônus, Horas Extras...
            // processor.AddStrategy(new IrrfStrategy());
            // processor.AddStrategy(new OvertimeBonusStrategy(10, 50));

            // Calcula salário final
            decimal salarioFinal = processor.ProcessarSalario(salarioBase);

            Console.WriteLine($"Salário base: {salarioBase:C}");
            Console.WriteLine($"Salário final: {salarioFinal:C}");
        }
    }
}