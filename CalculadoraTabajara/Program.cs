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


                if(opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4" || opcao == "s")
                {
                    Console.Write("Opção: ");
                    opcao = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Opção Invalida");
                }

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

            Console.Write($"O resultado da operação de {c.Operador} é: {c.Resultado}");

            Console.WriteLine();

            Console.ReadLine();

            Console.Clear();
        }

        private static Calculo Calculo(string opcao)
        {
      

            Console.Write($"Digite o primeiro número: ");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Digite o segundo número: ");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            Calculo c = new Calculo(primeiroNumero, segundoNumero);
            
           
            switch (opcao)
            {
                default:

                case "1":

                    c.Adicao();
                    calculadora.AdicionarCalculoNoHistorico(c);

                    break;

                case "2":
                    c.Subtracao();
                    break;

                case "3":

                    c.Multiplicacao();
                   
                    
                    break;

                case "4":

                    break;
            }
            calculadora.AdicionarCalculoNoHistorico(c);
            return c;
        }
    }
}
