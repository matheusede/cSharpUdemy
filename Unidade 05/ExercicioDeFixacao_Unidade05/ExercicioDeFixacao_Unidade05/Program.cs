using System;

namespace ExercicioDeFixacao_Unidade05 {
    class Program {
        static void Main(string[] args) {
            Conta conta = new Conta();

            Console.Write("Entre o número da conta: ");
            conta.NumConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            conta.Nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n) ?");
            if (Console.ReadLine().Equals("s")) {
                Console.Write("Entre o valor de depósito inicial: ");
                conta.Deposito(float.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"Conta {conta.NumConta}, Titular: {conta.Nome}, Saldo: $ {conta.Saldo}");

            Console.Write("Entre um valor para depósito: ");
            conta.Deposito(float.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine($"Conta {conta.NumConta}, Titular: {conta.Nome}, Saldo: $ {conta.Saldo}");

            Console.Write("Entre um valor para saque: ");
            conta.Saque(float.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine($"Conta {conta.NumConta}, Titular: {conta.Nome}, Saldo: $ {conta.Saldo}");
        }
    }
}
