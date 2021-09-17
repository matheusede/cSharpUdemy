using System;
using System.Globalization;

namespace ExFixacao03 {
    class Program {
        static void Main(string[] args) {
            Aluno aluno = new Aluno();
            Console.WriteLine("Digite o nome do aluno.");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno.");
            aluno.Nota1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"NOTA FINAL = {aluno.CalculaNotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
            if (aluno.Aprovado())
                Console.WriteLine("APROVADO");
            else
                Console.WriteLine($"REPROVADO \nFALTARAM {aluno.VerificaNota().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
