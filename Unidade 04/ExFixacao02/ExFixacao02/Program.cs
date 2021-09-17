using System;
using System.Globalization;

namespace ExFixacao02 {
    class Program {
        static void Main(string[] args) {
            Funcionario f1 = new Funcionario();
            double porcentagem;

            //Recebe e exibe dados iniciais
            Console.WriteLine("Insira o nome do funcionário.");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Insira o salário bruto do funcionário.");
            f1.SalarioBrtuo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o imposto a ser pago pelo funcionário.");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Funcionário: {f1.Nome}, $ {f1.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");

            //Dados atualizados
            Console.WriteLine("Digite a porcentagem para aumentar o salário:");
            porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f1.AumentaSalario();
            Console.WriteLine($"Dados atualizados: {f1.Nome}, ${f1.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
