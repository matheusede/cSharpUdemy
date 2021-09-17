using System;
using System.Collections.Generic;
using System.Text;

namespace ExFixacao01 {
    class Retangulo {
        public double Largura;
        public double Altura;

        public double CalculaArea() {
            return Largura * Altura;
        }
         public double CalculaPerimetro() {
            return (Altura * 2) + (Largura * 2);
        }

        public double CalculaDiagonal() {
            return Math.Sqrt(Math.Pow(Altura, 2.0) + Math.Pow(Largura, 2.0));
        }
    }
}
