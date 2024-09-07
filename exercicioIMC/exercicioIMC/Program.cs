using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu peso (em quilogramas): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura (em metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);  //formula imc

            Console.WriteLine($"Seu IMC é: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Classificação: Abaixo do peso");
            }
            else if (imc < 24.9)
            {
                Console.WriteLine("Classificação: Peso normal");
            }
            else if (imc < 29.9)
            {
                Console.WriteLine("Classificação: Sobrepeso");
            }
            else
            {
                Console.WriteLine("Classificação: Obesidade");
            }
            Console.ReadLine();
        }
    }
}
