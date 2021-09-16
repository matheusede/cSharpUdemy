/* Exercício 01
 * Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
 * mensagem explicativa, conforme exemplos.
 * Entrada: 10 \n 30.  Saída: SOMA = 40
 * Entrada: -30 \n 10.  Saída: SOMA = -20
 * Entrada: 0 \n 0.Saída: SOMA = 0 */
using System;

namespace ExProposto01 {
    class Program {
        static void Main(string[] args) {
            int n1, n2, soma;
            for(int i = 0; i <3; i++) {
                Console.WriteLine("Insira dois números que serão somados.");
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());
                soma = n1 + n2;
                Console.WriteLine($"SOMA = {soma}");
            }
        }
    }
}
