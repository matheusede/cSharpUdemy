/* Exercício 03
 * Fazer um programa para ler quatro valores inteiros A, B, C e D. 
 * A seguir, calcule e mostre a diferença do produto de A e B pelo 
 * produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
 *  ENTRADA: 5, 6, 7, 8, SAÍDA: DIFERENCA = -26
 *  ENTRADA: 5, 6, -7, 8, SAÍDA: DIFERENCA = 86
 */
using System;

namespace ExProposto03 {
    class Program {
        static void Main(string[] args) {
            int a, b, c, d, diferenca;
            for (int i = 0; i < 2; i++) {
                Console.WriteLine("Insira 4 números inteiros");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                d = int.Parse(Console.ReadLine());
                diferenca = (a * b - c * d);
                Console.WriteLine($"DIFERENCA = {diferenca}");
            }
        }
    }
}
