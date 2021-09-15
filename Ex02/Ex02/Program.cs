using System;
using System.Globalization;

namespace Ex02 {
    class Program {
        static void Main(string[] args) {
            //Declaração de variáveis
            string nomeCompleto, ultimoNome;
            int quartos, idade;
            float preco, altura;

            //Leitura de dados
            Console.WriteLine("Entre com seu nome completo:");
            nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] array = Console.ReadLine().Split(' ');
            ultimoNome = array[0];
            idade = int.Parse(array[1]);
            altura = float.Parse(array[2], CultureInfo.InvariantCulture);

            //Output de dados
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
