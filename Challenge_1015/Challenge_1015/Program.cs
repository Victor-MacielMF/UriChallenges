using System;
using System.Globalization;

namespace Challenge_1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] PrimeiraCoordenada = Console.ReadLine().Split(' ');
            string[] SegundaCoordenada = Console.ReadLine().Split(' ');

            double X1 = double.Parse(PrimeiraCoordenada[0], CultureInfo.InvariantCulture);
            double Y1 = double.Parse(PrimeiraCoordenada[1], CultureInfo.InvariantCulture);

            double X2 = double.Parse(SegundaCoordenada[0], CultureInfo.InvariantCulture);
            double Y2 = double.Parse(SegundaCoordenada[1], CultureInfo.InvariantCulture);

            double Calculo = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));

            Console.WriteLine(Calculo.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}