using System;
using System.Collections.Generic;

namespace ProjetoSistemaDescontos
{
    internal class SalarioProcessador
    {
        private readonly List<IDescontosAcrescimosStrategy> _strategies;
        public SalarioProcessador()
        {
            _strategies = new List<IDescontosAcrescimosStrategy>();
        }
        public void AddStrategy(IDescontosAcrescimosStrategy strategy)
        {
            _strategies.Add(strategy);
        }
        public decimal ProcessarSalario(decimal baseSalary)
        {
            decimal total = baseSalary;

            foreach (var strategy in _strategies)
            {
                total = strategy.AplicarDesconto(total);
            }
            return total;
        }
    }
}