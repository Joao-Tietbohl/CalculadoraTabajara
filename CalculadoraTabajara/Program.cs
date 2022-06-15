using System;

namespace CalculadoraTabajara
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string opcao;

            while (true)
            {


                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

                Console.WriteLine("Tela Principal\n");

                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração";
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");

                Console.WriteLine("Digite S para sair\n");

                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;


                
                string operacao;
                double resultado;


                Calculo(opcao, out operacao, out resultado);
              
                MostrarResultado(operacao, resultado);
          
            }
        }

        private static void MostrarResultado(string operacao, double resultado)
        {
            Console.Clear();

            Console.WriteLine("Calculadora Tabajara\n");

            Console.WriteLine("Tela de Resultados\n");

            Console.Write($"O resultado da operação de {operacao} é: {resultado}");

            Console.WriteLine();

            Console.ReadLine();

            Console.Clear();
        }

        private static void Calculo(string opcao, out string operacao, out double resultado)
        {
            Console.Clear();

            Console.WriteLine("Calculadora Tabajara\n");

            operacao = "";
            switch (opcao)
            {
                default:
                    break;
            }

            string subtitulo = $"Novo calculo de {operacao}";

            Console.WriteLine(subtitulo + "\n");

            Console.Write($"Digite o primeiro número: ");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Digite o segundo número: ");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            Calculo c = new Calculo();

            resultado = 0;
            switch (opcao)
            {
                default:

                case "1":
                    
                    break;

                case "2":

                    break;

                case "3":

                    break;

                case "4":

                    break;
            }
        }
    }
}
