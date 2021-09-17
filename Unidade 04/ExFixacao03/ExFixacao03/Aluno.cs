using System;
using System.Collections.Generic;
using System.Text;

namespace ExFixacao03 {
    class Aluno {
        public string Nome;
        public float Nota1, Nota2, Nota3;

        public float CalculaNotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado() {
            if (CalculaNotaFinal() >= 60.0f)
                return true;
            else
                return false;

        }

        public float VerificaNota() {
            if (CalculaNotaFinal() >= 60f)
                return 0.0f;
            else
                return 60.0f - CalculaNotaFinal();
        }
    }
}
