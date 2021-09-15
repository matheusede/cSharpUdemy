//Exercício que tem como intuito demonstrar os tipos de outputs de dados em c#
using System;
using System.Globalization;

namespace Ex01 {
    class Program {
        static void Main(string[] args) {

            //Declaração de variáveis
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0, preco2 = 650.50, medida = 53.234567;

            //Output dos dados usando as diversas opções de formatações e outputs do c#
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preco é ${preco1}");
            Console.WriteLine($"{produto2}, cujo preco é ${preco2}\n");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}\n");
            Console.WriteLine($"Medida com oito casas decimais: {medida}");
            Console.WriteLine($"Arredondando (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}