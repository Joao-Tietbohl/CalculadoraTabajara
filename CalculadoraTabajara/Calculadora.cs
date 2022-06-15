using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTabajara
{
    public class Calculadora
    {
        List<Calculo> historico;

        public void AdicionarCalculoNoHistorico(Calculo c)
        {
            historico.Add(c);
        }

    }
}
