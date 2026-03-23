using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Interfaces;
using Strategy.Models;

namespace Strategy.Strategies
{
    public class AprovaExameSangue : IAprovarExame
    {
        public void AprovarExame(Exame exame)
        {
            if (exame.Descricao.Equals("Sangue", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Aprovado");
            else
                Console.WriteLine("Reprovado");
        }
    }
}
