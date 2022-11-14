using System;

namespace Challenge_1016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TempoPorKm = 2;
            int Distancia = int.Parse(Console.ReadLine());

            int Calculo = Distancia * TempoPorKm;

            Console.WriteLine("{0} minutos", Calculo);
        }
    }
}