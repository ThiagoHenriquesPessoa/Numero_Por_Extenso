using ConverteNumero;
using System;

namespace Numero_Por_Extenso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            var numero = Convert.ToDecimal(Console.ReadLine());
            string extenso = Conversor.EscreverExtenso(numero);
            Console.WriteLine(extenso);

        }
    }
}
