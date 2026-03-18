using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Interfaces;
using Strategy.Models;

namespace Strategy.Strategies
{
    public class AprovaRaioX : IAprovarExame
    {
        public void AprovarExame(Exame exame)
        {
            if (exame.Descricao.Equals("RaioX", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Aprovado");
            else
                Console.WriteLine($"Reprovado");
        }
    }
}
