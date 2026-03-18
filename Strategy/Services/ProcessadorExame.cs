using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Interfaces;
using Strategy.Models;

namespace Strategy.Services
{
    public class ProcessadorExame
    {
        private IAprovarExame _estrategia;
        public ProcessadorExame(IAprovarExame estrategia)
        {
            _estrategia = estrategia;
        }
        public void Processar(Exame exame)
        {
            _estrategia.AprovarExame(exame);
        }
        public void SetEstrategia(IAprovarExame novaEstrategia)
        {
            _estrategia = novaEstrategia;
        }
    }
}
