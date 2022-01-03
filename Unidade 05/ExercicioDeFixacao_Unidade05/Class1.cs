using System;

public class Conta{
	private int _nConta;
	private string _nome;
	public float Saldo { get; private set; };

	public Conta(){
		_nConta = 0;
		_saldo = 0;
	}

	public int Conta {
		get { return _nConta};
		set {
			if (value != 0 && _nConta == 0)
				_nConta = value;
        }
	}

	public string Nome {
		get { return _nome};
		set {
			if (value != null && value.Length > 1) {
				_nome = value;
			}
		}
	}

	
}
