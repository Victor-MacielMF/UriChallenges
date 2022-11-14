using System;
using System.Globalization;

namespace Challenge_1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double GastoCombustivel = 12.0;
            int HorasGastas = int.Parse(Console.ReadLine());
            int VelocidadeMedia = int.Parse(Console.ReadLine());

            double DistanciaPercorrida = HorasGastas * VelocidadeMedia / GastoCombustivel;

            Console.WriteLine(DistanciaPercorrida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}