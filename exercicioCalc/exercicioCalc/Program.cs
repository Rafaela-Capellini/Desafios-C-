using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // primeiro número
            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

    
            //outro numero
            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            // operação desejada
            Console.WriteLine("Escolha a operação desejada:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.Write("Digite o número da operação desejada (1/2/3/4): ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            double resultado = 0;
            bool operacaoValida = true;

            switch (opcao)
            {
                case 1:
                    resultado = numero1 + numero2;
                    Console.WriteLine($"Resultado da soma: {resultado}");
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    Console.WriteLine($"Resultado da subtração: {resultado}");
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    Console.WriteLine($"Resultado da multiplicação: {resultado}");
                    break;
                case 4:
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine($"Resultado da divisão: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        operacaoValida = false;
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    operacaoValida = false;
                    break;
            }

            if (!operacaoValida)
            {
                Console.WriteLine("A operação não foi realizada.");
            }
            Console.ReadLine();
        }
    }
}
