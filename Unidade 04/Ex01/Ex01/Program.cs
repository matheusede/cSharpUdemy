using System;

namespace Ex01 {
    class Program {
        static void Main(string[] args) {
            Data pessoa1 = new Data(), pessoa2 = new Data();
            //Entrada de dados da primeira pessoa
            Console.WriteLine("Insira o nome da primeira pessoa.");
            pessoa1.Nome = Console.ReadLine();
            Console.WriteLine("Insira a idade da primeira pessoa.");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            //Entrada de dados da segunda pessoa
            Console.WriteLine("Insira o nome da segunda pessoa.");
            pessoa2.Nome = Console.ReadLine();
            Console.WriteLine("Insira a idade da segunda pessoa.");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados da primeira pessoa:\nNome: {pessoa1.Nome}. \nIdade: {pessoa1.Idade}.");
            Console.WriteLine($"Dados da segunda pessoa:\nNome: {pessoa2.Nome}. \nIdade: {pessoa2.Idade}.");

            if (pessoa1.Idade > pessoa2.Idade) {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.Nome);
            }
            else {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.Nome);
            }
        }
    }
}
