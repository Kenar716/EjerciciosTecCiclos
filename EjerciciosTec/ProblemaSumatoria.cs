using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    public class ProblemaSumatoria
    {
        private const int valorInicial = 1;
        public int ValorInicial
        {
            get { return valorInicial; }
        }

        private int valorFinal;
        public int ValorFinal
        {
            get { return valorFinal; }
        }

        private int valorSumatoria;
        public int ValorSumatoria
        {
            get { return valorSumatoria; }
        }

        public void AsignarValorASumar(int valorASumar)
        {
            valorFinal = valorASumar;
            for (int i = valorInicial; i <= valorFinal; i++)
            {
                valorSumatoria = valorSumatoria + i;
            }
        }

    }
}
