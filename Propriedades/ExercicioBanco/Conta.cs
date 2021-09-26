using System.Globalization;

namespace ExercicioBanco
{
    class Conta
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public Conta(int numeroConta, string titular, double saldo) : this(numeroConta, titular)
        {
            Saldo = saldo;
        }

        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }

        public void Sacar(double saque)
        {
            Saldo = (Saldo - saque) - 5;
        }


        public override string ToString()
        {
            return "Conta " + NumeroConta + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }



    }

}

