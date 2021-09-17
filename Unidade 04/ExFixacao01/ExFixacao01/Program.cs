using System;
using System.Globalization;

namespace ExFixacao01 {
    class Program {
        static void Main(string[] args) {
            Retangulo ret = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo:");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"AREA: {ret.CalculaArea().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO: {ret.CalculaPerimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"AREA: {ret.CalculaDiagonal().ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
