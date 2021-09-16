using System;

namespace Ex02 {
    class Program {
        static void Main(string[] args) {
            Funcionario f1 = new Funcionario(), f2 = new Funcionario();
            float media;

            //Leitura dos dados de cada funcionário
            Console.WriteLine("Insira o nome e salário do primeiro funcionário, nessa respectiva ordem.");
            f1.Nome = Console.ReadLine();
            f1.Salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o nome e salário do segundo funcionário, nessa respectiva ordem.");
            f2.Nome = Console.ReadLine();
            f2.Salario = float.Parse(Console.ReadLine());

            //Cálculo do média
            media = (f1.Salario + f2.Salario) / 2;

            //Output de dados
            Console.WriteLine($"Dados do primeiro funcionário: \nNome: {f1.Nome} \nSalario: {f1.Salario}");
            Console.WriteLine($"Dados do segundo funcionário: \nNome: {f2.Nome} \nSalario: {f2.Salario}");
            Console.WriteLine($"Média dos salários: {media}");
        }
    }
}
