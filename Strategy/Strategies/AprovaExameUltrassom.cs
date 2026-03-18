using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Interfaces;
using Strategy.Models;

namespace Strategy.Strategies
{
    public class AprovaExameUltrassom : IAprovarExame
    {
        public void AprovarExame(Exame exame)
        {
            if (exame.Descricao.Equals("Ultrassom", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Aprovado");
            else
                Console.WriteLine("Reprovado");
        }
    }
}
