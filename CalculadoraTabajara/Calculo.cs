using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTabajara
{
    public class Calculo
    {

        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Resultado { get; set; } 
        public string Operador { get; set; }


        public Calculo(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public void Multiplicacao()
        {
            Resultado = Num1 * Num2;
            Operador = "*";
       
        }

        public override string ToString()
        {
            return Num1 + " " + Operador + " " + Num2 + " = " + Resultado;
            ;
        }

        public void Subtracao()
        {
            Resultado = Num1 - Num2;
            Operador = "-";

        }
    }
}
