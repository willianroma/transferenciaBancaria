using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferenciaBancarias
{
    class Conta
    {
        //private int Id { get; set; }
        private TipoConta TipoConta { get; set;}
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        public Conta(TipoConta tipoConta, string nome, double saldo, double credito)
        {
            this.TipoConta = tipoConta;
            this.Nome = nome;
            this.Saldo = saldo;
            this.Credito = credito;
        }



        public bool Sacar(double saque)
        {
            if (this.Saldo - saque < (this.Credito*-1))
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }

            this.Saldo -= saque;
            Console.WriteLine("Saldo atual da conta do {0} é {1}", this.Nome, this.Saldo);
            return true;
            
        }

        public void Depositar(double deposito)
        {
            this.Saldo += deposito;
            Console.WriteLine("Deposito realizado com sucesso!");
        }
        public void Transferir(double valor, Conta conta)
        {
            if (this.Sacar(valor))
            {
                conta.Depositar(valor);
            }
        }
        public override string ToString()
        {
            string retorno="";

            //retorno += "Id " + this.Id + " | ";
            retorno += "TipoConta " + this.TipoConta +" | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Credito " + this.Credito + " | ";

            return retorno;
        }
    }
}
