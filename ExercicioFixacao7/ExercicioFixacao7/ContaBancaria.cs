using System.Globalization;

namespace ExercicioFixacao7
{
    class ContaBancaria
    {
        private string _nome;
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public static double Taxa = 5.00;

        public ContaBancaria(string nome, int numero)
        {
            _nome = nome;
            Numero = numero;
        }

        public ContaBancaria(string nome, int numero, double valor) : this(nome,numero)
        {
            Deposito(valor);
        }

        public string Nome {
            get { return _nome; }
            set
            {
                if(value != null && value.Length > 15)
                {
                    _nome = value;
                }
            }
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + Taxa;
        }

        public override string ToString()
        {
            return $"Conta {this.Numero}, Titular: {this.Nome}, Saldo: $ {this.Saldo.ToString("F2",CultureInfo.InvariantCulture)}";
        }

    }
}
