using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPotencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseValue = 0;
            int exponent = 0;

            Console.WriteLine("----------------------------");
            Console.WriteLine("| Calculadora de Potências |");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Por favor, insira um número inteiro válido para a base.");
            Console.Write("\nBase = ");
            int.TryParse(Console.ReadLine(), out baseValue);
            Console.WriteLine("Por favor, insira um número inteiro válido para o expoente.");
            Console.Write("\nExpoente = ");
            int.TryParse(Console.ReadLine(), out exponent);

            double res = Math.Pow(baseValue, exponent);

            Console.WriteLine($"O resultado de {baseValue} elevado {exponent} é igual a {res}");
            Console.ReadKey();
        }
    }
}
