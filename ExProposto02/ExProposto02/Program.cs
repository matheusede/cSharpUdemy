/* Exercício 02
 * Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
 * casas decimais conforme exemplos
 * Fórmula da área: area = π . raio2
 * Considere o valor de π = 3.14159
 */
using System;
using System.Globalization;

namespace ExProposto02 {
    class Program {
        static void Main(string[] args) {
            float raio = 0f; 
            for (int i = 0; i < 3; i++) {
                Console.WriteLine("Insira o raio do círculo.");
                raio = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                float area = 3.14159f * (float)Math.Pow(raio, 2);
                Console.WriteLine($"A = {area.ToString("F4", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
