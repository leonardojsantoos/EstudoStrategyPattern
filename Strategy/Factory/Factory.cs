using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Interfaces;
using Strategy.Models;
using Strategy.Strategies;

namespace Strategy.Factory
{
    internal class Factory
    {
        public static class ExameStrategyFactory
        {
            public static IAprovarExame Criar(TipoExame opcao)
            {
                return opcao switch
                {
                    TipoExame.Sangue => new AprovaExameSangue(),
                    TipoExame.RaioX => new AprovaRaioX(),
                    TipoExame.Ultrassom => new AprovaExameUltrassom(),
                    _ => throw new ArgumentException("Tipo de exame inválido")
                };
            }
        }
    }
}
