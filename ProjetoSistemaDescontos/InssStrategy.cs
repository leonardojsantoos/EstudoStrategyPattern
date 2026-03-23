using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSistemaDescontos 
{
    internal class InssStrategy : IDescontosAcrescimosStrategy
    {
        private readonly List<(decimal MaxValue, decimal Rate)> _ranges = new()
        {
            (1500m, 0.075m),
            (2500m, 0.09m),
            (3000m, 0.12m),
            (decimal.MaxValue, 0.15m)
        };
        public decimal AplicarDesconto(decimal valor)
        {
            foreach (var range in _ranges)
            {
                if (valor <= range.MaxValue)
                    return valor + (valor * range.Rate);
            }
            return valor;
        }
    }
}
