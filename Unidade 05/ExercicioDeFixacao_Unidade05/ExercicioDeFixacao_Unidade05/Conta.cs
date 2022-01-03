using System;

public class Conta{
	private int _nConta;
	private string _nome;
	public float Saldo { get; private set; }

	public Conta(){
		_nConta = 0;
		Saldo = 0;
	}

	public int NumConta {
		get { return _nConta; }
		set {
			if (value != 0 && _nConta == 0)
				_nConta = value;
        }
	}

	public string Nome {
		get { return _nome; }
		set {
			if (value != null && value.Length > 1) {
				_nome = value;
			}
		}
	}

	public void Deposito(float valor) {
		Saldo += valor;
    }

	public void Saque(float valor) {
		Saldo -= (valor + 5);
    }
}
