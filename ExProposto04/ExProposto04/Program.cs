/*Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
 *hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
 *decimais.
 * Entrada: 25 \n 200 \n 5.50 Saida: NUMBER = 25, SALARY = U$ 550.00
 * Entrada: 1 \n 200 \n 20.50 Saída: NUMBER = 1, SALARY = U$ 4100.00
 * Entrada: 6 \n 145 \n 15.55 Saída> NUMBER = 6, SALARY = U$ 2254.75
 */
using System.Globalization;
using System;

namespace ExProposto04 {
    class Program {
        static void Main(string[] args) {
            int id, horas;
            float pagamentoPorHora, salario;
            for (int i = 0; i < 3; i++) {
                Console.WriteLine("Insira a id, as horas tranalhadas e o pagamento por hora do funcionário.");
                id = int.Parse(Console.ReadLine());
                horas = int.Parse(Console.ReadLine());
                pagamentoPorHora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                salario = pagamentoPorHora * horas;
                Console.WriteLine($"NUMBER = {id}");
                Console.WriteLine($"SALARY U${salario.ToString("F2, CultureInfo.InvariantCulture)")}");
            }
        }
    }
}
