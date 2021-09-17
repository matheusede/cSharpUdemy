using System;
using System.Collections.Generic;
using System.Text;

namespace ExFixacao02 {
    class Funcionario {
        public string Nome;
        public double SalarioBrtuo;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBrtuo - Imposto;
        }

        public void AumentaSalario(double porcentagem) {
            Console.WriteLine(porcentagem);
            SalarioBrtuo = SalarioBrtuo + (SalarioBrtuo *= porcentagem / 100);
        }
    }
}
