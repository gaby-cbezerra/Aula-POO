using System.ComponentModel;

namespace Aula_POO;

class Program{

    public class Conta
    {
        public string titular;

        public string banco;

        public int numeracao;

        public int cpf;

        public int saldo;

        public Conta(string nomeTitular, string nomeBanco, int numberNumeracao, int numberCpf, int numberSaldo)
        {
            titular = nomeTitular;
            banco = nomeBanco;
            numeracao = numberNumeracao;
            cpf = numberCpf;
            saldo = numberSaldo;
        }
    }
}
