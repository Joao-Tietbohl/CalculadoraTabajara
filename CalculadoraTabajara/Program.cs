using System;

namespace CalculadoraTabajara
{
    internal class Program
    {

        static Calculadora calculadora = new Calculadora();

        static void Main(string[] args)
        {

            string opcao;

            while (true)
            {


                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

                Console.WriteLine("Tela Principal\n");

                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");

                Console.WriteLine("Digite S para sair\n");

                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;



                Calculo c = Calculo(opcao);
              
                MostrarResultado(c);
          
            }
        }

        private static void MostrarResultado(Calculo c)
        {
            Console.Clear();

            Console.WriteLine("Calculadora Tabajara\n");

            Console.WriteLine("Tela de Resultados\n");

            Console.Write(c);

            Console.WriteLine();

            Console.ReadLine();

            Console.Clear();
        }

        private static Calculo Calculo(string opcao)
        {

            decimal primeiroNumero, segundoNumero;

            Console.Write($"Digite o primeiro número: ");
            primeiroNumero = Convert.ToDecimal(Console.ReadLine());

            do
            {
                Console.Write($"Digite o segundo número: ");
                segundoNumero = Convert.ToDecimal(Console.ReadLine());

                if (opcao.Equals("4") && segundoNumero == 0)
                {
                    Console.WriteLine("Número inválido, divisão por zero");
                    continue;
                }

                else
                {
                    break;
                }
            } while (true);

            Calculo c = new Calculo(primeiroNumero, segundoNumero);
            
           
            switch (opcao)
            {
                default:

                case "1":

                    c.Adicao();
                    break;

                case "2":
                    c.Subtracao();
                    break;

                case "3":

                    c.Multiplicacao();                  
                    break;

                case "4":

                    c.Divisao();
                    break;
            }
            calculadora.AdicionarCalculoNoHistorico(c);
            return c;
        }
    }
}
